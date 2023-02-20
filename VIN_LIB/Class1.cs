﻿using System;
using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class Class1
    {
        public static bool CheckVIN(string vin)
        {
            Regex regex = new Regex(@"^[\dABCDEFGHJKLMNPRSTUVWXYZ]{17}$");
            try
            {
                if (regex.IsMatch(vin))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetVINCountry(string vin)
        {
            try
            {
                if (vin[0] == 'A' || vin[0] == 'B' || vin[0] == 'C' || vin[0] == 'D' || vin[0] == 'E' || vin[0] == 'F' || vin[0] == 'G' || vin[0] == 'H')
                {
                    return "Африка";
                }
                else if (vin[0] == 'J' || vin[0] == 'K' || vin[0] == 'L' || vin[0] == 'M' || vin[0] == 'N' || vin[0] == 'P' || vin[0] == 'R')
                {
                    return "Азия";
                }
                else if (vin[0] == 'S' || vin[0] == 'T' || vin[0] == 'U' || vin[0] == 'V' || vin[0] == 'W' || vin[0] == 'X' || vin[0] == 'Y' || vin[0] == 'Z')
                {
                    return "Европа";
                }
                else if (vin[0] == '1' || vin[0] == '2' || vin[0] == '3' || vin[0] == '4' || vin[0] == '5')
                {
                    return "Северная Америка";
                }
                else if (vin[0] == '6' || vin[0] == '7')
                {
                    return "Океания";
                }
                else if (vin[0] == '8' || vin[0] == '9')
                {
                    return "Южная Америка";
                }
                else
                {
                    return "Не определено";
                }
            }
            catch
            {
                return "Ошибка проверки";
            }
        }
    }
}

