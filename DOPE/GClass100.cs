using System;
using DarkorbitAPI;

public class GClass100 : GInterface4
{
	public void Run(GClass217 cmd)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		if (!value.method_19())
		{
			return;
		}
		if (cmd.Reset)
		{
			value.Game.Hero.Clear();
			value.Game.Map.Clear();
		}
		value.Game.method_6(cmd);
		value.SendMessage(new GClass158());
		if (cmd.Reset)
		{
			value.SendMessage(new GClass172(value.Game.Security.method_1(), value.Game.Settings.Use3D ? 1 : 0));
			value.SendMessage(new GClass172(value.Game.Security.method_1(), 2));
		}
	}

	public GClass100()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
