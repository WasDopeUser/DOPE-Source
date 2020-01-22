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
				return string.Format("{0}.{1}", 0, 46);
			}
		}

		public static bool FrozenLabirynthEnabled
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
				GClass279 gclass = new GClass279(0, 147, 1);
				return string.Format("{0}.{1}.{2}", gclass.int_0, gclass.int_1, gclass.int_2);
			}
		}

		public static bool IsOutdated(string localVersion, string remoteVersion)
		{
			if (localVersion == remoteVersion)
			{
				return false;
			}
			if (localVersion == "0.45.0-EXPERIMENTAL")
			{
				return true;
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
			return num > num3 || (num == num3 && num2 > num4);
		}

		public static bool bool_0;
	}
}
