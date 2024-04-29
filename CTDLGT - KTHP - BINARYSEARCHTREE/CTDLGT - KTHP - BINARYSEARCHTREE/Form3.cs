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
    public partial class Form3 : Form
    {
        public static List<Vaccine> VaccineList;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Vaccine> vaccineList)
        {
            InitializeComponent();
            VaccineList = vaccineList;
            dtgvVaccine.DataSource = VaccineList;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dtgvVaccine.DataSource = VaccineList;
            dtgvVaccine.Refresh();

        }

        private bool CheckControl()
        {
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbCapacity.Text == "" || txbID.Text == "" || txbName.Text == "" || txbOrigin.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string i;
                string n;
                int c;
                string o;

                i = txbID.Text;
                n = txbName.Text;
                o = txbOrigin.Text;

                if (int.TryParse(txbCapacity.Text, out c) && c > 0)
                {
                    VaccineList.Add(new Vaccine(i, n, c, o));
                    dtgvVaccine.DataSource = null;
                    dtgvVaccine.DataSource = VaccineList;
                    dtgvVaccine.Refresh();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đúng số lượng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
