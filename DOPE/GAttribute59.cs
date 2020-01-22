using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Property)]
public sealed class GAttribute59 : Attribute
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

	public GAttribute59(bool bool_1)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.method_1(bool_1);
	}

	[CompilerGenerated]
	private bool bool_0;
}
