using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class GAttribute69 : Attribute
{
	[CompilerGenerated]
	public string method_0()
	{
		return this.string_0;
	}

	[CompilerGenerated]
	public void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	public GAttribute69(string string_1)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.method_1(string_1);
	}

	[CompilerGenerated]
	private string string_0;
}
