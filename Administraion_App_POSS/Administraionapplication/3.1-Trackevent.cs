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
    public partial class Trackevent : Form
    {
        string error = "Error";
        DataHelper dhelper;
        Mainform main;
        public Trackevent(Mainform form)
        {
            InitializeComponent();
            main = form;
            dhelper = new DataHelper();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";

            main.label1.Text = " ";
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(main.panelmain);
            main.label2.Text = "Done....!";
            main.Show();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnconfirmedreservations_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing.....!";
            int holder = dhelper.yetvisitingtheevent();

            switch (holder)
            {

                case -1:
                    MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 1045:

                    MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;


            }
            main.label2.Text = "Done..!";

            main.label1.Text = holder + "  Records Found";
            lboutput.Items.Clear();
            lboutput.Items.Add(holder.ToString() + " : visitors are yet visiting the event");
        }

        private void btnnrofresvervations_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing.....!";
            int holder = dhelper.willvisitevent();

            switch (holder)
            {

                case -1:
                    MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 1045:

                    MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;


            }
            main.label2.Text = "Done..!";

            main.label1.Text = "Succeed";
            lboutput.Items.Clear();
            lboutput.Items.Add(holder.ToString() + " : visitors will visit the event");
        }

        private void btntotalbalance_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing.....!";

            int holder = dhelper.SumofBalance();

            switch (holder)
            {

                case -1:
                    MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 1045:

                    MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;


            }
            main.label2.Text = "Done..!";

            main.label1.Text = holder + "  Records Found";

            lboutput.Items.Clear();
            lboutput.Items.Add("Total Balance Of All Accounts is  :  " + holder.ToString() + "  Euros ");
        }

        private void btntotalpaid_Click(object sender, EventArgs e)
        {
            int totalbalance = dhelper.SumofBalance();
            int total_event_paymentfee = dhelper.Eventpaymenttotal();
            int totalamountofcamps = dhelper.sumofcampamount();
            int result = total_event_paymentfee + totalbalance + totalamountofcamps;
            lboutput.Items.Clear();
          
            lboutput.Items.Add( "Total Balance Of Visitors  is  "  +totalbalance +"  Euros ");
            lboutput.Items.Add( "Total Event Entry Amount is :"+ total_event_paymentfee + " Euros ");
            lboutput.Items.Add("Total Amount Received from camping spots is : " + totalamountofcamps + " Euros");
            lboutput.Items.Add("Total Amount Received in this Event is : " + result + " Euros");
            main.label2.Text = "Done..!";

            main.label1.Text = "Succeed";
        }

        private void btnbookedspotsandamount_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing.....!";
            int numberofcampsbooked = dhelper.NrofCampspotsBooked();
            int totalamountofcamps = dhelper.sumofcampamount();

            lboutput.Items.Clear();
            lboutput.Items.Add(numberofcampsbooked + "  Camping spots Has been booked");
            lboutput.Items.Add("Total Amount Received from camping spots is : " + totalamountofcamps + " Euros");
            //main.label2.Text = "Done..!";

            main.label1.Text = "Succeed";
        }

        private void btnfreecampingspots_Click(object sender, EventArgs e)
        {
            freecampinspotsform free = new freecampinspotsform(main);
            free.TopLevel = false;
            free.AutoScroll = true;
            free.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(free);
            free.Show();


        }

        private void btneventleft_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing.....!";
            int holder = dhelper.checkout();

            switch (holder)
            {

                case -1:
                    MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 1045:

                    MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;


            }
            main.label2.Text = "Done..!";

            main.label1.Text = "Succeed";
            lboutput.Items.Clear();
            if (holder == 0)
            {
                lboutput.Items.Add("No one have left event yet ");
            }
            else if (holder == 1)
            {
                lboutput.Items.Add(" 1 : visitor has checked out");
            }
            else
            {
                lboutput.Items.Add(holder.ToString() + " : visitors has checked out");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing.....!";
            int holder = dhelper.visitorcomeback();

            switch (holder)
            {

                case -1:
                    MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 1045:

                    MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;


            }
            main.label2.Text = "Done..!";

            main.label1.Text = "Succeed";
            lboutput.Items.Clear();
            if (holder == 0)
            {
                lboutput.Items.Add("No one have left event yet ");
            }
            else if (holder == 1)
            {
                lboutput.Items.Add(" 1 : visitor went outside");
            }
            else
            {
                lboutput.Items.Add(holder.ToString() + " : visitors are outside");
            }
        }
    }
}
