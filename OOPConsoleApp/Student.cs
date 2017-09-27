using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    class Student
    {
        //Name och Email är fält(field)
        //ett fält är deklarerat i klassen
        public string Name;
        public string Email;
        public string Phone;
        private int StudyHarderCounter = 0;
        public event EventHandler TooTired;

        public override string ToString()
        {
            //när en $ tecken så kallas en interpolera strängar en eller flera
            //
            return $"{this.Name}\n epost: {this.Email}\n mobil: {this.Phone}";
        }

        internal void StudyHarder()
        {
            StudyHarderCounter++;
            if (StudyHarderCounter > 2)
                TooTired?.Invoke(this, null);

            Name = "Super " + Name;
        }
    }
}
