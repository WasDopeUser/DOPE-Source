using System;
using DarkorbitAPI;

public class GClass96 : GInterface4
{
	public GameManager Game
	{
		get
		{
			return ConnectionManager.Instance.Value.Game;
		}
	}

	public void method_0(GClass188 gclass188_0)
	{
		this.Game.Hero.method_23("resource_labirynth-keys", (double)gclass188_0.int_0);
		this.Game.FrozenLabirynthOpening = DateTimeOffset.Now.AddSeconds(gclass188_0.gclass189_0.double_0);
		if (gclass188_0.gclass189_0.double_1 > 1.0)
		{
			this.Game.FrozenLabirynthClosing = DateTimeOffset.Now.AddSeconds(gclass188_0.gclass189_0.double_1);
			return;
		}
		this.Game.FrozenLabirynthClosing = DateTimeOffset.Now.AddSeconds(-1.0);
	}

	public GClass96()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
