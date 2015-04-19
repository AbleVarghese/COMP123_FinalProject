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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm();
            this.Hide();
            streamForm.Owner = this;
            streamForm.Show();
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
           

        }

        private void AboutButtonClick(object sender, EventArgs e)
        {

        }

       

    }
}
