namespace Administraionapplication
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.paneldisplay = new System.Windows.Forms.Panel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.btnAssignRfids = new System.Windows.Forms.Button();
            this.btnquitmainpanel = new System.Windows.Forms.Button();
            this.btntrackevent = new System.Windows.Forms.Button();
            this.btnshops = new System.Windows.Forms.Button();
            this.btntrackvisitor = new System.Windows.Forms.Button();
            this.panlefooterparent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelfootersmall = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ttshop = new System.Windows.Forms.ToolTip(this.components);
            this.tttrackVisitor = new System.Windows.Forms.ToolTip(this.components);
            this.tttrackevent = new System.Windows.Forms.ToolTip(this.components);
            this.ttAssignrfid = new System.Windows.Forms.ToolTip(this.components);
            this.ttQuit = new System.Windows.Forms.ToolTip(this.components);
            this.paneldisplay.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.panlefooterparent.SuspendLayout();
            this.panelfootersmall.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldisplay
            // 
            this.paneldisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneldisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.paneldisplay.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.paneldisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paneldisplay.Controls.Add(this.panelmain);
            this.paneldisplay.Location = new System.Drawing.Point(11, 40);
            this.paneldisplay.Name = "paneldisplay";
            this.paneldisplay.Size = new System.Drawing.Size(879, 459);
            this.paneldisplay.TabIndex = 3;
            this.ttshop.SetToolTip(this.paneldisplay, "Shops to buy Food and Hire electronics");
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panelmain.Controls.Add(this.btnAssignRfids);
            this.panelmain.Controls.Add(this.btnquitmainpanel);
            this.panelmain.Controls.Add(this.btntrackevent);
            this.panelmain.Controls.Add(this.btnshops);
            this.panelmain.Controls.Add(this.btntrackvisitor);
            this.panelmain.Location = new System.Drawing.Point(262, 64);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(397, 382);
            this.panelmain.TabIndex = 2;
            // 
            // btnAssignRfids
            // 
            this.btnAssignRfids.Location = new System.Drawing.Point(86, 242);
            this.btnAssignRfids.Name = "btnAssignRfids";
            this.btnAssignRfids.Size = new System.Drawing.Size(205, 37);
            this.btnAssignRfids.TabIndex = 6;
            this.btnAssignRfids.Text = "Assign RFID Numer to client";
            this.ttAssignrfid.SetToolTip(this.btnAssignRfids, "Assign RFID Braclets to Visitors");
            this.btnAssignRfids.UseVisualStyleBackColor = true;
            this.btnAssignRfids.Click += new System.EventHandler(this.btnAssignRfids_Click);
            // 
            // btnquitmainpanel
            // 
            this.btnquitmainpanel.Location = new System.Drawing.Point(108, 300);
            this.btnquitmainpanel.Name = "btnquitmainpanel";
            this.btnquitmainpanel.Size = new System.Drawing.Size(157, 57);
            this.btnquitmainpanel.TabIndex = 5;
            this.btnquitmainpanel.Text = "Quit";
            this.ttQuit.SetToolTip(this.btnquitmainpanel, "Close Application\r\n");
            this.btnquitmainpanel.UseVisualStyleBackColor = true;
            this.btnquitmainpanel.Click += new System.EventHandler(this.btnquitmainpanel_Click_1);
            // 
            // btntrackevent
            // 
            this.btntrackevent.Location = new System.Drawing.Point(86, 176);
            this.btntrackevent.Name = "btntrackevent";
            this.btntrackevent.Size = new System.Drawing.Size(205, 39);
            this.btntrackevent.TabIndex = 2;
            this.btntrackevent.Text = "Track event";
            this.tttrackevent.SetToolTip(this.btntrackevent, "Get information about event Progress");
            this.btntrackevent.UseVisualStyleBackColor = true;
            this.btntrackevent.Click += new System.EventHandler(this.btntrackevent_Click_1);
            // 
            // btnshops
            // 
            this.btnshops.Location = new System.Drawing.Point(86, 25);
            this.btnshops.Name = "btnshops";
            this.btnshops.Size = new System.Drawing.Size(205, 40);
            this.btnshops.TabIndex = 0;
            this.btnshops.Text = "Shops";
            this.ttshop.SetToolTip(this.btnshops, "Shops to Buy Food And Hire Elcetronics");
            this.btnshops.UseVisualStyleBackColor = true;
            this.btnshops.Click += new System.EventHandler(this.btnshops_Click_1);
            // 
            // btntrackvisitor
            // 
            this.btntrackvisitor.Location = new System.Drawing.Point(86, 106);
            this.btntrackvisitor.Name = "btntrackvisitor";
            this.btntrackvisitor.Size = new System.Drawing.Size(205, 40);
            this.btntrackvisitor.TabIndex = 1;
            this.btntrackvisitor.Text = "Track visitor";
            this.tttrackVisitor.SetToolTip(this.btntrackvisitor, "Get All Information of Client");
            this.btntrackvisitor.UseVisualStyleBackColor = true;
            this.btntrackvisitor.Click += new System.EventHandler(this.btntrackvisitor_Click_1);
            // 
            // panlefooterparent
            // 
            this.panlefooterparent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panlefooterparent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panlefooterparent.Controls.Add(this.label1);
            this.panlefooterparent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panlefooterparent.Location = new System.Drawing.Point(8, 508);
            this.panlefooterparent.Name = "panlefooterparent";
            this.panlefooterparent.Size = new System.Drawing.Size(885, 41);
            this.panlefooterparent.TabIndex = 4;
            this.panlefooterparent.Paint += new System.Windows.Forms.PaintEventHandler(this.panlefooterparent_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "hi";
            // 
            // panelfootersmall
            // 
            this.panelfootersmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelfootersmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panelfootersmall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelfootersmall.Controls.Add(this.label2);
            this.panelfootersmall.Location = new System.Drawing.Point(691, 508);
            this.panelfootersmall.Name = "panelfootersmall";
            this.panelfootersmall.Size = new System.Drawing.Size(199, 41);
            this.panelfootersmall.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(30, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "hi";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 557);
            this.Controls.Add(this.panelfootersmall);
            this.Controls.Add(this.panlefooterparent);
            this.Controls.Add(this.paneldisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "mainwindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneldisplay.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.panlefooterparent.ResumeLayout(false);
            this.panlefooterparent.PerformLayout();
            this.panelfootersmall.ResumeLayout(false);
            this.panelfootersmall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paneldisplay;
        public System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button btnquitmainpanel;
        private System.Windows.Forms.Button btntrackevent;
        private System.Windows.Forms.Button btnshops;
        private System.Windows.Forms.Button btntrackvisitor;
        private System.Windows.Forms.Panel panlefooterparent;
        private System.Windows.Forms.Panel panelfootersmall;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssignRfids;
        private System.Windows.Forms.ToolTip ttshop;
        private System.Windows.Forms.ToolTip tttrackVisitor;
        private System.Windows.Forms.ToolTip tttrackevent;
        private System.Windows.Forms.ToolTip ttAssignrfid;
        private System.Windows.Forms.ToolTip ttQuit;

    }
}

