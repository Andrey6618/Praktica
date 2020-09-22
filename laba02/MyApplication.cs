using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba02
{
    class MyApplication
    {
        public MyApplication()
        {

        }
        private void DisplayMainMenu()
        {
            Console.WriteLine("1-> Добавить преподавателя");
            Console.WriteLine("2-> Удалить преподавателя");
            Console.WriteLine("3-> Поиск преподавателя");
            Console.WriteLine("4-> Редактировать преподавателя");
            Console.WriteLine("5-> Сортировка преподавателей");
            Console.WriteLine("6-> Завершить работу");
            Console.WriteLine("7-> В начало");
            Console.WriteLine("8-> В конец");
            Console.WriteLine("9-> Следующий элемент");
            Console.WriteLine("10-> Предыдущий элемент");
        }
        public void ProcessMenuItem()
        {
            TovarLinkedList TovarLinkedList = new TovarLinkedList();
            int i;
            do
            {
                DisplayMainMenu();
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите количество элементов в списке:");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < count; j++)
                        {
                            TovarLinkedList.Add();
                        }
                        TovarLinkedList.PrintList();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите название для удаления:");
                        string name = Console.ReadLine();
                        TovarLinkedList.Remuve(name);
                        TovarLinkedList.PrintList();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите название для вывода:");
                        name = Console.ReadLine();
                        TovarLinkedList.Find(name).Write();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введите название для изменения:");
                        name = Console.ReadLine();
                        TovarLinkedList.Rename(i);
                        TovarLinkedList.PrintList();
                        break;
                    case 5:
                        Console.Clear();
                        TovarLinkedList.Sort();
                        TovarLinkedList.PrintList();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nError, please try again\n");
                        break;
                    case 7:
                      
                        TovarLinkedList.MovingItem_First();
                        break;
                    case 8:
                        TovarLinkedList.MovingItem_Last();
                        break;
                    case 9:
                        TovarLinkedList.MovingItem_Next();
                        break;
                    case 10:
                        TovarLinkedList.MovingItem_Back();
                        break;

                }
            }
            while (i != 6);
            Console.ReadKey();
        }
    }
}
