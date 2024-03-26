using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Ayşe Nur";
            person1.LastName = "Duran";
            person1.DateOfBirthYear = 1991;
            person1.NationalIdentity =123;

            // Degiskenler();
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }

        private static void Degiskenler()
        {
            string ad = "Aysenur";
            string soyad = "Duran";
            int dogumYili = 1985;
            long tcNo = 12345678910;
        }
    }
    
    public class Vatandas 
    {
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
