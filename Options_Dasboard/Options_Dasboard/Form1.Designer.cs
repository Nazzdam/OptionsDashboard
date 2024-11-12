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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsPricingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsPayoffProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDesc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsPricingToolStripMenuItem,
            this.optionsPayoffProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsPricingToolStripMenuItem
            // 
            this.optionsPricingToolStripMenuItem.Name = "optionsPricingToolStripMenuItem";
            this.optionsPricingToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.optionsPricingToolStripMenuItem.Text = "Options Pricing";
            this.optionsPricingToolStripMenuItem.Click += new System.EventHandler(this.optionsPricingToolStripMenuItem_Click);
            // 
            // optionsPayoffProfileToolStripMenuItem
            // 
            this.optionsPayoffProfileToolStripMenuItem.Name = "optionsPayoffProfileToolStripMenuItem";
            this.optionsPayoffProfileToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.optionsPayoffProfileToolStripMenuItem.Text = "Options payoff Profile";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(32, 46);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(703, 16);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Welcome to the options dashboard.This dashboard allows for the pricing on option " +
    "and to generate the payoff profiles.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 423);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Home page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsPricingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsPayoffProfileToolStripMenuItem;
        private System.Windows.Forms.Label lblDesc;
    }
}

