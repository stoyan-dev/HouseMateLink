using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HouseMateLink
{
    public partial class MainForm : Form
    {
        private int itemCounter;
        private bool isAdmin;
        public MainForm(bool a)
        {
            InitializeComponent();
            isAdmin = a;
            Initialization();

        }

        private void grbHome_Enter(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 4;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 1;
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 2;
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 3;
        }

        private void btnGrocery_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 5;
        }

        private void btnProfileOverview_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                ProfileOverviewAdmin profileOverviewAdmin = new ProfileOverviewAdmin();
                profileOverviewAdmin.Show();
                this.Close();
            }
            else
            {
                ProfileOverviewTenant profileOverviewTenant = new ProfileOverviewTenant();
                profileOverviewTenant.Show();
                this.Close();
            }
        }

        private void rbEvent_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Visible = rbEvent.Checked;


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form logIn = new Form();
            logIn.Show();
            this.Close();
        }

        private void LoadHouseRules()
        {
            string houseRules = $"House Rules:{Environment.NewLine}{Environment.NewLine}" +
                                $"1. Respect each other's space.{Environment.NewLine}" +
                                $"2. Always clean up after yourself in shared spaces like the kitchen, living room, and bathroom.{Environment.NewLine}" +
                                $"3. Maintain silence between 10 PM and 8 AM on weekdays to ensure everyone can study or rest.{Environment.NewLine}" +
                                $"4. Follow the rotating schedule for shared chores like taking out the trash and cleaning common areas.{Environment.NewLine}" +
                                $"5. Turn off lights, water taps, and electronics when not in use to save energy and reduce bills.{Environment.NewLine}" +
                                $"6. The use of illegal drugs or substances is strictly prohibited within the housing premises.{Environment.NewLine}" +
                                $"7. Smoking is prohibited inside the building. Use designated smoking areas outside.{Environment.NewLine}" +
                                $"8. Guests must respect the house rules and not disturb others.";


            rulesTextBox.Text = houseRules;
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

        private void btnAddToTheList_Click(object sender, EventArgs e)
        {
            string groceryItem = tbAddGroceries.Text.Trim();

            if (!string.IsNullOrEmpty(groceryItem))
            {
                lbShoppingList.Items.Add($"{itemCounter}. {groceryItem}");
                itemCounter++;

                tbAddGroceries.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter a grocery item before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearTheLastProduct_Click(object sender, EventArgs e)
        {
            if (lbShoppingList.Items.Count > 0)
            {
                lbShoppingList.Items.RemoveAt(0);
                RenumberShoppingList();
            }
            else
            {
                MessageBox.Show("The shopping list is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RenumberShoppingList()
        {
            for (int i = 0; i < lbShoppingList.Items.Count; i++)
            {
                string itemText = lbShoppingList.Items[i].ToString();
                int firstDotIndex = itemText.IndexOf('.');
                if (firstDotIndex != -1)
                {
                    itemText = itemText.Substring(firstDotIndex + 2);
                }

                lbShoppingList.Items[i] = $"{i + 1}. {itemText}";
            }

            itemCounter = lbShoppingList.Items.Count + 1;
        }

        private void Initialization()
        {
            itemCounter = 1;
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Visible = false;
            LoadHouseRules();

            btnEditRules.Visible = isAdmin;
            rulesTextBox.ReadOnly = true;
        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAllProducts_Click(object sender, EventArgs e)
        {
            if (lbShoppingList.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure?",
                    "Confirm Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lbShoppingList.Items.Clear(); 
                    itemCounter = 1; 
                    MessageBox.Show("All items have been cleared.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The shopping list is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
