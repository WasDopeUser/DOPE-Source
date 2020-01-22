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
			Class13.plZSWFPzBWWEZ();
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static NullLogManager()
		{
			Class13.plZSWFPzBWWEZ();
			NullLogManager.Instance = new NullLogManager();
		}

		public static readonly NullLogManager Instance;
	}
}
