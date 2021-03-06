﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Shared
{
    public static class Helper
    {
        public static string GetString(this object obj, string defaultValue = "")
        {
            var result = defaultValue;
            try
            {
                result = Convert.ToString(obj);
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        public static int GetInt32(this object obj, int defaultValue = 0)
        {
            var result = defaultValue;
            try
            {
                result = Convert.ToInt32(obj);
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
