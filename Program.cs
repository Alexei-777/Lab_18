using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки.
//Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
//Указание: задача решается однократным проходом по символам заданной строки слева направо;
//для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
//(при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string stroka = Convert.ToString(Console.ReadLine());
            string[] simvol = new string[stroka.Length];                                         // создам архив
            for (int i = 0; i < stroka.Length; i++)
            {
                simvol[i] = Convert.ToString(stroka[i]);                                              // заполню
            }
            List<string> list = new List<string>();
            list.AddRange(simvol);                                                           // добавлю в список архив                    
            for (int i = 0; i < 2; i++)                                                        //Погнали
            {
                if (list[0] == "{" && i == 0)
                {
                    list.RemoveAt(0);
                    for (int a = 0; a < list.Count; a++)
                    {
                        if (list[a] == "}")
                        {
                            i = 5;
                            list.RemoveAt(a);
                        }
                    }
                }
                if (list[0] == "(" && i == 0)
                {
                    list.RemoveAt(0);
                    for (int a = 0; a < list.Count; a++)
                    {
                        if (list[a] == ")")
                        {
                            i = 5;
                            list.RemoveAt(a);
                        }
                    }
                }
                if (list[0] == "[" && i <= 2)
                {
                    list.RemoveAt(0);
                    for (int a = 0; a < list.Count; a++)
                    {
                        if (list[a] == "]")
                        {
                            i = 5;
                            list.RemoveAt(a);
                        }
                    }
                }
                if (i == 5) { i = -1; } else { i = 5; }                         //метка на выход из цикла
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Строка соответствует условию задачи");
            }
            else
            {
                Console.WriteLine("Все пропало Шеф, строка не правильная!!!");
            }
            Console.ReadKey();
        }
    }
}
