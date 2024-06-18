
namespace HHCO
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chk_show = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.txt_un = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.er_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.Slidepanel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slidepanel)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chk_show
            // 
            this.chk_show.Animated = true;
            this.chk_show.BackColor = System.Drawing.Color.Transparent;
            this.chk_show.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.chk_show.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chk_show.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chk_show.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chk_show.CheckedState.Parent = this.chk_show;
            this.chk_show.Location = new System.Drawing.Point(74, 237);
            this.chk_show.Name = "chk_show";
            this.chk_show.ShadowDecoration.Parent = this.chk_show;
            this.chk_show.Size = new System.Drawing.Size(35, 20);
            this.chk_show.TabIndex = 12;
            this.chk_show.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chk_show.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.chk_show.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.chk_show.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.chk_show.UncheckedState.Parent = this.chk_show;
            this.chk_show.CheckedChanged += new System.EventHandler(this.chk_show_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Animated = true;
            this.txt_pass.BorderColor = System.Drawing.Color.Transparent;
            this.txt_pass.BorderRadius = 5;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.Parent = this.txt_pass;
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.FocusedState.Parent = this.txt_pass;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Red;
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.HoverState.Parent = this.txt_pass;
            this.txt_pass.Location = new System.Drawing.Point(72, 197);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_pass.PlaceholderText = "Password";
            this.txt_pass.SelectedText = "";
            this.txt_pass.ShadowDecoration.Parent = this.txt_pass;
            this.txt_pass.Size = new System.Drawing.Size(200, 31);
            this.txt_pass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_pass.TabIndex = 11;
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_exit.BorderRadius = 8;
            this.btn_exit.BorderThickness = 1;
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.btn_exit.FillColor = System.Drawing.Color.Firebrick;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Location = new System.Drawing.Point(33, 405);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(275, 37);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clear.BorderRadius = 8;
            this.btn_clear.BorderThickness = 1;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Firebrick;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(33, 358);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(275, 37);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_un
            // 
            this.txt_un.Animated = true;
            this.txt_un.BackColor = System.Drawing.Color.White;
            this.txt_un.BorderColor = System.Drawing.Color.Transparent;
            this.txt_un.BorderRadius = 5;
            this.txt_un.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_un.DefaultText = "";
            this.txt_un.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_un.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_un.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_un.DisabledState.Parent = this.txt_un;
            this.txt_un.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_un.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_un.FocusedState.Parent = this.txt_un;
            this.txt_un.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_un.ForeColor = System.Drawing.Color.Red;
            this.txt_un.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_un.HoverState.Parent = this.txt_un;
            this.txt_un.Location = new System.Drawing.Point(72, 155);
            this.txt_un.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_un.Name = "txt_un";
            this.txt_un.PasswordChar = '\0';
            this.txt_un.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_un.PlaceholderText = "Username";
            this.txt_un.ReadOnly = true;
            this.txt_un.SelectedText = "";
            this.txt_un.ShadowDecoration.Parent = this.txt_un;
            this.txt_un.Size = new System.Drawing.Size(200, 31);
            this.txt_un.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_un.TabIndex = 8;
            this.txt_un.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(90, 501);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Copyright © 2022 HHCO ";
            // 
            // btn_login
            // 
            this.btn_login.Animated = true;
            this.btn_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.BorderRadius = 8;
            this.btn_login.BorderThickness = 1;
            this.btn_login.CheckedState.Parent = this.btn_login;
            this.btn_login.CustomImages.Parent = this.btn_login;
            this.btn_login.FillColor = System.Drawing.Color.Firebrick;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.HoverState.Parent = this.btn_login;
            this.btn_login.Location = new System.Drawing.Point(33, 311);
            this.btn_login.Name = "btn_login";
            this.btn_login.ShadowDecoration.Parent = this.btn_login;
            this.btn_login.Size = new System.Drawing.Size(275, 37);
            this.btn_login.TabIndex = 26;
            this.btn_login.Text = "LOGIN";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(111, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Show Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.btn_login);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txt_un);
            this.guna2Panel1.Controls.Add(this.btn_clear);
            this.guna2Panel1.Controls.Add(this.btn_exit);
            this.guna2Panel1.Controls.Add(this.txt_pass);
            this.guna2Panel1.Controls.Add(this.chk_show);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(335, 525);
            this.guna2Panel1.TabIndex = 33;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(77, 31);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(195, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 35;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 55;
            this.guna2ControlBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2ControlBox2.BorderThickness = 1;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1070, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(27, 24);
            this.guna2ControlBox2.TabIndex = 35;
            // 
            // er_Password
            // 
            this.er_Password.ContainerControl = this;
            this.er_Password.Icon = ((System.Drawing.Icon)(resources.GetObject("er_Password.Icon")));
            // 
            // Slidepanel
            // 
            this.Slidepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Slidepanel.Image = ((System.Drawing.Image)(resources.GetObject("Slidepanel.Image")));
            this.Slidepanel.Location = new System.Drawing.Point(335, 0);
            this.Slidepanel.Name = "Slidepanel";
            this.Slidepanel.ShadowDecoration.Parent = this.Slidepanel;
            this.Slidepanel.Size = new System.Drawing.Size(767, 525);
            this.Slidepanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slidepanel.TabIndex = 34;
            this.Slidepanel.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 525);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.Slidepanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slidepanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox Slidepanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_un;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chk_show;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.ErrorProvider er_Password;
    }
}

