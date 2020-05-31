using System;

namespace DarkorbitAPI.Packets.Static
{
	[Flags]
	public enum MapGroup
	{
		Default = 1,
		GG = 2,
		Invasion = 4,
		TDM = 8,
		GOP = 16,
		FrozenLabyrinth = 32,
		PayloadEscort = 64
	}
}
