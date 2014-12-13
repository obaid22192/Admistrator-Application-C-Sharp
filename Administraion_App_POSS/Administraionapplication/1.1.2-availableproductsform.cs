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
    public partial class availableproducts : Form
    {
        Mainform main;
        DataSet myds;
        DataHelper dh;
        public availableproducts(Mainform form)
        {
            InitializeComponent();
            main = form;
            myds = new DataSet();
            dataGridView1.BorderStyle = BorderStyle.None;
            dh = new DataHelper(dataGridView1, bindingSource1, myds);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main.label2.Text = "Processing....!";
            main.label1.Text = " ";
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

            int holder =  dh.searchallavailableproducts();
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

            main.label1.Text = holder +"  Records Found";
        
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int holder = 0;
            main.label2.Text = "Processing...!";
            string error = "Error";
            try
            {

                if (IsInteger(this.tbsearch.Text))
                {
                    holder = dh.searxchproductbyID(Convert.ToInt32(tbsearch.Text));

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
                    dh.search_foodproduct_by_name(tbsearch.Text);
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
        
        public  bool IsInteger(string s)
        {
            if(s.All(char.IsDigit))
            {
                return true;
            }
            return false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void availableproducts_Load(object sender, EventArgs e)
        {
             
           

            int holder =  dh.searchallavailableproducts();
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

            main.label1.Text = holder +"  Records Found";
        }
    }
}
