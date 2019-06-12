
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else if (year == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year > 9999)
            {
                return -1;
            }
            
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if (month >= 13 && year > 9999)
                        {
                            return -1;
                        }
                        else
                        {
                            return 31;
                        }

                    }


                case 2:

                    if (month >= 13 && year > 9999)
                    {
                        return -1;
                    }
                    else if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }

                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        if (year > 9999 && month >= 13)
                        {
                            return -1;
                        }
                        else
                        {
                            return 30;
                        }
                    }

                default:

                    if (month >= 13)
                    {
                        return -1;
                    }
                    break;
            }
            return -1;
        }
    }
}
