using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class GAttribute13 : Attribute
{
	public GAttribute13()
	{
		Class13.igxcIukzfpare();
		this..ctor((GEnum0)7, (GEnum1)1);
	}

	public GAttribute13(GEnum0 genum0_1)
	{
		Class13.igxcIukzfpare();
		this..ctor(genum0_1, (GEnum1)1);
	}

	public GAttribute13(GEnum1 genum1_1)
	{
		Class13.igxcIukzfpare();
		this..ctor((GEnum0)7, genum1_1);
	}

	public GAttribute13(GEnum0 genum0_1, GEnum1 genum1_1)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.GEnum0_0 = genum0_1;
		this.GEnum1_0 = genum1_1;
	}

	[GAttribute12]
	public GEnum0 GEnum0_0 { get; private set; }

	[GAttribute12]
	public GEnum1 GEnum1_0 { get; private set; }

	[CompilerGenerated]
	private GEnum0 genum0_0;

	[CompilerGenerated]
	private GEnum1 genum1_0;
}
