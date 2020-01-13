using System;
using DOPE.UI.Models;

namespace DarkorbitAPI.Packets.Static
{
	public static class Ammo
	{
		public static string jNambvWvYx(this Enum enum_0)
		{
			GAttribute70 gattribute = enum_0.smethod_0<GAttribute70>();
			if (gattribute == null)
			{
				return null;
			}
			return gattribute.method_0();
		}

		public static string smethod_0(LaserType laserType_0)
		{
			return laserType_0.jNambvWvYx();
		}

		public static string smethod_1(RocketType rocketType_0)
		{
			return rocketType_0.jNambvWvYx();
		}

		public static string smethod_2(HellstormType hellstormType_0)
		{
			return hellstormType_0.jNambvWvYx();
		}
	}
}
