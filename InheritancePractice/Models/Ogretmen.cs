using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice.Models
{
    public class Ogretmen : BaseKisi
    {
        public string Maas { get; set; }

        public void MaasYaz()
        {
            Console.WriteLine($"Maaş: {Maas}");
        }
    }
}