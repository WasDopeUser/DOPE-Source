using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class GAttribute24 : Attribute
{
	public GAttribute24([GAttribute1] string format)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.String_0 = format;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
