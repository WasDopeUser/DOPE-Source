using System;
using DarkorbitAPI;

public class GClass99 : GInterface4
{
	public void Run(GClass209 cmd)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		if (!value.method_21())
		{
			return;
		}
		if (cmd.Reset)
		{
			value.Game.Hero.Clear();
			value.Game.Map.Clear();
		}
		value.Game.method_6(cmd);
		value.SendMessage(new GClass154());
		if (cmd.Reset)
		{
			value.SendMessage(new GClass168(value.Game.Security.method_16(), value.Game.Settings.Use3D ? 1U : 0U));
			value.SendMessage(new GClass168(value.Game.Security.method_16(), 2U));
		}
	}

	public GClass99()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
