namespace Administraionapplication
{
    partial class trackvisitormain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelsingleentry = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnquit = new System.Windows.Forms.Button();
            this.btntracksinglevisitor = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvvisitorsmainbu = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelsingleentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisitorsmainbu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelsingleentry);
            this.panel1.Controls.Add(this.btnquit);
            this.panel1.Controls.Add(this.btntracksinglevisitor);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.dgvvisitorsmainbu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 413);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panelsingleentry
            // 
            this.panelsingleentry.BackColor = System.Drawing.Color.Red;
            this.panelsingleentry.Controls.Add(this.label1);
            this.panelsingleentry.Controls.Add(this.richTextBox1);
            this.panelsingleentry.Location = new System.Drawing.Point(273, 46);
            this.panelsingleentry.Name = "panelsingleentry";
            this.panelsingleentry.Size = new System.Drawing.Size(328, 199);
            this.panelsingleentry.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(69, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(199, 59);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(505, 350);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(84, 50);
            this.btnquit.TabIndex = 3;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btntracksinglevisitor
            // 
            this.btntracksinglevisitor.Location = new System.Drawing.Point(381, 350);
            this.btntracksinglevisitor.Name = "btntracksinglevisitor";
            this.btntracksinglevisitor.Size = new System.Drawing.Size(81, 50);
            this.btntracksinglevisitor.TabIndex = 2;
            this.btntracksinglevisitor.Text = "Track One ";
            this.btntracksinglevisitor.UseVisualStyleBackColor = true;
            this.btntracksinglevisitor.Click += new System.EventHandler(this.btntracksinglevisitor_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(247, 350);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(86, 50);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvvisitorsmainbu
            // 
            this.dgvvisitorsmainbu.AllowUserToAddRows = false;
            this.dgvvisitorsmainbu.AllowUserToDeleteRows = false;
            this.dgvvisitorsmainbu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisitorsmainbu.Location = new System.Drawing.Point(0, 3);
            this.dgvvisitorsmainbu.Name = "dgvvisitorsmainbu";
            this.dgvvisitorsmainbu.ReadOnly = true;
            this.dgvvisitorsmainbu.Size = new System.Drawing.Size(882, 313);
            this.dgvvisitorsmainbu.TabIndex = 0;
            this.dgvvisitorsmainbu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvisitorsmainbu_CellContentClick);
            this.dgvvisitorsmainbu.Click += new System.EventHandler(this.dgvvisitorsmainbu_Click);
            // 
            // trackvisitormain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(912, 479);
            this.Controls.Add(this.panel1);
            this.Name = "trackvisitormain";
            this.Text = "trackvisitormain";
            this.Load += new System.EventHandler(this.trackvisitormain_Load);
            this.panel1.ResumeLayout(false);
            this.panelsingleentry.ResumeLayout(false);
            this.panelsingleentry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisitorsmainbu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btntracksinglevisitor;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvvisitorsmainbu;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel panelsingleentry;
        public System.Windows.Forms.Label label1;
    }
}