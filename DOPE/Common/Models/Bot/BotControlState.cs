using System;
using System.Runtime.InteropServices;

namespace DOPE.Common.Models.Bot
{
	[Guid("42905DD4-C0B4-4D61-A907-C1F7896CBCC5")]
	public enum BotControlState
	{
		Unknown,
		Running,
		Paused,
		Stopped,
		Waiting
	}
}
