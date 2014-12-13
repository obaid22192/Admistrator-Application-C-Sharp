using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
namespace Administraionapplication
{
    public partial class trackvisitor : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;
        public string rfid ="";
        public RFID reader ;
        public trackvisitor(Mainform form , RFID read)
        {
            InitializeComponent();
            main = form;
            myds = new DataSet();
            this.reader = read;
            dh = new DataHelper(dgvvisitorhistory  , bindingSource1 , myds);
            dgvvisitorhistory.BorderStyle = BorderStyle.None;
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            main.label2.Text = "Processing....!";
            trackvisitormain track = new trackvisitormain(main);
            track.TopLevel = false;
            track.AutoScroll = true;
            track.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(track);
            track.Show();
            main.label2.Text = "Done....!";
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void trackvisitor_Load(object sender, EventArgs e)
        {

            main.label2.Text = "Processing..!";

            int holder = dh.Client_info(rfid);
            string error = "Error";
            switch (holder)
            {
                case 0:
                    
                    main.label2.Text = "Processing....!";
                    trackvisitormain track = new trackvisitormain(main);
                    track.label1.Text = "Record with This RFID Doesnot Exist";
                    track.TopLevel = false;
                    track.AutoScroll = true;
                    track.FormBorderStyle = FormBorderStyle.None;
                    main.paneldisplay.Controls.Clear();
                    
                    main.paneldisplay.Controls.Add(track);
                    track.Show();
                    
                    track.panelsingleentry.Visible = true;

                    main.label2.Text = "Done....!";
                    break;
                case -1:
                    MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case 1045:

                    MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;


            }
            main.label2.Text = "Done..!";

            main.label1.Text = holder + " Recod Found";
        }

        private void btnclientinfo_Click(object sender, EventArgs e)
        {
            
            main.label2.Text = "Processing..!";

            int holder = dh.Client_info(rfid);
            string error = "Error";
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

            main.label1.Text = holder + " Recod Found";
           
        }

        private void btnAccountinfo_Click(object sender, EventArgs e)
        {
            
            main.label2.Text = "Processing..!";

            int holder = dh.Account_info(rfid);
            string error = "Error";
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
            if (holder == 0)
            {
                main.label1.Text = " No Information  Found About this account";
            }
            else
            {
                main.label1.Text = holder + " record Found";
            }
        }

        private void btnShoppingHistory_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";

            int holder = dh.Shoping_history(rfid);
            string error = "Error";
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
            if (holder == 0)
            {
                main.label1.Text = "This visitor does not have shopping history";

            }
            else
            {
                main.label1.Text = holder + " Record Found";
            }
           
        }

        private void btnItemshired_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";

            int holder = dh.Hired_stuff(rfid);
            string error = "Error";
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
            if (holder == 0)
            {
                main.label1.Text = "This visitor did not lend any thing";

            }
            else
            {
                main.label1.Text = holder + " Record Found";
            }
           
        }

        private void btntentbooked_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";

            int holder = dh.Tent_booked(rfid);
            string error = "Error";
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

            main.label1.Text = holder + " Record Found";
        }

        private void button2_Click(object sender, EventArgs e)
        {
             main.label2.Text = "Processing..!";

            int holder = dh.Event_payment_history(rfid);
            string error = "Error";
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
            if (holder == 0)
            {
                main.label1.Text = "This visitor does not have Event Payment history ";

            }
            else
            {
                main.label1.Text = holder + " Record Found";
            }
         
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";

            int holder = dh.Deposite(rfid);
            string error = "Error";
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
            if (holder == 0)
            {
            main.label1.Text = "This Visitor does not have any Deposite History";
            
            }
            else
            {
                main.label1.Text = holder + "record Found";
            }
        }

        private void paneloutput_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
