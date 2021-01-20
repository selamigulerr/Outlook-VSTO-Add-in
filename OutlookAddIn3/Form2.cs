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
    public partial class Form2 : Form
    {
 

        public Form2()
        {
            


            InitializeComponent();
            label1.Text = Ribbon1.subject;
            label2.Text = Ribbon1.body;
            label5.Text = Ribbon1.senderEmailAdress;
            label8.Text = Ribbon1.cc;
            label10.Text = Ribbon1.bcc;
            label12.Text = Ribbon1.to;
            label14.Text = Ribbon1.attachment.ToString();
            label16.Text = Ribbon1.entryId;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var client = new RestClient("https://crmtestmailapi.mysoft.com.tr/api/values/zmailinfo");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("MailSubject", label1.Text);
            request.AddParameter("MailBody", label2.Text);
            request.AddParameter("FromEmail", label5.Text);
            request.AddParameter("ToEmail", label12.Text);
            request.AddParameter("CcEmail", label8.Text);
            request.AddParameter("BccEmail", label10.Text);
            request.AddParameter("EntryId", label16.Text);
            IRestResponse response = client.Execute(request);

            ResultModel<string> model = null;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                model = JsonConvert.DeserializeObject<ResultModel<string>>(response.Content);
            }
            if (model != null)
            {
                if (model.succeed)
                {
                    MessageBox.Show("Login Success" + model.data);
                }
                else
                {
                    MessageBox.Show("Login unsuccess " + model.message);
                }
            }
            else
            {
                MessageBox.Show("Hata Alındı. Hata Kodu: " + response.StatusCode.ToString());
            }


        }
    

     
    }
}
