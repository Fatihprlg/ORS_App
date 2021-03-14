using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORS_App
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void işyeriTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessOperations businessOperations = new BusinessOperations();
            businessOperations.MdiParent = this;
            businessOperations.Show();
        }

        private void işyeriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessList businessList = new BusinessList();
            businessList.MdiParent = this;
            businessList.Show();
        }



        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandartUserList standartUserList = new StandartUserList();
            standartUserList.MdiParent = this;
            standartUserList.Show();
        }

        private void adminListMenuItem_Click(object sender, EventArgs e)
        {
            BusinessAdminsList businessAdminsList = new BusinessAdminsList();
            businessAdminsList.MdiParent = this;
            businessAdminsList.Show();
        }
    }
}
