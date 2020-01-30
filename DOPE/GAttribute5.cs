using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class GAttribute5 : Attribute
{
	public GAttribute5([GAttribute1] string name)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Name = name;
	}

	[GAttribute1]
	public string Name { get; private set; }

	[CompilerGenerated]
	private string mwTpzBaxau;
}
