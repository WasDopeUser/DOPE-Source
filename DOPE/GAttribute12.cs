using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.All)]
public sealed class GAttribute12 : Attribute
{
	public GAttribute12()
	{
		Class13.NP5bWyNzLwONS();
		this..ctor((GEnum0)7, (GEnum1)1);
	}

	public GAttribute12(GEnum0 genum0_1)
	{
		Class13.NP5bWyNzLwONS();
		this..ctor(genum0_1, (GEnum1)1);
	}

	public GAttribute12(GEnum1 genum1_1)
	{
		Class13.NP5bWyNzLwONS();
		this..ctor((GEnum0)7, genum1_1);
	}

	public GAttribute12(GEnum0 genum0_1, GEnum1 genum1_1)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.method_1(genum0_1);
		this.qOolKaFfsj(genum1_1);
	}

	[CompilerGenerated]
	public GEnum0 method_0()
	{
		return this.genum0_0;
	}

	[CompilerGenerated]
	private void method_1(GEnum0 genum0_1)
	{
		this.genum0_0 = genum0_1;
	}

	[CompilerGenerated]
	public GEnum1 method_2()
	{
		return this.genum1_0;
	}

	[CompilerGenerated]
	private void qOolKaFfsj(GEnum1 genum1_1)
	{
		this.genum1_0 = genum1_1;
	}

	[CompilerGenerated]
	private GEnum0 genum0_0;

	[CompilerGenerated]
	private GEnum1 genum1_0;
}
