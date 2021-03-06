﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDuyDat_QLQuanGame_CDTH17.Libraries
{
    class IdGenerate
    {
        public static string genId(string lastID, string prefixID)
        {
            if (lastID == "")
            {
                return prefixID + "01";
            }
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            int lengthNumberID = lastID.Length - prefixID.Length;
            string zeroNumber = "";

            for (int i = 1; i <= lengthNumberID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumberID - i; j++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;
        }
    }
}
