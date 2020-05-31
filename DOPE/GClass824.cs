using System;

public static class GClass824
{
	public static RAl4yXtL0bp0rbJJwvp kwfHlajlkp6<RAl4yXtL0bp0rbJJwvp>(this Enum enum_0) where RAl4yXtL0bp0rbJJwvp : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(RAl4yXtL0bp0rbJJwvp), false);
		if (customAttributes.Length == 0)
		{
			return default(RAl4yXtL0bp0rbJJwvp);
		}
		return (RAl4yXtL0bp0rbJJwvp)((object)customAttributes[0]);
	}

	public static BMvG5PtCfOSYXjBx7ob smethod_0<BMvG5PtCfOSYXjBx7ob>(this Enum enum_0) where BMvG5PtCfOSYXjBx7ob : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(BMvG5PtCfOSYXjBx7ob), false);
		if (customAttributes.Length == 0)
		{
			return default(BMvG5PtCfOSYXjBx7ob);
		}
		return (BMvG5PtCfOSYXjBx7ob)((object)customAttributes[0]);
	}
}
