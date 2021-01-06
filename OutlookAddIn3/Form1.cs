using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using OutlookAddIn3.Properties;
using RestSharp;
using ZendeskApi_v2.Requests.HelpCenter;
using RestSharp.Authenticators;
using System.Collections.Generic;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Linq;

namespace OutlookAddIn3
{
    public partial class Form1 : Form
    {
        public static string username = string.Empty;
        public static string password = string.Empty;
        public Form1()

        {


            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            username= textBox1.Text;
            password= textBox2.Text;
            var client = new RestClient("http://crmtest.mysoft.com.tr");
            client.Timeout = -1;
            RestRequest login = new RestRequest("/common/loginmobile", Method.POST);
            login.AddParameter("username", username);
            login.AddParameter("password", password);
            IRestResponse response = client.Execute(login);
            ResultModel<UserModel> model = null;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                model = JsonConvert.DeserializeObject<ResultModel<UserModel>>(response.Content);
            }
            if (model != null)
            {
                if (model.succeed)
                {
                    MessageBox.Show(model.currentUser.Name);
                }
                else
                {
                    MessageBox.Show(model.message);
                }
            }
            else
            {
                MessageBox.Show("Hata Alındı. Hata Kodu: "+ response.StatusCode.ToString());
            }
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

            /*Main m = new Main();
            this.Hide();

            SqlCommand sm = new SqlCommand("insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')", data);

            data.Open();
            sm.ExecuteNonQuery();
            data.Close();
            MessageBox.Show("Kullanıcı Kaydedildi");*/


        }
  

        private void AddQueryParameter(string v1, string v2)
        {
            throw new NotImplementedException();
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
 