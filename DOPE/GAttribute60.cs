using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute60 : Attribute
{
	public GAttribute60([GAttribute1] string name)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Name = name;
	}

	[GAttribute1]
	public string Name { get; private set; }

	[CompilerGenerated]
	private string string_0;
}
