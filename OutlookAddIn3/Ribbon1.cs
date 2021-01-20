using Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace OutlookAddIn3
{
   
    public partial class Ribbon1
    {
        public static string cc = string.Empty;
        public static string bcc = string.Empty;
        public static string subject = string.Empty;
        public static string body = string.Empty;
        public static string senderEmailAdress = string.Empty;
        public static string entryId = string.Empty;
        public static string attachment = string.Empty;
        public static string to = string.Empty;
        public static string url = string.Empty;



        Inspectors inspectors;

        public void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
           
            inspectors = Globals.ThisAddIn.Application.Inspectors;
          
        }



        private void login_Click(object sender, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        public void getMail_Click(object sender, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs e)
        {

            if (Properties.Settings.Default.username == "" || Properties.Settings.Default.adress == "" || Properties.Settings.Default.password == "")
            {
                MessageBox.Show("Giriş Yapınız");
            }

            else {
                
                        Microsoft.Office.Interop.Outlook.Explorer explorer = Globals.ThisAddIn.Application.ActiveExplorer();
                            if (explorer != null)
                            {
                        Object obj = explorer.Selection[1];
                        if (obj is Microsoft.Office.Interop.Outlook.MailItem)
                        {
                            Microsoft.Office.Interop.Outlook.MailItem item = (obj as Microsoft.Office.Interop.Outlook.MailItem);
                            var client = new RestClient(Form1.adress + "/api/values/zmailinfo");
                            client.Timeout = -1;
                            var request = new RestRequest(Method.POST);
                            request.AddParameter("MailSubject", item.Subject);
                            request.AddParameter("MailBody", item.Body);
                            request.AddParameter("FromEmail", item.SenderEmailAddress);
                            request.AddParameter("ToEmail", item.To);
                            request.AddParameter("CcEmail", item.CC);
                            request.AddParameter("BccEmail", item.BCC);
                            request.AddParameter("EntryId", item.EntryID);
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
                                    MessageBox.Show("E-mail CRM uygulamanıza gönderildi");
                                }
                                else
                                {
                                    MessageBox.Show("Gönderilemedi.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hata Alındı. Hata Kodu: " + response.StatusCode.ToString());
                            }

                    }
                }

                
            
            }
        }
    }

}

