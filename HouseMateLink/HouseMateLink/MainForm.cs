﻿using System;
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
        private Building myBuilding;
        private int itemCounter;
        private bool isAdmin;
        private int bit;
        private User currentUser;
        public MainForm(bool a)
        {
            InitializeComponent();
            isAdmin = a;

        }
        public MainForm(bool a, User user, Building b)
        {
            InitializeComponent();
            dateTimePicker = new DateTimePicker();
            currentUser = user;
            myBuilding = b;
            isAdmin = a;
            Initialization();
            CustomizeTabHeaders();
            LoadShoppingListFromJson();

            currentUser = user;

            lblUserName.Text = currentUser.Name;
            lblUserRole.Text = currentUser.Role.ToString();
            lblUserRoom.Text = currentUser.RoomNumber.ToString();

            if (!string.IsNullOrEmpty(currentUser.Photo) && File.Exists(currentUser.Photo))
            {
                pbUser.Image = Image.FromFile(currentUser.Photo);
                pbUser.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbUser.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void Initialization()
        {
            itemCounter = 1;
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Visible = false;
            LoadHouseRules();

            btnEditRules.Visible = isAdmin;
            rulesTextBox.ReadOnly = true;

            if (bit == 1) isAdmin = true;
            if (bit == 0) isAdmin = false;

            //to hide the tab control headers
            tabHome.Appearance = TabAppearance.FlatButtons;
            tabHome.ItemSize = new Size(0, 1);
            tabHome.SizeMode = TabSizeMode.Fixed;
        }
        private void CustomizeTabHeaders()
        {
            tabHome.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabHome.DrawItem += TabControl1_DrawTabHeaders;
        }

        private void TabControl1_DrawTabHeaders(object sender, DrawItemEventArgs e)
        {
            
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
                ProfileOverviewAdmin profileOverviewAdmin = new ProfileOverviewAdmin(isAdmin);
                profileOverviewAdmin.Show();
                this.Hide();
            }
            else
            {
                ProfileOverviewTenant profileOverviewTenant = new ProfileOverviewTenant(myBuilding, isAdmin);
                profileOverviewTenant.Show();
                this.Hide();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn logInForm = new logIn();
            this.Hide();
            logInForm.ShowDialog();
            this.Close();
        }

        private void LoadHouseRules()
        {  
            rulesTextBox.Text = myBuilding.LoadHouseRules();
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
        private void LoadShoppingListFromJson()
        {
            try
            {

                if (File.Exists("ShoppingList.json"))
                {
                    string jsonString = File.ReadAllText("ShoppingList.json");

                    string[] shoppingList = JsonSerializer.Deserialize<string[]>(jsonString);

                    lbShoppingList.Items.Clear();

                    foreach (var item in shoppingList)
                    {
                        lbShoppingList.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Shopping list file not found.", "Info");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading from file: {ex.Message}", "Error");
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

            currentUser.CreateAnnouncement(message);
            //SaveAnnouncementToJson();
            panelAnnouncements.Controls.Clear();
            foreach (Announcement announcement in currentUser.GetAnnouncements())
            {
                AnnouncementMessageControl newAnnouncement = new AnnouncementMessageControl(announcement.Description, announcement.CreatedAt, currentUser.Name, ArchiveAnnouncement);
                newAnnouncement.Size = new Size(400, 125);
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
            }
            panelAnnouncements.AutoScrollMinSize = new Size(panelAnnouncements.Width, panelAnnouncements.Controls[panelAnnouncements.Controls.Count - 1].Bottom + 10);
            tbAnnouncement.Clear();
            SaveAnnouncementsToJson(currentUser.GetAnnouncements());


        }

        private void ArchiveAnnouncement(AnnouncementMessageControl announcementMessageControl)
        {
            panelAnnouncements.Controls.Remove(announcementMessageControl);
        }

        private void SaveAnnouncementsToJson(List<Announcement> announcements)
        {
            string filePath = "announcements.json";
            bool isFileCreated = !File.Exists(filePath);

            try
            {
                string jsonString = JsonSerializer.Serialize(announcements, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);

                if (isFileCreated)
                {
                    MessageBox.Show("File created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving announcements: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnPostComplaint_Click(object sender, EventArgs e)
        {
            string complain = tbCreateComplaint.Text.Trim();
            if (string.IsNullOrEmpty(complain))
            {
                MessageBox.Show("Please enter a complaint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            myBuilding.CreateComplaint(complain);
            panelComplaint.Controls.Clear();
            foreach (Complaint complaint in myBuilding.GetComplaints())
            {
                ComplaintMessageControl newComplaint = new ComplaintMessageControl(complaint.Description, complaint.CreatedAt, ArchiveComplaint);
                newComplaint.Size = new Size(400, 110);
                int newX = 10;
                int newY = 10;

                if (panelComplaint.Controls.Count > 0)
                {
                    Control lastControl = panelComplaint.Controls[panelComplaint.Controls.Count - 1];
                    newX = lastControl.Left;
                    newY = lastControl.Bottom + 10;
                }
                newComplaint.Location = new Point(newX, newY);
                panelComplaint.Controls.Add(newComplaint);
            }
            panelComplaint.AutoScrollMinSize = new Size(panelComplaint.Width, panelComplaint.Controls[panelComplaint.Controls.Count - 1].Bottom + 10);
            tbCreateComplaint.Clear();
            SaveComplaintsToJson(myBuilding.GetComplaints());
        }

        private void ArchiveComplaint(ComplaintMessageControl complaintMessageControl)
        {
            panelComplaint.Controls.Remove(complaintMessageControl);
        }

        private void SaveComplaintsToJson(List<Complaint> complaints)
        {
            string filePath = "complaints.json";
            bool isFileCreated = !File.Exists(filePath);

            try
            {
                string jsonString = JsonSerializer.Serialize(complaints, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);

                if (isFileCreated)
                {
                    MessageBox.Show("File created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving complainst: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabHomePage_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 0;
        }

        private void btnHomeComplaints_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 0;

        }

        private void btnHomeRules_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 0;

        }

        private void btnHomeGrocery_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 0;

        }
    }
}
