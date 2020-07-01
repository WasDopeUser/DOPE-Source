using System;
using NLog;

namespace DarkorbitAPI.NativeWrappers
{
	public class NullLogManager : ILogManager
	{
		public Logger Get(string string_0)
		{
			return LogManager.CreateNullLogger();
		}

		public NullLogManager()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static NullLogManager()
		{
			Class13.F93tSdiz1aNIA();
			NullLogManager.Instance = new NullLogManager();
		}

		public static readonly NullLogManager Instance;
	}
}
