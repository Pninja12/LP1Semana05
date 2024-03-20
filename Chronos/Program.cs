using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        /// <summary>
        /// Programa que faz 2 cronómetros correrem com uma diferença de começo
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //criação dos dois cronómetros
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //começo do cronómetro 1
            crono1.Start();
            Thread.Sleep(600);

            //começo do cronómetro 2
            crono2.Start();
            Thread.Sleep(200);

            //paragem dos dois cronómetros
            crono1.Stop();
            crono2.Stop();

            float tempo1 = crono1.ElapsedMilliseconds;
            float tempo2 = crono2.ElapsedMilliseconds;
            Console.WriteLine($"Cronómetro 1: {tempo1/1000:f3}s");
            Console.WriteLine($"Cronómetro 2: {tempo2/1000:f3}s");
        }
    }
}
