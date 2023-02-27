using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] plotn = { 0.1, 0.3, 1, 5, 10, 20, 30, 40, 50, 60 };
            double[] Temp = { 298.15, 323.15, 348.15, 373.15, 398.15 };
            double[,] Otvet = { };
            for (int j = 0; j < Temp.Length; j++)
            {
                for (int i = 0; i < plotn.Length; i++)
                {
                    Console.WriteLine(Func(ref plotn[i], ref Temp[j]));
                }
            }
            string strVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            DateTime modification = File.GetLastWriteTime(@"C:\Users\Liza\source\repos\laba_2_tecn.sln");
            Console.WriteLine(strVersion);
            Console.WriteLine(modification);
        }
        static double Func(ref double p, ref double T)
        {
            double A0 = 1232.7;
            double A1 = -0.8404;
            double A2 = 0.1143 * Math.Pow(10, -3);
            double C = 0.08365;
            double B0 = 452.16;
            double B1 = -1.5087;
            double B2 = 1.4034 * Math.Pow(10, -3);
            double P = 0;
            P = (A0 + A1 * T + A2 * Math.Pow(T, 2)) / (1 - C * Math.Log((B0 + B1 * T + B2 * Math.Pow(T, 2) + p) / (B0 + B1 * T + B2 * Math.Pow(T, 2) + p)));
            return P;
        }
    }
}