using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
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
            dateTimePicker = new DateTimePicker();
            isAdmin = a;
            Initialization();
            CustomizeTabHeaders();

        }

        private void Initialization()
        {
            itemCounter = 1;
            dateTimePicker.Value = DateTime.Now;  // Now safe to access the control
            dateTimePicker.Visible = false;
            LoadHouseRules();

            btnEditRules.Visible = isAdmin;
            rulesTextBox.ReadOnly = true;
        }
        private void CustomizeTabHeaders()
        {
            tabHome.DrawMode = TabDrawMode.OwnerDrawFixed; // Enable custom drawing
            tabHome.DrawItem += TabControl1_DrawTabHeaders; // Attach event handler
        }

        private void TabControl1_DrawTabHeaders(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            if (tabControl == null)
                return;

            // Get the rectangle for the current tab
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            // Set the background color (Gold for all tabs)
            Color backgroundColor = e.State == DrawItemState.Selected ? Color.DarkGoldenrod : Color.Gold;
            Color textColor = Color.Black;

            using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                // Fill the background for the tab header
                e.Graphics.FillRectangle(backgroundBrush, tabBounds);

                // Draw the tab text
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, e.Font, textBrush, tabBounds, stringFormat);
            }
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
                this.Hide();
            }
            else
            {
                ProfileOverviewTenant profileOverviewTenant = new ProfileOverviewTenant();
                profileOverviewTenant.Show();
                this.Hide();
            }
        }

        //private void rbEvent_CheckedChanged(object sender, EventArgs e)
        //{
        //  dateTimePicker.Visible = rbEvent.Checked;


        //}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn logInForm = new logIn();
            this.Hide();
            logInForm.ShowDialog();
            this.Close();
        }

        private void LoadHouseRules()
        {
            string defaultRules = $"House Rules:{Environment.NewLine}{Environment.NewLine}" +
                                  $"1. Respect each other's space.{Environment.NewLine}" +
                                  $"2. Always clean up after yourself in shared spaces like the kitchen, living room, and bathroom.{Environment.NewLine}" +
                                  $"3. Maintain silence between 10 PM and 8 AM on weekdays to ensure everyone can study or rest.{Environment.NewLine}" +
                                  $"4. Follow the rotating schedule for shared chores like taking out the trash and cleaning common areas.{Environment.NewLine}" +
                                  $"5. Turn off lights, water taps, and electronics when not in use to save energy and reduce bills.{Environment.NewLine}" +
                                  $"6. The use of illegal drugs or substances is strictly prohibited within the housing premises.{Environment.NewLine}" +
                                  $"7. Smoking is prohibited inside the building. Use designated smoking areas outside.{Environment.NewLine}" +
                                  $"8. Guests must respect the house rules and not disturb others.";

            rulesTextBox.Text = defaultRules;

            rulesTextBox.ReadOnly = true;
            btnEditRules.Text = "Edit Rules";
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

                string[] rulesArray = updatedRules.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                SaveToJsonFile(rulesArray);
                MessageBox.Show("Rules saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rulesTextBox.ReadOnly = true;
                btnEditRules.Text = "Edit Rules";
            }
        }

        private void SaveToJsonFile(string[] rulesArray)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(rulesArray, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("rules.json", jsonString);

                MessageBox.Show("File created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
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

                SaveShoppingListToJson();
            }
            else
            {
                MessageBox.Show("Please enter a grocery item before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearSelectedProduct_Click(object sender, EventArgs e)
        {
            if (lbShoppingList.SelectedIndex != -1)
            {
                lbShoppingList.Items.RemoveAt(lbShoppingList.SelectedIndex);

                RenumberShoppingList();
                SaveShoppingListToJson();
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SaveShoppingListToJson()
        {
            try
            {
                string[] shoppingList = new string[lbShoppingList.Items.Count];
                for (int i = 0; i < lbShoppingList.Items.Count; i++)
                {
                    shoppingList[i] = lbShoppingList.Items[i].ToString();
                }

                string jsonString = JsonSerializer.Serialize(shoppingList, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("ShoppingList.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            string message = tbAnnouncement.Text.Trim();
            
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter an announcement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AnnouncementMessageControl newAnnouncement = new AnnouncementMessageControl(message);

            newAnnouncement.Size = new Size(200, 80); 

            int newX = 10;   
            int newY = 10;  

            if (panelAnnouncements.Controls.Count > 0)
            {
                Control lastControl = panelAnnouncements.Controls[panelAnnouncements.Controls.Count - 1];

                newX = lastControl.Left;
                newY = lastControl.Bottom + 10;  
            }

            newAnnouncement.Location = new Point(newX, newY);

            panelAnnouncements.Controls.Add(newAnnouncement);

            panelAnnouncements.AutoScrollMinSize = new Size(panelAnnouncements.Width, newAnnouncement.Bottom + 10); 

            tbAnnouncement.Clear();
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

        private void grbAnnouncements_Enter(object sender, EventArgs e)
        {

        }
    }
}
