using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;

namespace DOPE.UI
{
	public partial class MapControl : UserControl
	{
		public Map Map
		{
			get
			{
				return this.Context.Game.Map;
			}
		}

		public GClass810 Context
		{
			get
			{
				return base.DataContext as GClass810;
			}
		}

		public MapControl()
		{
			Class8.xDph7tozmh5WD();
			this.Timer = new Timer();
			this.LastRender = DateTime.Now;
			base..ctor();
			base.MouseLeftButtonUp += this.MapControl_MouseLeftButtonUp;
			base.MouseRightButtonUp += this.MapControl_MouseRightButtonUp;
			this.InitializeComponent();
		}

		private bool method_0(object object_0, MouseButtonEventArgs mouseButtonEventArgs_0, out int int_0, out int int_1)
		{
			int_1 = 0;
			int_0 = 0;
			if (this.Map == null)
			{
				return false;
			}
			double num = (double)this.Map.MapSize.Width / base.ActualWidth;
			double num2 = (double)this.Map.MapSize.Height / base.ActualHeight;
			System.Windows.Point position = mouseButtonEventArgs_0.GetPosition(this);
			int_0 = (int)(position.X * num);
			int_1 = (int)(position.Y * num2);
			return position.X <= base.ActualWidth && position.Y <= base.ActualHeight;
		}

		private void MapControl_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
		{
			int int_;
			int int_2;
			if (this.method_0(sender, e, out int_, out int_2))
			{
				e.Handled = this.method_2(int_, int_2);
			}
		}

		private void MapControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			int int_;
			int int_2;
			if (this.method_0(sender, e, out int_, out int_2))
			{
				e.Handled = this.method_1(int_, int_2);
			}
		}

		private bool method_1(int int_0, int int_1)
		{
			MapControl.<>c__DisplayClass9_0 CS$<>8__locals1 = new MapControl.<>c__DisplayClass9_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.x = int_0;
			CS$<>8__locals1.y = int_1;
			if (this.Map.Grid.method_8((float)CS$<>8__locals1.x, (float)CS$<>8__locals1.y))
			{
				return true;
			}
			if (this.Context.Run)
			{
				bool isPaused = this.Context.IsPaused;
			}
			if (Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), -1) && this.Context.CurrentPath != null)
			{
				Vector2 vector = this.Context.CurrentPath.Path.Skip(1).FirstOrDefault<Vector2>();
				this.Map.Game.Connection.Server.method_5(vector.X, vector.Y, true);
			}
			return true;
		}

		private bool method_2(int int_0, int int_1)
		{
			SecurityManager security = this.Map.Game.Security;
			Vector2 vector2_ = new Vector2((float)int_0, (float)int_1);
			Gate gate = this.Map.method_5<Gate>(vector2_, null, null, 0);
			if (gate == null)
			{
				return false;
			}
			if (security.method_18(vector2_, gate.Position, 0) && security.method_18(gate.Position, this.Map.Hero.Position, 0))
			{
				this.Map.Game.Connection.Server.method_2(gate.Id);
				return true;
			}
			return false;
		}

		private void method_3(object sender, ElapsedEventArgs e)
		{
			if (this.LastRender.Cooldown(50))
			{
				base.Dispatcher.Invoke(new Action(base.InvalidateVisual));
			}
		}

		protected override void OnRender(DrawingContext drawingContext)
		{
			this.LastRender = DateTime.Now;
			drawingContext.DrawRectangle(System.Windows.Media.Brushes.Black, null, new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight));
			this.Progress.Visibility = Visibility.Collapsed;
			base.OnRender(drawingContext);
			if (base.DataContext != null && this.Map != null)
			{
				Map map = this.Map;
				float float_ = (float)base.ActualWidth / (float)map.MapSize.Width;
				float float_2 = (float)base.ActualHeight / (float)map.MapSize.Height;
				try
				{
					this.method_4(drawingContext, float_, float_2, this.Map);
				}
				catch
				{
				}
				this.method_5(drawingContext, float_, float_2, this.Map);
				string text = this.Map.method_1() ?? "";
				if (!string.IsNullOrWhiteSpace(text))
				{
					this.Progress.Visibility = Visibility.Visible;
					NpcShip npcShip = this.Map.SelectedShip as NpcShip;
					if (npcShip != null)
					{
						int range = npcShip.Range;
					}
					this.Progress.Text = (text ?? "");
				}
				foreach (KeyValuePair<int, Gate> keyValuePair in map.Gates)
				{
					this.method_8(drawingContext, float_, float_2, keyValuePair.Value);
				}
				foreach (KeyValuePair<string, Collectible> keyValuePair2 in map.Collectibles)
				{
					this.method_9(drawingContext, float_, float_2, keyValuePair2.Value);
				}
				foreach (KeyValuePair<int, Ship> keyValuePair3 in map.Ships)
				{
					Vector2 position = keyValuePair3.Value.Position;
					DarkorbitAPI.CommonStructures.Size mapSize = this.Map.MapSize;
					if (position.X <= (float)mapSize.Width && position.Y <= (float)mapSize.Height && position.X >= 0f && position.Y >= 0f)
					{
						this.method_7(drawingContext, float_, float_2, keyValuePair3.Value);
					}
				}
				Vector2 position2 = this.Map.Hero.Position;
				DarkorbitAPI.CommonStructures.Size mapSize2 = this.Map.MapSize;
				bool flag;
				if (flag = (position2.X <= (float)mapSize2.Width && position2.Y <= (float)mapSize2.Height && position2.X >= 0f && position2.Y >= 0f))
				{
					this.method_6(drawingContext, float_, float_2, this.Map.Hero);
				}
				if (this.Context != null && flag)
				{
					this.method_10(drawingContext, float_, float_2, this.Context);
				}
				return;
			}
		}

		public void method_4(DrawingContext drawingContext_0, float float_0, float float_1, Map map_0)
		{
			SolidColorBrush lime = System.Windows.Media.Brushes.Lime;
			System.Windows.Media.Color cyan = Colors.Cyan;
			System.Windows.Media.Brush brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(60, cyan.R, cyan.G, cyan.B));
			foreach (KeyValuePair<string, ICollidable> keyValuePair in map_0.Collidables)
			{
				ICollidable value = keyValuePair.Value;
				if (value != null)
				{
					CollidableSphere collidableSphere = keyValuePair.Value as CollidableSphere;
					if (collidableSphere != null)
					{
						drawingContext_0.DrawEllipse(brush, null, new System.Windows.Point((double)(collidableSphere.Center.X * float_0), (double)(collidableSphere.Center.Y * float_1)), (double)((float)collidableSphere.Radius * float_0), (double)((float)collidableSphere.Radius * float_1));
					}
					else if (value.imethod_0(map_0) != CollidableType.None)
					{
						Rectangle rectangle = value.imethod_1();
						if (rectangle.Y < 0)
						{
							rectangle.Height += rectangle.Y;
							rectangle.Y = 0;
						}
						if (rectangle.Bottom > map_0.MapSize.Height)
						{
							rectangle.Height -= rectangle.Bottom - map_0.MapSize.Height;
						}
						if (rectangle.Height >= 0 && rectangle.Width >= 0)
						{
							drawingContext_0.DrawRectangle(brush, null, new Rect((double)(float_0 * (float)rectangle.X), (double)(float_1 * (float)rectangle.Y), (double)((float)rectangle.Width * float_0), (double)((float)rectangle.Height * float_1)));
						}
					}
				}
			}
			PathSequence pathSequence = this.Context.Map.Grid.PathCache.method_2();
			if (pathSequence != null)
			{
				List<Vector2> path = pathSequence.Path;
				if (path.Count > 1)
				{
					Vector2 vector = path.FirstOrDefault<Vector2>();
					foreach (Vector2 vector2 in path)
					{
						if (!(vector2 == vector))
						{
							drawingContext_0.DrawLine(new System.Windows.Media.Pen(System.Windows.Media.Brushes.Red, 2.0), new System.Windows.Point((double)(vector.X * float_0), (double)(vector.Y * float_1)), new System.Windows.Point((double)(vector2.X * float_0), (double)(vector2.Y * float_1)));
							vector = vector2;
						}
					}
				}
			}
		}

		public void method_5(DrawingContext drawingContext_0, float float_0, float float_1, Map map_0)
		{
			foreach (KeyValuePair<int, Asset> keyValuePair in map_0.Assets)
			{
				System.Drawing.Color color = MapUtils.smethod_12(map_0, keyValuePair.Value);
				drawingContext_0.DrawEllipse(new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B)), new System.Windows.Media.Pen(System.Windows.Media.Brushes.DarkGray, 1.0), new System.Windows.Point((double)((float)keyValuePair.Value.PosX * float_0), (double)((float)keyValuePair.Value.PosY * float_1)), 3.0, 3.0);
			}
			if (map_0.Battlestation != null)
			{
				System.Windows.Media.Color color2 = Colors.Orange;
				System.Windows.Media.Color color3 = Colors.Orange;
				if (map_0.Battlestation.method_1(map_0.Hero))
				{
					color2 = (color3 = Colors.Red);
				}
				color2.A = 180;
				color3.A = 140;
				drawingContext_0.DrawEllipse(new SolidColorBrush(color2), new System.Windows.Media.Pen(new SolidColorBrush(color3), 2.0), new System.Windows.Point((double)((float)map_0.Battlestation.PosX * float_0), (double)((float)map_0.Battlestation.PosY * float_1)), 15.0, 15.0);
			}
		}

		public static Rect smethod_0(double double_0, double double_1, double double_2, double double_3)
		{
			return new Rect(double_0 - double_2 / 2.0, double_1 - double_3 / 2.0, double_2, double_3);
		}

		public void method_6(DrawingContext drawingContext_0, float float_0, float float_1, Hero hero_0)
		{
			Vector2 position = hero_0.Position;
			Vector2? movementDestination = hero_0.MovementDestination;
			if (movementDestination != null)
			{
				Vector2 value = movementDestination.Value;
				drawingContext_0.DrawLine(new System.Windows.Media.Pen(System.Windows.Media.Brushes.RoyalBlue, 2.0), new System.Windows.Point((double)(position.X * float_0), (double)(position.Y * float_1)), new System.Windows.Point((double)(value.X * float_0), (double)(value.Y * float_1)));
			}
			SolidColorBrush solidColorBrush = System.Windows.Media.Brushes.Chartreuse.Clone();
			solidColorBrush.Opacity = 0.3;
			drawingContext_0.DrawRectangle(solidColorBrush, null, MapControl.smethod_0((double)(position.X * float_0), (double)(position.Y * float_1), (double)(1920f * float_0), (double)(1080f * float_1)));
			drawingContext_0.DrawRectangle(System.Windows.Media.Brushes.DarkCyan, null, MapControl.smethod_0((double)(position.X * float_0), (double)(position.Y * float_1), 6.0, 6.0));
		}

		public void method_7(DrawingContext drawingContext_0, float float_0, float float_1, Ship ship_0)
		{
			Vector2 position = ship_0.Position;
			System.Drawing.Color color = MapUtils.smethod_12(this.Context.Map, ship_0);
			NpcShip npcShip = ship_0 as NpcShip;
			if (npcShip != null)
			{
				GClass820 gclass = this.Context.Behavior ?? this.Context.gclass820_0;
				if (!gclass.vmethod_6(npcShip) || !gclass.vmethod_5(npcShip))
				{
					color = System.Drawing.Color.Gray;
				}
			}
			System.Windows.Media.Pen pen = null;
			if (this.Map.SelectedShip == ship_0)
			{
				pen = new System.Windows.Media.Pen(System.Windows.Media.Brushes.Violet, 2.0);
			}
			SolidColorBrush solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
			drawingContext_0.DrawRectangle(solidColorBrush, pen, MapControl.smethod_0((double)(position.X * float_0), (double)(position.Y * float_1), 4.0, 4.0));
			drawingContext_0.DrawText(new FormattedText(ship_0.Name, CultureInfo.InvariantCulture, FlowDirection.LeftToRight, new Typeface("Arial"), 9.0, solidColorBrush, 1.25), new System.Windows.Point((double)((float)ship_0.PosX * float_0), (double)((float)ship_0.PosY * float_1)));
		}

		public void method_8(DrawingContext drawingContext_0, float float_0, float float_1, Gate gate_0)
		{
			System.Drawing.Color color = MapUtils.smethod_12(this.Map, gate_0);
			SolidColorBrush brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
			drawingContext_0.DrawRectangle(brush, null, MapControl.smethod_0((double)((float)gate_0.PosX * float_0), (double)((float)gate_0.PosY * float_1), 3.0, 3.0));
			drawingContext_0.DrawEllipse(null, new System.Windows.Media.Pen(brush, 2.0), new System.Windows.Point((double)((float)gate_0.PosX * float_0), (double)((float)gate_0.PosY * float_1)), 10.0, 10.0);
		}

		public void method_9(DrawingContext drawingContext_0, float float_0, float float_1, Collectible collectible_0)
		{
			System.Drawing.Color color = MapUtils.smethod_12(this.Map, collectible_0);
			System.Windows.Media.Brush brush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
			drawingContext_0.DrawRectangle(brush, null, MapControl.smethod_0((double)((float)collectible_0.PosX * float_0), (double)((float)collectible_0.PosY * float_1), 3.0, 3.0));
		}

		public void method_10(DrawingContext drawingContext_0, float float_0, float float_1, GClass810 gclass810_0)
		{
			foreach (KeyValuePair<string, Collectible> keyValuePair in gclass810_0.DormantTargets)
			{
				Collectible value = keyValuePair.Value;
				drawingContext_0.DrawRectangle(System.Windows.Media.Brushes.Pink, null, MapControl.smethod_0((double)(value.Position.X * float_0), (double)(value.Position.Y * float_1), 2.0, 2.0));
			}
			if (gclass810_0.RoamTarget != Vector2.Zero)
			{
				Vector2 roamTarget = gclass810_0.RoamTarget;
				drawingContext_0.DrawEllipse(System.Windows.Media.Brushes.Magenta, null, new System.Windows.Point((double)(roamTarget.X * float_0), (double)(roamTarget.Y * float_1)), 6.0, 6.0);
			}
			GClass820 behavior = gclass810_0.Behavior;
			List<Rectangle> list = (behavior != null) ? behavior.vmethod_13() : null;
			if (list != null)
			{
				foreach (Rectangle rectangle in list)
				{
					Rect rectangle2 = new Rect((double)((float)rectangle.X * float_0), (double)((float)rectangle.Y * float_1), (double)((float)rectangle.Width * float_0), (double)((float)rectangle.Height * float_1));
					drawingContext_0.DrawRectangle(null, new System.Windows.Media.Pen(System.Windows.Media.Brushes.Pink, 2.0), rectangle2);
				}
			}
		}

		public Timer Timer;

		public DateTime LastRender;
	}
}
