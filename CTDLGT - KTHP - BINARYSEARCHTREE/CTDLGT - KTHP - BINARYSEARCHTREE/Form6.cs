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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(Record record)
        {
            InitializeComponent();
            lbfullname.Text = record.name;
            lbID.Text = record.id.ToString();
            lbbirthday.Text = record.birthday.ToString("dd/MM/yyyy");
            lbGender.Text = record.gender;
            lbaddress.Text = record.address;

            if (record.dose1 != null)
            {
                lbM1Vaccine_name.Text = record.dose1.vaccine.vaccine_name;
                lbM1VaccineID.Text = record.dose1.vaccine.vaccine_id;
                lbM1Date.Text = record.dose1.injection_date.ToString("dd/MM/yyyy");
                lbM1Address.Text = record.dose1.location.name;
                lbM1Reaction.Text = record.dose1.adverse_reaction;
            }
            
            if (record.dose2 != null)
            {
                lbM2Vaccine_name.Text = record.dose2.vaccine.vaccine_name;
                lbM2VaccineID.Text = record.dose2.vaccine.vaccine_id;
                lbM2Date.Text = record.dose2.injection_date.ToString("dd/MM/yyyy");
                lbM2Address.Text = record.dose2.location.name;
                lbM2Reaction.Text = record.dose2.adverse_reaction;

            }

            if (record.dose3 != null)
            {
                lbM3Vaccine_name.Text = record.dose3.vaccine.vaccine_name;
                lbM3VaccineID.Text = record.dose3.vaccine.vaccine_id;
                lbM3Date.Text = record.dose3.injection_date.ToString("dd/MM/yyyy");
                lbM3Address.Text = record.dose3.location.name;
                lbM3Reaction.Text = record.dose3.adverse_reaction;
            }    

            if (record.dose4 != null)
            {

                lbM4Vaccine_name.Text = record.dose4.vaccine.vaccine_name;
                lbM4VaccineID.Text = record.dose4.vaccine.vaccine_id;
                lbM4Date.Text = record.dose4.injection_date.ToString("dd/MM/yyyy");
                lbM4Address.Text = record.dose4.location.name;
                lbM4Reaction.Text = record.dose4.adverse_reaction;
            }    

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }


    }
}
