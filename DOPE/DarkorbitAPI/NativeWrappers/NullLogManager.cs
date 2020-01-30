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
			Class13.Gj4N3WdzaR1LY();
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static NullLogManager()
		{
			Class13.Gj4N3WdzaR1LY();
			NullLogManager.Instance = new NullLogManager();
		}

		public static readonly NullLogManager Instance;
	}
}
