using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class GAttribute21 : Attribute
{
	[GAttribute0]
	public string String_0 { get; set; }

	[CompilerGenerated]
	public int method_0()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	public void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	[GAttribute0]
	public string Target { get; set; }

	public GAttribute21()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_1;
}
