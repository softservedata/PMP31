namespace ProjectPZ
{
    partial class SingInForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.singin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(477, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electronics Shop";
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(640, 369);
            this.login_txt.Multiline = true;
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(214, 30);
            this.login_txt.TabIndex = 1;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(640, 451);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(214, 30);
            this.password_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(646, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(646, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Login";
            // 
            // singin_btn
            // 
            this.singin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singin_btn.Location = new System.Drawing.Point(622, 533);
            this.singin_btn.Name = "singin_btn";
            this.singin_btn.Size = new System.Drawing.Size(251, 49);
            this.singin_btn.TabIndex = 6;
            this.singin_btn.Text = "Sing in";
            this.singin_btn.UseVisualStyleBackColor = true;
            this.singin_btn.Click += new System.EventHandler(this.singin_btn_Click);
            // 
            // SingInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectPZ.Properties.Resources.digo_ws_green_wallpapers_0046;
            this.ClientSize = new System.Drawing.Size(1228, 576);
            this.Controls.Add(this.singin_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.label1);
            this.Name = "SingInForm";
            this.Text = "SingInForm";
            this.Load += new System.EventHandler(this.SingInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button singin_btn;
    }
}