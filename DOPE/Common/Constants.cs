using System;

namespace DOPE.Common
{
	public static class Constants
	{
		public static string Endpoint
		{
			get
			{
				return new Uri("https://powerofdark.space").Host;
			}
		}

		public static string VersionString
		{
			get
			{
				return string.Format("{0}.{1}", 0, 52);
			}
		}

		public static bool FrozenLabirynthEnabled
		{
			get
			{
				return false;
			}
		}

		public static bool PayloadEscortEnabled
		{
			get
			{
				return false;
			}
		}

		public static bool ColdWaveEnabled
		{
			get
			{
				return false;
			}
		}

		public static string GameVersionString
		{
			get
			{
				GClass283 gclass = new GClass283(0, 134, 4);
				return string.Format("{0}.{1}.{2}", gclass.int_0, gclass.int_1, gclass.int_2);
			}
		}

		public static bool IsOutdated(string localVersion, string remoteVersion)
		{
			if (localVersion == remoteVersion)
			{
				return false;
			}
			string[] array = remoteVersion.Split(new char[]
			{
				'.'
			});
			int num = int.Parse(array[0]);
			int num2 = int.Parse(array[1]);
			string[] array2 = localVersion.Split(new char[]
			{
				'.'
			});
			int num3 = int.Parse(array2[0]);
			int num4 = int.Parse(array2[1]);
			return num > num3 || (num == num3 && num2 > num4) || localVersion != remoteVersion;
		}

		public static bool bool_0;
	}
}
