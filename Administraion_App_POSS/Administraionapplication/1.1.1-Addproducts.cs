using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administraionapplication
{
    public partial class Addproducts : Form
    {
        Mainform main;
        DataHelper dh;
        public Addproducts(Mainform form)
        {
            InitializeComponent();
            main = form;
            dh = new DataHelper();
            dtpmanufacture.Format = DateTimePickerFormat.Custom;
            dtpmanufacture.CustomFormat = "yyyy-MM-dd";
            dtpexpire.Format = DateTimePickerFormat.Custom;
            dtpexpire.CustomFormat = "yyyy-MM-dd";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void paneladdproducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            foodstalls temp = new foodstalls(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            temp.Show();
            main.label2.Text = "Done....!";
            main.label1.Text = " ";
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            Application.Exit();
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            try
            {
                DateTime expiredate = dtpexpire.Value.Date;
                DateTime manufacturedate = dtpmanufacture.Value.Date;
                // MessageBox.Show(manufacturedate.ToString());
                int holder = dh.Addproduct(Convert.ToDouble(tbproductid.Text), Convert.ToDouble(tbbrandid.Text), tbname.Text, Convert.ToDouble(tbprice.Text), expiredate, manufacturedate, Convert.ToInt32(tbquantity.Text));
                if (holder == -1)
                {
                    MessageBox.Show(" " , "Error while adding product", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    main.label2.Text = "Error....!";
                    main.label1.Text = "";
                }
                else
                {
                    main.label1.Text = holder + "Record Inserted Sucessfully...!";
                    main.label2.Text = "Done....!";
                   
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , " " , MessageBoxButtons.OK , MessageBoxIcon.Error);
                main.label2.Text = "Error....!";
                main.label1.Text = "";
            }
        }
    }
}
