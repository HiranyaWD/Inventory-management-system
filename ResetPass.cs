using HHCO;
using System;
using System.Windows.Forms;

namespace MOOI
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter New Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.cmd = new System.Data.SqlClient.SqlCommand("UPDATE[dbo].[Registered_User] SET [password] = '" + guna2TextBox1.Text + "'WHERE Email ='" + txt_gmail.Text + "'", db.con);
                db.con.Open();
                int i = db.cmd.ExecuteNonQuery();
                db.con.Close();
                db.cmd.Dispose();
                if (i == 1)
                {
                    MessageBox.Show("Password Reset Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
            }
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            txt_gmail.Text = Reset.Cmbval;
            guna2TextBox1.UseSystemPasswordChar = true;
            guna2TextBox2.UseSystemPasswordChar= true;
            
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                guna2TextBox1.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox1.UseSystemPasswordChar = true;
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked)
            {
               guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Recognize ur = new User_Recognize();
            ur.Show();
        }
    }
}
