using System;
using DarkorbitAPI;

public class GClass100 : GInterface4
{
	public void Run(GClass216 cmd)
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
		value.SendMessage(new GClass157());
		if (cmd.Reset)
		{
			value.SendMessage(new GClass171(value.Game.Security.method_1(), value.Game.Settings.Use3D ? 1 : 0));
			value.SendMessage(new GClass171(value.Game.Security.method_1(), 2));
		}
	}

	public GClass100()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}
}
