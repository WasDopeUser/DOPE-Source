using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute64 : Attribute
{
	public GAttribute64([GAttribute1] string baseType)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.String_0 = baseType;
	}

	public GAttribute64([GAttribute1] string baseType, string string_2)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.String_0 = baseType;
		this.String_1 = string_2;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[GAttribute0]
	public string String_1 { get; private set; }

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;
}
