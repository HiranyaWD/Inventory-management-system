using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HHCO
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PBQ3S51;Initial Catalog=HHCO;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            txt_un.Text = "MOOI";
            txt_pass.UseSystemPasswordChar = true;
        }
        
        private int ImageNumber = 1;
        
        private void LoadNextImage()
        {
            
            if (ImageNumber == 7)
            {
                ImageNumber = 1;
            }
            Slidepanel.ImageLocation = string.Format(@"images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pass.Clear();
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.Trim().Equals(string.Empty))
            {
                er_Password.SetError(txt_pass, "Please Enter The Password!");
                txt_pass.Focus();
                return;
            }
            
            SqlDataAdapter da = new SqlDataAdapter("Select Count(*) from Login where UserName='" + txt_un.Text + "' and Password='" + txt_pass.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                User_Recognize sk = new User_Recognize();
                sk.Show();

            }
            else
            {
                er_Password.SetError(txt_pass,"Please Check the Password Again!");
                txt_pass.Clear();
            }

        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_Password.SetError(txt_pass, string.Empty);
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txt_pass.Text.Trim().Equals(string.Empty))
                {
                    er_Password.SetError(txt_pass, "Please Enter The Password!");
                    txt_pass.Focus();
                    return;
                }

                SqlDataAdapter da = new SqlDataAdapter("Select Count(*) from Login where UserName='" + txt_un.Text + "' and Password='" + txt_pass.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    User_Recognize sk = new User_Recognize();
                    sk.Show();

                }
                else
                {
                    er_Password.SetError(txt_pass, "Please Check the Password Again!");
                    txt_pass.Clear();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
