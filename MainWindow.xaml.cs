using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SkiaSharp;
using SkiaSharp.Views.Desktop;
using SkiaSharp.Views.WPF;

namespace Rayteam_Advantures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float staticWidth = 800f;
        public float staticHeight = 450f;
        
        public MainWindow()
        {
            InitializeComponent();
            VDOP.CreateSprite("thing", 400, 225, 300, 100);
            VDOP.CreateSprite("thing2", 10, 50, 50, 50);
            VDOP.CreateSprite("thing3", 300, 400, 50, 50);
            VDOP.CreateSprite("thing4", 150, 225, 200, 200);
        }
        private void Skia_Painter(object sender, SKPaintSurfaceEventArgs e)
        {
            SKCanvas canvas = e.Surface.Canvas;
            SKImageInfo info = e.Info;

            
            canvas.Clear(SKColors.Gray);

            float scaleX = (float)info.Width / staticWidth;
            float scaleY = (float)info.Height / staticHeight;
            canvas.Scale(scaleX, scaleY);

            foreach (KeyValuePair<string, VDSprite> Sprite2rend in VDMem.VDSprites) {
                VDOP.RenderSprite(canvas, Sprite2rend.Value);
            }
            
            SkiaCustomRendrer.InvalidateVisual();
        }
    }
}
