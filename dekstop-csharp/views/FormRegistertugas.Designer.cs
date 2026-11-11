namespace dekstop_csharp.views
{
    partial class FormRegistertugas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.cmblvl = new System.Windows.Forms.ComboBox();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtnamapetugas = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.cmblevel = new System.Windows.Forms.Label();
            this.txtkonfirmasipassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(35, 70);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(55, 13);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // cmblvl
            // 
            this.cmblvl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmblvl.FormattingEnabled = true;
            this.cmblvl.Location = new System.Drawing.Point(40, 287);
            this.cmblvl.Name = "cmblvl";
            this.cmblvl.Size = new System.Drawing.Size(179, 21);
            this.cmblvl.TabIndex = 2;
            this.cmblvl.SelectedIndexChanged += new System.EventHandler(this.cmblvl_SelectedIndexChanged);
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(144, 328);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 3;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 238);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(40, 328);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnamapetugas
            // 
            this.txtnamapetugas.AutoSize = true;
            this.txtnamapetugas.Location = new System.Drawing.Point(35, 121);
            this.txtnamapetugas.Name = "txtnamapetugas";
            this.txtnamapetugas.Size = new System.Drawing.Size(77, 13);
            this.txtnamapetugas.TabIndex = 8;
            this.txtnamapetugas.Text = "Nama Petugas";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Location = new System.Drawing.Point(37, 172);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(53, 13);
            this.txtpassword.TabIndex = 9;
            this.txtpassword.Text = "Password";
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            // 
            // cmblevel
            // 
            this.cmblevel.AutoSize = true;
            this.cmblevel.Location = new System.Drawing.Point(37, 271);
            this.cmblevel.Name = "cmblevel";
            this.cmblevel.Size = new System.Drawing.Size(33, 13);
            this.cmblevel.TabIndex = 10;
            this.cmblevel.Text = "Level";
            this.cmblevel.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtkonfirmasipassword
            // 
            this.txtkonfirmasipassword.AutoSize = true;
            this.txtkonfirmasipassword.Location = new System.Drawing.Point(37, 222);
            this.txtkonfirmasipassword.Name = "txtkonfirmasipassword";
            this.txtkonfirmasipassword.Size = new System.Drawing.Size(104, 13);
            this.txtkonfirmasipassword.TabIndex = 11;
            this.txtkonfirmasipassword.Text = "Konfirmasi Password";
            // 
            // FormRegistertugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 450);
            this.Controls.Add(this.txtkonfirmasipassword);
            this.Controls.Add(this.cmblevel);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtnamapetugas);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.cmblvl);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRegistertugas";
            this.Text = "FormRegistertugas";
            this.Load += new System.EventHandler(this.FormRegistertugas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.ComboBox cmblvl;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label txtnamapetugas;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.Label cmblevel;
        private System.Windows.Forms.Label txtkonfirmasipassword;
    }
}