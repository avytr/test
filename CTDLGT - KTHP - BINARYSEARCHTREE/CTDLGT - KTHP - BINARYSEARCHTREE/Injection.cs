using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public class Injection
    {
        public Vaccine vaccine {get; set;}
        public DateTime injection_date { get; set;}
        public string adverse_reaction { get; set;}
        public location location { get; set;}

        public Injection(Vaccine vaccine, DateTime injection_date, string adverse_reaction, location location)
        {
            if (vaccine.capacity > 0)
            {
                this.injection_date = injection_date;
                this.vaccine = vaccine;
                this.adverse_reaction = adverse_reaction;
                this.vaccine.capacity = vaccine.capacity - 1;
                this.location = location;
            }
        }

        public override string ToString()
        {
            return $"{vaccine.ToString()}+ Ngày tiêm: {injection_date.ToString("dd/MM/yyyy")}\n+ Triệu chứng: {adverse_reaction}";
        }
    }
}
