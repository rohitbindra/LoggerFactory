﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerFactory
{
    public class ExcelLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Excel Log");
        }
    }
}