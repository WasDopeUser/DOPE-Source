using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class GAttribute8 : Attribute
{
	public GAttribute8([GAttribute1] string contract)
	{
		Class13.NP5bWyNzLwONS();
		this..ctor(contract, false);
	}

	public GAttribute8([GAttribute1] string contract, bool bool_0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.String_0 = contract;
		this.method_1(bool_0);
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	public bool method_0()
	{
		return this.ObtlxOlyWW;
	}

	[CompilerGenerated]
	private void method_1(bool bool_0)
	{
		this.ObtlxOlyWW = bool_0;
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private bool ObtlxOlyWW;
}
