using System;
using DarkorbitAPI;

public class GClass100 : GInterface4
{
	public void Run(GClass219 cmd)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		if (!value.method_18())
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
			value.SendMessage(new GClass172(value.Game.Security.method_1(), value.Game.Settings.Use3D ? 1U : 0U));
			value.SendMessage(new GClass172(value.Game.Security.method_1(), 2U));
		}
	}

	public GClass100()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}
}
