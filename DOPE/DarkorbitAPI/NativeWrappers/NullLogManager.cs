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
			Class13.tMHx78BzgCM8j();
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static NullLogManager()
		{
			Class13.tMHx78BzgCM8j();
			NullLogManager.Instance = new NullLogManager();
		}

		public static readonly NullLogManager Instance;
	}
}
