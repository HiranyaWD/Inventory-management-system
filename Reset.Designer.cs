namespace HHCO
{
    partial class Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_otp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_send = new Guna.UI2.WinForms.Guna2Button();
            this.btn_verifycode = new Guna.UI2.WinForms.Guna2Button();
            this.er_user = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.er_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(73, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 28);
            this.label2.TabIndex = 63;
            this.label2.Text = "PASSWORD RECOVERY VERIFICATION";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label8.Location = new System.Drawing.Point(86, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "OTP";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(86, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Animated = true;
            this.txt_email.AutoRoundedCorners = true;
            this.txt_email.BorderColor = System.Drawing.Color.White;
            this.txt_email.BorderRadius = 18;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.Parent = this.txt_email;
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.FocusedState.Parent = this.txt_email;
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.HoverState.Parent = this.txt_email;
            this.txt_email.Location = new System.Drawing.Point(68, 142);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.ShadowDecoration.Parent = this.txt_email;
            this.txt_email.Size = new System.Drawing.Size(296, 38);
            this.txt_email.TabIndex = 171;
            // 
            // txt_otp
            // 
            this.txt_otp.Animated = true;
            this.txt_otp.AutoRoundedCorners = true;
            this.txt_otp.BorderColor = System.Drawing.Color.White;
            this.txt_otp.BorderRadius = 18;
            this.txt_otp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_otp.DefaultText = "";
            this.txt_otp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_otp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_otp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_otp.DisabledState.Parent = this.txt_otp;
            this.txt_otp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_otp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txt_otp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_otp.FocusedState.Parent = this.txt_otp;
            this.txt_otp.ForeColor = System.Drawing.Color.White;
            this.txt_otp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_otp.HoverState.Parent = this.txt_otp;
            this.txt_otp.Location = new System.Drawing.Point(68, 237);
            this.txt_otp.Margin = new System.Windows.Forms.Padding(5);
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.PasswordChar = '\0';
            this.txt_otp.PlaceholderText = "";
            this.txt_otp.SelectedText = "";
            this.txt_otp.ShadowDecoration.Parent = this.txt_otp;
            this.txt_otp.Size = new System.Drawing.Size(296, 38);
            this.txt_otp.TabIndex = 172;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Animated = true;
            this.btn_send.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_send.BorderRadius = 8;
            this.btn_send.BorderThickness = 1;
            this.btn_send.CheckedState.Parent = this.btn_send;
            this.btn_send.CustomImages.Parent = this.btn_send;
            this.btn_send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.HoverState.Parent = this.btn_send;
            this.btn_send.Location = new System.Drawing.Point(397, 142);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.ShadowDecoration.Parent = this.btn_send;
            this.btn_send.Size = new System.Drawing.Size(105, 38);
            this.btn_send.TabIndex = 173;
            this.btn_send.Text = "SEND";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_verifycode
            // 
            this.btn_verifycode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_verifycode.Animated = true;
            this.btn_verifycode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_verifycode.BorderRadius = 8;
            this.btn_verifycode.BorderThickness = 1;
            this.btn_verifycode.CheckedState.Parent = this.btn_verifycode;
            this.btn_verifycode.CustomImages.Parent = this.btn_verifycode;
            this.btn_verifycode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btn_verifycode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_verifycode.ForeColor = System.Drawing.Color.White;
            this.btn_verifycode.HoverState.Parent = this.btn_verifycode;
            this.btn_verifycode.Location = new System.Drawing.Point(397, 237);
            this.btn_verifycode.Margin = new System.Windows.Forms.Padding(4);
            this.btn_verifycode.Name = "btn_verifycode";
            this.btn_verifycode.ShadowDecoration.Parent = this.btn_verifycode;
            this.btn_verifycode.Size = new System.Drawing.Size(105, 38);
            this.btn_verifycode.TabIndex = 174;
            this.btn_verifycode.Text = "VERIFY";
            this.btn_verifycode.Click += new System.EventHandler(this.btn_verifycode_Click);
            // 
            // er_user
            // 
            this.er_user.ContainerControl = this;
            this.er_user.Icon = ((System.Drawing.Icon)(resources.GetObject("er_user.Icon")));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(507, 13);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 22);
            this.guna2ControlBox1.TabIndex = 175;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(557, 364);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btn_verifycode);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_otp);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset";
            this.Load += new System.EventHandler(this.Reset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.er_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_otp;
        private Guna.UI2.WinForms.Guna2Button btn_send;
        private Guna.UI2.WinForms.Guna2Button btn_verifycode;
        private System.Windows.Forms.ErrorProvider er_user;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}