using System;
using DOPE.UI.Models;

namespace DarkorbitAPI.Packets.Static
{
	public static class Ammo
	{
		public static string smethod_0(this Enum enum_0)
		{
			GAttribute70 gattribute = enum_0.smethod_0<GAttribute70>();
			if (gattribute == null)
			{
				return null;
			}
			return gattribute.method_0();
		}

		public static string smethod_1(LaserType laserType_0)
		{
			return laserType_0.smethod_0();
		}

		public static string smethod_2(RocketType rocketType_0)
		{
			return rocketType_0.smethod_0();
		}

		public static string smethod_3(HellstormType hellstormType_0)
		{
			return hellstormType_0.smethod_0();
		}
	}
}
