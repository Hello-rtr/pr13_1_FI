using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace prakt_13
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Фамилия" });
                foreach (object r in list)
                {
                    Console.WriteLine(r);
                }
                list.RemoveAt(0);
                list.Reverse();
                Console.WriteLine(list[1]);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                //#1
                try
                {
                    Console.WriteLine("Задание 1");
                    Console.WriteLine("введите значение n");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    if (n1 > 0 && n1 < list.Count)
                    {
                        ArrayList arr = new ArrayList();
                        arr.Add("Слово");
                        arr.Add(15);
                        arr.Add(52);
                        arr.Add(',');
                        arr.Add(9.9);
                        list.InsertRange(n1, arr);
                        int n = n1 / 2;
                        Console.WriteLine("Введите k");
                        int k = Convert.ToInt32(Console.ReadLine());
                        list.RemoveRange(n, k);
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    else { Console.WriteLine("Вы ввели слишком маленькое число"); }
                    Console.ReadKey();
                }
                catch 
                {
                    Console.WriteLine("Вы ввели неверный символ");
                }
            }
        }
    }
}
