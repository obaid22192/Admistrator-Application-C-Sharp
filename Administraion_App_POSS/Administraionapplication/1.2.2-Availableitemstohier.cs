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
    public partial class Availableitemstohier : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;
        public Availableitemstohier(Mainform form)
        {
            InitializeComponent();
            main = form;
            myds = new DataSet();
            dh = new DataHelper(dgvhieritems , bindingSource1, myds);
            dgvhieritems.BorderStyle = BorderStyle.None;
           
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label1.Text = " ";
            main.label2.Text = "Processing...!";
            Loanmatrial temp = new Loanmatrial(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            main.label2.Text = "Done...!";
            temp.Show();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           
            int holder = 0;
            main.label2.Text = "Processing...!";
            string error = "Error";
            try
            {

                if (IsInteger(this.tbsearchitems.Text))
                {
                    holder = dh.search_available_hire_item_by_id(Convert.ToInt32(this.tbsearchitems.Text));

                    main.label1.Text = holder + "  Records Found";
                    main.label2.Text = "Done....!";


                    switch (holder)
                    {

                        case -1:
                            MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case 1045:

                            MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;


                    }
                }
                else
                {
                    dh.search_hire_item_by_name(this.tbsearchitems.Text);
                    main.label1.Text = holder + "  Records Found";
                    main.label2.Text = "Done....!";
                    switch (holder)
                    {

                        case -1:
                            MessageBox.Show("Cannot connect to server. Contact administrator", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;
                        case 1045:

                            MessageBox.Show("Invalid username/password, please try again ", error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            break;


                    }
                }
            }

            catch (FormatException ex)
            {
                main.label1.Text = ex.Message;
            }

        }

        private void btnsearchall_Click(object sender, EventArgs e)
        {
            
            main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.search_all_available_items_to_hire();
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

        private void Availableitemstohier_Load(object sender, EventArgs e)
        {
            main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.search_all_available_items_to_hire();
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
        public bool IsInteger(string s)
        {
            if (s.All(char.IsDigit))
            {
                return true;
            }
            return false;

        }
    }
}
