﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using ScottPlot.Drawing;

namespace ScottPlot.Demo.Customize
{
    class Colors
    {
        public class DefaultColorset : PlotDemo, IPlotDemo
        {
            public string name { get; } = "Default Colorset";
            public string description { get; } = "Default colorset is the same one used by matplotlib.";

            public void Render(Plot plt)
            {
                plt.Title($"Default Colorset (Default)");

                Random rand = new Random(0);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.AxisAuto(horizontalMargin: 0);
            }
        }

        public class NordColorset : PlotDemo, IPlotDemo
        {
            public string name { get; } = "Nord Colorset";
            public string description { get; } = "Example colorset using Nord colors.";

            public void Render(Plot plt)
            {
                plt.Colorset(Palette.Nord);
                plt.Title($"Nord Colorset");

                Random rand = new Random(0);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.AxisAuto(horizontalMargin: 0);
            }
        }

        public class DarkColorset : PlotDemo, IPlotDemo
        {
            public string name { get; } = "Dark Colorset";
            public string description { get; } = "Example colorset designed for use on a dark background.";

            public void Render(Plot plt)
            {
                plt.Style(Style.Gray1);
                plt.Colorset(Palette.OneHalfDark);
                plt.Title($"OneHalfDark Colorset");

                Random rand = new Random(0);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.PlotSignal(DataGen.RandomWalk(rand, 1000), lineWidth: 2);
                plt.AxisAuto(horizontalMargin: 0);
            }
        }
    }
}
