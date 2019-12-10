using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using NLog;

public class GClass101 : GInterface4
{
	public void Run(GClass211 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		bool isControlDisabled = value.Game.Hero.Pet.IsControlDisabled;
		value.Game.Hero.Pet.IsControlDisabled = e.bool_0;
		if (!e.bool_0)
		{
			GClass101.<>c__DisplayClass0_0 CS$<>8__locals1 = new GClass101.<>c__DisplayClass0_0();
			if (isControlDisabled)
			{
				value.Game.Hero.Pet.method_18();
			}
			GClass243 gclass;
			if (!value.Game.Hero.Pet.Modes.TryGetValue(PetMode.Kamikaze, out gclass))
			{
				return;
			}
			CS$<>8__locals1.int_0 = gclass.int_1 * 50 + 350;
			CS$<>8__locals1.vector2_0 = value.Game.Hero.Pet.Position;
			int num = value.Game.Map.Ships.Count(new Func<KeyValuePair<int, Ship>, bool>(CS$<>8__locals1.method_0));
			string text = string.Format("Kamikaze hit {0} enemies", num);
			if (value.ProxySocket != null)
			{
				value.ProxySocket.SendMessage(new GClass255(GClass90.Log(text)));
			}
			LogManager.GetLogger("Base-Game-Pet").Info(text);
		}
	}

	public GClass101()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
