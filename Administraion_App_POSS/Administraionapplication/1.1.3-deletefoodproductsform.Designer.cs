﻿namespace Administraionapplication
{
    partial class deletefoodproducts
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
            this.paneldeletefood = new System.Windows.Forms.Panel();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnsearchall = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvdeletefood = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paneldeletefood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletefood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldeletefood
            // 
            this.paneldeletefood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneldeletefood.Controls.Add(this.btnquit);
            this.paneldeletefood.Controls.Add(this.btnsearchall);
            this.paneldeletefood.Controls.Add(this.btnsearch);
            this.paneldeletefood.Controls.Add(this.textBox1);
            this.paneldeletefood.Controls.Add(this.btnback);
            this.paneldeletefood.Controls.Add(this.dgvdeletefood);
            this.paneldeletefood.Location = new System.Drawing.Point(20, 12);
            this.paneldeletefood.Name = "paneldeletefood";
            this.paneldeletefood.Size = new System.Drawing.Size(854, 443);
            this.paneldeletefood.TabIndex = 4;
            this.paneldeletefood.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldeletefood_Paint);
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(595, 389);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(103, 45);
            this.btnquit.TabIndex = 5;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnsearchall
            // 
            this.btnsearchall.Location = new System.Drawing.Point(445, 389);
            this.btnsearchall.Name = "btnsearchall";
            this.btnsearchall.Size = new System.Drawing.Size(110, 44);
            this.btnsearchall.TabIndex = 4;
            this.btnsearchall.Text = "Delete All";
            this.btnsearchall.UseVisualStyleBackColor = true;
            this.btnsearchall.Click += new System.EventHandler(this.btnsearchall_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(286, 390);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(119, 44);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Delete";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(139, 389);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(120, 45);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvdeletefood
            // 
            this.dgvdeletefood.AllowUserToAddRows = false;
            this.dgvdeletefood.AllowUserToDeleteRows = false;
            this.dgvdeletefood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.dgvdeletefood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeletefood.Location = new System.Drawing.Point(21, 57);
            this.dgvdeletefood.Name = "dgvdeletefood";
            this.dgvdeletefood.ReadOnly = true;
            this.dgvdeletefood.Size = new System.Drawing.Size(801, 316);
            this.dgvdeletefood.TabIndex = 0;
            this.dgvdeletefood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeletefood_CellContentClick);
            // 
            // deletefoodproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 504);
            this.Controls.Add(this.paneldeletefood);
            this.Name = "deletefoodproducts";
            this.Text = "deletefoodproducts";
            this.Load += new System.EventHandler(this.deletefoodproducts_Load);
            this.paneldeletefood.ResumeLayout(false);
            this.paneldeletefood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletefood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paneldeletefood;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnsearchall;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvdeletefood;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}