using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class GAttribute8 : Attribute
{
	public GAttribute8([GAttribute1] string contract)
	{
		Class13.xnk8ImWzpOt04();
		this..ctor(contract, false);
	}

	public GAttribute8([GAttribute1] string contract, bool bool_1)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.String_0 = contract;
		this.method_1(bool_1);
	}

	[GAttribute1]
	public string String_0 { get; private set; }

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

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool bool_0;
}
