using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDLDPT_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getdata();
        }
        //Hàm chuyển đổi hình ảnh sang chuỗi byte
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(txtUrl.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        //Hàm chuyển đổi chuỗi byte sang hình ảnh
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void BtnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = openFile.FileName;
            }
        }

        private void Btnimgbyte_Click(object sender, EventArgs e)
        {
            
            richConvert.Text = Convert.ToBase64String(converImgToByte());
        }

        private void Btnbyteimg_Click(object sender, EventArgs e)
        {
            
            imageList1.Images.Add(ByteToImg(richConvert.Text));
            imageList1.ImageSize = new Size(220, 250);
            this.listView_img.View = View.LargeIcon;
            for (int counter = 0; counter < imageList1.Images.Count; counter++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = counter;
                this.listView_img.Items.Add(item);
            }
            this.listView_img.LargeImageList = imageList1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            clear();
            string constr = @"Data Source=PLASTIC_PIG;Initial Catalog=CSDLDPT;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "INSERT INTO IMG VALUES(@title, @Byte)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Byte", richConvert.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            getdata();
        }
        public void getdata()
        {
            string constr = @"Data Source=PLASTIC_PIG;Initial Catalog=CSDLDPT;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM IMG", conn))
                {
                    DataTable dt = new DataTable("IMG");
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtTitle.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            richConvert.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }
        public void clear()
        {
            txtTitle.Clear();
            txtUrl.Clear();
            richConvert.Clear();
        }
    }
}
