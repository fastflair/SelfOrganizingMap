using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gigasoft.ProEssentials.Enums;

namespace SOM {
   public partial class frmMain : Form {
      private bool headingPresent = false;
      private string[] heading;

      public frmMain() {
         InitializeComponent();
      }

      private void loadCSVToolStripMenuItem_Click(object sender, EventArgs e) {
         string dataFile = getFile(".csv", @"D:\nnTest", true);
         if (dataFile == null) return;
         int numInputs = getNumInputs(dataFile);
         int scale = Convert.ToInt32(txtScale.Text);

         Map map = new Map(numInputs, scale);
         SOMS[] Asoms = map.organize(dataFile, Convert.ToDouble(txtError.Text), Convert.ToInt32(txtMaxIter.Text));
         lblResErr.Text = "Result Error: " + Asoms[0].error.ToString("0.00000000");
         updateGraph(Asoms, scale);
      }

      private int getNumInputs(string dataFile) {
         string line = "";
         string[] cols;
         Regex split = new Regex(",");
         double dbl;
         int neurons;

         using (StreamReader sr = new StreamReader(dataFile)) {
            line = sr.ReadLine();
            cols = split.Split(line);
            if (!double.TryParse(cols[0], out dbl)) {
               headingPresent = true;
               heading = cols;
            }
            neurons = cols.Length - 1;
         }
         return neurons;
      }

      private string getFile(string fileType, string initialDir, bool rememberPreviousDir) {
         OpenFileDialog fd = new OpenFileDialog();
         fd.CheckPathExists = true;
         fd.CheckFileExists = true;
         fd.DefaultExt = ".csv";
         fd.InitialDirectory = @"D:\nnTest";
         fd.RestoreDirectory = true;
         fd.ShowDialog();
         if (fd.FileName.Length < 1) {
            return null;
         }

         return fd.FileName;
      }

      private void updateGraph(SOMS[] Asoms, int scale) {
         // Enable Bar Glass Effect //
         Pesgo1.PePlot.Option.BarGlassEffect = true;

         // Enable Plotting style gradient and bevel features //
         Pesgo1.PePlot.Option.AreaGradientStyle = PlotGradientStyle.RadialBottomRight;
         Pesgo1.PePlot.Option.AreaBevelStyle = BevelStyle.MediumSmooth;
         Pesgo1.PePlot.Option.SplineGradientStyle = PlotGradientStyle.RadialBottomRight;
         Pesgo1.PePlot.Option.SplineBevelStyle = SplineBevelStyle.MediumSmooth;

         // v7.2 new features //
         Pesgo1.PePlot.Option.PointGradientStyle = PlotGradientStyle.VerticalAscentInverse;
         Pesgo1.PeColor.PointBorderColor = Color.FromArgb(100, 0, 0, 0);
         Pesgo1.PePlot.Option.LineSymbolThickness = 3;
         Pesgo1.PeUserInterface.Dialog.AllowSvgExport = true;

         // Prepare images in memory //
         Pesgo1.PeConfigure.PrepareImages = true;


         // Set DataShadows to show 3D //
         Pesgo1.PePlot.DataShadows = DataShadows.Shadows;

         Pesgo1.PeUserInterface.Allow.FocalRect = false;
         Pesgo1.PeGrid.LineControl = GridLineControl.Both;
         Pesgo1.PeGrid.Style = GridStyle.Dot;
         Pesgo1.PePlot.Allow.Ribbon = true;
         Pesgo1.PeUserInterface.Allow.Zooming = AllowZooming.HorzAndVert;
         Pesgo1.PeUserInterface.Allow.ZoomStyle = ZoomStyle.Ro2Not;

         // Enable middle mouse dragging //
         Pesgo1.PeUserInterface.Scrollbar.MouseDraggingX = true;
         Pesgo1.PeUserInterface.Scrollbar.MouseDraggingY = true;

         Pesgo1.PeString.MainTitle = "SOM Results";
         Pesgo1.PeString.SubTitle = "";
         Pesgo1.PeString.YAxisLabel = "Y Scale";
         Pesgo1.PeString.XAxisLabel = "X Scale";
         Pesgo1.PeGrid.Configure.ManualScaleControlY = ManualScaleControl.MinMax;
         Pesgo1.PeGrid.Configure.ManualScaleControlX = ManualScaleControl.MinMax;
         Pesgo1.PeGrid.Configure.ManualMinY = 0.0F;
         Pesgo1.PeGrid.Configure.ManualMaxY = (float)scale;
         Pesgo1.PeGrid.Configure.ManualMinX = 0.0F;
         Pesgo1.PeGrid.Configure.ManualMaxX = (float)scale;


         Pesgo1.PeLegend.SimplePoint = true;
         Pesgo1.PeLegend.SimpleLine = true;
         Pesgo1.PeLegend.Style = LegendStyle.OneLine;

         // Allow stacked type graphs //
         Pesgo1.PePlot.Allow.StackedData = true;

         // Various other features //
         Pesgo1.PeFont.Fixed = true;
         Pesgo1.PeColor.BitmapGradientMode = true;
         Pesgo1.PeColor.QuickStyle = QuickStyle.DarkInset;

         Pesgo1.PePlot.Option.GradientBars = 8;
         Pesgo1.PePlot.Option.LineShadows = true;
         Pesgo1.PeFont.MainTitle.Bold = true;
         Pesgo1.PeFont.SubTitle.Bold = true;
         Pesgo1.PeFont.Label.Bold = true;
         Pesgo1.PeConfigure.TextShadows = TextShadows.BoldText;
         Pesgo1.PeFont.FontSize = FontSize.Large;

         Pesgo1.PeData.Precision = DataPrecision.OneDecimal;
         Pesgo1.PePlot.MarkDataPoints = false;

         // Set various export defaults //
         Pesgo1.PeSpecial.DpiX = 600;
         Pesgo1.PeSpecial.DpiY = 600;

         // default export setting //
         Pesgo1.PeUserInterface.Dialog.ExportSizeDef = ExportSizeDef.NoSizeOrPixel;
         Pesgo1.PeUserInterface.Dialog.ExportTypeDef = ExportTypeDef.Png;
         Pesgo1.PeUserInterface.Dialog.ExportDestDef = ExportDestDef.Clipboard;
         Pesgo1.PeUserInterface.Dialog.ExportUnitXDef = "1280";
         Pesgo1.PeUserInterface.Dialog.ExportUnitYDef = "768";
         Pesgo1.PeUserInterface.Dialog.ExportImageDpi = 300;
         Pesgo1.PeUserInterface.Dialog.AllowSvgExport = true;

         Pesgo1.PeConfigure.RenderEngine = RenderEngine.Direct2D;
         Pesgo1.PeConfigure.AntiAliasGraphics = true;
         Pesgo1.PeConfigure.AntiAliasText = true;

         Pesgo1.PeSpecial.AutoImageReset = true; // Set just because example 17 resets to false 

         Pesgo1.PeData.Subsets = 1;
         // Clear out default data //
         Pesgo1.PeData.X[0, 0] = 0;
         Pesgo1.PeData.X[0, 1] = 0;
         Pesgo1.PeData.X[0, 2] = 0;
         Pesgo1.PeData.X[0, 3] = 0;
         Pesgo1.PeData.Y[0, 0] = 0;
         Pesgo1.PeData.Y[0, 1] = 0;
         Pesgo1.PeData.Y[0, 2] = 0;
         Pesgo1.PeData.Y[0, 3] = 0;

         // Add some various graph annotations //
         Pesgo1.PeAnnotation.Show = true;
         Pesgo1.PeFont.GraphAnnotationTextSize = 115;

         // Controls default placement of all annotations //
         Pesgo1.PeAnnotation.InFront = false;

         // Give user ability to show or hide annotations //
         Pesgo1.PeUserInterface.Menu.AnnotationControl = true;

         // Display Data
         int count = 0;
         for (int i = 0; i < Asoms.Length; i++) {
            // Place a paragraph of text //'
            //Pesgo1.PeAnnotation.Graph.X[count] = Asoms[i].x;
            //Pesgo1.PeAnnotation.Graph.Y[count] = Asoms[i].y;
            //Pesgo1.PeAnnotation.Graph.Type[count] = (int)GraphAnnotationType.Paragraph;
            //Pesgo1.PeAnnotation.Graph.Color[count] = Color.White;
            //Pesgo1.PeAnnotation.Graph.Text[count] = Asoms[i].ID;
            //Pesgo1.PeAnnotation.Graph.Font[count] = "Courier New";
            //count++;

            // Place a symbol //
            Pesgo1.PeAnnotation.Graph.X[count] = Asoms[i].x;
            Pesgo1.PeAnnotation.Graph.Y[count] = Asoms[i].y;
            Pesgo1.PeAnnotation.Graph.Type[count] = (int)GraphAnnotationType.SmallDotSolid;
            Pesgo1.PeAnnotation.Graph.Color[count] = Color.LightGreen;
            Pesgo1.PeAnnotation.Graph.Text[count] = Asoms[i].ID;
            Pesgo1.PeAnnotation.Graph.GradientStyle[count] = (int)Gigasoft.ProEssentials.Enums.PlotGradientStyle.RadialTopLeft;
            Pesgo1.PeAnnotation.Graph.Shadow[count] = true;
            Pesgo1.PeAnnotation.Graph.Bold[count] = false;
            count++;
         }


         // Show annotations shadows //
         Pesgo1.PeAnnotation.Graph.ShowShadows = true;

         // Allow user to move ArrowPointer annotation //
         Pesgo1.PeAnnotation.Graph.Moveable = true;
         Pesgo1.PeUserInterface.HotSpot.GraphAnnotation = AnnotationHotSpot.GraphOnly;

         // Other various properties //
         Pesgo1.PeColor.BitmapGradientMode = true;
         Pesgo1.PeColor.QuickStyle = QuickStyle.MediumLine;

         // Generally call ReinitializeResetImage at end **'
         Pesgo1.PeFunction.ReinitializeResetImage();
         Pesgo1.Refresh();

      }
   }
}
