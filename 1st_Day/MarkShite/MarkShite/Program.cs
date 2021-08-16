using System;

namespace MarkShite
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Mark, GP, CGP, GPA;
            double TotalCGP = 0;
            int TotalCredit= 21;
            for (int i = 1; i <= 6; i++)
            {
                int ObtianedMark;
                int[] TC = new int[1];
                int[] TF = new int[1];
                int[] PC = new int[1];
                int[] PF = new int[1];
                int[] CH = new int[1];
                int[] TotalMarks = new int[1];

                Console.WriteLine("Subject {0}", i);
                Console.WriteLine("Subject {0} Obtained TC Marks:", i);
                TC[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Subject {0} Obitianed TF Marks: ", i);
                TF[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Subject {0} Obtained PC Marks:", i);
                PC[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Subject {0} Obtained PF Marks:", i);
                PF[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Subject {0} Credit Hours:", i);
                CH[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Subject {0} Total Marks:", i);
                TotalMarks[0] = Convert.ToInt32(Console.ReadLine());

                ObtianedMark = TC[0] + TF[0] + PC[0] + PF[0];
                Mark = (ObtianedMark * 100) / TotalMarks[0];
                {
                    if ((Mark <= 100) && (Mark >= 80))
                    { GP = 4.00; }
                    else if ((Mark <= 79) && (Mark >= 75))
                    { GP = 3.75; }
                    else if ((Mark <= 74) && (Mark >= 70))
                    {GP=4.00 ;}
                    else if ((Mark <= 69) && (Mark >= 65))
                    { GP = 3.50;}
                    else if ((Mark <= 64) && (Mark >= 60))
                    { GP = 2.75; }
                    else if ((Mark <= 59) && (Mark >= 55))
                    { GP = 2.75 ;}
                    else if ((Mark <= 54) && (Mark >= 50))
                    { GP = 2.50; }
                    else if ((Mark <= 49) && (Mark >= 45))
                    { GP = 2.00; }
                    else
                    { GP = 0.0; }
                    Console.WriteLine("Subject {0} GP id :{1}", i, GP);
                }
                CGP = (CH[0] * GP);
                {
                    Console.WriteLine("Subject {0} CGP is: {1}\n", i, CGP);
                }
                TotalCGP += CGP;
            }
            GPA = TotalCGP / TotalCredit;
            Console.WriteLine("Final GPA {0 }",GPA);
        }
    }
}
