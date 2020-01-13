using System;
using System.Drawing;

namespace DarkorbitAPI.Structures
{
	public interface ICollidable
	{
		string Name { get; }

		int Shape { get; }

		bool Active { get; set; }

		CollidableType Type { get; }

		CollidableType imethod_0(Map map_0);

		Rectangle imethod_1();
	}
}
