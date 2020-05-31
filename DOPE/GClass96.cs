using System;
using DarkorbitAPI;
using NLog;

public class GClass96 : GInterface4
{
	public GameManager Game
	{
		get
		{
			return ConnectionManager.Instance.Value.Game;
		}
	}

	public Logger Log
	{
		get
		{
			return this.Game.LogManager.Get("Net-Handlers");
		}
	}

	public void method_0(GClass189 gclass189_0)
	{
		this.Game.Hero.method_22("resource_labirynth-keys", (double)gclass189_0.int_0);
		this.Game.EventGateOpening = DateTimeOffset.Now.AddSeconds(gclass189_0.gclass190_0.double_1);
		if (gclass189_0.gclass190_0.double_0 > 1.0)
		{
			this.Game.EventGateClosing = DateTimeOffset.Now.AddSeconds(gclass189_0.gclass190_0.double_0);
			return;
		}
		this.Game.EventGateClosing = DateTimeOffset.Now.AddSeconds(-1.0);
	}

	public void method_1(GClass256 gclass256_0)
	{
		this.Game.Hero.method_22("resource_payload-keys", (double)gclass256_0.gclass257_0.int_0);
		if (gclass256_0.gclass258_0.double_0 > 1.0)
		{
			this.Game.EventGateOpening = DateTimeOffset.Now.AddSeconds(-1.0);
			this.Game.EventGateClosing = DateTimeOffset.Now.AddSeconds(gclass256_0.gclass258_0.double_0);
			this.Game.EventGateGoal = DateTimeOffset.Now.AddSeconds(-1.0);
		}
		else
		{
			this.Game.EventGateOpening = DateTimeOffset.Now.AddSeconds(gclass256_0.gclass258_0.double_1);
			this.Game.EventGateClosing = DateTimeOffset.Now.AddSeconds(-1.0);
			this.Game.EventGateGoal = DateTimeOffset.Now.AddSeconds(gclass256_0.gclass258_0.double_2);
		}
		this.Log.Info("Payload escort update -- {keys} keys; {open}~{closing} ({remaining})", new object[]
		{
			gclass256_0.gclass257_0.int_0,
			this.Game.EventGateOpening,
			this.Game.EventGateClosing,
			this.Game.EventGateGoal
		});
	}

	public GClass96()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}
}
