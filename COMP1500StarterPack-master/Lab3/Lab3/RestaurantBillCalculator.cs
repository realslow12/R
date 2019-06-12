using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        { 
            string s = input.ReadLine();
            string s1 = input.ReadLine();
            string s2 = input.ReadLine();
            string s3 = input.ReadLine();
            string s4 = input.ReadLine();
            string s5 = input.ReadLine();

            double sum1 = double.Parse(s);
            double sum2 = double.Parse(s1);
            double sum3 = double.Parse(s2);
            double sum4 = double.Parse(s3);
            double sum5 = double.Parse(s4);
           
            double foodCost = sum1 + sum2 + sum3 + sum4 + sum5;
            
            Console.WriteLine($"음식가격 = {foodCost}");
          
            double tex = foodCost * 0.05;

            tex = Math.Round(tex, 2);
        
            Console.WriteLine($"세금 = {tex}");

            double tip = (foodCost + tex) * double.Parse(s5) / 100;

            tip = Math.Round(tip, 2);

            Console.WriteLine($"팁 = {tip}");

            double totalCost = foodCost + tex + tip;

            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"총가격 = {totalCost}");

            return totalCost;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            Console.WriteLine("결제할 인원수를 입력하시오");

            string c = input.ReadLine();

            totalCost = (double)totalCost / double.Parse(c);

            totalCost = Math.Round(totalCost, 2);

            Console.WriteLine($" 한명이 결제할 금액 {totalCost} ");

            return totalCost;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            Console.WriteLine("한명이 결제할 금액을 입력하시오 ");

            string r = input.ReadLine();

            totalCost = (double)totalCost / double.Parse(r);

            totalCost = Math.Ceiling(totalCost);
            
            Console.WriteLine($"결제할 인원수 {totalCost}");

            return (uint)totalCost;
        }
    }
}
