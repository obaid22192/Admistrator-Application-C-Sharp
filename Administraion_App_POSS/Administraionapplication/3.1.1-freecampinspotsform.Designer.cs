namespace Administraionapplication
{
    partial class freecampinspotsform
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
            this.dgvfreecamp = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnback = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfreecamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfreecamp
            // 
            this.dgvfreecamp.AllowUserToAddRows = false;
            this.dgvfreecamp.AllowUserToDeleteRows = false;
            this.dgvfreecamp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvfreecamp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.dgvfreecamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfreecamp.Location = new System.Drawing.Point(243, 16);
            this.dgvfreecamp.Name = "dgvfreecamp";
            this.dgvfreecamp.ReadOnly = true;
            this.dgvfreecamp.Size = new System.Drawing.Size(538, 346);
            this.dgvfreecamp.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(340, 377);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(102, 45);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(530, 377);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(101, 45);
            this.btnquit.TabIndex = 2;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // freecampinspotsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 476);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvfreecamp);
            this.Name = "freecampinspotsform";
            this.Text = "freecampinspotsform";
            this.Load += new System.EventHandler(this.freecampinspotsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfreecamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfreecamp;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnquit;
    }
}