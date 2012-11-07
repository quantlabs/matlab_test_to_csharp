using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using TestMatlabNet;
using AlgoTradingDemo;


namespace TestInCSharpCon
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {

                AlgoTradingClass td = new AlgoTradingClass();
                VoronoiCell vgc = new VoronoiCell();
                double[] X = { 0.5, -0.5 };
                double[] Y = { 0, 0.5, 0.1 };

                td.AlgoTradingDemo1CS();

                //MWArray[] Results2 = (MWArray[])td.AlgoTrading1CS(void);

                MWArray[] Results = (MWArray[])vgc.NDimVoronoiDiagram(3, (MWNumericArray)X, (MWNumericArray)Y);
                double[,] EdgeX = (double[,])Results[0].ToArray();
                double[,] EdgeY = (double[,])Results[1].ToArray();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception);
            }
        }
    }
}
