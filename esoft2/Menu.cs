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
            FormClient client = new FormClient();
            client.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormAuthorization auto = new FormAuthorization();
            this.Close();
            auto.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            FormAgent agent = new FormAgent();
            agent.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            FormRealEstate re = new FormRealEstate();
            re.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            FormSupply sup = new FormSupply();
            sup.Show();
        }

        private void buttonOpenDemand_Click(object sender, EventArgs e)
        {
            FormDemand dem = new FormDemand();
            dem.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            FormDeal dea = new FormDeal();
            dea.Show();
        }
    }
}
