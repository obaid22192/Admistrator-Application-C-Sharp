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
    
    public partial class AssignRfid : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;
        private RFID myRFIDReader;
        bool connection = false;
        public AssignRfid(Mainform main)
        {
            InitializeComponent();
            this.main = main;
            myds = new DataSet();
            dh = new DataHelper(dgvassignrfids , bindingSource1 , myds);
            this.panelred.Visible = false;
            try
            {
                myRFIDReader = new RFID();
                
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
              
            }
            catch (PhidgetException) { main.label1.Text ="Error"; } 
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 10)
            {
                main.label2.Text = "Processing..!";

                string temprfid = richTextBox1.Text;
                int holder = dh.AssignRfid(temprfid);
                dh.updaterfidindeposite(temprfid);
                dh.updaterfidinpyamentevent(temprfid);
                dh.updaterfidincamp_booked_by(temprfid);
                dgvassignrfids.Rows.RemoveAt(dgvassignrfids.CurrentCell.RowIndex);
                dgvassignrfids.Refresh();
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
                if (holder > 0)
                {
                    main.label1.Text = holder + " RFID ASSIGNED SUCESSFULLy";
                }
                else
                {
                main.label1.Text = " Fail to assign Rfid";
                }
                richTextBox1.Text = string.Empty;
                dgvassignrfids.Refresh();
                
            }
        }

        private void AssignRfid_Load(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.Notgotrfidyet();
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

            main.label1.Text = holder + " Records Found";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.label1.Text = " ";
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
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (connection)
            {
                myRFIDReader.LED = false;
                myRFIDReader.Antenna = false;
                myRFIDReader.close();
            }
            Application.Exit();
        }

       

        private void dgvassignrfids_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            main.label2.Text = "Processing...";
            if (e.ColumnIndex == 0)
            {
                try
                {
                    myRFIDReader.open();
                    myRFIDReader.waitForAttachment(3000);
                    main.label1.Text = "an RFID-reader is found and opened.";
                    myRFIDReader.Antenna = true;
                    myRFIDReader.LED = true;
                    panelred.Visible = true;
                    connection = true;
                }
                catch (PhidgetException) { main.label1.Text = "No RFID Scanner found"; }
            }
            else
                MessageBox.Show("Please click Under Column RFID");
           
        }

        private void dgvassignrfids_Click(object sender, EventArgs e)
        {
            panelred.Visible = false;
            
        }

        private void BtnAssign_Click(object sender, EventArgs e)
        {

        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            richTextBox1.Text = e.Tag;
        }

      
    }
}
