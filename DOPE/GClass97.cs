using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass97 : GInterface4
{
	public GroupManager Group
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Hero.Group;
		}
	}

	public void method_0(GClass195 gclass195_0)
	{
		this.Group.method_2(gclass195_0);
	}

	public void method_1(GClass213 gclass213_0)
	{
		this.Group.method_3(gclass213_0);
	}

	public void method_2(GClass192 gclass192_0)
	{
		this.Group.dHwOrswsKe(gclass192_0);
	}

	public void method_3(GClass193 gclass193_0)
	{
		this.Group.method_5(gclass193_0);
	}

	public void method_4(GClass194 gclass194_0)
	{
		this.Group.method_4(gclass194_0);
	}

	public void method_5(GClass211 gclass211_0)
	{
		this.Group.method_6(gclass211_0);
	}

	public void method_6(GClass212 gclass212_0)
	{
		this.Group.method_7(gclass212_0);
	}

	public void method_7(GClass214 gclass214_0)
	{
		this.Group.method_8(gclass214_0);
	}

	public GClass97()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
