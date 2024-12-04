using System;
using System.Windows.Forms;

namespace HouseMateLink
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            LoadHouseRules();
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
    }
}