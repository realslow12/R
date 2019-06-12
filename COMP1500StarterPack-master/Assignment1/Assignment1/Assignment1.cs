using System.IO;
using System;

namespace Assignment1
{
    public static class Assignment1
    {
        public static void PrintIntegers(StreamReader input, StreamWriter output)
        {

            int num = int.Parse(input.ReadLine());
            int num2 = int.Parse(input.ReadLine());
            int num3 = int.Parse(input.ReadLine());
            int num4 = int.Parse(input.ReadLine());
            int num5 = int.Parse(input.ReadLine());


            string data1 = Convert.ToString(num, 8);
            string data2 = Convert.ToString(num, 10);
            string data3 = num.ToString("X");

            string data4 = Convert.ToString(num2, 8);
            string data5 = Convert.ToString(num2, 10);
            string data6 = num2.ToString("X");

            string data7 = Convert.ToString(num3, 8);
            string data8 = Convert.ToString(num3, 10);
            string data9 = num3.ToString("X");

            string data10 = Convert.ToString(num4, 8);
            string data11 = Convert.ToString(num4, 10);
            string data12 = num4.ToString("X");

            string data13 = Convert.ToString(num5, 8);
            string data14 = Convert.ToString(num5, 10);
            string data15 = num5.ToString("X");

            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", "oct", "dec", "hex"));
            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", "------------", "----------", "--------"));
            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", data1, data2, data3));
            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", data4, data5, data6));
            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", data7, data8, data9));
            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", data10, data11, data12));
            output.WriteLine(string.Format("{0,12} {1,10} {2,8}", data13, data14, data15));

        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {

            float f1 = float.Parse(input.ReadLine());
            float f2 = float.Parse(input.ReadLine());
            float f3 = float.Parse(input.ReadLine());
            float f4 = float.Parse(input.ReadLine());
            float f5 = float.Parse(input.ReadLine());


            output.WriteLine(string.Format("{0,20:F3}", f1));
            output.WriteLine(string.Format("{0,20:F3}", f2));
            output.WriteLine(string.Format("{0,20:F3}", f3));
            output.WriteLine(string.Format("{0,20:F3}", f4));
            output.WriteLine(string.Format("{0,20:F3}", f5));


            float min = int.MaxValue; ;
            float max = int.MinValue;

            float[] data = { f1, f2, f3, f4, f5 };

            

            for (int i = 0; i < data.Length; i++)
            {
                if (max < data[i])
                {
                    max = data[i];
                }
            }


            for (int i = 0; i < data.Length; i++)
            {
                if (min > data[i])
                {
                    min = data[i];
                }
            }


            float sum = f1 + f2 + f3 + f4 + f5;

            float avearage = sum / 5;

            output.WriteLine(string.Format("Min {0,16:F3}", min));
            output.WriteLine(string.Format("Max {0,16:F3}", max));
            output.WriteLine(string.Format("Sum {0,16:F3}", sum));
            output.WriteLine(string.Format("Average {0,12:F3}", avearage));


        }
    }
}