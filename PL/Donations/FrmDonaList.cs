using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al3ooryCharity.PL
{
    public partial class FrmDonaList : Form
    {
        BL.cls_Donations cls_Donations = new BL.cls_Donations();
        
        public FrmDonaList()
        {
            InitializeComponent();
            dglist.DataSource = cls_Donations.GET_ALL_Donations();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
