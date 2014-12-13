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
    public partial class deletefoodproducts : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;
        public deletefoodproducts(Mainform form)
        {
            InitializeComponent();
            main = form;
             myds = new DataSet();
            dh = new DataHelper(dgvdeletefood, bindingSource1, myds);
            dgvdeletefood.BorderStyle = BorderStyle.None;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label1.Text = " ";
            main.label2.Text = "Processing....!";
            foodstalls temp = new foodstalls(main);
            temp.TopLevel = false;
            temp.AutoScroll = true;
            temp.FormBorderStyle = FormBorderStyle.None;
            main.paneldisplay.Controls.Clear();
            main.paneldisplay.Controls.Add(temp);
            main.label2.Text = "Done....!";
            temp.Show();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsearchall_Click(object sender, EventArgs e)
        {
          

            main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.deleteallfoodproducts() ;
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

            main.label1.Text = holder + "  Records Deleted";
           
        }

        private void paneldeletefood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

           
            main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.DeleteFoodProduct();
            if (holder > 0)
            {

                dgvdeletefood.Rows.RemoveAt(dgvdeletefood.CurrentCell.RowIndex);
                dgvdeletefood.Refresh();
            }
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

            main.label1.Text = holder + "  Records Deleted";
        }

        private void deletefoodproducts_Load(object sender, EventArgs e)
        {

            main.label2.Text = "Processing..!";
            //  DataHelper dh = new DataHelper(dataGridView1, bindingSource1, myds);

            int holder = dh.searchallavailableproducts();
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

        private void dgvdeletefood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
