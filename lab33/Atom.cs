using System;
using System.Collections.Generic;

namespace lab33
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string Fullname { get; set; }
        public double Weight { get; set; }

        private List<Atom> _listAtomic = new List<Atom>();
        public bool Accept()
        {
            Console.WriteLine("Enter atomic number");
            this.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol");
            this.Symbol = Console.ReadLine();
            Console.WriteLine("Enter full name");
            this.Fullname = Console.ReadLine();
            Console.WriteLine("Enter atomic weight");
            this.Weight = Convert.ToDouble(Console.ReadLine());
            _listAtomic.Add(this);
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < _listAtomic.Count; i++)
            {
                Atom atom = _listAtomic[i];
                if (_listAtomic.Count > 10)
                {
                    Console.WriteLine("Chi nhan toi da 10 phan tu");
                    return;
                }
                else
                {
                    Console.WriteLine($"Number{atom.Number}, Symbol{atom.Symbol}, FullName{atom.Fullname}, Number{atom.Number}");
                }
            }
            
        }
    }
}