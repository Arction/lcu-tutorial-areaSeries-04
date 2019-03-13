// ------------------------------------------------------------------------------------------------------
// LightningChart® example code: 2D AreaSeries Chart Demo.
//
// If you need any assistance, or notice error in this example code, please contact support@arction.com. 
//
// Permission to use this code in your application comes with LightningChart® license. 
//
// http://arction.com/ | support@arction.com | sales@arction.com
//
// © Arction Ltd 2009-2019. All rights reserved.  
// ------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Media;

// Arction namespaces.
using Arction.Wpf.SemibindableCharting; // LightningChartUltimate and general types.

namespace Simple2DAreaSeriesTutorial_WPF_SB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create chart.
            // This is done using XAML.

            // Disable rendering before updating chart properties to improve performance
            // and to prevent unnecessary chart redrawing while changing multiple properties.
            chart.BeginUpdate();

            // Create variable for view from ViewXY.
            // This is done using XAML.

            // 1. Create a new AreaSeries.
            // This is done using XAML.

            // Add styling for created series.
            areaSeries1.Fill.Color = Color.FromRgb(176, 196, 222);  // LightSteelBlue.
            areaSeries1.LineStyle.Color = Color.FromRgb(0, 0, 0);   // Black.
            areaSeries1.Fill.GradientFill = GradientFill.Solid;

            // 2. Define AreaSeriesPoints and add them to AreaSeries.
            AreaSeriesPoint[] points1 = new AreaSeriesPoint[]{
                new AreaSeriesPoint(0, 10),
                new AreaSeriesPoint(1, 8),
                new AreaSeriesPoint(2, 9),
                new AreaSeriesPoint(3, 8),
                new AreaSeriesPoint(4, 7),
                new AreaSeriesPoint(5, 8),
                new AreaSeriesPoint(6, 7),
                new AreaSeriesPoint(7, 9),
                new AreaSeriesPoint(9, 8),
                new AreaSeriesPoint(10, 9)
            };

            // Add points to series.
            areaSeries1.AddValues(points1);

            // 3. Add AreaSeries to chart.
            // This is done using XAML.

            // 4. Create 2 new AreaSeries.
            // This is done using XAML.

            // Add styling for created series.
            areaSeries2.Fill.Color = Color.FromRgb(250, 250, 210);  // LightGoldenrodYellow.
            areaSeries2.LineStyle.Color = Color.FromRgb(0, 0, 0);   // Black.
            areaSeries2.Fill.GradientFill = GradientFill.Solid;

            areaSeries3.Fill.Color = Color.FromRgb(255, 140, 0);    // DarkOrange.
            areaSeries3.LineStyle.Color = Color.FromRgb(0, 0, 0);   // Black. 
            areaSeries3.Fill.GradientFill = GradientFill.Solid;

            // 5. Define AreaSeriesPoints for both new AreaSeries and add them to AreaSeries.
            AreaSeriesPoint[] points2 = new AreaSeriesPoint[]{
                new AreaSeriesPoint(0, 5),
                new AreaSeriesPoint(1, 7),
                new AreaSeriesPoint(3, 5),
                new AreaSeriesPoint(4, 6),
                new AreaSeriesPoint(5, 3),
                new AreaSeriesPoint(6, 5),
                new AreaSeriesPoint(7, 6),
                new AreaSeriesPoint(8, 7),
                new AreaSeriesPoint(9, 5),
                new AreaSeriesPoint(10, 4)
            };

            AreaSeriesPoint[] points3 = new AreaSeriesPoint[]{
                new AreaSeriesPoint(0, 1),
                new AreaSeriesPoint(1, 3),
                new AreaSeriesPoint(3, 1),
                new AreaSeriesPoint(4, 3),
                new AreaSeriesPoint(5, 2),
                new AreaSeriesPoint(6, 3),
                new AreaSeriesPoint(7, 2),
                new AreaSeriesPoint(8, 4),
                new AreaSeriesPoint(9, 1),
                new AreaSeriesPoint(10, 2)
            };

            // Add points to series.
            areaSeries2.AddValues(points2);
            areaSeries3.AddValues(points3);

            // 6. Add AreaSeries to chart.
            // This is done using XAML.

            // Auto-scale X- and Y-axes.
            chart.ViewXY.ZoomToFit();

            #region Hidden polishing
            // Customize chart.
            CustomizeChart(chart);
            #endregion

            // Call EndUpdate to enable rendering again.
            chart.EndUpdate();
        }

    #region Hidden polishing
    void CustomizeChart(LightningChartUltimate chart)
        {
            chart.ChartBackground.Color = Color.FromArgb(255, 30, 30, 30);
            chart.ChartBackground.GradientFill = GradientFill.Solid;
            chart.ViewXY.GraphBackground.Color = Color.FromArgb(255, 20, 20, 20);
            chart.ViewXY.GraphBackground.GradientFill = GradientFill.Solid;
            chart.Title.Color = Color.FromArgb(255, 249, 202, 3);
            chart.Title.MouseHighlight = MouseOverHighlight.None;

            foreach (var yAxis in chart.ViewXY.YAxes)
            {
                yAxis.Title.Color = Color.FromArgb(255, 249, 202, 3);
                yAxis.Title.MouseHighlight = MouseOverHighlight.None;
                yAxis.MajorGrid.Color = Color.FromArgb(35, 255, 255, 255);
                yAxis.MajorGrid.Pattern = LinePattern.Solid;
                yAxis.MinorDivTickStyle.Visible = false;
            }

            foreach (var xAxis in chart.ViewXY.XAxes)
            {
                xAxis.Title.Color = Color.FromArgb(255, 249, 202, 3);
                xAxis.Title.MouseHighlight = MouseOverHighlight.None;
                xAxis.MajorGrid.Color = Color.FromArgb(35, 255, 255, 255);
                xAxis.MajorGrid.Pattern = LinePattern.Solid;
                xAxis.MinorDivTickStyle.Visible = false;
                xAxis.ValueType = AxisValueType.Number;
            }
        }
        #endregion
    }
}

