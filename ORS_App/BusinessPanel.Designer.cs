
namespace ORS_App
{
    partial class BusinessPanel
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
            this.businessPanelTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.appointmentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteMsgBtn = new System.Windows.Forms.Button();
            this.answerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.messageList = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveBtn = new System.Windows.Forms.Button();
            this.fdyEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.fdyStart = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.thsdyEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.thsdyStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.wsdyEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.wsdyStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tsdyEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tsdyStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mdyEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.mdyStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bAppointmentsList = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.businessPanelTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // businessPanelTab
            // 
            this.businessPanelTab.Controls.Add(this.tabPage1);
            this.businessPanelTab.Controls.Add(this.tabPage2);
            this.businessPanelTab.Controls.Add(this.tabPage3);
            this.businessPanelTab.Controls.Add(this.tabPage4);
            this.businessPanelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.businessPanelTab.Location = new System.Drawing.Point(0, 0);
            this.businessPanelTab.Name = "businessPanelTab";
            this.businessPanelTab.SelectedIndex = 0;
            this.businessPanelTab.Size = new System.Drawing.Size(780, 450);
            this.businessPanelTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rejectBtn);
            this.tabPage1.Controls.Add(this.acceptBtn);
            this.tabPage1.Controls.Add(this.appointmentList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Randevu Talepleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(399, 371);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(365, 44);
            this.rejectBtn.TabIndex = 2;
            this.rejectBtn.Text = "Reddet";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(8, 371);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(385, 44);
            this.acceptBtn.TabIndex = 1;
            this.acceptBtn.Text = "Onayla";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // appointmentList
            // 
            this.appointmentList.BackColor = System.Drawing.SystemColors.Window;
            this.appointmentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader11,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.appointmentList.FullRowSelect = true;
            this.appointmentList.HideSelection = false;
            this.appointmentList.Location = new System.Drawing.Point(8, 6);
            this.appointmentList.Name = "appointmentList";
            this.appointmentList.Size = new System.Drawing.Size(756, 357);
            this.appointmentList.TabIndex = 0;
            this.appointmentList.UseCompatibleStateImageBehavior = false;
            this.appointmentList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tarih";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İsim";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Not";
            this.columnHeader4.Width = 349;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Durum";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Saat";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteMsgBtn);
            this.tabPage2.Controls.Add(this.answerBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.answerTxt);
            this.tabPage2.Controls.Add(this.messageList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteMsgBtn
            // 
            this.deleteMsgBtn.Location = new System.Drawing.Point(683, 312);
            this.deleteMsgBtn.Name = "deleteMsgBtn";
            this.deleteMsgBtn.Size = new System.Drawing.Size(81, 33);
            this.deleteMsgBtn.TabIndex = 4;
            this.deleteMsgBtn.Text = "Mesajı Sil";
            this.deleteMsgBtn.UseVisualStyleBackColor = true;
            this.deleteMsgBtn.Click += new System.EventHandler(this.deleteMsgBtn_Click);
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(683, 273);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(81, 33);
            this.answerBtn.TabIndex = 3;
            this.answerBtn.Text = "Cevapla";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cevabınız";
            // 
            // answerTxt
            // 
            this.answerTxt.Location = new System.Drawing.Point(8, 273);
            this.answerTxt.Multiline = true;
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(669, 140);
            this.answerTxt.TabIndex = 1;
            // 
            // messageList
            // 
            this.messageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.messageList.FullRowSelect = true;
            this.messageList.HideSelection = false;
            this.messageList.Location = new System.Drawing.Point(8, 6);
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(756, 236);
            this.messageList.TabIndex = 0;
            this.messageList.UseCompatibleStateImageBehavior = false;
            this.messageList.View = System.Windows.Forms.View.Details;
            this.messageList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.messageList_MouseDoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID";
            this.columnHeader10.Width = 41;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kimden";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Geliş Tarihi";
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Konu";
            this.columnHeader8.Width = 131;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "İçerik";
            this.columnHeader9.Width = 388;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.saveBtn);
            this.tabPage3.Controls.Add(this.fdyEnd);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.fdyStart);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.thsdyEnd);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.thsdyStart);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.wsdyEnd);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.wsdyStart);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tsdyEnd);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tsdyStart);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.mdyEnd);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.mdyStart);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Randevu Saatleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(337, 240);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 39);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // fdyEnd
            // 
            this.fdyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fdyEnd.Location = new System.Drawing.Point(513, 165);
            this.fdyEnd.Name = "fdyEnd";
            this.fdyEnd.Size = new System.Drawing.Size(200, 22);
            this.fdyEnd.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cuma Bitiş";
            // 
            // fdyStart
            // 
            this.fdyStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fdyStart.Location = new System.Drawing.Point(157, 167);
            this.fdyStart.Name = "fdyStart";
            this.fdyStart.Size = new System.Drawing.Size(200, 22);
            this.fdyStart.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Cuma Başlangıç";
            // 
            // thsdyEnd
            // 
            this.thsdyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.thsdyEnd.Location = new System.Drawing.Point(513, 137);
            this.thsdyEnd.Name = "thsdyEnd";
            this.thsdyEnd.Size = new System.Drawing.Size(200, 22);
            this.thsdyEnd.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Perşembe Bitiş";
            // 
            // thsdyStart
            // 
            this.thsdyStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.thsdyStart.Location = new System.Drawing.Point(157, 139);
            this.thsdyStart.Name = "thsdyStart";
            this.thsdyStart.Size = new System.Drawing.Size(200, 22);
            this.thsdyStart.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Perşembe Başlangıç";
            // 
            // wsdyEnd
            // 
            this.wsdyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.wsdyEnd.Location = new System.Drawing.Point(513, 109);
            this.wsdyEnd.Name = "wsdyEnd";
            this.wsdyEnd.Size = new System.Drawing.Size(200, 22);
            this.wsdyEnd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Çarşamba Bitiş";
            // 
            // wsdyStart
            // 
            this.wsdyStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.wsdyStart.Location = new System.Drawing.Point(157, 111);
            this.wsdyStart.Name = "wsdyStart";
            this.wsdyStart.Size = new System.Drawing.Size(200, 22);
            this.wsdyStart.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Çarşamba Başlangıç";
            // 
            // tsdyEnd
            // 
            this.tsdyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tsdyEnd.Location = new System.Drawing.Point(513, 81);
            this.tsdyEnd.Name = "tsdyEnd";
            this.tsdyEnd.Size = new System.Drawing.Size(200, 22);
            this.tsdyEnd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salı Bitiş";
            // 
            // tsdyStart
            // 
            this.tsdyStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tsdyStart.Location = new System.Drawing.Point(157, 83);
            this.tsdyStart.Name = "tsdyStart";
            this.tsdyStart.Size = new System.Drawing.Size(200, 22);
            this.tsdyStart.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salı Başlangıç";
            // 
            // mdyEnd
            // 
            this.mdyEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.mdyEnd.Location = new System.Drawing.Point(513, 53);
            this.mdyEnd.Name = "mdyEnd";
            this.mdyEnd.Size = new System.Drawing.Size(200, 22);
            this.mdyEnd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pazartesi Bitiş";
            // 
            // mdyStart
            // 
            this.mdyStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.mdyStart.Location = new System.Drawing.Point(157, 55);
            this.mdyStart.Name = "mdyStart";
            this.mdyStart.Size = new System.Drawing.Size(200, 22);
            this.mdyStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pazartesi Başlangıç";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bAppointmentsList);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(772, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "İşyeri Randevuları";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bAppointmentsList
            // 
            this.bAppointmentsList.BackColor = System.Drawing.SystemColors.Window;
            this.bAppointmentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.bAppointmentsList.FullRowSelect = true;
            this.bAppointmentsList.HideSelection = false;
            this.bAppointmentsList.Location = new System.Drawing.Point(0, 0);
            this.bAppointmentsList.Name = "bAppointmentsList";
            this.bAppointmentsList.Size = new System.Drawing.Size(772, 421);
            this.bAppointmentsList.TabIndex = 1;
            this.bAppointmentsList.UseCompatibleStateImageBehavior = false;
            this.bAppointmentsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Kullanıcı Adı";
            this.columnHeader12.Width = 116;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Tarih";
            this.columnHeader13.Width = 86;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Saat";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "İsim";
            this.columnHeader15.Width = 75;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Not";
            this.columnHeader16.Width = 349;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Durum";
            // 
            // BusinessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.businessPanelTab);
            this.Name = "BusinessPanel";
            this.Text = "BusinessPanel";
            this.businessPanelTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl businessPanelTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button rejectBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.ListView appointmentList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView messageList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button deleteMsgBtn;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answerTxt;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker fdyEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fdyStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker thsdyEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker thsdyStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker wsdyEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker wsdyStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tsdyEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tsdyStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker mdyEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker mdyStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView bAppointmentsList;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
    }
}