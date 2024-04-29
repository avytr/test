using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public partial class Form4 : Form
    {
        public static List<location> LocationList;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(List<location> locationList)
        {
            InitializeComponent();
            LocationList = locationList;
            dtgvLocation.DataSource = LocationList;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txbAddress.Text == "" || txbID.Text == "" || txbName.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string i;
                string n;
                string a;

                i = txbID.Text;
                n = txbName.Text;
                a = txbAddress.Text;
                LocationList.Add(new location(i, n, a));
                dtgvLocation.DataSource = null;
                dtgvLocation.DataSource = LocationList;
                dtgvLocation.Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
