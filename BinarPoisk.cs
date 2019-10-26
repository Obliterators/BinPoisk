using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бинарный_поиск
{
    class Program
    {
        static public int[] sort1(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int z = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = z;
                    }
                }
            }

            return Arr;
        }

        static public int binPoisk(int elem, int[] array)
        {
            int centr;
            int levo = 0;
            int pravo = array.Length - 1;
            centr = (pravo + levo) / 2;
            while (levo < pravo - 1)
            {
                centr = (pravo + levo) / 2;
                if (array[centr] == elem)
                    return centr;
                if (array[centr] < elem)
                    levo = centr;
                else
                    pravo = centr;
            }
            if (array[centr] != elem)
            {
                if (array[levo] == elem)
                    centr = levo;
                else
                {
                    if (array[pravo] == elem)
                        centr = pravo;
                    else
                        centr = -1;
                };
            }
            return centr;
        }
        static public void vivod(int[] arr)
        {
            foreach (int el in arr)
                Console.Write($"{el} ");
        }
        static public int vvod()
        {


            Random rnd = new Random();
            int mam = rnd.Next(5, 30);
            return mam;





        }

        static void Main(string[] args)
        {



            int col = vvod();
            int[] arr = new int[col];
            Random rn = new Random();
            for (int i = 0; i < col; i++)
            {
                arr[i] = rn.Next(0, 1000);
            }
            Console.WriteLine("Сгенерированный массив");
            vivod(arr);
            sort1(arr);
            Console.WriteLine("\n Отсортированный массив:");
            vivod(arr);
            do
            {
                Console.Write("\n Введите эллемент который хотите найти: ");
                try
                {
                    int element = Convert.ToInt32(Console.ReadLine());
                    int k = binPoisk(element, arr);

                    if (k > -1)
                        Console.WriteLine("Индек искомого элемента = {0}", k);
                    else
                        Console.WriteLine("Данного элимента нет в массиве");
                }
                catch (Exception jo)
                {
                    Console.WriteLine("\n Введены некоректные данные: " + jo.Message + "\n");
                }
                Console.WriteLine("Для повторного запуска поиска нажмите r для выхода любую другую");


            }
            while (Console.ReadLine() == "r");


        }
    }
}
