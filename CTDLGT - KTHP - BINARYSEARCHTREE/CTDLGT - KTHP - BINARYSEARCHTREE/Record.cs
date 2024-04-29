using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public class Record
    {
        public long id {  get; set; }
        public string name { get; set; }
        public DateTime birthday { get; set; }

        public string gender { get; set; }
        public string address { get; set; }
        public Injection dose1 { get; set; }
        public Injection dose2 { get; set; }
        public Injection dose3 { get; set; }
        public Injection dose4 { get; set; }

        public Record(long id, string name, string address, DateTime birthday, string gender, Injection dose1, Injection dose2, Injection dose3, Injection dose4)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.address = address;
            this.gender = gender;
            this.dose1 = dose1;
            this.dose2 = dose2;
            this.dose3 = dose3;
            this.dose4 = dose4;
        }

        public Record(long id, string name, string address, DateTime birthday, string gender, Injection dose1)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.address = address;
            this.gender = gender;
            this.dose1 = dose1;
        }

        public Record(long id, string name, string address, DateTime birthday, string gender, Injection dose1, Injection dose2)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.address = address;
            this.gender = gender;
            this.dose1 = dose1;
            this.dose2 = dose2;
        }

        public Record (long id, string name, DateTime birthday, string gender, string address, Injection dose1, Injection dose2, Injection dose3)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.address = address;
            this.dose1 = dose1;
            this.dose2 = dose2;
            this.dose3 = dose3;

        }

        public Record()
        {

        }

        public Record (Record record)
        {
            this.id = record.id;
            this.name = record.name;
            this.birthday = record.birthday;
            this.address = record.address;
            this.gender = record.gender;
            this.dose1 = record.dose1;
            this.dose2 = record.dose2;
            this.dose3 = record.dose3;
            this.dose4= record.dose4;
        }


        public static List<Record> GetRecords(List<Vaccine> Vaccines, List<location> Locations)
        {
            List<Record> records = new List<Record>();
            records.Add(new Record(31231020502, "Trần Anh Vy", "514/26 Phú Định Phường 16 Quận 8 TP. Hồ Chí Minh", new DateTime(2005, 12, 24),"Nữ",
                                                 new Injection(Vaccines[1], new DateTime(2021, 12, 23), "Không", Locations[1]),
                                                 new Injection(Vaccines[1], new DateTime(2022, 02, 10), "Không", Locations[6])));
            records.Add(new Record(31231021355, "Lê Nguyễn Trâm Anh", "176 Xô Viết Nghệ Tĩnh Phường 21 Quận Bình Thạnh TP. Hồ Chí Minh", new DateTime(2005, 04, 03),"Nữ",
                                                 new Injection(Vaccines[2], new DateTime(2021, 12, 9), "Không", Locations[7]),
                                                 new Injection(Vaccines[2], new DateTime(2022, 03, 10), "Không", Locations[2])));
            records.Add(new Record(31231022591, "Nguyễn Tấn Phát", "103 Lý Chiêu Hoàng Phường 11 Quận 6 TP. Hồ Chí Minh", new DateTime(2005, 04, 18),"Nam",
                                                 new Injection(Vaccines[5], new DateTime(2021, 11, 15), "Không", Locations[5]),
                                                 new Injection(Vaccines[5], new DateTime(2022, 02, 02), "Không", Locations[3])));
            records.Add(new Record(31231025969, "Phạm Tiến Thành", "574/69 Sinco Phường Bình Trị Đông B Quận Bình Tân", new DateTime(2005, 07, 19), "Nam",
                                                 new Injection(Vaccines[4], new DateTime(2021, 11, 29), "Không", Locations[6]),
                                                 new Injection(Vaccines[4], new DateTime(2022, 02, 20), "Không", Locations[5])));

            return records;        
        }

        public static void Swap(Record a, Record b)
        {
            Record temp = new Record(a.id, a.name, a.address, a.birthday, a.gender, a.dose1, a.dose2, a.dose3, a.dose4);
            a.id = b.id;
            a.name = b.name;
            a.birthday = b.birthday;
            a.address = b.address;
            a.gender = b.gender;
            a.dose1 = b.dose1;
            a.dose2 = b.dose2;
            a.dose3 = b.dose3;
            a.dose4 = b.dose4;
            b.id = temp.id;
            b.name = temp.name;
            b.birthday = temp.birthday;
            b.address = temp.address;
            b.gender = temp.gender;
            b.dose1 = temp.dose1;
            b.dose2 = temp.dose2;
            b.dose3 = temp.dose3;
            b.dose4 = temp.dose4;
        }
        public static void SortAZ(List<Record> recordList)
        {
            int i = 1;
            while (i < recordList.Count)
            {
                int j = i;
                while ((j > 0) && (recordList[j - 1].dose1.injection_date.CompareTo(recordList[j].dose1.injection_date)) == 1)
                {
                    Swap(recordList[j], recordList[j - 1]);
                    j = j - 1;
                }
                i = i + 1;
            }
        }

        public static void SortZA(List<Record> recordList)
        {
            int i = 1;
            while (i < recordList.Count)
            {
                int j = i;
                while ((j > 0) && (recordList[j - 1].dose1.injection_date.CompareTo(recordList[j].dose1.injection_date)) == -1)
                {
                    Swap(recordList[j], recordList[j - 1]);
                    j = j - 1;
                }
                i = i + 1;
            }
        }
    }
}
