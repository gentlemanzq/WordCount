﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using wordcount.function;

namespace wordcount.function
{
   public class asccount
    {
        public static int asccounts()//打开文件并统计字符个数
        {
                string str = File.ReadAllText(@path.s);
                int num = Regex.Matches(str, @".").Count;
                if (linescount.lines() == 0)
                    return num + linescount.lines();
                else
                    return num + linescount.lines() - 1;
           
        }
    }
}
