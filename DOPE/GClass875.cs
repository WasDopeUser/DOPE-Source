using System;

public static class GClass875
{
	public static W7VxTDuCgIYAChOeQCA smethod_0<W7VxTDuCgIYAChOeQCA>(this Enum enum_0) where W7VxTDuCgIYAChOeQCA : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(W7VxTDuCgIYAChOeQCA), false);
		if (customAttributes.Length == 0)
		{
			return default(W7VxTDuCgIYAChOeQCA);
		}
		return (W7VxTDuCgIYAChOeQCA)((object)customAttributes[0]);
	}

	public static Yps2iiu0sIGvau3xNOQ smethod_1<Yps2iiu0sIGvau3xNOQ>(this Enum enum_0) where Yps2iiu0sIGvau3xNOQ : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(Yps2iiu0sIGvau3xNOQ), false);
		if (customAttributes.Length == 0)
		{
			return default(Yps2iiu0sIGvau3xNOQ);
		}
		return (Yps2iiu0sIGvau3xNOQ)((object)customAttributes[0]);
	}
}
