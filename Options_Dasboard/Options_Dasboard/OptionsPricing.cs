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
                excercise = decimal.Parse(txtExe.Text);
                spot = decimal.Parse(txtSpot.Text);
                rfr = double.Parse(txtRfr.Text);
                vol = double.Parse(txtVol.Text);
                time = int.Parse(txtTime.Text);

                if(decimal.TryParse(txtExe.Text,out excercise)){
                    if(decimal.TryParse(txtSpot.Text,out spot))
                    {
                        if(double.TryParse(txtRfr.Text,out rfr))
                        {
                            if (double.TryParse(txtVol.Text,out vol))
                            {
                                if(int.TryParse(txtTime.Text,out time))
                                {
                                    double d1 =// cmpute formula for calculationg d1 of option. ;
                                }
                                else
                                {
                                    lblTimeErr.Text = "Enter the timeas a ratio of 365.";
                                }
                            }
                            else
                            {
                                lblVolErr.Text = "Please eneter the volatility as a percentage.";
                            }
                        }
                        else
                        {
                            lblRFRerror.Text = "Please enter the rfr as a percetage.";
                        }
                    }
                }

                
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
