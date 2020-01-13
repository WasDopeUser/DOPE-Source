using System;
using System.Collections.Generic;
using System.Linq;
using DarkorbitAPI;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using NLog;

public class GClass102 : GInterface4
{
	public void Run(GClass221 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		bool isControlDisabled = value.Game.Hero.Pet.IsControlDisabled;
		value.Game.Hero.Pet.IsControlDisabled = e.bool_0;
		if (!e.bool_0)
		{
			GClass102.<>c__DisplayClass0_0 CS$<>8__locals1 = new GClass102.<>c__DisplayClass0_0();
			if (isControlDisabled)
			{
				value.Game.Hero.Pet.method_22();
			}
			HeroPet.PetModeData petModeData;
			if (!value.Game.Hero.Pet.Modes.TryGetValue(PetMode.Kamikaze, out petModeData))
			{
				return;
			}
			CS$<>8__locals1.int_0 = petModeData.Data.int_0 * 50 + 350;
			CS$<>8__locals1.vector2_0 = value.Game.Hero.Pet.Position;
			int num = value.Game.Map.Ships.Count(new Func<KeyValuePair<int, Ship>, bool>(CS$<>8__locals1.method_0));
			string text = string.Format("Kamikaze hit {0} enemies", num);
			if (value.ProxySocket != null)
			{
				value.ProxySocket.SendMessage(new GClass269(GClass90.Log(text)));
			}
			LogManager.GetLogger("Base-Game-Pet").Info(text);
		}
	}

	public GClass102()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
