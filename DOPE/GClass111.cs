using System;
using DarkorbitAPI;

public class GClass111 : GInterface4
{
	public void Run(GClass224 e)
	{
		ConnectionManager value = ConnectionManager.Instance.Value;
		foreach (GClass236 gclass in e.vector_0)
		{
			foreach (GClass237 gclass2 in gclass.Items)
			{
				value.Game.Hero.method_12(new GClass223(gclass2.gclass171_0, null, gclass2.gclass263_0.double_0, gclass2.gclass263_0.double_1));
				value.Game.Hero.method_13(gclass2.Status);
			}
		}
	}

	public GClass111()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
