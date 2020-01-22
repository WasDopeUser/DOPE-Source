using System;

public static class GClass807
{
	public static s6htBVbsjTFerONxfJu smethod_0<s6htBVbsjTFerONxfJu>(this Enum enum_0) where s6htBVbsjTFerONxfJu : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(s6htBVbsjTFerONxfJu), false);
		if (customAttributes.Length == 0)
		{
			return default(s6htBVbsjTFerONxfJu);
		}
		return (s6htBVbsjTFerONxfJu)((object)customAttributes[0]);
	}

	public static XYQdoNbRIjPOkg73Ii0 smethod_1<XYQdoNbRIjPOkg73Ii0>(this Enum enum_0) where XYQdoNbRIjPOkg73Ii0 : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(XYQdoNbRIjPOkg73Ii0), false);
		if (customAttributes.Length == 0)
		{
			return default(XYQdoNbRIjPOkg73Ii0);
		}
		return (XYQdoNbRIjPOkg73Ii0)((object)customAttributes[0]);
	}
}
