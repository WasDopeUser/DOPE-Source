using System;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;

public class GClass118 : GInterface4
{
	public void Run(GClass245 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		value.Game.Hero.Pet.Mode = PetMode.Off;
		value.Game.Hero.Pet.IsEnabled = false;
		if (e.Enabled)
		{
			value.Game.Hero.Pet.IsRepairNeeded = true;
		}
	}

	public GClass118()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
