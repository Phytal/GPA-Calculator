using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Dashboard : Form
    {
        List<User> users = new List<User>();
        public Dashboard()
        {
            InitializeComponent();
            
            UpdateBinding();
        }

        public void UpdateBinding()
        {
            peopleFoundListbox.DataSource = users;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButtonn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            users = db.GetUser(nameBox.Text);

            UpdateBinding();
        }
    }
}