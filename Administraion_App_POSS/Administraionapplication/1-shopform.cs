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
    public partial class Shop : Form
    {
        Mainform main;
        foodstalls foodstall;
        Loanmatrial loanshop;
        public Shop(Mainform foodshop)
        {
            InitializeComponent();
            foodstall = new foodstalls(foodshop);
            loanshop = new Loanmatrial(foodshop);
            main = foodshop;
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void btnFood_stallsmain_Click(object sender, EventArgs e)
        {
            
          
            main.label1.Text  = " ";
            main.label2.Text = "Processing....!";
            foodstall.TopLevel = false;
            foodstall.AutoScroll = true;
            foodstall.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(foodstall);
            main.label2.Text = "Done....!";
            foodstall.Show();
           
            
           
            
           
        }

        private void btnLoanmatarialmain_Click(object sender, EventArgs e)
        {
            main.label1.Text = " ";
            main.label2.Text = "Processing....!";
            loanshop.TopLevel = false;
            loanshop.AutoScroll = true;
            loanshop.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(loanshop);
            main.label2.Text = "Done....!";
            loanshop.Show();
        }

        private void btnquitfoodandloanmatarial_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbackpanelfoddandloan_Click(object sender, EventArgs e)
        {
            main.label1.Text = " ";
            main.label2.Text = "Processing....!";
            main.paneldisplay.Controls.Clear();

            main.paneldisplay.Controls.Add(main.panelmain);
            main.label2.Text = "Done....!";
          
        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
