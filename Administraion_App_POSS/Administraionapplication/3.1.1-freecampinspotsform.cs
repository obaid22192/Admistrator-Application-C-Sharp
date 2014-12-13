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
    public partial class freecampinspotsform : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;

        public freecampinspotsform(Mainform main)
        {
            InitializeComponent();
            this.main = main;
            dgvfreecamp.BorderStyle = BorderStyle.None;
            myds = new DataSet();
            dh = new DataHelper(dgvfreecamp, bindingSource1, myds);
            
            
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Trackevent back = new Trackevent(main);
            back.TopLevel = false;
            back.AutoScroll = true;
            back.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(back);
            back.Show();

        }

        private void freecampinspotsform_Load(object sender, EventArgs e)
        {
           // main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.free_camp_spots();
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

            main.label1.Text = holder + " Camping spots Found";
        }
    }
}
