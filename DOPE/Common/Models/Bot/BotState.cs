using System;

namespace DOPE.Common.Models.Bot
{
	[Flags]
	public enum BotState
	{
		Default = 1,
		Roam = 2,
		Flee = 4,
		Travel = 8,
		Collect = 16,
		Repair = 32,
		Hunt = 64,
		Logout = 128,
		Dodge = 256,
		PErkava = 512,
		TradePalladium = 1024
	}
}
