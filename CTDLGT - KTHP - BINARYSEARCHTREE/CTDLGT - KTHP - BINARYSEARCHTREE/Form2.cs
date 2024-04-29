using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public partial class Form2 : Form
    {
        public static List<location> locationList = location.GetLocations();
        public static List<Vaccine> vaccineList = Vaccine.GetVaccines();
        public static List<Record> recordList = Record.GetRecords(vaccineList, locationList);

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string Name)
        {
            InitializeComponent();
            lbName.Text = Name;

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbVaccine_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(vaccineList);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lbLocation_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(locationList);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void lbRecord_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(recordList);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
