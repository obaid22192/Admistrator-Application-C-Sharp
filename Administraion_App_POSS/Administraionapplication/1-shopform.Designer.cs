namespace Administraionapplication
{
    partial class Shop
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
            this.components = new System.ComponentModel.Container();
            this.panelfoodandloanmain = new System.Windows.Forms.Panel();
            this.btnquitfoodandloanmatarial = new System.Windows.Forms.Button();
            this.btnbackpanelfoddandloan = new System.Windows.Forms.Button();
            this.btnLoanmatarialmain = new System.Windows.Forms.Button();
            this.btnFood_stallsmain = new System.Windows.Forms.Button();
            this.ttfoodstall = new System.Windows.Forms.ToolTip(this.components);
            this.ttloan = new System.Windows.Forms.ToolTip(this.components);
            this.ttback = new System.Windows.Forms.ToolTip(this.components);
            this.ttquit = new System.Windows.Forms.ToolTip(this.components);
            this.panelfoodandloanmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfoodandloanmain
            // 
            this.panelfoodandloanmain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelfoodandloanmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panelfoodandloanmain.Controls.Add(this.btnquitfoodandloanmatarial);
            this.panelfoodandloanmain.Controls.Add(this.btnbackpanelfoddandloan);
            this.panelfoodandloanmain.Controls.Add(this.btnLoanmatarialmain);
            this.panelfoodandloanmain.Controls.Add(this.btnFood_stallsmain);
            this.panelfoodandloanmain.Location = new System.Drawing.Point(253, 91);
            this.panelfoodandloanmain.Name = "panelfoodandloanmain";
            this.panelfoodandloanmain.Size = new System.Drawing.Size(383, 338);
            this.panelfoodandloanmain.TabIndex = 4;
            // 
            // btnquitfoodandloanmatarial
            // 
            this.btnquitfoodandloanmatarial.Location = new System.Drawing.Point(214, 208);
            this.btnquitfoodandloanmatarial.Name = "btnquitfoodandloanmatarial";
            this.btnquitfoodandloanmatarial.Size = new System.Drawing.Size(83, 57);
            this.btnquitfoodandloanmatarial.TabIndex = 3;
            this.btnquitfoodandloanmatarial.Text = "Quit";
            this.ttquit.SetToolTip(this.btnquitfoodandloanmatarial, "Close Application");
            this.btnquitfoodandloanmatarial.UseVisualStyleBackColor = true;
            this.btnquitfoodandloanmatarial.Click += new System.EventHandler(this.btnquitfoodandloanmatarial_Click);
            // 
            // btnbackpanelfoddandloan
            // 
            this.btnbackpanelfoddandloan.Location = new System.Drawing.Point(101, 208);
            this.btnbackpanelfoddandloan.Name = "btnbackpanelfoddandloan";
            this.btnbackpanelfoddandloan.Size = new System.Drawing.Size(88, 57);
            this.btnbackpanelfoddandloan.TabIndex = 2;
            this.btnbackpanelfoddandloan.Text = "Back";
            this.ttback.SetToolTip(this.btnbackpanelfoddandloan, "Previous Page");
            this.btnbackpanelfoddandloan.UseVisualStyleBackColor = true;
            this.btnbackpanelfoddandloan.Click += new System.EventHandler(this.btnbackpanelfoddandloan_Click);
            // 
            // btnLoanmatarialmain
            // 
            this.btnLoanmatarialmain.Location = new System.Drawing.Point(101, 138);
            this.btnLoanmatarialmain.Name = "btnLoanmatarialmain";
            this.btnLoanmatarialmain.Size = new System.Drawing.Size(196, 51);
            this.btnLoanmatarialmain.TabIndex = 1;
            this.btnLoanmatarialmain.Text = "Loan Matarial";
            this.ttloan.SetToolTip(this.btnLoanmatarialmain, "Electronic Hire Section");
            this.btnLoanmatarialmain.UseVisualStyleBackColor = true;
            this.btnLoanmatarialmain.Click += new System.EventHandler(this.btnLoanmatarialmain_Click);
            // 
            // btnFood_stallsmain
            // 
            this.btnFood_stallsmain.Location = new System.Drawing.Point(101, 59);
            this.btnFood_stallsmain.Name = "btnFood_stallsmain";
            this.btnFood_stallsmain.Size = new System.Drawing.Size(196, 50);
            this.btnFood_stallsmain.TabIndex = 0;
            this.btnFood_stallsmain.Text = "Food Stalls";
            this.ttfoodstall.SetToolTip(this.btnFood_stallsmain, "Food And Drinks ");
            this.btnFood_stallsmain.UseVisualStyleBackColor = true;
            this.btnFood_stallsmain.Click += new System.EventHandler(this.btnFood_stallsmain_Click);
            // 
            // ttback
            // 
            this.ttback.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip3_Popup);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 522);
            this.Controls.Add(this.panelfoodandloanmain);
            this.Name = "Shop";
            this.Text = "shopsform";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.panelfoodandloanmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnquitfoodandloanmatarial;
        private System.Windows.Forms.Button btnbackpanelfoddandloan;
        private System.Windows.Forms.Button btnLoanmatarialmain;
        private System.Windows.Forms.Button btnFood_stallsmain;
        public System.Windows.Forms.Panel panelfoodandloanmain;
        private System.Windows.Forms.ToolTip ttfoodstall;
        private System.Windows.Forms.ToolTip ttloan;
        private System.Windows.Forms.ToolTip ttback;
        private System.Windows.Forms.ToolTip ttquit;
    }
}