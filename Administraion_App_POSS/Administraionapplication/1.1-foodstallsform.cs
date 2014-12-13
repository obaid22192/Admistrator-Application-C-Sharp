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
    public partial class foodstalls : Form
    {
        Mainform main;
        public foodstalls(Mainform myform)
        {
            InitializeComponent();
            main = myform;
        }

        private void btnADDproductsofpanelfoodstall_Click(object sender, EventArgs e)
        {
             main.label2.Text = "Processing....!";
            Addproducts addproduct = new Addproducts(main);
            addproduct.TopLevel = false;
            addproduct.AutoScroll = true;
            addproduct.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(addproduct);
            addproduct.Show();
            main.label2.Text = "Done....!";

        }

        private void panelfoodstall_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQUITpanelfoodstall_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBAckpanelfoodstall_Click(object sender, EventArgs e)
        {
            Shop back = new Shop(main);
            back.TopLevel = false;
            back.AutoScroll = true;
            back.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(back);
            back.Show();
        }

        private void BtnAvailableproofpanelfoodstall_Click(object sender, EventArgs e)
        {
           
            availableproducts availableproduct = new availableproducts(main);
            main.label2.Text = "Processing....!";
            availableproduct.TopLevel = false;
            availableproduct.AutoScroll = true;
            availableproduct.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(availableproduct);
           
            availableproduct.Show();
           
            


            
        }

        private void btndelproductofpanelfoodstall_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing...!";
            deletefoodproducts deleteproduct = new deletefoodproducts(main);
            deleteproduct.TopLevel = false;
            deleteproduct.AutoScroll = true;
            deleteproduct.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(deleteproduct);
            deleteproduct.Show();
            main.label2.Text = "Done...!";
           
        }
    }
}
