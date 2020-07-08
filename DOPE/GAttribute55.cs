using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class GAttribute55 : Attribute
{
	public GAttribute55([GAttribute1] string tagName, [GAttribute1] Type controlType)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.String_0 = tagName;
		this.Type_0 = controlType;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[GAttribute1]
	public Type Type_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private Type type_0;
}
