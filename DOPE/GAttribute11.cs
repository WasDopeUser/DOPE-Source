using System;
using System.Runtime.CompilerServices;

[GAttribute11(typeof(Attribute))]
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class GAttribute11 : Attribute
{
	public GAttribute11([GAttribute1] Type baseType)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.Type_0 = baseType;
	}

	[GAttribute1]
	public Type Type_0 { get; private set; }

	[CompilerGenerated]
	private Type type_0;
}
