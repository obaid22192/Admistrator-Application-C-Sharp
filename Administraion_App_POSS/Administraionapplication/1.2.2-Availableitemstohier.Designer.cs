namespace Administraionapplication
{
    partial class Availableitemstohier
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
            this.panelavailablehieritems = new System.Windows.Forms.Panel();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnsearchall = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.tbsearchitems = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvhieritems = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelavailablehieritems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhieritems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelavailablehieritems
            // 
            this.panelavailablehieritems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelavailablehieritems.Controls.Add(this.btnquit);
            this.panelavailablehieritems.Controls.Add(this.btnsearchall);
            this.panelavailablehieritems.Controls.Add(this.btnsearch);
            this.panelavailablehieritems.Controls.Add(this.tbsearchitems);
            this.panelavailablehieritems.Controls.Add(this.btnback);
            this.panelavailablehieritems.Controls.Add(this.dgvhieritems);
            this.panelavailablehieritems.Location = new System.Drawing.Point(18, 7);
            this.panelavailablehieritems.Name = "panelavailablehieritems";
            this.panelavailablehieritems.Size = new System.Drawing.Size(855, 432);
            this.panelavailablehieritems.TabIndex = 2;
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(527, 376);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(103, 45);
            this.btnquit.TabIndex = 5;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnsearchall
            // 
            this.btnsearchall.Location = new System.Drawing.Point(352, 376);
            this.btnsearchall.Name = "btnsearchall";
            this.btnsearchall.Size = new System.Drawing.Size(110, 44);
            this.btnsearchall.TabIndex = 4;
            this.btnsearchall.Text = "Refresh";
            this.btnsearchall.UseVisualStyleBackColor = true;
            this.btnsearchall.Click += new System.EventHandler(this.btnsearchall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(338, 22);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(103, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // tbsearchitems
            // 
            this.tbsearchitems.Location = new System.Drawing.Point(159, 25);
            this.tbsearchitems.Name = "tbsearchitems";
            this.tbsearchitems.Size = new System.Drawing.Size(133, 20);
            this.tbsearchitems.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(159, 376);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(120, 45);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvhieritems
            // 
            this.dgvhieritems.AllowUserToAddRows = false;
            this.dgvhieritems.AllowUserToDeleteRows = false;
            this.dgvhieritems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.dgvhieritems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhieritems.Location = new System.Drawing.Point(159, 72);
            this.dgvhieritems.Name = "dgvhieritems";
            this.dgvhieritems.ReadOnly = true;
            this.dgvhieritems.Size = new System.Drawing.Size(670, 298);
            this.dgvhieritems.TabIndex = 0;
            // 
            // Availableitemstohier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 488);
            this.Controls.Add(this.panelavailablehieritems);
            this.Name = "Availableitemstohier";
            this.Text = "Availableitemstohier";
            this.Load += new System.EventHandler(this.Availableitemstohier_Load);
            this.panelavailablehieritems.ResumeLayout(false);
            this.panelavailablehieritems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhieritems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelavailablehieritems;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnsearchall;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox tbsearchitems;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvhieritems;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}