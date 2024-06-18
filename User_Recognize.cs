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
using System.IO;

namespace HHCO
{
    public partial class User_Recognize : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PBQ3S51;Initial Catalog=HHCO;Integrated Security=True");
        
        public User_Recognize()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void txt_reginame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2TextBox1.Focus();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            
            

            if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        if (txtname.Text.Trim().Equals(string.Empty))
                        {
                          MessageBox.Show("Please Enter Your Registered Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          return;
                        }

                        SqlDataAdapter dr = new SqlDataAdapter("Select * from  Registered_User where UserID = '" + txtname.Text + "'", con);
                        DataTable dt = new DataTable();
                        dr.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.Hide();
                            Menu m = new Menu();
                            m.Show();
                        }
                        else
                        {
                           MessageBox.Show("Name Doesn't Exist! Please Register First","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                           txtname.Clear();
                        }
                    }
                    catch(Exception)
                    {
                       MessageBox.Show("Name Already Exists or Error While Registering", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            
                    
                }
             
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void User_Recognize_Load(object sender, EventArgs e)
        {
            txt_Admin.UseSystemPasswordChar = true;
            guna2Panel1.Visible = false;
            txt_userid.Enabled = false;
            txt_Admin.Visible = false;
            txt_Admin.Clear();
            chk_show.Visible = false;
            label7.Visible = false;
        }

       

        private void txt_Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter dr = new SqlDataAdapter("SELECT * from Adminpass where Password = '" + txt_Admin.Text + "'", con);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txt_userid.Enabled = true;
                    txt_Admin.Visible = false;
                    txt_Admin.Clear();
                    chk_show.Visible = false;
                    label7.Visible = false;
                    guna2Panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Admin Password Invaid", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Admin.Visible = true;
            txt_Admin.Clear();
            chk_show.Visible = true;
            label7.Visible = true;
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked)
            {
                txt_Admin.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Admin.UseSystemPasswordChar = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_userid.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the name to Register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (guna2TextBox1.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the name to Register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                SqlCommand cmd = con.CreateCommand();
                var Profilepic = new ImageConverter().ConvertTo(Pictureprofile.Image, typeof(Byte[]));
                cmd.Parameters.AddWithValue("@Profilepic", Profilepic);
                cmd.CommandText = ("Insert into Registered_User (UserID,Name,Profilepic) values('" + txt_userid.Text + "','" + guna2TextBox1.Text + "',@Profilepic");
                MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txt_userid.Enabled = false;


            }
            catch (Exception)
            {
                MessageBox.Show("Saving Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userid.Clear();
            }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenFileDialog opendlg = new OpenFileDialog();
                opendlg.FileName = "";
                opendlg.Filter = "Supported Images|*.jpg;*.jpeg;*.png;";
                if(opendlg.ShowDialog() == DialogResult.OK)
                {
                    Pictureprofile.Load(opendlg.FileName);
                }
            }
        }
    }
}
