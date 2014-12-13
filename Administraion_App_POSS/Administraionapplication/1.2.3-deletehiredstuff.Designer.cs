namespace Administraionapplication
{
    partial class deletehiredstuff
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
            this.paneldeletehirestuff = new System.Windows.Forms.Panel();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnsearchall = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvdeletehirestuff = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paneldeletehirestuff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletehirestuff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldeletehirestuff
            // 
            this.paneldeletehirestuff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneldeletehirestuff.Controls.Add(this.btnquit);
            this.paneldeletehirestuff.Controls.Add(this.btnsearchall);
            this.paneldeletehirestuff.Controls.Add(this.btnsearch);
            this.paneldeletehirestuff.Controls.Add(this.textBox1);
            this.paneldeletehirestuff.Controls.Add(this.btnback);
            this.paneldeletehirestuff.Controls.Add(this.dgvdeletehirestuff);
            this.paneldeletehirestuff.Location = new System.Drawing.Point(16, 12);
            this.paneldeletehirestuff.Name = "paneldeletehirestuff";
            this.paneldeletehirestuff.Size = new System.Drawing.Size(854, 427);
            this.paneldeletehirestuff.TabIndex = 3;
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(676, 374);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(103, 45);
            this.btnquit.TabIndex = 5;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnsearchall
            // 
            this.btnsearchall.Location = new System.Drawing.Point(513, 374);
            this.btnsearchall.Name = "btnsearchall";
            this.btnsearchall.Size = new System.Drawing.Size(110, 44);
            this.btnsearchall.TabIndex = 4;
            this.btnsearchall.Text = "Delete All";
            this.btnsearchall.UseVisualStyleBackColor = true;
            this.btnsearchall.Click += new System.EventHandler(this.btnsearchall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(353, 375);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(111, 44);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Delete";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(192, 374);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(120, 45);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvdeletehirestuff
            // 
            this.dgvdeletehirestuff.AllowUserToAddRows = false;
            this.dgvdeletehirestuff.AllowUserToDeleteRows = false;
            this.dgvdeletehirestuff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.dgvdeletehirestuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeletehirestuff.Location = new System.Drawing.Point(177, 48);
            this.dgvdeletehirestuff.Name = "dgvdeletehirestuff";
            this.dgvdeletehirestuff.ReadOnly = true;
            this.dgvdeletehirestuff.Size = new System.Drawing.Size(641, 309);
            this.dgvdeletehirestuff.TabIndex = 0;
            this.dgvdeletehirestuff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeletehirestuff_CellContentClick);
            // 
            // deletehiredstuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 524);
            this.Controls.Add(this.paneldeletehirestuff);
            this.Name = "deletehiredstuff";
            this.Text = "deletehiredstuff";
            this.Load += new System.EventHandler(this.deletehiredstuff_Load);
            this.paneldeletehirestuff.ResumeLayout(false);
            this.paneldeletehirestuff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletehirestuff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paneldeletehirestuff;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnsearchall;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvdeletehirestuff;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}