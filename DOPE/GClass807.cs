using System;

public static class GClass807
{
	public static V0TIQ3PI8Zsi6oCXr7Y smethod_0<V0TIQ3PI8Zsi6oCXr7Y>(this Enum enum_0) where V0TIQ3PI8Zsi6oCXr7Y : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(V0TIQ3PI8Zsi6oCXr7Y), false);
		if (customAttributes.Length == 0)
		{
			return default(V0TIQ3PI8Zsi6oCXr7Y);
		}
		return (V0TIQ3PI8Zsi6oCXr7Y)((object)customAttributes[0]);
	}

	public static oFvlO4PRI4mEYYQ6IM4 smethod_1<oFvlO4PRI4mEYYQ6IM4>(this Enum enum_0) where oFvlO4PRI4mEYYQ6IM4 : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(oFvlO4PRI4mEYYQ6IM4), false);
		if (customAttributes.Length == 0)
		{
			return default(oFvlO4PRI4mEYYQ6IM4);
		}
		return (oFvlO4PRI4mEYYQ6IM4)((object)customAttributes[0]);
	}
}
