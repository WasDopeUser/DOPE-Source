using System;
using System.Numerics;

namespace DarkorbitAPI.CommonStructures
{
	public struct Size : IEquatable<Size>
	{
		public Size(int int_0, int int_1)
		{
			Class13.lOBHd9Nzn7x2T();
			this.Width = int_0;
			this.Height = int_1;
			this.Vector = new Vector2((float)int_0, (float)int_1);
		}

		public Vector2 Vector { get; }

		public bool Equals(Size other)
		{
			return this.Width == other.Width && this.Height == other.Height;
		}

		public override bool Equals(object obj)
		{
			return obj != null && obj is Size && this.Equals((Size)obj);
		}

		public override int GetHashCode()
		{
			return this.Width * 397 ^ this.Height;
		}

		public static bool operator ==(Size size_0, Size size_1)
		{
			return size_0.Equals(size_1);
		}

		public static bool operator !=(Size size_0, Size size_1)
		{
			return !(size_0 == size_1);
		}

		public readonly int Width;

		public readonly int Height;
	}
}
