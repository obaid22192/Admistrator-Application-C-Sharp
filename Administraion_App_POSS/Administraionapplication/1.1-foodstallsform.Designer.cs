namespace Administraionapplication
{
    partial class foodstalls
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
            this.panelfoodstall = new System.Windows.Forms.Panel();
            this.BtnAvailableproofpanelfoodstall = new System.Windows.Forms.Button();
            this.btndelproductofpanelfoodstall = new System.Windows.Forms.Button();
            this.btnADDproductsofpanelfoodstall = new System.Windows.Forms.Button();
            this.btnQUITpanelfoodstall = new System.Windows.Forms.Button();
            this.btnBAckpanelfoodstall = new System.Windows.Forms.Button();
            this.ttaddproducts = new System.Windows.Forms.ToolTip(this.components);
            this.ttavailableproducts = new System.Windows.Forms.ToolTip(this.components);
            this.ttdelete = new System.Windows.Forms.ToolTip(this.components);
            this.ttquit = new System.Windows.Forms.ToolTip(this.components);
            this.ttback = new System.Windows.Forms.ToolTip(this.components);
            this.panelfoodstall.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfoodstall
            // 
            this.panelfoodstall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelfoodstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panelfoodstall.Controls.Add(this.BtnAvailableproofpanelfoodstall);
            this.panelfoodstall.Controls.Add(this.btndelproductofpanelfoodstall);
            this.panelfoodstall.Controls.Add(this.btnADDproductsofpanelfoodstall);
            this.panelfoodstall.Controls.Add(this.btnQUITpanelfoodstall);
            this.panelfoodstall.Controls.Add(this.btnBAckpanelfoodstall);
            this.panelfoodstall.Location = new System.Drawing.Point(281, 75);
            this.panelfoodstall.Name = "panelfoodstall";
            this.panelfoodstall.Size = new System.Drawing.Size(383, 338);
            this.panelfoodstall.TabIndex = 5;
            this.panelfoodstall.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfoodstall_Paint);
            // 
            // BtnAvailableproofpanelfoodstall
            // 
            this.BtnAvailableproofpanelfoodstall.Location = new System.Drawing.Point(73, 111);
            this.BtnAvailableproofpanelfoodstall.Name = "BtnAvailableproofpanelfoodstall";
            this.BtnAvailableproofpanelfoodstall.Size = new System.Drawing.Size(196, 51);
            this.BtnAvailableproofpanelfoodstall.TabIndex = 8;
            this.BtnAvailableproofpanelfoodstall.Text = "Available Products";
            this.ttavailableproducts.SetToolTip(this.BtnAvailableproofpanelfoodstall, "List of All products or Search for specific product");
            this.BtnAvailableproofpanelfoodstall.UseVisualStyleBackColor = true;
            this.BtnAvailableproofpanelfoodstall.Click += new System.EventHandler(this.BtnAvailableproofpanelfoodstall_Click);
            // 
            // btndelproductofpanelfoodstall
            // 
            this.btndelproductofpanelfoodstall.Location = new System.Drawing.Point(73, 182);
            this.btndelproductofpanelfoodstall.Name = "btndelproductofpanelfoodstall";
            this.btndelproductofpanelfoodstall.Size = new System.Drawing.Size(196, 48);
            this.btndelproductofpanelfoodstall.TabIndex = 7;
            this.btndelproductofpanelfoodstall.Text = "Delete Product";
            this.ttdelete.SetToolTip(this.btndelproductofpanelfoodstall, "Delete Specific product or Delete All");
            this.btndelproductofpanelfoodstall.UseVisualStyleBackColor = true;
            this.btndelproductofpanelfoodstall.Click += new System.EventHandler(this.btndelproductofpanelfoodstall_Click);
            // 
            // btnADDproductsofpanelfoodstall
            // 
            this.btnADDproductsofpanelfoodstall.Location = new System.Drawing.Point(73, 46);
            this.btnADDproductsofpanelfoodstall.Name = "btnADDproductsofpanelfoodstall";
            this.btnADDproductsofpanelfoodstall.Size = new System.Drawing.Size(196, 50);
            this.btnADDproductsofpanelfoodstall.TabIndex = 6;
            this.btnADDproductsofpanelfoodstall.Text = "Add products";
            this.ttaddproducts.SetToolTip(this.btnADDproductsofpanelfoodstall, "Add products");
            this.btnADDproductsofpanelfoodstall.UseVisualStyleBackColor = true;
            this.btnADDproductsofpanelfoodstall.Click += new System.EventHandler(this.btnADDproductsofpanelfoodstall_Click);
            // 
            // btnQUITpanelfoodstall
            // 
            this.btnQUITpanelfoodstall.Location = new System.Drawing.Point(186, 252);
            this.btnQUITpanelfoodstall.Name = "btnQUITpanelfoodstall";
            this.btnQUITpanelfoodstall.Size = new System.Drawing.Size(83, 57);
            this.btnQUITpanelfoodstall.TabIndex = 5;
            this.btnQUITpanelfoodstall.Text = "Quit";
            this.ttquit.SetToolTip(this.btnQUITpanelfoodstall, "Close Application\r\n");
            this.btnQUITpanelfoodstall.UseVisualStyleBackColor = true;
            this.btnQUITpanelfoodstall.Click += new System.EventHandler(this.btnQUITpanelfoodstall_Click);
            // 
            // btnBAckpanelfoodstall
            // 
            this.btnBAckpanelfoodstall.Location = new System.Drawing.Point(73, 252);
            this.btnBAckpanelfoodstall.Name = "btnBAckpanelfoodstall";
            this.btnBAckpanelfoodstall.Size = new System.Drawing.Size(88, 57);
            this.btnBAckpanelfoodstall.TabIndex = 4;
            this.btnBAckpanelfoodstall.Text = "Back";
            this.ttback.SetToolTip(this.btnBAckpanelfoodstall, "Previous Page");
            this.btnBAckpanelfoodstall.UseVisualStyleBackColor = true;
            this.btnBAckpanelfoodstall.Click += new System.EventHandler(this.btnBAckpanelfoodstall_Click);
            // 
            // foodstalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 518);
            this.Controls.Add(this.panelfoodstall);
            this.Name = "foodstalls";
            this.Text = "foodstalls";
            this.panelfoodstall.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAvailableproofpanelfoodstall;
        private System.Windows.Forms.Button btndelproductofpanelfoodstall;
        private System.Windows.Forms.Button btnADDproductsofpanelfoodstall;
        private System.Windows.Forms.Button btnQUITpanelfoodstall;
        private System.Windows.Forms.Button btnBAckpanelfoodstall;
        public System.Windows.Forms.Panel panelfoodstall;
        private System.Windows.Forms.ToolTip ttaddproducts;
        private System.Windows.Forms.ToolTip ttavailableproducts;
        private System.Windows.Forms.ToolTip ttdelete;
        private System.Windows.Forms.ToolTip ttquit;
        private System.Windows.Forms.ToolTip ttback;

    }
}