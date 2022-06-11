using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esoft2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
            if (FormAuthorization.users.type == "agent")
            {
                labelHello.ForeColor = Color.Blue;
                label1.ForeColor = Color.Blue;
            }
            else
            {
                labelHello.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
            }
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization auto = new FormAuthorization();
            this.Close();
            auto.Show();
        }
    }
}
