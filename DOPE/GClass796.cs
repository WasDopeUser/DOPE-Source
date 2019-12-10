using System;

public static class GClass796
{
	public static Kl37hiqXVetPTTEdPff smethod_0<Kl37hiqXVetPTTEdPff>(this Enum enum_0) where Kl37hiqXVetPTTEdPff : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(Kl37hiqXVetPTTEdPff), false);
		if (customAttributes.Length == 0)
		{
			return default(Kl37hiqXVetPTTEdPff);
		}
		return (Kl37hiqXVetPTTEdPff)((object)customAttributes[0]);
	}

	public static fc5xM5qi4pGAOGL2tlI smethod_1<fc5xM5qi4pGAOGL2tlI>(this Enum enum_0) where fc5xM5qi4pGAOGL2tlI : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(fc5xM5qi4pGAOGL2tlI), false);
		if (customAttributes.Length == 0)
		{
			return default(fc5xM5qi4pGAOGL2tlI);
		}
		return (fc5xM5qi4pGAOGL2tlI)((object)customAttributes[0]);
	}
}
