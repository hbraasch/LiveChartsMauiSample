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
    public class CodeBehindMainPage : ContentPage
    {
        CartesianChart chart;
        public CodeBehindMainPage()
        {
            var label = new Label { Text = "Entry - I'm displaying" };
            chart = new CartesianChart() { VerticalOptions = LayoutOptions.Center };
            chart.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6, 6, 6 },
                    Fill = null
                }
            };
            var grid = new Grid() { Margin = 10};
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.Add(label,0,0);
            grid.Add(chart, 0, 1);
            Content = grid;
        }

    }
}
