using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public class Vaccine
    {
        public string vaccine_id { get; set; }
        public string vaccine_name {  get; set; }
        public int capacity {  get; set; }
        public string origin { get; set; }


        public Vaccine(string vaccine_id, string vaccine_name, int capacity, string origin)
        {
            this.vaccine_id = vaccine_id;
            this.vaccine_name = vaccine_name;
            this.capacity = capacity;
            this.origin = origin;
        }

        public Vaccine() { }

        public override string ToString()
        {
            return $"\n+ Loại Vaccine: {vaccine_id}\n+ Số lô: {vaccine_id}\n";
        }

        public static List<Vaccine> GetVaccines()
        {
            List<Vaccine> vaccineList = new List<Vaccine>();
            vaccineList.Add(new Vaccine("PF001", "Pfizer", 10000, "Mỹ"));
            vaccineList.Add(new Vaccine("VC001", "Vero Cell", 50000, "Trung Quốc"));
            vaccineList.Add(new Vaccine("MO001", "Moderna", 12000, "Mỹ"));
            vaccineList.Add(new Vaccine("JA001", "Janssen", 8000, "Hà Lan & Bỉ"));
            vaccineList.Add(new Vaccine("AZ001", "AstraZeneca", 5000, "Anh Quốc"));
            vaccineList.Add(new Vaccine("SV001", " SPUTNIK V", 7500, "Nga"));
            return vaccineList;
        }

        public static Vaccine FindVaccine(string targetid, List<Vaccine> vaccineList)
        {
            Vaccine current = new Vaccine();
            foreach (Vaccine v in vaccineList)
            {
                if (v.vaccine_id.Equals(targetid))
                    current = v;
            }
            return current;
        }

    }

    
}
