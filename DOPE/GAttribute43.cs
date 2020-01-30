using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class GAttribute43 : Attribute
{
	public GAttribute43([GAttribute1] string name)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Name = name;
	}

	[GAttribute1]
	public string Name { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
