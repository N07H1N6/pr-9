using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Практическая работа №9");
            int x1, x2, xn, x, xv;
            Console.Write("Введите x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите xn = ");
            xn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения массива:");
            //1.объявление и инициализация
           const int n = 10;
            int sum = 0, i = 1;
            char usl;
            int[] mass = new int[n];
            bool err;
                        
            //2.
            for (i = 0; i < n;)
            {
                err = false;
                try
                {
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException e)
                { 
                    err = true;
                    Console.WriteLine("Возникла ошибка:" + e.Message);
                }
                if (!err) i++;
            }
            //3.Подсчет суммы элементов массив
            for (i = 0; i < n; i++)
            {
                sum += mass[i];
            }
            xv = x1 + x2 + xn / n;//формула среднего арифметического дисперсии
            Console.WriteLine("Среднее арифметическое дисперсии ={0}", xv);
            xn = (int)Math.Sqrt(sum * Math.Pow((x - xv), 2) / n);//формула среднего квадратичного отклонения
            Console.WriteLine("Среднее квадратичное отклонение ={0}", xn);
            Console.WriteLine("Хотите перезапустить программу?\n y-да n-нет");
            err = false;
            try
            {
                usl=char
                if(usl=y)
            }
                       
        }
    }
}
