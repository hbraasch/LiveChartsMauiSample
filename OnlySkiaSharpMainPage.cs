using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Maui;
using SkiaSharp;
using SkiaSharp.Views.Maui.Controls;

namespace MauiSample
{
    public class OnlySkiaSharpMainPage : ContentPage
    {
        public OnlySkiaSharpMainPage()
        {
            var canvas = new SKCanvasView { VerticalOptions = LayoutOptions.Center };
            canvas.PaintSurface += Canvas_PaintSurface;

            var grid = new Grid() { Margin = 10 };
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.Add(canvas, 0, 0);
            Content = grid;
        }

        private void Canvas_PaintSurface(object sender, SkiaSharp.Views.Maui.SKPaintSurfaceEventArgs e)
        {
            using var paint = new SKPaint { Color = SKColors.Blue };
            e.Surface.Canvas.DrawText("Hello from skia", new SKPoint(50, 50), paint);
        }
    }
}
