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
    public partial class OptionsPricing : Form
    {
        // Decleration of public variables to be used by the whole class
        decimal excercise, spot;
        double rfr, vol;
        int time;

        private void btnEuroCall_Click(object sender, EventArgs e)
        {
            /*This button will be used to calculate the value of a European call option by making use of the Black-Scholes model 
             * and will use the formula SN(d1)-Xe^-rTN(d2)*/

            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OptionsPricing()
        {
            InitializeComponent();
           
        }

        private void OptionsPricing_Load(object sender, EventArgs e)
        {
            lblOutput.Hide();
            lblRFRerror.Hide();
            lblTimeErr.Hide();
            lblVolErr.Hide();
        }
    }
}
