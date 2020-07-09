using System;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;

public class GClass119 : GInterface4
{
	public void Run(GClass258 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		value.Game.Hero.Pet.Mode = PetMode.Off;
		value.Game.Hero.Pet.IsEnabled = false;
		if (e.Enabled)
		{
			value.Game.Hero.Pet.IsRepairNeeded = true;
		}
	}

	public GClass119()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
