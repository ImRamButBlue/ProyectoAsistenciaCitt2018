﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Librerias.MailClient.EjemploAPI().Wait();
            Console.ReadKey();
        }
    }
}
