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
    public partial class BusinessList : Form
    {
        public BusinessList()
        {
            InitializeComponent();
        }

        private void BusinessList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'randevuSisDataSet.workPlace' table. You can move, or remove it, as needed.
            this.workPlaceTableAdapter.Fill(this.randevuSisDataSet.workPlace);

        }
    }
}
