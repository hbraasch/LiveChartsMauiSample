using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSample
{
    internal class CodeBehindMainPage : ContentPage
    {
        public CodeBehindMainPage()
        {
            var chart = new CartesianChart();
            chart.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
            };
            var grid = new Grid();
            grid.Add(chart);
            Content = grid;
        }
    }
}
