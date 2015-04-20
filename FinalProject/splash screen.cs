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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
//3 second timer setting function
        private void timer_Tick(object sender, EventArgs e)
        {
            
            SelectionForm selectionForm = new SelectionForm();

            this.Hide();
            selectionForm.Show();
            timer.Enabled = false;

        }
    }
}
