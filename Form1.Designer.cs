namespace GravatarCSharpFormApplication
{
    partial class frmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.textbox_mail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(42, 78);
            this.btn_result.Margin = new System.Windows.Forms.Padding(6);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(600, 63);
            this.btn_result.TabIndex = 1;
            this.btn_result.Text = "Gravatar Inage";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // textbox_mail
            // 
            this.textbox_mail.Location = new System.Drawing.Point(132, 34);
            this.textbox_mail.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_mail.Name = "textbox_mail";
            this.textbox_mail.Size = new System.Drawing.Size(510, 32);
            this.textbox_mail.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(37, 34);
            this.lblMail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(74, 26);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Email:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 783);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.textbox_mail);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravatar Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.TextBox textbox_mail;
        private System.Windows.Forms.Label lblMail;
    }
}

