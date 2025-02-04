﻿namespace Options_Dasboard
{
    partial class OptionsPricing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExe = new System.Windows.Forms.Label();
            this.lblVolatility = new System.Windows.Forms.Label();
            this.lblSpot = new System.Windows.Forms.Label();
            this.lblRiskFreeRate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.txtSpot = new System.Windows.Forms.TextBox();
            this.txtRfr = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnEuroCall = new System.Windows.Forms.Button();
            this.btnEuroPut = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblVolErr = new System.Windows.Forms.Label();
            this.lblRFRerror = new System.Windows.Forms.Label();
            this.lblTimeErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExe
            // 
            this.lblExe.AutoSize = true;
            this.lblExe.Location = new System.Drawing.Point(13, 40);
            this.lblExe.Name = "lblExe";
            this.lblExe.Size = new System.Drawing.Size(95, 16);
            this.lblExe.TabIndex = 0;
            this.lblExe.Text = "Exercise price:";
            // 
            // lblVolatility
            // 
            this.lblVolatility.AutoSize = true;
            this.lblVolatility.Location = new System.Drawing.Point(12, 106);
            this.lblVolatility.Name = "lblVolatility";
            this.lblVolatility.Size = new System.Drawing.Size(179, 16);
            this.lblVolatility.TabIndex = 1;
            this.lblVolatility.Text = "Volatility(standard deviation):";
            // 
            // lblSpot
            // 
            this.lblSpot.AutoSize = true;
            this.lblSpot.Location = new System.Drawing.Point(13, 75);
            this.lblSpot.Name = "lblSpot";
            this.lblSpot.Size = new System.Drawing.Size(71, 16);
            this.lblSpot.TabIndex = 2;
            this.lblSpot.Text = "Spot price:";
            // 
            // lblRiskFreeRate
            // 
            this.lblRiskFreeRate.AutoSize = true;
            this.lblRiskFreeRate.Location = new System.Drawing.Point(13, 142);
            this.lblRiskFreeRate.Name = "lblRiskFreeRate";
            this.lblRiskFreeRate.Size = new System.Drawing.Size(84, 16);
            this.lblRiskFreeRate.TabIndex = 3;
            this.lblRiskFreeRate.Text = "risk-free rate:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 175);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // txtExe
            // 
            this.txtExe.Location = new System.Drawing.Point(115, 40);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(100, 22);
            this.txtExe.TabIndex = 5;
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(197, 106);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(100, 22);
            this.txtVol.TabIndex = 6;
            // 
            // txtSpot
            // 
            this.txtSpot.Location = new System.Drawing.Point(115, 69);
            this.txtSpot.Name = "txtSpot";
            this.txtSpot.Size = new System.Drawing.Size(100, 22);
            this.txtSpot.TabIndex = 7;
            // 
            // txtRfr
            // 
            this.txtRfr.Location = new System.Drawing.Point(103, 142);
            this.txtRfr.Name = "txtRfr";
            this.txtRfr.Size = new System.Drawing.Size(100, 22);
            this.txtRfr.TabIndex = 8;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(60, 175);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 9;
            // 
            // btnEuroCall
            // 
            this.btnEuroCall.Location = new System.Drawing.Point(316, 195);
            this.btnEuroCall.Name = "btnEuroCall";
            this.btnEuroCall.Size = new System.Drawing.Size(107, 62);
            this.btnEuroCall.TabIndex = 10;
            this.btnEuroCall.Text = "Generate European call";
            this.btnEuroCall.UseVisualStyleBackColor = true;
            this.btnEuroCall.Click += new System.EventHandler(this.btnEuroCall_Click);
            // 
            // btnEuroPut
            // 
            this.btnEuroPut.Location = new System.Drawing.Point(617, 192);
            this.btnEuroPut.Name = "btnEuroPut";
            this.btnEuroPut.Size = new System.Drawing.Size(107, 62);
            this.btnEuroPut.TabIndex = 11;
            this.btnEuroPut.Text = "Generate European Put";
            this.btnEuroPut.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(228, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(402, 16);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "This pricing model makes use of the Black-Scholes pricing method";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(486, 215);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(44, 16);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.Text = "label2";
            // 
            // lblVolErr
            // 
            this.lblVolErr.AutoSize = true;
            this.lblVolErr.Location = new System.Drawing.Point(313, 106);
            this.lblVolErr.Name = "lblVolErr";
            this.lblVolErr.Size = new System.Drawing.Size(53, 16);
            this.lblVolErr.TabIndex = 14;
            this.lblVolErr.Text = "volerror";
            // 
            // lblRFRerror
            // 
            this.lblRFRerror.AutoSize = true;
            this.lblRFRerror.Location = new System.Drawing.Point(219, 145);
            this.lblRFRerror.Name = "lblRFRerror";
            this.lblRFRerror.Size = new System.Drawing.Size(46, 16);
            this.lblRFRerror.TabIndex = 15;
            this.lblRFRerror.Text = "rfrerror";
            // 
            // lblTimeErr
            // 
            this.lblTimeErr.AutoSize = true;
            this.lblTimeErr.Location = new System.Drawing.Point(183, 178);
            this.lblTimeErr.Name = "lblTimeErr";
            this.lblTimeErr.Size = new System.Drawing.Size(52, 16);
            this.lblTimeErr.TabIndex = 16;
            this.lblTimeErr.Text = "timerror";
            // 
            // OptionsPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Options_Dasboard.Properties.Resources.options1;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.lblTimeErr);
            this.Controls.Add(this.lblRFRerror);
            this.Controls.Add(this.lblVolErr);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnEuroPut);
            this.Controls.Add(this.btnEuroCall);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtRfr);
            this.Controls.Add(this.txtSpot);
            this.Controls.Add(this.txtVol);
            this.Controls.Add(this.txtExe);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRiskFreeRate);
            this.Controls.Add(this.lblSpot);
            this.Controls.Add(this.lblVolatility);
            this.Controls.Add(this.lblExe);
            this.Name = "OptionsPricing";
            this.Text = "OptionsPricing";
            this.Load += new System.EventHandler(this.OptionsPricing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExe;
        private System.Windows.Forms.Label lblVolatility;
        private System.Windows.Forms.Label lblSpot;
        private System.Windows.Forms.Label lblRiskFreeRate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.TextBox txtVol;
        private System.Windows.Forms.TextBox txtSpot;
        private System.Windows.Forms.TextBox txtRfr;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnEuroCall;
        private System.Windows.Forms.Button btnEuroPut;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblVolErr;
        private System.Windows.Forms.Label lblRFRerror;
        private System.Windows.Forms.Label lblTimeErr;
    }
}