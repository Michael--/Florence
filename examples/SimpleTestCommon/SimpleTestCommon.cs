﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Florence;

namespace SimpleTestCommon
{
    public static class SimpleTestCommon
    {
        public static void Run(InteractiveHost plot)
        {
            plot.Start();

            var x = new double[] { 1.0, 2.0, 3.0 };
            var y = new double[] { 1.0, 2.0, 3.0 };
            var z = new double[] { 0.0, 2.0, 4.0 };
            var plot1 = new PointPlot() { AbscissaData = x, OrdinateData = y };
            plot.Add(plot1);

            Console.ReadLine();

            var plot2 = new LinePlot() { AbscissaData = x, OrdinateData = y };
            plot.Title = "Test Plot 2";
            plot.XAxis1.Label = "X2";
            plot.YAxis1.Label = "Y2";

            plot.Add(plot2);

            Console.ReadLine();

            plot.Stop();
        }
    }
}
