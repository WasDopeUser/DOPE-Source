using System;

public static class GClass874
{
	public static vvkwsZ5St5NyBC1IIaJ smethod_0<vvkwsZ5St5NyBC1IIaJ>(this Enum enum_0) where vvkwsZ5St5NyBC1IIaJ : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(vvkwsZ5St5NyBC1IIaJ), false);
		if (customAttributes.Length == 0)
		{
			return default(vvkwsZ5St5NyBC1IIaJ);
		}
		return (vvkwsZ5St5NyBC1IIaJ)((object)customAttributes[0]);
	}

	public static G5ULQI5XT5m1jwi0a8M smethod_1<G5ULQI5XT5m1jwi0a8M>(this Enum enum_0) where G5ULQI5XT5m1jwi0a8M : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(G5ULQI5XT5m1jwi0a8M), false);
		if (customAttributes.Length == 0)
		{
			return default(G5ULQI5XT5m1jwi0a8M);
		}
		return (G5ULQI5XT5m1jwi0a8M)((object)customAttributes[0]);
	}
}
