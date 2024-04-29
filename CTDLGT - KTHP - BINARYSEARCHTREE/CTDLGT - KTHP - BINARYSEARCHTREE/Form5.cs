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
    public partial class Form5 : Form
    {
        public static BinarySearchTree BST_record = new BinarySearchTree();
        public Form5()
        {
            InitializeComponent();
        }

        public Form5(List<Record> recordList)
        {
            InitializeComponent();
            foreach (Record record in recordList)
            {
                BST_record.Insert(record);
            }
            dtgvRecord.DataSource = recordList;

            List<Vaccine> vaccineList = Vaccine.GetVaccines();
            foreach (Vaccine v in vaccineList)
            {
                cbbP2VaccineName.Items.Add(v.vaccine_name);
                cbbP2ID.Items.Add(v.vaccine_id);
            }

            List<location> locationList = location.GetLocations();
            foreach (location location in locationList)
            {
                cbbP2Location.Items.Add(location.name);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public bool IsLetter(string text)
        {
            bool result = false;
            string letter = " aáàảãạăắằẳẵặâấầẩẫậeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵbcdđfghjklmnpqrstvwxzAÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴBCDĐFGHJKLMNPQRSTVWXZ";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (letter[j] != text[i])
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                        break;
                    }

                }
                if (result == false)
                    return false;

            }
            return result;
        }

        public bool IsNumber(string text)
        {
            string number = "0123456789";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] == text[i])
                        return true;
                }
            }
            return false;
        }

        public bool IsLower(char c)
        {
            string lowerletter = "aáàảãạăắằẳẵặâấầẩẫậeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵbcdđfghjklmnpqrstvwxz";
            for (int i = 0; i < lowerletter.Length; i++)
            {
                if (c == lowerletter[i])
                    return true;
            }
            return false;
        }

        public bool IsUpper(char c)
        {
            string upperletter = "AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴBCDĐFGHJKLMNPQRSTVWXZ";
            for (int i = 0; i < upperletter.Length; i++)
            {
                if (c == upperletter[i])
                    return true;
            }
            return false;
        }

        public char LowerToUpper(char c)
        {
            string lowerletter = "aáàảãạăắằẳẵặâấầẩẫậeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵbcdđfghjklmnpqrstvwxz";
            string upperletter = "AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴBCDĐFGHJKLMNPQRSTVWXZ";

            for (int i = 0; i < lowerletter.Length; i++)
            {
                if (c == lowerletter[i])
                    return upperletter[i];
            }
            return '0';
        }

        public char UpperToLower(char c)
        {
            string lowerletter = "aáàảãạăắằẳẵặâấầẩẫậeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵbcdđfghjklmnpqrstvwxz";
            string upperletter = "AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬEÉÈẺẼẸÊẾỀỂỄỆIÍÌỈĨỊOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰYÝỲỶỸỴBCDĐFGHJKLMNPQRSTVWXZ";

            for (int i = 0; i < upperletter.Length; i++)
            {
                if (c == upperletter[i])
                    return lowerletter[i];
            }
            return '0';
        }

        public string LetterCheck(string text)
        {
            string target = null;

            //Xóa đoạn trắng đầu và cuối
            if (text[0].ToString() == " ")
            {
                if (text[text.Length - 1].ToString() == " ")
                {
                    for (int i = 1; i < text.Length - 1; i++)
                    {
                        target += text[i];
                    }
                }
                else
                {
                    for (int i = 1; i < text.Length; i++)
                    {
                        target += text[i];
                    }
                }

            }

            //Viết hoa chữ cái đầu
            if (target == null)
                target = text;

            List<int> index = new List<int>();
            index.Add(0);

            for (int i = 0; i < target.Length; i++)
            {
                if (target[i].ToString() == " ")
                {
                    index.Add(i + 1);
                }
            }
            string current = "";

            int v = 0;
            for (int i = 0; i < target.Length; i++)
            {
                if (i == index[v])
                {
                    if (IsLower(target[i]))
                        current += LowerToUpper(target[i]);
                    else
                        current += target[i];
                    if (v < index.Count - 1)
                        v++;
                }
                else
                {
                    while (target[i].ToString() != " ")
                    {
                        current += target[i];
                        if (i < target.Length - 1)
                            i++;
                        else
                            break;
                    }
                    if (i != target.Length - 1)
                        current += target[i];
                }
            }
            target = current;

            if (target == null)
                target = text;

            List<int> index2 = new List<int>();
            for (int i = 1; i < target.Length; i++)
            {
                if (IsLetter(target[i].ToString()) && IsLetter(target[i - 1].ToString()) && target[i - 1].ToString() != " ")
                {
                    index2.Add(i);
                }
            }

            current = "";
            v = 0;
            for (int i = 0; i < target.Length; i++)
            {
                if (i != index2[v])
                {
                    current += target[i];
                }
                else
                {
                    if (IsUpper(target[i]))
                    {
                        current += UpperToLower(target[i]);
                        if (v < index2.Count - 1)
                            v++;
                    }
                    else
                    {
                        current += target[i];
                        if (v < index2.Count - 1)
                            v++;
                    }

                }
            }
            target = current;

            return target;
        }



        private void btnFindName_Click_1(object sender, EventArgs e)
        {
            if (IsLetter(txbName.Text))
            {
                string current = LetterCheck(txbName.Text);
                List<Record> FindList = new List<Record>();
                BST_record.FindThroughName(current, BST_record.root, FindList);
                dtgvRecord.DataSource = FindList;
                dtgvRecord.Refresh();

                if (FindList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hồ sơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Tên không bao gồm số và ký tự đặc biệt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void btnFindDate_Click(object sender, EventArgs e)
        {
            List<Record> FindList = new List<Record>();
            BST_record.FindThroughTime(BST_record.root, FindList, dtpFrom.Value.Date, dtpUntil.Value.Date);
            dtgvRecord.DataSource = FindList;
            dtgvRecord.Refresh();
            if (FindList.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hồ sơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void btnAZ_Click(object sender, EventArgs e)
        {
            List<Record> FindList = new List<Record>();
            BST_record.FindThroughTime(BST_record.root, FindList, dtpFrom.Value.Date, dtpUntil.Value.Date);
            Record.SortAZ(FindList);
            dtgvRecord.DataSource = FindList;
            dtgvRecord.Refresh();

        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            List<Record> FindList = new List<Record>();
            BST_record.FindThroughTime(BST_record.root, FindList, dtpFrom.Value.Date, dtpUntil.Value.Date);
            Record.SortZA(FindList);
            dtgvRecord.DataSource = FindList;
            dtgvRecord.Refresh();
        }


        private void dtgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Record> current = dtgvRecord.DataSource as List<Record>;
            int index = e.RowIndex;
            Form6 f = new Form6(current[index]);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private bool CheckVaccine(string id, string name)
        {
            foreach (Vaccine v in Form2.vaccineList)
            {
                if (id == v.vaccine_id && name == v.vaccine_name)
                    return true;
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbP2ID.Text == "" || txbP2Name.Text == "" || txbP2Address.Text == "" || txbP2Reaction.Text == "" || cbbP2Dose.Text == "" || cbbP2Gender.Text == "" || cbbP2ID.Text == "" || cbbP2Location.Text == "" || cbbP2VaccineName.Text == "")
            {
                MessageBox.Show("Bạn phải đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!IsLetter(txbP2Name.Text))
                {
                    MessageBox.Show("Tên không bao gồm số và ký tự đặc biệt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbbP2Dose.Text == "Mũi 1")
                {
                    txbP2Name.Text = LetterCheck(txbP2Name.Text);
                    if (CheckVaccine(cbbP2ID.Text, cbbP2VaccineName.Text))
                    {
                        Vaccine currentvaccine = Vaccine.FindVaccine(cbbP2ID.Text, Form2.vaccineList);
                        location currentlocation = location.FindLocation(cbbP2Location.Text, Form2.locationList);
                        Injection newinjection = new Injection(currentvaccine, dtpP2Date.Value.Date, txbP2Reaction.Text, currentlocation);
                        long id;
                        if (long.TryParse(txbP2ID.Text, out id))
                        {
                            Record newrecord = new Record(id, txbP2Name.Text, cbbP2Location.Text, dtpP2Birthday.Value.Date, cbbP2Gender.Text, newinjection);
                            Form2.recordList.Add(newrecord);
                            BST_record.Insert(newrecord);
                            dtgvRecord.DataSource = null;
                            dtgvRecord.DataSource = Form2.recordList;
                            dtgvRecord.Refresh();
                        }
                        else
                            MessageBox.Show("Bạn phải nhập đúng CCCD", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Bạn phải nhập đúng mã lô vacxin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Bạn phải nhập thông tin cho Mũi 1", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (txbP2ID.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số CCCD hồ sơ muốn điều chỉnh", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long id;
                if (long.TryParse(txbP2ID.Text, out id))
                {
                    Record current = new Record();
                    current = BST_record.FindThroughID(id);
                    if (current.dose1 == null)
                    {
                        MessageBox.Show("Hồ sơ chưa tồn tại, bạn cần tạo mới", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CheckVaccine(cbbP2ID.Text, cbbP2VaccineName.Text))
                    {
                        if (current.dose2 == null)
                        {
                            if (cbbP2Dose.Text == "Mũi 2")
                            {
                                BST_record.Remove(current);
                                Vaccine currentvaccine = Vaccine.FindVaccine(cbbP2ID.Text, Form2.vaccineList);
                                location currentlocation = location.FindLocation(cbbP2Location.Text, Form2.locationList);
                                Injection newinjection = new Injection(currentvaccine, dtpP2Date.Value.Date, txbP2Reaction.Text, currentlocation);
                                foreach (Record record in Form2.recordList)
                                {
                                    if (record.id == id)
                                    {
                                        record.dose2 = newinjection;
                                    }
                                }
                                current.dose2 = newinjection;
                                BST_record.Insert(current);
                                dtgvRecord.DataSource = null;
                                dtgvRecord.DataSource = Form2.recordList;
                                dtgvRecord.Refresh();
                            }
                            else
                                MessageBox.Show("Bạn phải nhập thông tin Mũi 2", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (current.dose3 == null)
                        {
                            if (cbbP2Dose.Text == "Mũi 3")
                            {
                                BST_record.Remove(current);
                                Vaccine currentvaccine = Vaccine.FindVaccine(cbbP2ID.Text, Form2.vaccineList);
                                location currentlocation = location.FindLocation(cbbP2Location.Text, Form2.locationList);
                                Injection newinjection = new Injection(currentvaccine, dtpP2Date.Value.Date, txbP2Reaction.Text, currentlocation);
                                foreach (Record record in Form2.recordList)
                                {
                                    if (record.id == id)
                                    {
                                        record.dose3 = newinjection;
                                    }
                                }
                                current.dose3 = newinjection;
                                BST_record.Insert(current);
                                dtgvRecord.DataSource = null;
                                dtgvRecord.DataSource = Form2.recordList;
                                dtgvRecord.Refresh();
                            }

                            else
                                MessageBox.Show("Bạn phải nhập thông tin Mũi 3", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (current.dose4 == null)
                        {
                            if (cbbP2Dose.Text == "Mũi 4")
                            {
                                BST_record.Remove(current);
                                Vaccine currentvaccine = Vaccine.FindVaccine(cbbP2ID.Text, Form2.vaccineList);
                                location currentlocation = location.FindLocation(cbbP2Location.Text, Form2.locationList);
                                Injection newinjection = new Injection(currentvaccine, dtpP2Date.Value.Date, txbP2Reaction.Text, currentlocation);
                                foreach (Record record in Form2.recordList)
                                {
                                    if (record.id == id)
                                    {
                                        record.dose4 = newinjection;
                                    }
                                }
                                current.dose4 = newinjection;
                                BST_record.Insert(current);
                                dtgvRecord.DataSource = null;
                                dtgvRecord.DataSource = Form2.recordList;
                                dtgvRecord.Refresh();
                            }

                        }
                    }
                    else
                        MessageBox.Show("Bạn phải nhập đúng mã lô vacxin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                    MessageBox.Show("Bạn phải nhập đúng CCCD", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txbP2ID.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số CCCD hồ sơ muốn xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long id;
                if (long.TryParse(txbP2ID.Text, out id))
                {
                    Record current = new Record();
                    current = BST_record.FindThroughID(id);
                    if (current.dose1 == null)
                    {
                        MessageBox.Show("Hồ sơ không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BST_record.Remove(current);
                        Form2.recordList.Remove(current);
                        dtgvRecord.DataSource = null;
                        dtgvRecord.DataSource = Form2.recordList;
                        dtgvRecord.Refresh();
                    }
                }

                else
                    MessageBox.Show("Bạn phải nhập đúng CCCD", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnP2Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSortOldNew_Click(object sender, EventArgs e)
        {
            List<Record> current = dtgvRecord.DataSource as List<Record>;
            if (cbbNewOld.Text == "Mới nhất")
            {
                Record.SortZA(current);
                dtgvRecord.DataSource = current;
                dtgvRecord.Refresh();
            }
            else
            {
                Record.SortAZ(current);
                dtgvRecord.DataSource = current;
                dtgvRecord.Refresh();
            }
        }
    }
}
