using System;
using NLog;

namespace DarkorbitAPI.NativeWrappers
{
	public interface ILogManager
	{
		Logger Get(string string_0);
	}
}
