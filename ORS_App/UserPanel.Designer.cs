
namespace ORS_App
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userPanelTab = new System.Windows.Forms.TabControl();
            this.appointmentOps = new System.Windows.Forms.TabPage();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bAdminCBox = new System.Windows.Forms.ComboBox();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.Not = new System.Windows.Forms.Label();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.hourPicker = new System.Windows.Forms.DateTimePicker();
            this.searchCategory = new System.Windows.Forms.Button();
            this.searchBusiness = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.categorySearchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.businessSearchTxt = new System.Windows.Forms.TextBox();
            this.businessList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myQuestionsTab = new System.Windows.Forms.TabPage();
            this.messagesList = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appointmentReqTab = new System.Windows.Forms.TabPage();
            this.appointmentsList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.adminList = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.messageContent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userPanelTab.SuspendLayout();
            this.appointmentOps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.myQuestionsTab.SuspendLayout();
            this.appointmentReqTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPanelTab
            // 
            this.userPanelTab.Controls.Add(this.appointmentOps);
            this.userPanelTab.Controls.Add(this.myQuestionsTab);
            this.userPanelTab.Controls.Add(this.appointmentReqTab);
            this.userPanelTab.Controls.Add(this.tabPage1);
            this.userPanelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanelTab.Location = new System.Drawing.Point(0, 0);
            this.userPanelTab.Name = "userPanelTab";
            this.userPanelTab.SelectedIndex = 0;
            this.userPanelTab.Size = new System.Drawing.Size(800, 450);
            this.userPanelTab.TabIndex = 0;
            // 
            // appointmentOps
            // 
            this.appointmentOps.Controls.Add(this.refreshBtn);
            this.appointmentOps.Controls.Add(this.panel1);
            this.appointmentOps.Controls.Add(this.searchCategory);
            this.appointmentOps.Controls.Add(this.searchBusiness);
            this.appointmentOps.Controls.Add(this.label2);
            this.appointmentOps.Controls.Add(this.categorySearchTxt);
            this.appointmentOps.Controls.Add(this.label1);
            this.appointmentOps.Controls.Add(this.businessSearchTxt);
            this.appointmentOps.Controls.Add(this.businessList);
            this.appointmentOps.Location = new System.Drawing.Point(4, 25);
            this.appointmentOps.Name = "appointmentOps";
            this.appointmentOps.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentOps.Size = new System.Drawing.Size(792, 421);
            this.appointmentOps.TabIndex = 0;
            this.appointmentOps.Text = "Randevu İşlemleri";
            this.appointmentOps.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(351, 199);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Sıfırla";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bAdminCBox);
            this.panel1.Controls.Add(this.appointmentBtn);
            this.panel1.Controls.Add(this.Not);
            this.panel1.Controls.Add(this.noteTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.hourPicker);
            this.panel1.Location = new System.Drawing.Point(11, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 167);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kime";
            // 
            // bAdminCBox
            // 
            this.bAdminCBox.FormattingEnabled = true;
            this.bAdminCBox.Location = new System.Drawing.Point(370, 41);
            this.bAdminCBox.Name = "bAdminCBox";
            this.bAdminCBox.Size = new System.Drawing.Size(121, 24);
            this.bAdminCBox.TabIndex = 13;
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appointmentBtn.Location = new System.Drawing.Point(317, 69);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Size = new System.Drawing.Size(261, 27);
            this.appointmentBtn.TabIndex = 10;
            this.appointmentBtn.Text = "Randevu Talebi Oluştur";
            this.appointmentBtn.UseVisualStyleBackColor = false;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click);
            // 
            // Not
            // 
            this.Not.AutoSize = true;
            this.Not.Location = new System.Drawing.Point(27, 44);
            this.Not.Name = "Not";
            this.Not.Size = new System.Drawing.Size(30, 17);
            this.Not.TabIndex = 12;
            this.Not.Text = "Not";
            // 
            // noteTxt
            // 
            this.noteTxt.Location = new System.Drawing.Point(70, 41);
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.Size = new System.Drawing.Size(200, 22);
            this.noteTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarih";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(70, 13);
            this.datePicker.MinDate = new System.DateTime(2021, 1, 18, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 8;
            // 
            // hourPicker
            // 
            this.hourPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourPicker.Location = new System.Drawing.Point(370, 13);
            this.hourPicker.Name = "hourPicker";
            this.hourPicker.Size = new System.Drawing.Size(200, 22);
            this.hourPicker.TabIndex = 7;
            // 
            // searchCategory
            // 
            this.searchCategory.Location = new System.Drawing.Point(465, 199);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(75, 23);
            this.searchCategory.TabIndex = 6;
            this.searchCategory.Text = "Ara";
            this.searchCategory.UseVisualStyleBackColor = true;
            this.searchCategory.Click += new System.EventHandler(this.searchCategory_Click);
            // 
            // searchBusiness
            // 
            this.searchBusiness.Location = new System.Drawing.Point(232, 199);
            this.searchBusiness.Name = "searchBusiness";
            this.searchBusiness.Size = new System.Drawing.Size(75, 23);
            this.searchBusiness.TabIndex = 5;
            this.searchBusiness.Text = "Ara";
            this.searchBusiness.UseVisualStyleBackColor = true;
            this.searchBusiness.Click += new System.EventHandler(this.searchBusiness_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Ara";
            // 
            // categorySearchTxt
            // 
            this.categorySearchTxt.Location = new System.Drawing.Point(639, 199);
            this.categorySearchTxt.Name = "categorySearchTxt";
            this.categorySearchTxt.Size = new System.Drawing.Size(145, 22);
            this.categorySearchTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "İşyeri Ara";
            // 
            // businessSearchTxt
            // 
            this.businessSearchTxt.Location = new System.Drawing.Point(81, 199);
            this.businessSearchTxt.Name = "businessSearchTxt";
            this.businessSearchTxt.Size = new System.Drawing.Size(145, 22);
            this.businessSearchTxt.TabIndex = 1;
            // 
            // businessList
            // 
            this.businessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.businessList.FullRowSelect = true;
            this.businessList.HideSelection = false;
            this.businessList.Location = new System.Drawing.Point(8, 6);
            this.businessList.Name = "businessList";
            this.businessList.Size = new System.Drawing.Size(776, 187);
            this.businessList.TabIndex = 0;
            this.businessList.UseCompatibleStateImageBehavior = false;
            this.businessList.View = System.Windows.Forms.View.Details;
            this.businessList.SelectedIndexChanged += new System.EventHandler(this.businessList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İşyeri Adı";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tür";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adres";
            this.columnHeader4.Width = 392;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 112;
            // 
            // myQuestionsTab
            // 
            this.myQuestionsTab.Controls.Add(this.messagesList);
            this.myQuestionsTab.Location = new System.Drawing.Point(4, 25);
            this.myQuestionsTab.Name = "myQuestionsTab";
            this.myQuestionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.myQuestionsTab.Size = new System.Drawing.Size(792, 421);
            this.myQuestionsTab.TabIndex = 1;
            this.myQuestionsTab.Text = "Sorularım";
            this.myQuestionsTab.UseVisualStyleBackColor = true;
            // 
            // messagesList
            // 
            this.messagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader10,
            this.columnHeader13});
            this.messagesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesList.FullRowSelect = true;
            this.messagesList.HideSelection = false;
            this.messagesList.Location = new System.Drawing.Point(3, 3);
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(786, 415);
            this.messagesList.TabIndex = 0;
            this.messagesList.UseCompatibleStateImageBehavior = false;
            this.messagesList.View = System.Windows.Forms.View.Details;
            this.messagesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.messagesList_MouseDoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Kimden";
            this.columnHeader11.Width = 116;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Konu";
            this.columnHeader10.Width = 166;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Yanıt";
            this.columnHeader13.Width = 541;
            // 
            // appointmentReqTab
            // 
            this.appointmentReqTab.Controls.Add(this.appointmentsList);
            this.appointmentReqTab.Location = new System.Drawing.Point(4, 25);
            this.appointmentReqTab.Name = "appointmentReqTab";
            this.appointmentReqTab.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentReqTab.Size = new System.Drawing.Size(792, 421);
            this.appointmentReqTab.TabIndex = 2;
            this.appointmentReqTab.Text = "Randevu Taleplerim";
            this.appointmentReqTab.UseVisualStyleBackColor = true;
            // 
            // appointmentsList
            // 
            this.appointmentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.appointmentsList.HideSelection = false;
            this.appointmentsList.Location = new System.Drawing.Point(8, 6);
            this.appointmentsList.Name = "appointmentsList";
            this.appointmentsList.Size = new System.Drawing.Size(778, 407);
            this.appointmentsList.TabIndex = 0;
            this.appointmentsList.UseCompatibleStateImageBehavior = false;
            this.appointmentsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kimden";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tarih";
            this.columnHeader7.Width = 122;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 3;
            this.columnHeader8.Text = "Durum";
            this.columnHeader8.Width = 114;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 2;
            this.columnHeader9.Text = "Saat";
            this.columnHeader9.Width = 86;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.messageContent);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.messageSubject);
            this.tabPage1.Controls.Add(this.adminList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Mesaj Gönderme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // adminList
            // 
            this.adminList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.adminList.FullRowSelect = true;
            this.adminList.HideSelection = false;
            this.adminList.Location = new System.Drawing.Point(6, 6);
            this.adminList.Name = "adminList";
            this.adminList.Size = new System.Drawing.Size(776, 187);
            this.adminList.TabIndex = 1;
            this.adminList.UseCompatibleStateImageBehavior = false;
            this.adminList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "İsim";
            this.columnHeader14.Width = 96;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Kullanıcı Adı";
            this.columnHeader15.Width = 105;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Telefon";
            this.columnHeader16.Width = 392;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Mail";
            this.columnHeader17.Width = 112;
            // 
            // messageSubject
            // 
            this.messageSubject.Location = new System.Drawing.Point(68, 199);
            this.messageSubject.Name = "messageSubject";
            this.messageSubject.Size = new System.Drawing.Size(280, 22);
            this.messageSubject.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Konu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "İçerik";
            // 
            // messageContent
            // 
            this.messageContent.Location = new System.Drawing.Point(68, 227);
            this.messageContent.Multiline = true;
            this.messageContent.Name = "messageContent";
            this.messageContent.Size = new System.Drawing.Size(280, 186);
            this.messageContent.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userPanelTab);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.userPanelTab.ResumeLayout(false);
            this.appointmentOps.ResumeLayout(false);
            this.appointmentOps.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.myQuestionsTab.ResumeLayout(false);
            this.appointmentReqTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userPanelTab;
        private System.Windows.Forms.TabPage appointmentOps;
        private System.Windows.Forms.TabPage myQuestionsTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Label Not;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker hourPicker;
        private System.Windows.Forms.Button searchCategory;
        private System.Windows.Forms.Button searchBusiness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categorySearchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox businessSearchTxt;
        private System.Windows.Forms.ListView businessList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage appointmentReqTab;
        private System.Windows.Forms.ListView appointmentsList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bAdminCBox;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListView messagesList;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView adminList;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox messageContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox messageSubject;
    }
}