using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam teamOne = new ResearchTeam();
            Console.WriteLine(teamOne.ToShortString());

            Console.WriteLine(teamOne[TimeFrame.Year].ToString());
            Console.WriteLine(teamOne[TimeFrame.TwoYears].ToString());
            Console.WriteLine(teamOne[TimeFrame.Long].ToString());

            teamOne.Theme = "Biology";
            teamOne.Organization = "RSMU";
            teamOne.Id = 145;
            teamOne.Duration = TimeFrame.Long;
            teamOne.List = new Paper[] { new Paper("Физика", new Person(), new DateTime(2021, 4, 6)) };
            Console.WriteLine(teamOne.ToString());

            teamOne.AddPapers(new Paper("МА", new Person(), new DateTime(2021, 5, 3)));
            Console.WriteLine(teamOne.ToString());
            Console.WriteLine(teamOne.Last);


            // Блок с массивами
            Console.WriteLine("Введите количество строк(row) и столбцов(col) в формате row*col или row/col или row col");
            string[] answer = Console.ReadLine().Split('*', '/', ' ');
            int row = Convert.ToInt32(answer[0]);
            int column = Convert.ToInt32(answer[1]);
            long totalSize = row * column;

            Paper[] list1 = new Paper[totalSize];
            Paper[,] list2 = new Paper[row, column];
            Paper[][] list3 = new Paper[4][];

            long firstSize = totalSize / 3;
            list3[0] = new Paper[firstSize];

            long secondSize = firstSize / 2;
            list3[1] = new Paper[secondSize];

            long thirdSize = secondSize / 2;
            list3[2] = new Paper[thirdSize];

            long fourthSize = totalSize - firstSize - secondSize - thirdSize;
            list3[3] = new Paper[fourthSize];


            //Инициализация

            for (int i = 0; i < list1.Length; i++)
            {
                list1[i] = new Paper();
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    list2[i, j] = new Paper();
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < list3[i].Length; j++)

                {
                    list3[i][j] = new Paper();
                }
            }

            Stopwatch sw = new Stopwatch();


            //Одномерный массив
            sw.Start();
            foreach (Paper item in list1)
            {
                item.Title = "Harry Potter";
            }
            sw.Stop();

            Console.WriteLine(sw.Elapsed + " - одномерный массив " + list1.Length);
            sw.Reset();


            //Двумерный прямоугольный массив
            sw.Start();
            foreach (Paper item in list2)
            {
                item.Title = "Harry Potter";
            }
            sw.Stop();

            Console.WriteLine(sw.Elapsed + " - двумерный прямоугольный массив " + list2.Length);
            sw.Reset();


            //Двумерный ступенчатый массив
            sw.Start();
            foreach (Paper[] item in list3)
            {
                foreach (Paper innerItem in item)
                {
                    innerItem.Title = "Harry Potter";
                }
            }
            sw.Stop();

            Console.WriteLine(sw.Elapsed + " - двумерный ступенчатый массив " + (list3[0].Length + list3[1].Length + list3[2].Length + list3[3].Length));
            sw.Reset();

            Console.ReadKey();
        }
    }
}