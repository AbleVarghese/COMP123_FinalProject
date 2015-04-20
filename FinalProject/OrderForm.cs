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
        //Constructor of Order form Class ###################################################
        public OrderForm()
        {
            InitializeComponent();

        }

        // Stream button click navigates from order form to selection form
        private void StreamButtonClick(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            this.Hide();
            streamForm.Owner = this;
            streamForm.Show();

        }

        //Cancel Button click action (exiting he app).
        private void CancelButtonClick(object sender, EventArgs e)
        {
            Application.Exit();

        }



        //Print button click execute the print preview dialogbox
        private void PrintButtonClick(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }


        //About button click - Showing about button
        private void AboutButtonClick(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            this.Hide();
            aboutBox.Owner = this;
            aboutBox.Show();

        }

        //Back button click that takes from order form to the selection form
        private void backButtonClick(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            this.Hide();
            selectionForm.Owner = this;
            selectionForm.Show();
        }



    }
}