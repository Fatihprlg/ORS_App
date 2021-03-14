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
    public partial class StandartUserList : Form
    {
        public StandartUserList()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.randevuSisDataSet);

        }

        private void StandartUserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'randevuSisDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.randevuSisDataSet.UserTable);

        }
    }
}
