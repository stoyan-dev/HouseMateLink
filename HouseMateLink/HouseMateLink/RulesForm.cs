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
            string houseRules = @"House Rules:

1. Respect each other's space.
2. Clean up after yourself.
3. No loud music after 11 PM.
4. Take out the trash on designated days.
5. Don't throw any objects in the toilet.
6. Shared expenses should be paid on time.
7. Keep common areas tidy.
8. No smoking in shared areas.";

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