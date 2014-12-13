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
    public partial class Loanmatrial :Form
    {
        Mainform main;
        public Loanmatrial(Mainform form)
        {
            InitializeComponent();

            main = form;
        }

        private void btnQuitpanelLoanmatarials_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbackpanelLoanmatarials_Click(object sender, EventArgs e)
        {
           
            Shop back = new Shop(main);
            back.TopLevel = false;
            back.AutoScroll = true;
            back.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(back);
            main.label2.Text = "Done....!";
            back.Show();
        }

        private void btnAddItemofpanelLoanmatarials_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            main.label1.Text = "";
            Additems temp = new Additems(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            main.label2.Text = "Done....!";
            temp.Show();
        }

        private void btnAvailableitemofpanelLoanmatarials_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            main.label1.Text = "";
            Availableitemstohier temp = new Availableitemstohier(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            main.label2.Text = "Done....!";
            temp.Show();
        }

        private void btndeleteofpanelLoanmatarials_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            
            main.label1.Text = "";
           deletehiredstuff temp = new deletehiredstuff(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            main.label2.Text = "Done";
            temp.Show();
        }
    }
}
