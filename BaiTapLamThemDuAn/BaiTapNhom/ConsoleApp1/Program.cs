using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<String> listThamSo = new List<string>();
        static List<String> listToanTu = new List<string>();
        private static void CutString3(string lichsu)
        {
            bool flag = false;
            int dem1 = 0, dem2 = 0;
            int gan = 0;
            string s = "";
            for (int i = 0; i < lichsu.Length; i++)//12+232+4
            {
                if (char.IsSymbol(lichsu[i]))
                {
                     listToanTu.Add(lichsu[i].ToString());
                    flag = true;
                    dem2++;//3

                }
                else
                {
                   
                    dem1++;//7 
                    if (flag == true && dem2 == 1)
                    {
                        s = lichsu.Substring(0, dem1 - 1);
                        listThamSo.Add(s);
                        flag = false;
                        gan = i;
                    }
                    if (flag == true && dem2 > 1)
                    {
                        s = lichsu.Substring(gan, dem1 - gan);
                        listThamSo.Add(s);
                        gan = i;
                        flag = false;
                        
                        dem1++;
                    }
                    if (dem1 + 1 == lichsu.Length - 1)
                    {
                        s = lichsu.Substring(gan, dem1 - gan + 2); // ch su 6+
                        listThamSo.Add(s);

                    }
                }

            }

        }
        static void Main()
        {
            //Console.Write("Nhập biểu thức toán học: ");
            //string expression = Console.ReadLine();

            //// Tính toán biểu thức
            //double result = Evaluate(expression);

            //Console.WriteLine("Kết quả là: {0}", result);

            CutString3("123333+25554+66888+33666+9999-3333");
            listThamSo.ForEach(h => Console.WriteLine(h));
            listToanTu.ForEach(h => Console.Write(h));

            Console.ReadKey();
        }

    }
}
