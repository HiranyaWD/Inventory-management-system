using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using MOOI;

namespace HHCO
{
    public partial class Reset : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HIRA;Initial Catalog=MOOI;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        string randomCode;
        public static string to;
        public Reset()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
           

            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * from Registered_User where Email = '" + txt_email.Text + "'", con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                try
                {

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("mooiclothinglk@gmail.com");
                    msg.To.Add(txt_email.Text);
                    msg.Subject = "Password Resetting Code";
                    msg.Body = "Your Reset Code is " + randomCode;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "mooiclothinglk@gmail.com";
                    ntcd.Password = "rcrbeezhdtwnijlq";

                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Mail sent Successfully");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_verifycode_Click(object sender, EventArgs e)
        {

            if (txt_otp.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Enter the OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (randomCode == txt_otp.Text.ToString())
            {
                Cmbval = txt_email.Text;
                to = txt_email.Text;
                ResetPass obj = new ResetPass();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Correct OTP Code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

        }

        private void Reset_Load(object sender, EventArgs e)
        {
            
        }
        public static string Cmbval
        {
            get; set;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Recognize ur = new User_Recognize();
            ur.Show();
        }
    }
}
