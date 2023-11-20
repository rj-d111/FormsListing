using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsListing
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

        }
        private void Txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prevents user entering letters
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))){
                e.Handled= true;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!BeAValidAge())
            {
                MessageBox.Show("Invalid age. Must be at least 18 years old.");
                txt_age.Text = String.Empty;
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_fname.Text) || 
                string.IsNullOrWhiteSpace(txt_lname.Text) || !BeAValidAge()) 
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                MessageBox.Show("Successfully added to your list");

                ListViewItem listView = new ListViewItem(ArrayStrings());
                Home.instance.listView_record.Items.Add(listView);

                ClearData();
            }
        }

        private void Add_Form_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btn_submit_Click(this, EventArgs.Empty);
        }


        private void ClearData()
        {

            //Remove all the user input
            txt_fname.Text = String.Empty;
            txt_lname.Text = String.Empty;
            txt_age.Text = String.Empty;
        }

        public string[] ArrayStrings()
        {
            string[] arr = { txt_fname.Text, txt_lname.Text, txt_age.Text };
            return arr;
        }

        private bool BeAValidAge()
        {
            if (string.IsNullOrWhiteSpace(txt_age.Text))
            {
                return false;
            }
            if(Convert.ToInt32(txt_age.Text)< 18)
            {
                return false;
            }
            return true;
        }

   

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
