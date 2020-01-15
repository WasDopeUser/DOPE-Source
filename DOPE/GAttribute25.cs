using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class GAttribute25 : Attribute
{
	public GAttribute25([GAttribute1] string format)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.TuSebQwtlc = format;
	}

	[GAttribute1]
	public string TuSebQwtlc { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
