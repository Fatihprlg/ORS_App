
namespace ORS_App
{
    partial class AdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işyeriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işyeriİşlemleriToolStripMenuItem
            // 
            this.işyeriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriTanımlamaToolStripMenuItem,
            this.işyeriListesiToolStripMenuItem});
            this.işyeriİşlemleriToolStripMenuItem.Name = "işyeriİşlemleriToolStripMenuItem";
            this.işyeriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.işyeriİşlemleriToolStripMenuItem.Text = "İşyeri işlemleri";
            // 
            // işyeriTanımlamaToolStripMenuItem
            // 
            this.işyeriTanımlamaToolStripMenuItem.Name = "işyeriTanımlamaToolStripMenuItem";
            this.işyeriTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.işyeriTanımlamaToolStripMenuItem.Text = "İşyeri Tanımlama";
            this.işyeriTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.işyeriTanımlamaToolStripMenuItem_Click);
            // 
            // işyeriListesiToolStripMenuItem
            // 
            this.işyeriListesiToolStripMenuItem.Name = "işyeriListesiToolStripMenuItem";
            this.işyeriListesiToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.işyeriListesiToolStripMenuItem.Text = "İşyeri Listesi";
            this.işyeriListesiToolStripMenuItem.Click += new System.EventHandler(this.işyeriListesiToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminListMenuItem,
            this.kullanıcıListesiToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // adminListMenuItem
            // 
            this.adminListMenuItem.Name = "adminListMenuItem";
            this.adminListMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminListMenuItem.Text = "Yetkili Listesi";
            this.adminListMenuItem.Click += new System.EventHandler(this.adminListMenuItem_Click);
            // 
            // kullanıcıListesiToolStripMenuItem
            // 
            this.kullanıcıListesiToolStripMenuItem.Name = "kullanıcıListesiToolStripMenuItem";
            this.kullanıcıListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kullanıcıListesiToolStripMenuItem.Text = "Kullanıcı Listesi";
            this.kullanıcıListesiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListesiToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işyeriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListesiToolStripMenuItem;
    }
}