using System;
using System.Collections.Generic;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            double[] terms = new double[100];

            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                if (0 <= usersPerDay[i] && usersPerDay[i] <= 10)
                {
                    terms[i] = (double)usersPerDay[i] / 2;
                }
                else if (10 < usersPerDay[i] && usersPerDay[i] <= 100)
                {
                    terms[i] = 16 * (double)usersPerDay[i];
                }
                else if (100 < usersPerDay[i] && usersPerDay[i] <= 1000)
                {
                    terms[i] = revenuePerDay[i] = usersPerDay[i] ^ 2 / 4 - 2 * usersPerDay[i] - 2007;
                }
                else if (usersPerDay[i] > 1000)
                {
                    terms[i] = revenuePerDay[i] = 245743 + usersPerDay[i] / 4;
                }
                Math.Round(terms[i], 2);
            }

            if (terms.Length != revenuePerDay.Length) // 참인 배열값이 기존 배열과 같지 않으면 true
            {
                return true;
            }
            if (revenuePerDay.Length != usersPerDay.Length || revenuePerDay.Length == terms.Length) // 두배열의 길이가 다르거나 잘못된 데이터가 없을때
            {
                return false;
            }
            return false;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            double[] terms = new double[100];

            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                if (0 <= usersPerDay[i] && usersPerDay[i] <= 10)
                {
                    terms[i] = (double)usersPerDay[i] / 2;
                }
                else if (10 < usersPerDay[i] && usersPerDay[i] <= 100)
                {
                    terms[i] = 16 * (double)usersPerDay[i];
                }
                else if (100 < usersPerDay[i] && usersPerDay[i] <= 1000)
                {
                    terms[i] = revenuePerDay[i] = usersPerDay[i] ^ 2 / 4 - 2 * usersPerDay[i] - 2007;
                }
                else if (usersPerDay[i] > 1000)
                {
                    terms[i] = revenuePerDay[i] = 245743 + usersPerDay[i] / 4;
                }
                Math.Round(terms[i], 2);
            }

            for (int i = 0; i < revenuePerDay.Length; i++)
            {
                for (int j = 0; j < terms.Length; j++)
                {
                    int sum = 0;
                    if (revenuePerDay[i] == terms[i])
                    {
                        sum += 1;
                        int numInvalidEntries = sum;
                        return numInvalidEntries;
                    }

                }
            }
            if (usersPerDay.Length != revenuePerDay.Length) // 두배열의 길이 검사  
            {
                return -1;
            }
            return -1;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            double totalRevenue = 0;

            for (start = 0; start <= revenuePerDay[end]; start++)
            {
                totalRevenue += start;

                if (revenuePerDay[start] > revenuePerDay.Length || revenuePerDay[end] > revenuePerDay.Length)
                {
                    return -1;
                }
                else if (revenuePerDay[start] < revenuePerDay[end])
                {
                    return -1;
                }
            }

            if (revenuePerDay.Length == 0)
            {
                return -1;
            }
            return 0.0;
        }
    }
}