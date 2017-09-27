using System.Collections.Generic;

namespace CarBuilderApp
{
    internal class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
        }

        public List<object> Parts { get; internal set; }
            = new List<object>();

        public decimal Cost { get; internal set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}