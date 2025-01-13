using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice.Models
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void EkranaYaz()
        {
            Console.WriteLine($"Adı Soyadı: {Ad} {Soyad}");
        }
    }
}
