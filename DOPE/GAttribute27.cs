using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class GAttribute27 : Attribute
{
	public GAttribute27([GAttribute1] string format)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.String_0 = format;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
