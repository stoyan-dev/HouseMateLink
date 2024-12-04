using System;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class RulesForm : Form
    {

        public bool IsAdmin { get; set; }
        public RulesForm(bool isAdmin)
        {
            InitializeComponent();
            LoadHouseRules();
            IsAdmin = isAdmin;

            btnEditRules.Visible = IsAdmin;
            rulesTextBox.ReadOnly = true;
        }

        private void LoadHouseRules()
        {
            string houseRules = "House Rules:\n\n" +
                                "1. Respect each other's space.\n" +
                                "2. Clean up after yourself.\n" +
                                "3. No loud music after 11 PM.\n" +
                                "4. Take out the trash on designated days.\n" +
                                "5. Don't throw any objects in the toilet.\n" +
                                "6. Shared expenses should be paid on time.\n" +
                                "7. Keep common areas tidy.\n" +
                                "8. No smoking in shared areas.\n";

            rulesTextBox.Text = houseRules;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditRules_Click(object sender, EventArgs e)
        {
            if (rulesTextBox.ReadOnly)
            {

                rulesTextBox.ReadOnly = false;
                btnEditRules.Text = "Save Rules"; 

            }

            else
            {
                string updatedRules = rulesTextBox.Text;

                // Logic for later
                //System.IO.File.WriteAllText("houseRules.txt", updatedRules);

                rulesTextBox.ReadOnly = true;
            }
        }
    }
}