using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boss_of_this_Gym
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSdeck_Click(object sender, EventArgs e)
        {
            Sdack newForm = new Sdack();
            newForm.Owner = this;
            newForm.Show();
        }

        private void buttonOPN_Click(object sender, EventArgs e)
        {
            OPN newForm = new OPN();
            newForm.Owner = this;
            newForm.Show();
        }

        private void buttonSortings_Click(object sender, EventArgs e)
        {
            Sorting newForm = new Sorting();
            newForm.Owner = this;
            newForm.Show();
        }

        private void buttonAutomat_Click(object sender, EventArgs e)
        {
            Automat newForm = new Automat();
            newForm.Owner = this;
            newForm.Show();
        }
    }
}
