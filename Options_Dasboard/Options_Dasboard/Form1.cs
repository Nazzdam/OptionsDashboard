using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Options_Dasboard
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private void optionsPricingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsPricing PricingView = new OptionsPricing();
            PricingView.MdiParent = this;
            PricingView.Show();
        }

        private void optionsPayoffProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payoff_Profile Profiles= new Payoff_Profile();
            Profiles.MdiParent = this;
            Profiles.Show();
        }
    }
}
