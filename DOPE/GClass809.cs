using System;

public static class GClass809
{
	public static HbXXjYnjLhRCoPRq1Fb smethod_0<HbXXjYnjLhRCoPRq1Fb>(this Enum enum_0) where HbXXjYnjLhRCoPRq1Fb : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(HbXXjYnjLhRCoPRq1Fb), false);
		if (customAttributes.Length == 0)
		{
			return default(HbXXjYnjLhRCoPRq1Fb);
		}
		return (HbXXjYnjLhRCoPRq1Fb)((object)customAttributes[0]);
	}

	public static PZ1pZWn7Lh80D1JbGJL smethod_1<PZ1pZWn7Lh80D1JbGJL>(this Enum enum_0) where PZ1pZWn7Lh80D1JbGJL : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(PZ1pZWn7Lh80D1JbGJL), false);
		if (customAttributes.Length == 0)
		{
			return default(PZ1pZWn7Lh80D1JbGJL);
		}
		return (PZ1pZWn7Lh80D1JbGJL)((object)customAttributes[0]);
	}
}
