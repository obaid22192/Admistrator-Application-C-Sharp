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
    public partial class Mainform : XCoolForm.XCoolForm
    {
        Shop myForm;
        //foodstalls foodstall;

        public Mainform()
        {
            InitializeComponent();
            myForm = new Shop(this);
         
          this.Icon = Properties.Resources.Poss_Logo;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.panelfoodandloanmain.Visible = false;
            //this.panelfoodstall.Visible = false;
            
            
        }
        // ***************PANEl MAIN bUTTON EVENTS************************
        

        

        private void btnshops_Click_1(object sender, EventArgs e)// 1
        {
            

           
            
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            paneldisplay.Controls.Clear();
            paneldisplay.Controls.Add(myForm);
            
            // Form1.Panel1.Controls.Add(myForm);
            myForm.Show();
            //this.panel2.Visible = false;
             
           // paneldisplay.Controls.Clear();
            //paneldisplay.Controls.Add(panelfoodandloanmain);
           // panelfoodandloanmain.Visible = true;
            //panelLoanmatarials.Visible = false;
            //shop.Show();
           
        }
          private void btntrackvisitor_Click_1(object sender, EventArgs e)//2
        {
            label1.Text = "";
            label2.Text = "Processing...!";
            trackvisitormain temp = new trackvisitormain(this);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            this.paneldisplay.Controls.Clear();
            this.paneldisplay.Controls.Add(temp);
            label2.Text = "Done....!";
            temp.Show();
        }

        private void btntrackevent_Click_1(object sender, EventArgs e)//3
        {
            label1.Text = "";
            label2.Text = "Processing...!";
            Trackevent temp = new Trackevent(this);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            this.paneldisplay.Controls.Clear();
            this.paneldisplay.Controls.Add(temp);
            label2.Text = "Done....!";
            temp.Show();
        }

        private void btnbackmainpanel_Click_1(object sender, EventArgs e)//4
        {

        }

        private void btnquitmainpanel_Click_1(object sender, EventArgs e)//5
        {
            Application.Exit();
        }

        private void panlefooterparent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssignRfids_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "Processing...!";
            AssignRfid temp = new AssignRfid(this);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            this.paneldisplay.Controls.Clear();
            this.paneldisplay.Controls.Add(temp);
            label2.Text = "Done....!";
            temp.Show();
            label1.Text = "Please Click Under the RFID Colum to assign rfid";
        }

          //******************END MAINPANEL EVENTS**************************


       
    }
}
