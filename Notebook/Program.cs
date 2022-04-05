using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Notebook
{
    internal class Program
    {
        /// <summary>
        /// Ввод данных персоны
        /// </summary>
        static public void PersonEntry()
        {
            Console.WriteLine("Введите данные");

            Console.Write("ФИО:");
            Person.FullName = Console.ReadLine();

            Console.Write("Улица:");
            Person.Street = Console.ReadLine();

            Console.Write("Номер дома:");
            Person.HouseNumber = Console.ReadLine();

            Console.Write("Номер квартиры:");
            Person.ApartmentNumber = Console.ReadLine();

            Console.Write("Мобильный телефон:");
            Person.MobilePhone = Console.ReadLine();

            Console.Write("Домашний телефон:");
            Person.HomePhone = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PersonEntry();

            XElement myPerson = new XElement("Person");
            XElement myAddress = new XElement("Address");
            XElement myPhones = new XElement("Phones");

            XAttribute xAttributeFullName = new XAttribute("name", Person.FullName);

            myPerson.Add(myAddress, myPhones, xAttributeFullName);

            XElement myStreet = new XElement("Streat", Person.Street);
            XElement myHouseNumber = new XElement("HouseNumber", Person.HouseNumber);
            XElement myFlatNumber = new XElement("FlatNumber", Person.ApartmentNumber);

            myAddress.Add(myStreet, myHouseNumber, myFlatNumber);

            XElement myMobilePhone = new XElement("MobilePhone", Person.MobilePhone);
            XElement myFlatPhone = new XElement("FlatPhone", Person.HomePhone);

            myPhones.Add(myMobilePhone, myFlatPhone);

            myPerson.Save("_myPerson.xml");
        }
    }
}
