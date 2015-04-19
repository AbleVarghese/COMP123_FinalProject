using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FinalProject
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
           
            this.labelProgrammerName.Text = "Programmer Name: Able Varghese";
            this.labelVersion.Text = "Version: 1.00v";
            this.labelContactNumber.Text = "Contact Number: +1 912 323 3434";
            this.labelWebsite.Text = "Website: MovieBonanza.com";
        }

      

        private void AboutBox_Load(object sender, EventArgs e)
        {

        }


        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
