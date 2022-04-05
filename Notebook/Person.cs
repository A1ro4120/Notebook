using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public struct Person
    {
        /// <summary>
        /// ФИО
        /// </summary>
        static public string FullName { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        static public string Street { get; set; }

        /// <summary>
        /// Номер дома
        /// </summary>
        static public string HouseNumber { get; set; }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        static public string ApartmentNumber { get; set; }

        /// <summary>
        /// Мобильный телефон
        /// </summary>
        static public string MobilePhone { get; set; }

        /// <summary>
        /// Домашний телефон
        /// </summary>
        static public string HomePhone { get; set; }
    }
}
