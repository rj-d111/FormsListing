using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsListing
{
    public partial class Home : Form
    {
        public static Home instance;
        public Home()
        {
            instance = this;
            InitializeComponent();
            listView_record.FullRowSelect = true;
        }

        private void Btn_Add(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();

        }

        private void Btn_Delete(object sender, EventArgs e)
        {
            if(listView_record.Items.Count == 0)
            {
                MessageBox.Show("Nothing to delete", "Delete", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                return;
            }           
            
            if (listView_record.SelectedItems.Count >0)
            {
                //It will delete the selected rows
                listView_record.Items.Remove(listView_record.SelectedItems[0]);
            }
            else
            {
                //It will delete the last record if the user did not select anything
                listView_record.Items.RemoveAt(listView_record.Items.Count - 1);
            }

        }

        private void Btn_Count(object sender, EventArgs e)
        {
            int count = listView_record.Items.Count;
            MessageBox.Show("There are " + count + " existing in the list");
        }

        private void Btn_Clear(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure you want to clear all of the contents?\nAll the contents will be permanently deleted?", "Confirm Delete All", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //If the user pressed OK
            if(result== DialogResult.OK)
            listView_record.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private async void Btn_Export(object sender, EventArgs e)
        {

            //Check if there are really record items in the list view
            if(listView_record.Items.Count == 0)
            {
                MessageBox.Show("Please add at least 1 record before proceeding exporting","Export Error" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames=true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("First Name,Last Name,Age");
                        foreach(ListViewItem item in listView_record.Items)
                        {
                            sb.AppendLine(string.Format("{0},{1},{2}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text));
                        }
                        await sw.WriteLineAsync(sb.ToString());
                        MessageBox.Show("Your data has been successfully exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
