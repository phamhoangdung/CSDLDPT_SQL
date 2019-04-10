namespace CSDLDPT_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.btnimgbyte = new System.Windows.Forms.Button();
            this.richConvert = new System.Windows.Forms.RichTextBox();
            this.listView_img = new System.Windows.Forms.ListView();
            this.btnbyteimg = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Byte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(36, 30);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(383, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(452, 14);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(156, 23);
            this.btnGetFile.TabIndex = 1;
            this.btnGetFile.Text = "Chọn hình";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.BtnGetFile_Click);
            // 
            // btnimgbyte
            // 
            this.btnimgbyte.Location = new System.Drawing.Point(452, 41);
            this.btnimgbyte.Name = "btnimgbyte";
            this.btnimgbyte.Size = new System.Drawing.Size(75, 23);
            this.btnimgbyte.TabIndex = 2;
            this.btnimgbyte.Text = "img -> byte";
            this.btnimgbyte.UseVisualStyleBackColor = true;
            this.btnimgbyte.Click += new System.EventHandler(this.Btnimgbyte_Click);
            // 
            // richConvert
            // 
            this.richConvert.Location = new System.Drawing.Point(36, 83);
            this.richConvert.Name = "richConvert";
            this.richConvert.Size = new System.Drawing.Size(572, 96);
            this.richConvert.TabIndex = 3;
            this.richConvert.Text = "";
            // 
            // listView_img
            // 
            this.listView_img.Location = new System.Drawing.Point(36, 202);
            this.listView_img.Name = "listView_img";
            this.listView_img.Size = new System.Drawing.Size(572, 222);
            this.listView_img.TabIndex = 4;
            this.listView_img.UseCompatibleStateImageBehavior = false;
            // 
            // btnbyteimg
            // 
            this.btnbyteimg.Location = new System.Drawing.Point(533, 41);
            this.btnbyteimg.Name = "btnbyteimg";
            this.btnbyteimg.Size = new System.Drawing.Size(75, 23);
            this.btnbyteimg.TabIndex = 5;
            this.btnbyteimg.Text = "byte -> img";
            this.btnbyteimg.UseVisualStyleBackColor = true;
            this.btnbyteimg.Click += new System.EventHandler(this.Btnbyteimg_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(36, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(101, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(224, 55);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.Byte});
            this.dataGridView1.Location = new System.Drawing.Point(627, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 410);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Tiêu đề";
            this.title.Name = "title";
            // 
            // Byte
            // 
            this.Byte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Byte.DataPropertyName = "Byte";
            this.Byte.HeaderText = "Nội dung";
            this.Byte.Name = "Byte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnbyteimg);
            this.Controls.Add(this.listView_img);
            this.Controls.Add(this.richConvert);
            this.Controls.Add(this.btnimgbyte);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = ":)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.Button btnimgbyte;
        private System.Windows.Forms.RichTextBox richConvert;
        private System.Windows.Forms.ListView listView_img;
        private System.Windows.Forms.Button btnbyteimg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Byte;
    }
}

