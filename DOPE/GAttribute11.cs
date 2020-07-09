using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
[GAttribute11(typeof(Attribute))]
public sealed class GAttribute11 : Attribute
{
	public GAttribute11([GAttribute1] Type baseType)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.Type_0 = baseType;
	}

	[GAttribute1]
	public Type Type_0 { get; private set; }

	[CompilerGenerated]
	private Type type_0;
}
