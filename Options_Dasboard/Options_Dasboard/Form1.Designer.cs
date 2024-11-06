namespace Options_Dasboard
{
    partial class HomePage
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnOptionPricing = new System.Windows.Forms.Button();
            this.btnPayoffProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(276, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(209, 16);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Welcome to the options dasboard";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(103, 25);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(594, 16);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "This dashboard is intended to help users price their options and generate an opti" +
    "on pay off diagram";
            // 
            // btnOptionPricing
            // 
            this.btnOptionPricing.Location = new System.Drawing.Point(106, 116);
            this.btnOptionPricing.Name = "btnOptionPricing";
            this.btnOptionPricing.Size = new System.Drawing.Size(167, 60);
            this.btnOptionPricing.TabIndex = 2;
            this.btnOptionPricing.Text = "Option pricing";
            this.btnOptionPricing.UseVisualStyleBackColor = true;
            // 
            // btnPayoffProfile
            // 
            this.btnPayoffProfile.Location = new System.Drawing.Point(458, 116);
            this.btnPayoffProfile.Name = "btnPayoffProfile";
            this.btnPayoffProfile.Size = new System.Drawing.Size(167, 60);
            this.btnPayoffProfile.TabIndex = 3;
            this.btnPayoffProfile.Text = "payoff Diagram";
            this.btnPayoffProfile.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 213);
            this.Controls.Add(this.btnPayoffProfile);
            this.Controls.Add(this.btnOptionPricing);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "HomePage";
            this.Text = "Login page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnOptionPricing;
        private System.Windows.Forms.Button btnPayoffProfile;
    }
}

