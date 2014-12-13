namespace Administraionapplication
{
    partial class AssignRfid
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
            this.panelred = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Quit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvassignrfids = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvassignrfids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelred);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.dgvassignrfids);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 427);
            this.panel1.TabIndex = 0;
            // 
            // panelred
            // 
            this.panelred.BackColor = System.Drawing.Color.Red;
            this.panelred.Controls.Add(this.label1);
            this.panelred.Controls.Add(this.richTextBox1);
            this.panelred.Location = new System.Drawing.Point(325, 73);
            this.panelred.Name = "panelred";
            this.panelred.Size = new System.Drawing.Size(253, 185);
            this.panelred.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCAN BRACELET";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 41);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(539, 384);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(91, 33);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(290, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvassignrfids
            // 
            this.dgvassignrfids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvassignrfids.Location = new System.Drawing.Point(179, 34);
            this.dgvassignrfids.Name = "dgvassignrfids";
            this.dgvassignrfids.Size = new System.Drawing.Size(552, 318);
            this.dgvassignrfids.TabIndex = 0;
            this.dgvassignrfids.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvassignrfids_CellClick);
            this.dgvassignrfids.Click += new System.EventHandler(this.dgvassignrfids_Click);
            // 
            // AssignRfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 491);
            this.Controls.Add(this.panel1);
            this.Name = "AssignRfid";
            this.Text = "AssignRfid";
            this.Load += new System.EventHandler(this.AssignRfid_Load);
            this.panel1.ResumeLayout(false);
            this.panelred.ResumeLayout(false);
            this.panelred.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvassignrfids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvassignrfids;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelred;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
    }
}