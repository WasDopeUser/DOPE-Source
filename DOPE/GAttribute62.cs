using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute62 : Attribute
{
	public GAttribute62([GAttribute1] string type, [GAttribute1] string fieldName)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Type = type;
		this.String_0 = fieldName;
	}

	[GAttribute1]
	public string Type { get; private set; }

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;
}
