namespace Administraionapplication
{
    partial class Additems
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
            this.paneladditems = new System.Windows.Forms.Panel();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbproductid = new System.Windows.Forms.TextBox();
            this.tbdescription = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.paneladditems.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneladditems
            // 
            this.paneladditems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paneladditems.Controls.Add(this.btnquit);
            this.paneladditems.Controls.Add(this.btnadd);
            this.paneladditems.Controls.Add(this.btnback);
            this.paneladditems.Controls.Add(this.label6);
            this.paneladditems.Controls.Add(this.tbprice);
            this.paneladditems.Controls.Add(this.label3);
            this.paneladditems.Controls.Add(this.label2);
            this.paneladditems.Controls.Add(this.label1);
            this.paneladditems.Controls.Add(this.tbproductid);
            this.paneladditems.Controls.Add(this.tbdescription);
            this.paneladditems.Controls.Add(this.tbname);
            this.paneladditems.Location = new System.Drawing.Point(245, 104);
            this.paneladditems.Name = "paneladditems";
            this.paneladditems.Size = new System.Drawing.Size(486, 321);
            this.paneladditems.TabIndex = 5;
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(331, 249);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(89, 46);
            this.btnquit.TabIndex = 52;
            this.btnquit.Text = "Quit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(207, 249);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(99, 46);
            this.btnadd.TabIndex = 51;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(68, 249);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(105, 46);
            this.btnback.TabIndex = 50;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(65, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Product Name";
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(285, 150);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(135, 20);
            this.tbprice.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(65, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Rental Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Product Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Product(Barcode)";
            // 
            // tbproductid
            // 
            this.tbproductid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbproductid.Location = new System.Drawing.Point(286, 26);
            this.tbproductid.Name = "tbproductid";
            this.tbproductid.Size = new System.Drawing.Size(135, 20);
            this.tbproductid.TabIndex = 42;
            // 
            // tbdescription
            // 
            this.tbdescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbdescription.Location = new System.Drawing.Point(286, 108);
            this.tbdescription.Name = "tbdescription";
            this.tbdescription.Size = new System.Drawing.Size(135, 20);
            this.tbdescription.TabIndex = 44;
            // 
            // tbname
            // 
            this.tbname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbname.Location = new System.Drawing.Point(286, 66);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(135, 20);
            this.tbname.TabIndex = 43;
            // 
            // Additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.BackgroundImage = global::Administraionapplication.Properties.Resources.bee_sweet_request_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 504);
            this.Controls.Add(this.paneladditems);
            this.Name = "Additems";
            this.Text = "Additems";
            this.paneladditems.ResumeLayout(false);
            this.paneladditems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paneladditems;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbproductid;
        public System.Windows.Forms.TextBox tbdescription;
        public System.Windows.Forms.TextBox tbname;
    }
}