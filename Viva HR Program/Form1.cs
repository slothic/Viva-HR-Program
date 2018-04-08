using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viva_HR_Program
{
    public partial class Form1 : Form
    {
        public List<string> userlist = new List<string>();
        public List<string> useremail = new List<string>();
        public Form1()
        {
            InitializeComponent();
            loggedon1.Hide();

            for (int i = 0; i < 100; i++)
            {
                string user = "username" + i;
                string email = user + "@fakemail.com";
                userlist.Add(user);
                useremail.Add(email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fake info population.


            loginpanel1.Hide();
            retrieveUsersOnLoad(textBox1.Text, textBox2.Text);
            loggedon1.Show();
            userList1.DataSource = userlist;
            tabControl1.Hide();
            

        }
        
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.userList1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                tabControl1.Show();
                userInfoEmail.Text = useremail[index];
                userInfoCaseList1.DataSource = useremail;

                
            }
        }

        private void retrieveUsersOnLoad(string username, string password)
        {
            //create connection
            //retrieve users
            
            return;
        }
        private void button2_Click(object sender, EventArgs e)
        {
             
            
        }
    }
}
