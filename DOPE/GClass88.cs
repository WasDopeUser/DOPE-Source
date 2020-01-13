using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.NativeWrappers;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using NLog;

public class GClass88
{
	public ConnectionManager Connection { get; set; }

	public Logger Log
	{
		get
		{
			ILogManager logManager = this.Connection.Game.LogManager;
			if (logManager == null)
			{
				return null;
			}
			return logManager.Get("Net-ServerCommands");
		}
	}

	public GClass88(ConnectionManager connectionManager_1)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.Connection = connectionManager_1;
	}

	public void method_0(int int_0)
	{
		this.Log.Trace("Activate interactible {id}", int_0);
		this.method_4();
		this.Connection.SendMessage(new GClass159(int_0));
	}

	public void method_1()
	{
		this.Log.Trace("Opening ore trade window");
		this.Connection.SendMessage(new GClass162());
	}

	public void method_2(int int_0 = 0)
	{
		this.Log.Trace("Jump gate {gateId}", int_0);
		if (int_0 != 0)
		{
			this.method_4();
			this.Connection.SendMessage(new GClass159(int_0));
		}
		this.Connection.SendMessage(new GClass160());
	}

	public void method_3(int int_0)
	{
		this.Log.Trace("Select config {configId}", int_0);
		this.Connection.method_2(new string[]
		{
			"S",
			"CFG",
			int_0.ToString(),
			this.Connection.Game.Settings.FlashSettings.userID.ToString(),
			this.Connection.Game.Settings.FlashSettings.sessionID
		});
	}

	public void method_4()
	{
		this.Connection.SendMessage(new GClass274(null)
		{
			vector_0 = new DarkorbitAPI.CommonStructures.Vector<GClass271>
			{
				new GClass272("map_clicks", 1)
			}
		});
	}

	public int method_5(float float_0, float float_1, bool bool_0 = false)
	{
		return this.method_6((int)float_0, (int)float_1, bool_0);
	}

	public int method_6(int int_0, int int_1, bool bool_0 = false)
	{
		Hero hero = this.Connection.Game.Hero;
		if (!hero.CanMove)
		{
			return 0;
		}
		Vector2 position = hero.Position;
		if (this.Connection.Game.Security.method_1(position, int_0, int_1, 0) && bool_0)
		{
			this.method_4();
		}
		GClass161 gclass = new GClass161((int)position.X, int_1, int_0, (int)position.Y);
		if ((gclass.int_1 + int_0) % 3 == 0)
		{
			gclass.int_1++;
		}
		gclass.int_2 -= (gclass.int_2 + int_1) % 3;
		this.Connection.SendMessage(gclass);
		int num = hero.method_4(int_0, int_1, hero.Speed);
		GInterface5 proxySocket = this.Connection.ProxySocket;
		if (proxySocket != null)
		{
			proxySocket.SendMessage(new GClass267(this.Connection.Game.Hero.Id, int_0, int_1, num));
		}
		return num;
	}

	public void method_7(uint uint_0 = 1U)
	{
		this.Log.Trace("Repair ship {selection}", uint_0);
		GClass241 gclass = this.Connection.method_15();
		gclass.string_0 = "";
		gclass.int_0 = 0;
		this.Connection.SendMessage(new GClass167(new GClass260(uint_0), gclass));
		this.Connection.method_14();
	}

	public bool method_8(Ship ship_0, bool bool_0 = false)
	{
		if (ship_0 == null)
		{
			return false;
		}
		this.Log.Trace("Select ship {shipName}", (ship_0 != null) ? ship_0.Name : null);
		GameManager game = this.Connection.Game;
		Vector2 position = game.Hero.Position;
		Vector2 position2 = ship_0.Position;
		if (!bool_0 && !game.Security.method_2(position, ship_0.Position, 0))
		{
			return false;
		}
		this.method_4();
		GClass168 gclass = new GClass168(ship_0.Id, (int)position2.X, (int)position2.Y, (int)position.X, (int)position.Y);
		gclass.int_1 -= (gclass.int_3 + gclass.int_1 + gclass.int_2 + gclass.int_4) % 5;
		this.Connection.SendMessage(gclass);
		return true;
	}

	public void method_9()
	{
		this.method_14("equipment_extra_repbot_rep", true, false);
	}

	public void method_10()
	{
		this.Log.Trace("Stop attacking");
		this.Connection.SendMessage(new GClass170());
	}

	public void method_11(Ship ship_0)
	{
		if (ship_0 == null)
		{
			return;
		}
		this.Log.Trace("Attack {shipName}", (ship_0 != null) ? ship_0.Name : null);
		Vector2 position = ship_0.Position;
		GClass142 gclass = new GClass142(ship_0.Id, (int)position.X, (int)position.Y);
		if ((gclass.int_1 + gclass.int_0) % 3 == 0)
		{
			gclass.int_1++;
		}
		this.Connection.SendMessage(gclass);
	}

	public void method_12(Ship ship_0)
	{
		if (ship_0 == null)
		{
			return;
		}
		this.Log.Trace("Attack rocket {shipName}", (ship_0 != null) ? ship_0.Name : null);
		Vector2 position = ship_0.Position;
		GClass143 gclass = new GClass143(ship_0.Id, (int)position.X, (int)position.Y);
		if ((gclass.int_0 + gclass.int_1) % 3 == 0)
		{
			gclass.int_1++;
		}
		this.Connection.SendMessage(gclass);
	}

	public void method_13(Collectible collectible_0)
	{
		if (collectible_0 == null)
		{
			return;
		}
		this.Log.Trace("Collect {boxType}", collectible_0.Type);
		this.method_4();
		DarkorbitAPI.Structures.Resource resource = collectible_0 as DarkorbitAPI.Structures.Resource;
		if (resource != null)
		{
			this.Connection.SendMessage(new GClass145(resource.Hash));
			return;
		}
		GClass144 gclass = new GClass144(collectible_0.Hash, collectible_0.PosX, collectible_0.PosY, collectible_0.PosX, collectible_0.PosY);
		if ((gclass.int_1 + gclass.int_3 + gclass.int_2) % 3 == 0)
		{
			gclass.int_2++;
		}
		this.Connection.SendMessage(gclass);
	}

	public void method_14(string string_0, bool bool_0, bool bool_1 = false)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		this.Log.Trace<string, bool>("Use {type}, activate={activate}", string_0, bool_0);
		this.Connection.SendMessage(new GClass173(string_0, bool_0 ? 1U : 0U, bool_1 ? 1U : 0U));
	}

	public void method_15(string string_0, bool bool_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		Hero hero = this.Connection.Game.Hero;
		if (!hero.method_15(string_0))
		{
			return;
		}
		if (hero.method_18(string_0) == bool_0)
		{
			return;
		}
		this.method_14(string_0, false, false);
	}

	public void method_16(string string_0)
	{
		this.Log.Trace("Use HUD button {id}", string_0);
		this.Connection.SendMessage(new GClass174(string_0));
	}

	public void method_17()
	{
		this.method_16("logout");
	}

	public void method_18(PetState petState_0)
	{
		this.Log.Trace<PetState>("Set pet state {petState}", petState_0);
		this.Connection.SendMessage(new GClass164((uint)petState_0));
	}

	public void method_19(PetMode petMode_0, int int_0 = 0)
	{
		this.Log.Trace<PetMode>("Set pet mode {petMode}", petMode_0);
		this.Connection.SendMessage(new GClass163(new GClass258((uint)petMode_0), int_0));
		this.Connection.Game.Hero.Pet.Mode = petMode_0;
		this.Connection.Game.Hero.Pet.ModeExtra = int_0;
	}

	public void method_20(ResourceType resourceType_0, double double_0)
	{
		if (double_0 == 0.0)
		{
			return;
		}
		this.Log.Trace<double, ResourceType>("Refine {count} of {resource}", double_0, resourceType_0);
		this.Connection.SendMessage(new GClass166(new GClass135(new GClass261((uint)resourceType_0), double_0)));
		this.Connection.SendMessage(new GClass158());
	}

	public void method_21(ResourceType resourceType_0, double double_0)
	{
		if (double_0 == 0.0)
		{
			return;
		}
		this.Log.Trace<double, ResourceType>("Sell {count} of {resource}", double_0, resourceType_0);
		if (resourceType_0 == ResourceType.PALLADIUM)
		{
			double_0 -= double_0 % 15.0;
			this.Connection.method_2(new string[]
			{
				"XCP",
				((int)double_0).ToString()
			});
		}
		else
		{
			this.Connection.SendMessage(new GClass171(new GClass135(new GClass261((uint)resourceType_0), double_0)));
		}
		this.Connection.SendMessage(new GClass158());
	}

	public void method_22(int int_0)
	{
		this.Log.Trace("Accepting group invite from id {id}", int_0);
		this.Connection.SendMessage(new GClass148(int_0));
	}

	public void method_23(int int_0)
	{
		this.Log.Trace("Kicking group member with id {id}", int_0);
		this.Connection.SendMessage(new GClass152(int_0));
	}

	public void method_24(string string_0)
	{
		if (string.IsNullOrWhiteSpace(string_0))
		{
			return;
		}
		this.Log.Trace("Sending group invite to {player}", string_0);
		this.Connection.SendMessage(new GClass151(string_0));
	}

	public void method_25(int int_0)
	{
		this.Log.Trace("Declining group invite from id {id}", int_0);
		this.Connection.SendMessage(new GClass150(int_0));
	}

	public void method_26(Vector2 vector2_0)
	{
		this.method_27((int)vector2_0.X, (int)vector2_0.Y);
	}

	public void method_27(int int_0, int int_1)
	{
		this.Log.Trace<int, int>("Pinging map location ({x}, {y})", int_0, int_1);
		this.Connection.SendMessage(new GClass154(int_0, int_1));
	}

	[CompilerGenerated]
	private ConnectionManager connectionManager_0;
}
