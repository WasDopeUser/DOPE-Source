using System;

public static class GClass808
{
	public static VJyVAcNzwp5aEr4Tgcw smethod_0<VJyVAcNzwp5aEr4Tgcw>(this Enum enum_0) where VJyVAcNzwp5aEr4Tgcw : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(VJyVAcNzwp5aEr4Tgcw), false);
		if (customAttributes.Length == 0)
		{
			return default(VJyVAcNzwp5aEr4Tgcw);
		}
		return (VJyVAcNzwp5aEr4Tgcw)((object)customAttributes[0]);
	}

	public static pXFm5QPTqdCZKRNw0OP smethod_1<pXFm5QPTqdCZKRNw0OP>(this Enum enum_0) where pXFm5QPTqdCZKRNw0OP : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(pXFm5QPTqdCZKRNw0OP), false);
		if (customAttributes.Length == 0)
		{
			return default(pXFm5QPTqdCZKRNw0OP);
		}
		return (pXFm5QPTqdCZKRNw0OP)((object)customAttributes[0]);
	}
}
