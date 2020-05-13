namespace Key_Encryptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbPath = new System.Windows.Forms.RichTextBox();
            this.tbPassword = new System.Windows.Forms.RichTextBox();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbEmail = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.RichTextBox();
            this.tbSaveD = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbPath.ForeColor = System.Drawing.Color.Silver;
            this.tbPath.Location = new System.Drawing.Point(11, 30);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(295, 25);
            this.tbPath.TabIndex = 5;
            this.tbPath.Text = "";
            this.tbPath.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(76, 105);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(321, 25);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "";
            this.tbPassword.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbEncrypt.ForeColor = System.Drawing.Color.Brown;
            this.rbEncrypt.Location = new System.Drawing.Point(11, 67);
            this.rbEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(81, 24);
            this.rbEncrypt.TabIndex = 3;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Key:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.radioButton2.Location = new System.Drawing.Point(96, 67);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Decrypt";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Silver;
            this.tbEmail.Location = new System.Drawing.Point(61, 143);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.MaximumSize = new System.Drawing.Size(336, 25);
            this.tbEmail.MinimumSize = new System.Drawing.Size(336, 25);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(336, 25);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Text = "";
            this.tbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(11, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(311, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbSave
            // 
            this.tbSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbSave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbSave.ForeColor = System.Drawing.Color.Silver;
            this.tbSave.Location = new System.Drawing.Point(49, 228);
            this.tbSave.Margin = new System.Windows.Forms.Padding(2);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(129, 25);
            this.tbSave.TabIndex = 4;
            this.tbSave.Text = "\\\\Mac\\Home\\Documents\\UnassumingFolder\\EncryptedFile";
            this.tbSave.Visible = false;
            // 
            // tbSaveD
            // 
            this.tbSaveD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tbSaveD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSaveD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tbSaveD.ForeColor = System.Drawing.Color.Silver;
            this.tbSaveD.Location = new System.Drawing.Point(210, 228);
            this.tbSaveD.Margin = new System.Windows.Forms.Padding(2);
            this.tbSaveD.Name = "tbSaveD";
            this.tbSaveD.Size = new System.Drawing.Size(129, 25);
            this.tbSaveD.TabIndex = 13;
            this.tbSaveD.Text = "\\\\Mac\\Home\\Documents\\UnassumingFolder\\DecryptedFile";
            this.tbSaveD.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(408, 238);
            this.Controls.Add(this.tbSaveD);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEncrypt);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(424, 277);
            this.MinimumSize = new System.Drawing.Size(424, 277);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbPath;
        private System.Windows.Forms.RichTextBox tbPassword;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RichTextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbSave;
        private System.Windows.Forms.RichTextBox tbSaveD;
    }
}

