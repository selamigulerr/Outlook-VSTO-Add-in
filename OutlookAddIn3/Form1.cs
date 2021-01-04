using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using OutlookAddIn3.Properties;

namespace OutlookAddIn3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection data = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thegulers\Desktop\OutlookAddIn3\OutlookAddIn3\Database1.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
        
            if (checkBox1.Checked == true)
            {
                Settings.Default.username = textBox1.Text;
                Settings.Default.password =textBox2.Text;
                Settings.Default.remember = true;

            }
            else  
            {
                Settings.Default.remember = false;


            }

            Settings.Default.Save();

            Main m = new Main();
            this.Hide();

            SqlCommand sm = new SqlCommand("insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')", data);

            data.Open();
            sm.ExecuteNonQuery();
            data.Close();
            MessageBox.Show("Kullanıcı Kaydedildi");


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            this.ControlBox = false;
            if (Settings.Default.remember)
            {
                if (Settings.Default.username != string.Empty)
                {
                    textBox1.Text = Settings.Default.username;
                }
                if (Settings.Default.password != string.Empty)
                {
                    textBox2.Text = Settings.Default.password;

                }
                Settings.Default.remember = true;
            }
            else
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
            }
            }
        
    }
}
 