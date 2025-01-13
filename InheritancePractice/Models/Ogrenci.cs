using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice.Models
{
    public class Ogrenci : BaseKisi
    {
        public string OkulNo { get; set; }

        public void OkulNoYaz()
        {
            Console.WriteLine($"Öğrenci No: {OkulNo}");
        }
    }
}
