using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookAddIn3
{
    public partial class Form2 : Form
    {
        public Form2()
        {



        InitializeComponent();
            label1.Text = Ribbon1.subject.ToString();
            label2.Text = Ribbon1.body.ToString();
            label3.Text = Ribbon1.senderEmailAdress.ToString();
            label4.Text = Ribbon1.senderName.ToString();
            label5.Text = Ribbon1.senderType.ToString();
            label6.Text = Ribbon1.sendUsingAccount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
