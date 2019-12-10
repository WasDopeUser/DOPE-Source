using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class GAttribute23 : Attribute
{
	public GAttribute23([GAttribute1] string format)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.gdfydtMiae = format;
	}

	[GAttribute1]
	public string gdfydtMiae { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
