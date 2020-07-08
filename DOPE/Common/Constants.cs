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
				return string.Format("{0}.{1}", 0, 55);
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
				return "688b75415cb841f68eaae105cf0f2de9";
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
