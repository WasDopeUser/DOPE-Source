using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class GAttribute44 : Attribute
{
	public GAttribute44(GEnum2 genum2_1)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.method_1(genum2_1);
	}

	[CompilerGenerated]
	public GEnum2 method_0()
	{
		return this.genum2_0;
	}

	[CompilerGenerated]
	private void method_1(GEnum2 genum2_1)
	{
		this.genum2_0 = genum2_1;
	}

	[CompilerGenerated]
	private GEnum2 genum2_0;
}
