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
    public class VDMem
    {
		public static Dictionary<string, VDSprite> VDSprites = new Dictionary<string, VDSprite>();
		public static int GlobalPlayerX;
		public static int GlobalPlayerY;
		public static string OldState;
		public static string CurrentState;
	}
	public class VDOP
	{
		public static void CreateSprite(string N, int X, int Y, int W, int H)
		{
			VDSprite value = new VDSprite(X, Y, W, H, "", 0, 0);
			try
			{
				VDMem.VDSprites.Add(N, value);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
		public static void RenderSprite(SKCanvas canvas, VDSprite sprite)
		{
			SKPaint skpaint = new SKPaint();
			skpaint.Color = SKColors.Magenta;
			skpaint.Style = 0;
			skpaint.IsAntialias = false;

			SKPaint skpaint2 = new SKPaint();
			skpaint2.Color = SKColors.Black;
			skpaint2.Style = 0;
			skpaint2.IsAntialias = false;

			float num = (float)sprite.x;
			float num2 = (float)sprite.y;
			float num3 = (float)sprite.width;
			float num4 = (float)sprite.height;

			SKRect skrect; SKRect skrect2; SKRect skrect3; SKRect skrect4;
			skrect = new SKRect(num, num2, num + num3 / 2f, num2 + num4 / 2f);
			skrect2 = new SKRect(num + num3, num2, num + num3 / 2f, num2 + num4 / 2f);
			skrect3 = new SKRect(num, num2 + num4 / 2f, num + num3 / 2f, num2 + num4);
			skrect4 = new SKRect(num + num3 / 2f, num2 + num4 / 2f, num + num3, num2 + num4);

			canvas.DrawRect(skrect, skpaint2);
			canvas.DrawRect(skrect2, skpaint);
			canvas.DrawRect(skrect3, skpaint);
			canvas.DrawRect(skrect4, skpaint2);
		}
	}
	public class VDSprite
	{
		public int x { get; set; }
		public int y { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public string spritesheet { get; set; }
		public int ssx { get; set; }
		public int ssy { get; set; }
		public VDSprite(int X, int Y, int W, int H, string SS, int SSX, int SSY)
		{
			this.x = X;
			this.y = Y;
			this.width = W;
			this.height = H;
			this.spritesheet = SS;
			this.ssx = SSX;
			this.ssy = SSY;
		}
	}
	public class VDTile
	{
	}
	public class VDPlayer
	{
	}
}
