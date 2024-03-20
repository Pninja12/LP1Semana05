﻿using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();
            float tempo1 = crono1.ElapsedMilliseconds;
            float tempo2 = crono2.ElapsedMilliseconds;
            Console.Write($"Cronómetro 1: {tempo1/1000:f3}s\n");
            Console.Write($"Cronómetro 2: {tempo2/1000:f3}s");


        }
    }
}