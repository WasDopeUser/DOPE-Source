using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Property)]
public sealed class GAttribute60 : Attribute
{
	[CompilerGenerated]
	public bool method_0()
	{
		return this.bool_0;
	}

	[CompilerGenerated]
	private void method_1(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public GAttribute60(bool bool_1)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.method_1(bool_1);
	}

	[CompilerGenerated]
	private bool bool_0;
}
