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
    public partial class trackvisitormain : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;
        public RFID myRFIDReader;
        bool connection = false;
        public trackvisitormain(Mainform main)
        {
            InitializeComponent();
            this.main = main;
            myds = new DataSet();
            dh = new DataHelper(dgvvisitorsmainbu , bindingSource1, myds);
            this.panelsingleentry.Visible = false;
            try
            {
                myRFIDReader = new RFID();

                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);

            }
            catch (PhidgetException) { main.label1.Text = "Error"; } 
        }

        private void btntracksinglevisitor_Click(object sender, EventArgs e)
        {
            
            main.label2.Text = "Processing...";
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
                main.label1.Text = "an RFID-reader is found and opened.";
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
                panelsingleentry.Visible = true;
                connection = true;
            }
            catch (PhidgetException) { main.label1.Text = "No RFID Scanner found"; }     
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
         
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(main.panelmain);
            if (connection)
            {
                myRFIDReader.LED = false;
                myRFIDReader.Antenna = false;
                myRFIDReader.close();
            }
            main.label2.Text = "Done....!";
            main.label1.Text = "";
        }

        private void trackvisitormain_Load(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";
            int holder = dh.Track_All_Clients();
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

            main.label1.Text = holder + "  Records Found";
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            if (connection)
            {
                myRFIDReader.LED = false;
                myRFIDReader.Antenna = false;
                myRFIDReader.close();
            }
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 10)
            {
                main.label2.Text = "Processing....!";
                trackvisitor track = new trackvisitor(main, myRFIDReader);
                track.TopLevel = false;
                track.AutoScroll = true;
                track.FormBorderStyle = FormBorderStyle.None;
                main.paneldisplay.Controls.Clear();
                main.paneldisplay.Controls.Add(track);
                track.rfid = richTextBox1.Text;
                track.Show();
               
                main.label2.Text = "Done....!";
                main.label1.Text = "";
               
            }
            
        }

        private void dgvvisitorsmainbu_Click(object sender, EventArgs e)
        {
            panelsingleentry.Visible = false;
          
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panelsingleentry.Visible = false;
           
        }

        private void dgvvisitorsmainbu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panelsingleentry.Visible = true;
            richTextBox1.Visible = true;
            richTextBox1.Text = (string)(dgvvisitorsmainbu.Rows[dgvvisitorsmainbu.CurrentCell.RowIndex].Cells[0].Value);
        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            richTextBox1.Text = e.Tag;
        }
    }
}
