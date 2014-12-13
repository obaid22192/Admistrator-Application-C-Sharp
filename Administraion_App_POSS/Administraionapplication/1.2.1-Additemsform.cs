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
    public partial class Additems : Form
    {
        Mainform main;
        DataHelper dh;
        public Additems(Mainform form)
        {
            InitializeComponent();
            main = form;
            dh = new DataHelper();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label1.Text = " ";
            main.label2.Text = "Processing....!";
            Loanmatrial temp = new Loanmatrial(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            main.label2.Text = "Done....!";
            temp.Show();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int holder = 0;
            try
            {
                main.label2.Text = "Done...!";
                holder = dh.AddhiredItem(Convert.ToInt32(tbproductid.Text), tbname.Text, tbdescription.Text, Convert.ToInt32(tbprice.Text));
               
                

                    main.label1.Text =  " 1  Record Added secessfully ";
                    main.label2.Text = "Done...!";
              

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                main.label1.Text = ex.Message;
            }
            switch (holder)
            {
                case -1:
                    MessageBox.Show("error", "Cannot connect to server. Contact administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     main.label1.Text = "Record insertion Faild ";
                     main.label2.Text = "Error...!";
                    break;
                case 1045:

                    MessageBox.Show("error", "Invalid username/password, please try again ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     main.label1.Text = "Record insertion Faild ";
                     main.label2.Text = "Error...!";
                     break;
            }
        }
    }
}
