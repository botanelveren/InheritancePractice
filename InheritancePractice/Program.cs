using InheritancePractice.Models;
using System;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Ali";
            ogretmen.Soyad = "Veli";
            ogretmen.Maas = "5000";
            ogretmen.EkranaYaz();
            ogretmen.MaasYaz();

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ayse";
            ogrenci.Soyad = "Fatma";
            ogrenci.OkulNo = "123";
            ogrenci.EkranaYaz();
            ogrenci.OkulNoYaz();
        }
    }
}