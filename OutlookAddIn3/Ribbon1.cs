using Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutlookAddIn3
{
   
    public partial class Ribbon1
    {
        public static string subject = string.Empty;
        public static string body = string.Empty;
        public static string senderEmailAdress = string.Empty;
        public static string senderName = string.Empty;
        public static string senderType = string.Empty;
        public static string sendUsingAccount = string.Empty;
     
        


        Inspectors inspectors;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            
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
            Form2 form2 = new Form2();
            form2.Show();
           
            inspectors = Globals.ThisAddIn.Application.Inspectors;
            var item = e.Control.Context as Inspector;
            if (item != null)
            {
                MailItem mail = item.CurrentItem as MailItem;
                if (mail != null)
                {
                    subject = mail.Subject.ToString();
                    body = mail.Body.ToString();
                    senderEmailAdress = mail.SenderEmailAddress.ToString();
                    senderName = mail.SenderName.ToString();
                    senderType = mail.SenderEmailType.ToString();
                    sendUsingAccount = mail.SendUsingAccount.ToString();
                }
            }
            else
            {
                Microsoft.Office.Interop.Outlook._Application _application = new Microsoft.Office.Interop.Outlook.Application();

                var selectionList = _application.ActiveExplorer().Selection;

                foreach (Object selObject in selectionList)
                {
                    if (selObject is Microsoft.Office.Interop.Outlook.MailItem)
                    {
                        var outlookMail = (selObject as Microsoft.Office.Interop.Outlook.MailItem);
                        subject = outlookMail.Subject.ToString();
                        body = outlookMail.Body.ToString();
                        senderEmailAdress = outlookMail.SenderEmailAddress.ToString();
                        senderName = outlookMail.SenderName.ToString();
                        senderType = outlookMail.SenderEmailType.ToString();
                        sendUsingAccount = outlookMail.SendUsingAccount.ToString();
                       
                    }
                }
            }
            label1.Label = subject.ToString();

        }
    }
}
