using System;

namespace Planner
{
    class Building
    {
        public Building(string address)
        {
            _address = address;
        }
        private string _designer = "Rick Blake";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }
        public void Display()
        {
            Console.WriteLine($@"{_address}
            ---------------
            Designed by {_designer}
            Constructed on {_dateConstructed}
            Owned by {_owner}
            {Volume} cubic meters of space");
        }
    }
}