using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class OrderForm : Form
    {
       
        public OrderForm()
        {
            InitializeComponent();
         
        }

      

       

        private void StreamButtonClick(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            this.Hide();
            streamForm.Owner = this;
            streamForm.Show();

        }


        private void CancelButtonClick(object sender, EventArgs e)
        {
            Application.Exit();

        }


        

        private void PrintButtonClick(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();  
        }



        private void AboutButtonClick(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            this.Hide();
            aboutBox.Owner = this;
            aboutBox.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            this.Hide();
            selectionForm.Owner = this;
            selectionForm.Show();

        }

       

    }
}
