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
            Form2 form2 = new Form2();
            form2.Show();
           
      
           
            }

        private void button1_Click(object sender, Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs e)
        {
         
        }
    }
    }

