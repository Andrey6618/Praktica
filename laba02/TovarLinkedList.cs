using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba02
{
    class TovarLinkedList
    {
        int number = 0;
        private LinkedList<Tovar> Tovarlist = null;

        public TovarLinkedList()
        {
            Tovarlist = new LinkedList<Tovar>();

        }



        public int Length //Свойство длинна
        {
            get { return Tovarlist.Count; }
        }

        public void Add() //Метод добавления элементов в список
        {
            Tovar item = new Tovar();
            item.Input();
            Tovarlist.AddLast(item);

        }

        public void Remuve(string name) //Метод удаления элементов из списка
        {
            Tovar item = new Tovar();
            LinkedListNode<Tovar> current = Tovarlist.First;
            foreach (var o in Tovarlist)
            {
                item = current.Value;
                if (item.Name == name)
                    break;
                current = current.Next;
            }
            Tovarlist.Remove(item);
        }


        public void PrintList() //Метод вывода списка в консоль
        {
            for (int i = 0; i < Tovarlist.Count; i++)
                Tovarlist.ElementAt(i).Write();



            //Tovar item = new Tovar();
            //LinkedListNode<Tovar> current = Tovarlist.First;
            //foreach (var o in Tovarlist)
            //{
            //    item = current.Value;
            //    item.Write();
            //    current = current.Next;
            //}
        }


        public Tovar Find(string name) //Метод поиска элемента в списке
        {
            Tovar item = new Tovar();
            LinkedListNode<Tovar> current = Tovarlist.First;
            foreach (var o in Tovarlist)
            {
                item = current.Value;
                if (item.Name == name)
                    break;
                current = current.Next;
            }
            return item;
        }


        public void Rename(int i ) //Метод переименования элемента из списка
        {



            Tovarlist.ElementAt(i).Input();

            //Tovar item = new Tovar();
            //LinkedListNode<Tovar> current = Tovarlist.First;
            //foreach (var o in Tovarlist)
            //{
            //    item = current.Value;
            //    if (item.Name == name)
            //        break;
            //    current = current.Next;
            //}
            //Console.WriteLine("Введите Фамилию ЦК Стаж");
            //item.Name = Console.ReadLine();
            //item.Ck = Console.ReadLine();
            //item.St = double.Parse(Console.ReadLine());
        }


        public void Sort() //Метод сортировки списка по стажу
        {
            var sort = from w in Tovarlist
                       orderby w.St ascending
                       select w;
            foreach (Tovar w in sort)
                Console.WriteLine(w.St);
        }
        public void MovingItem_First()
        {


            Tovarlist.First().Write();

            //LinkedListNode<Tovar> node;
            //Console.WriteLine("*Начало списка*");
            //for (node = Tovarlist.First; node != null; node = node.Next)
            //    node.Value.Write();
            //Console.WriteLine();
        }
        public void MovingItem_Last()
        {
            Tovarlist.Last().Write();
            //LinkedListNode<Tovar> node;
            //Console.WriteLine("*Конец списка*");
            //for (node = Tovarlist.Last; node != null; node = node.Previous)
            //    node.Value.Write();
            //Console.WriteLine();
        }
        public void MovingItem_Next()
        {
            Console.WriteLine();
            Console.WriteLine("*Следующий элемент*");
            number += 1;
            var a = Tovarlist.ElementAt(number);
            a.Write();
            Console.WriteLine();
        }
        public void MovingItem_Back()
        {
            Console.WriteLine();
            Console.WriteLine("*Предыдущий элемент*");
            number -= 1;
            if (number >= 0)
            {
                var a = Tovarlist.ElementAt(number);
                a.Write();
            }
            Console.WriteLine();
        }

    }
}