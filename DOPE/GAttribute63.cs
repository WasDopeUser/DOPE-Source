using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute63 : Attribute
{
	public GAttribute63([GAttribute1] string directive)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.String_0 = directive;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
