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
               2. Always clean up after yourself in shared spaces like the kitchen, living room, and bathroom.
               3. Maintain silence between 10 PM and 8 AM on weekdays to ensure everyone can study or rest.
               5. Follow the rotating schedule for shared chores like taking out the trash, cleaning the common 
               areas.
               6. Turn off lights, water taps, and electronics when not in use to save energy and reduce bills.
               7. The use of illegal drugs or substances is strictly prohibited within the housing premises.
               8. Smoking is prohibited inside the building. Use designated smoking areas outside.
               9. Guests must respect the house rules and not disturb others.";
            

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