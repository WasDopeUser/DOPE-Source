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

	public void method_0(GClass196 gclass196_0)
	{
		this.Group.method_2(gclass196_0);
	}

	public void method_1(GClass214 gclass214_0)
	{
		this.Group.iZanvyDsIr(gclass214_0);
	}

	public void method_2(GClass193 gclass193_0)
	{
		this.Group.method_6(gclass193_0);
	}

	public void method_3(GClass194 gclass194_0)
	{
		this.Group.method_4(gclass194_0);
	}

	public void method_4(GClass195 gclass195_0)
	{
		this.Group.method_3(gclass195_0);
	}

	public void method_5(GClass212 gclass212_0)
	{
		this.Group.method_5(gclass212_0);
	}

	public void method_6(GClass213 gclass213_0)
	{
		this.Group.method_7(gclass213_0);
	}

	public void method_7(GClass215 gclass215_0)
	{
		this.Group.method_8(gclass215_0);
	}

	public GClass97()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}
}
