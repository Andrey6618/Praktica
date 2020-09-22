using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    class Tovar
    {
        public string Name { get; set; }
        public string Ck { get; set; }
        public double St { get; set; }
        public Tovar()
        {
            Name = null;
            Ck = null;
            St = 0;
        }
        public Tovar(string name, string ck, double st)
        {
            Name = name;
            Ck = ck;
            St = st;
        }
        public void Input()
        {
            Console.Write("Введите Фамилию: ");
            string name = Console.ReadLine();
            Name = name;
            Console.Write("Введите ЦК: ");
            string ck = Convert.ToString(Console.ReadLine());
            Ck = ck;
            Console.Write("Введите Педагогич. стаж: ");
            double st = Convert.ToDouble(Console.ReadLine());
            St = st;
        }
        public void Write()
        {
            Console.WriteLine("Фамилия: {0} ЦК: {1} Педагогич. стаж: {2}", Name, Ck, St);
        }
    }
}
