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
        public static string adress = string.Empty;
        public Form1()

        {
           

            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            username= textBox1.Text;
            password= textBox2.Text;
            adress = textBox3.Text;
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
                if (checkBox1.Checked == true)
                {
                    Properties.Settings.Default.username = textBox1.Text;
                    Properties.Settings.Default.password = textBox2.Text;
                    Properties.Settings.Default.adress = textBox3.Text;
                    Properties.Settings.Default.Save();

                }
                else
                {
                    Properties.Settings.Default.username = "";
                    Properties.Settings.Default.password = "";
                    Properties.Settings.Default.adress = "";
                    Properties.Settings.Default.Save();


                }
            }
            if (model != null)
            {
                if (model.succeed)
                {
                    MessageBox.Show("Giriş Başarılı "+ model.currentUser.Name);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre  " + model.message);
                }
            }
            else
            {
                MessageBox.Show("Hata Alındı. Hata Kodu: "+ response.StatusCode.ToString());
            }
           
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
            if(Properties.Settings.Default.username!=string.Empty)
            {
                textBox1.Text = Properties.Settings.Default.username;
                textBox2.Text = Properties.Settings.Default.password;
                textBox3.Text = Properties.Settings.Default.adress;

            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 