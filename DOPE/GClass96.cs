using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass96 : GInterface4
{
	public GroupManager Group
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Hero.Group;
		}
	}

	public void method_0(GClass185 gclass185_0)
	{
		this.Group.method_0(gclass185_0);
	}

	public void method_1(GClass203 gclass203_0)
	{
		this.Group.method_1(gclass203_0);
	}

	public void method_2(GClass182 gclass182_0)
	{
		this.Group.method_4(gclass182_0);
	}

	public void method_3(GClass183 gclass183_0)
	{
		this.Group.method_3(gclass183_0);
	}

	public void method_4(GClass184 gclass184_0)
	{
		this.Group.method_2(gclass184_0);
	}

	public void method_5(GClass201 gclass201_0)
	{
		this.Group.zqvcnxOcgC(gclass201_0);
	}

	public void method_6(GClass202 gclass202_0)
	{
		this.Group.method_5(gclass202_0);
	}

	public void method_7(GClass204 gclass204_0)
	{
		this.Group.method_6(gclass204_0);
	}

	public GClass96()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}
}
