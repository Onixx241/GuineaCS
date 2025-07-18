﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ParseArgs 
{
    public static void Args(string[] Allargs, CrawlConfig config) 
    {
        for(int i = 0; i < Allargs.Length; i++) 
        {
            switch (Allargs[i])
            {

                case "-url":
                     config.Url = Allargs[i + 1];
                break;

                case "-limit":
                    config.CrawlLimit = Convert.ToInt32(Allargs[i + 1]);
                    break;

                case "-dmode":
                    config.SameDomain = Convert.ToBoolean(Allargs[i + 1]);
                    break;

                case "-json":
                    config.Mode = SaveMode.Json;
                    break;

                case "-db":
                    config.Mode = SaveMode.Database;
                    break;
            }
        }
    }
}