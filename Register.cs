using HHCO;
using System;
using System.IO;
using System.Windows.Forms;

namespace MOOI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.FileName = "";
            opendlg.Filter = "Supported Images|*.jpg;*.jpeg;*.png;";
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.Load(opendlg.FileName);
            }

        }
        Database db = new Database();
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_userid.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the UserID to Register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt_name.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the name to Register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt_email.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Enter the Email to Register!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt_password.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Please Input Your Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (guna2CirclePictureBox1.Image == null)
                {
                    MessageBox.Show("Please Input Your Profile Picture!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MemoryStream stream = new MemoryStream();
                guna2CirclePictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Profilepic = stream.ToArray();

                int i = db.Register(txt_userid.Text, txt_name.Text, txt_email.Text, Profilepic, txt_password.Text);

                if (i == 1)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    User_Recognize ur = new User_Recognize();
                    ur.Show();
                }
                else
                {
                    MessageBox.Show("Register Process Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Recognize ur = new User_Recognize();
            ur.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
