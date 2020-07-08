using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace DarkorbitAPI.Structures.Pathing
{
	public class PathSequence
	{
		public List<Vector2> Path { get; private set; }

		public int CurrentIndex { get; private set; }

		public Vector2 Destination { get; internal set; }

		public PathSequence(Vector2 vector2_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			this.Path = new List<Vector2>();
			this.Destination = vector2_0;
			this.CurrentIndex = 0;
		}

		public int method_0(Vector2 vector2_0, MapGrid mapGrid_0, int int_0 = 30)
		{
			if (this.Path.Count != 1)
			{
				for (int i = this.Path.Count - 1; i >= 0; i--)
				{
					if (this.method_1(vector2_0, i, int_0) && !mapGrid_0.method_3(vector2_0, this.Path[i + 1]))
					{
						return i + 1;
					}
				}
				return -1;
			}
			if (!mapGrid_0.method_3(vector2_0, this.Path[0]))
			{
				return 0;
			}
			return -1;
		}

		private bool method_1(Vector2 vector2_0, int int_0, int int_1 = 30)
		{
			if (this.CurrentIndex == -1)
			{
				return Vector2.Distance(vector2_0, this.Path.FirstOrDefault<Vector2>()) < (float)int_1;
			}
			int num = int_0 + 1;
			return num < this.Path.Count && GClass877.smethod_13(this.Path[int_0], this.Path[num], vector2_0, true) < (double)int_1;
		}

		public bool method_2(Vector2 vector2_0, Action<Vector2> action_0, MapGrid mapGrid_0, int int_0 = 30)
		{
			int num = this.method_0(vector2_0, mapGrid_0, int_0);
			if (num == -1)
			{
				return false;
			}
			action_0(this.Path[num]);
			return true;
		}

		public bool method_3(Vector2 vector2_0, int int_0)
		{
			return this.Destination.X / 100f == vector2_0.X / 100f && this.Destination.Y / 50f == vector2_0.Y / 50f;
		}
	}
}
