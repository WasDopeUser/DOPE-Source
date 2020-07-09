using System;

public static class GClass875
{
	public static L5d3qsQFhEjB5yDXfNu smethod_0<L5d3qsQFhEjB5yDXfNu>(this Enum enum_0) where L5d3qsQFhEjB5yDXfNu : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(L5d3qsQFhEjB5yDXfNu), false);
		if (customAttributes.Length == 0)
		{
			return default(L5d3qsQFhEjB5yDXfNu);
		}
		return (L5d3qsQFhEjB5yDXfNu)((object)customAttributes[0]);
	}

	public static w83INFQO7N2LMgSr2Wa smethod_1<w83INFQO7N2LMgSr2Wa>(this Enum enum_0) where w83INFQO7N2LMgSr2Wa : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(w83INFQO7N2LMgSr2Wa), false);
		if (customAttributes.Length == 0)
		{
			return default(w83INFQO7N2LMgSr2Wa);
		}
		return (w83INFQO7N2LMgSr2Wa)((object)customAttributes[0]);
	}
}
