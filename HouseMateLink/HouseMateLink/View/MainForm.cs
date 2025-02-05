﻿using System.Text.Json;
using HouseMateLink.Data;

namespace HouseMateLink
{
    public partial class MainForm : Form
    {
        private Building myBuilding;
        private DBHelper myDBHelper;
        private int itemCounter = 1;
        private bool isAdmin;
        private User currentUser;
        private DateTime weekStart;
        private int taskIndex = 0;
        public MainForm(bool a, User user, Building b)
        {
            InitializeComponent();
            currentUser = user;
            myBuilding = b;
            isAdmin = a;
            Initialization();
            CustomizeTabHeaders();
            LoadShoppingListFromJson();
            InitializeDBHelper();

            currentUser = user;

            RefreshProfile();
            LoadAnnouncements();
            LoadComplaint();

            weekStart = GetWeekStart(DateTime.Now);
            LoadTasks();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void InitializeDBHelper()
        {
            if (myDBHelper == null)
            {
                myDBHelper = new DBHelper();
            }
        }

        private void Initialization()
        {
            itemCounter = 1;
            //dateTimePicker.Visible = false;
            LoadHouseRules();
            LoadAnnouncements();
            //myDBHelper = new DBHelper();

            btnEditRules.Visible = isAdmin;
            rulesTextBox.ReadOnly = true;

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
            //Calendar calendarForm = new Calendar();
            //calendarForm.FormClosed += (s, args) => this.Show();
            //calendarForm.Show();
            //this.Hide();

            Calendar calendarForm = new Calendar(isAdmin, currentUser, myBuilding);
            calendarForm.Show();
            this.Hide();
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
                ProfileOverviewAdmin profileOverviewAdmin = new ProfileOverviewAdmin(myBuilding, isAdmin, currentUser);
                profileOverviewAdmin.Show();
                this.Hide();
            }
            else
            {
                ProfileOverviewTenant profileOverviewTenant = new ProfileOverviewTenant(myBuilding, isAdmin, currentUser);
                profileOverviewTenant.Show();
                this.Hide();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn logInForm = new logIn();
            logInForm.Show();
            this.Hide();
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
                MessageBox.Show("Rules saved successfully!");

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
            int quantity = (int)numericUpDown1.Value;
            double price = (double)numericUpDown2.Value;

            LoadShoppingListFromJson();

            if (!string.IsNullOrEmpty(groceryItem))
            {
                lbShoppingList.Items.Add($"{itemCounter}. {groceryItem} | Quantity: {quantity} | Price: {price}€");
                itemCounter++;

                tbAddGroceries.Text = string.Empty;
                numericUpDown1.Value = numericUpDown1.Minimum;
                numericUpDown2.Value = numericUpDown2.Minimum;

                SaveShoppingListToJson();
            }
            else
            {
                MessageBox.Show("Please enter a grocery item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void RenumberShoppingList()
        {
            int newCounter = 1;

            for (int i = 0; i < lbShoppingList.Items.Count; i++)
            {
                string itemText = lbShoppingList.Items[i].ToString().Trim();

                if (string.IsNullOrEmpty(itemText)) continue;

                int firstDotIndex = itemText.IndexOf('.');
                if (firstDotIndex != -1)
                {
                    itemText = itemText.Substring(firstDotIndex + 2).Trim();
                }

                lbShoppingList.Items[i] = $"{newCounter}. {itemText}";
                newCounter++;
            }
            itemCounter = newCounter;
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
                MessageBox.Show($"Error saving to file: {ex.Message}");
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
                    int maxItemCounter = 0;

                    foreach (var item in shoppingList)
                    {
                        lbShoppingList.Items.Add(item);
                        string[] parts = item.Split('.');
                        if (parts.Length > 0 && int.TryParse(parts[0].Trim(), out int itemNumber))
                        {
                            if (itemNumber > maxItemCounter)
                            {
                                maxItemCounter = itemNumber;
                            }
                        }
                    }
                    itemCounter = maxItemCounter + 1;
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
                MessageBox.Show("Please enter an announcement.");
                return;
            }

            Announcement announcement = new Announcement(currentUser.Username, message, false);
            myDBHelper.AddAnnouncement(announcement);
            LoadAnnouncements();
            //SaveAnnouncementToJson();
            //SaveAnnouncementsToJson(currentUser.GetAnnouncements());


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
                    MessageBox.Show("File created successfully!");
                }
                else
                {
                    MessageBox.Show("File updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving announcements: {ex.Message}");
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
                    MessageBox.Show("All items have been cleared.");
                    SaveShoppingListToJson();
                }
            }
            else
            {
                MessageBox.Show("The shopping list is empty.");
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
                MessageBox.Show("Please enter a complaint.");
                return;
            }

            Complaint complaint = new Complaint(complain, false);
            myDBHelper.AddComplaintToDB(complaint);
            LoadComplaint();
            // SaveComplaintsToJson(myBuilding.GetComplaints());
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
                    MessageBox.Show("File created successfully!");
                }
                else
                {
                    MessageBox.Show("File updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving complainst: {ex.Message}");
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

        private void LoadAnnouncements()
        {
            panelAnnouncements.Controls.Clear();
            List<Announcement> announcements = myDBHelper?.LoadUnarchivedAnnouncement();

            if (announcements != null && announcements.Count > 0)
            {
                announcements.Reverse();
                int yPositionLeft = 0;
                int yPositionRight = 0;
                int columnWidth = panelAnnouncements.Width / 2 - 20;

                for (int i = 0; i < announcements.Count; i++)
                {
                    Announcement a = announcements[i];
                    AnnouncementMessageControl newAnnouncement = new AnnouncementMessageControl(
                        a.Description,
                        a.CreatedAt,
                        a.Username,
                        currentUser,
                        ArchiveAnnouncement,
                        a.AnnouncementID
                    );

                    if(isAdmin)
                    {
                        newAnnouncement.Size = new Size(columnWidth, 175);
                    }
                    else
                    {
                        newAnnouncement.Size = new Size(columnWidth, 125);
                    }

                    if (i % 2 == 0)
                    {
                        newAnnouncement.Location = new Point(10, yPositionLeft);
                        yPositionLeft += newAnnouncement.Height + 10;
                    }
                    else
                    {
                        newAnnouncement.Location = new Point(columnWidth + 20, yPositionRight);
                        yPositionRight += newAnnouncement.Height + 10;
                    }

                    panelAnnouncements.Controls.Add(newAnnouncement);
                }

                panelAnnouncements.AutoScrollMinSize = new Size(
                    panelAnnouncements.Width,
                    Math.Max(yPositionLeft, yPositionRight)
                );

                if (panelAnnouncements.Controls.Count > 0)
                {
                    panelAnnouncements.VerticalScroll.Value = 0;
                    panelAnnouncements.ScrollControlIntoView(panelAnnouncements.Controls[0]);
                }

                tbAnnouncement.Clear();
            }
            else
            {
                panelAnnouncements.AutoScrollMinSize = new Size(panelAnnouncements.Width, 0);
            }
        }


        private void LoadComplaint()
        {
            panelComplaint.Controls.Clear();
            List<Complaint> complaints = myDBHelper?.LoadUnarchivedComplaints();

            if (complaints != null && complaints.Count > 0)
            {
                complaints.Reverse();
                int yPositionLeft = 0;
                int yPositionRight = 0;
                int columnWidth = panelComplaint.Width / 2 - 20;

                for (int i = 0; i < complaints.Count; i++)
                {
                    Complaint c = complaints[i];
                    ComplaintMessageControl newComplaint = new ComplaintMessageControl(
                        c.Description,
                        c.CreatedAt,
                        ArchiveComplaint,
                        currentUser,
                        c.ComplaintID
                    );

                    if (isAdmin)
                    {
                        newComplaint.Size = new Size(columnWidth, 150);
                    }
                    else 
                    {
                        newComplaint.Size = new Size(columnWidth, 110);
                    }

                    if (i % 2 == 0)
                    {
                        newComplaint.Location = new Point(10, yPositionLeft);
                        yPositionLeft += newComplaint.Height + 10;
                    }
                    else
                    {
                        newComplaint.Location = new Point(columnWidth + 20, yPositionRight);
                        yPositionRight += newComplaint.Height + 10;
                    }
                    panelComplaint.Controls.Add(newComplaint);
                }

                panelComplaint.AutoScrollMinSize = new Size(
                    panelComplaint.Width,
                    Math.Max(yPositionLeft, yPositionRight)
                );


                if (panelComplaint.Controls.Count > 0)
                {
                    panelComplaint.VerticalScroll.Value = 0;
                    panelComplaint.ScrollControlIntoView(panelComplaint.Controls[0]);
                }

                tbCreateComplaint.Clear();
            }
            else
            {
                panelComplaint.AutoScrollMinSize = new Size(panelComplaint.Width, 0);
            }
        }

        private void LoadTasks()
        {
            List<User> tenants = myDBHelper.LoadTenants();
            List<Task> thisWeekTasks = myBuilding.GenerateWeeklyTasks(weekStart, tenants);

            lbTasks.Items.Clear();
            foreach (Task t in thisWeekTasks)
            {
                lbTasks.Items.Add(t.GetInfo());
            }

            lblWeekTasks.Text = $"Tasks for week starting: {weekStart:dd-MM-yyyy}";
        }

        public DateTime GetWeekStart(DateTime date)
        {
            int daysToSubtract = ((int)date.DayOfWeek + 6) % 7;
            return date.AddDays(-daysToSubtract).Date;
        }


        private void RefreshProfile()
        {
            if (currentUser.Role == Role.TENANT)
            {
                lblUserName.Text = currentUser.Name;
                lblUserRole.Text = currentUser.Role.ToString();
                lblUserRoom.Text = currentUser.RoomNumber.ToString();
            }
            else if (currentUser.Role == Role.ADMIN)
            {
                lblUserName.Text = currentUser.Name;
                lblUserRole.Text = currentUser.Role.ToString();
                label5.Visible = false;
                lblUserRoom.Visible = false;

            }
            if (!string.IsNullOrWhiteSpace(currentUser.Photo))
            {
                try
                {
                    byte[] photoBytes = Convert.FromBase64String(currentUser.Photo);

                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        pbUser.Image = Image.FromStream(ms);
                    }

                    pbUser.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading photo for {currentUser.Name}: {ex.Message}");
                    pbUser.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                pbUser.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void btnHomeTasks_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 0;
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 6;
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            weekStart = weekStart.AddDays(7);
            List<User> tenants = myDBHelper.LoadTenants();
            myBuilding.MoveToNextWeek(tenants);
            LoadTasks();
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            weekStart = weekStart.AddDays(-7);
            List<User> tenants = myDBHelper.LoadTenants();
            myBuilding.MoveToPreviousWeek(tenants);
            LoadTasks();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbAddGroceries_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
