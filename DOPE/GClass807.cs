using System;

public static class GClass807
{
	public static P77I3hEU7kMSsbeGTK8 smethod_0<P77I3hEU7kMSsbeGTK8>(this Enum enum_0) where P77I3hEU7kMSsbeGTK8 : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(P77I3hEU7kMSsbeGTK8), false);
		if (customAttributes.Length == 0)
		{
			return default(P77I3hEU7kMSsbeGTK8);
		}
		return (P77I3hEU7kMSsbeGTK8)((object)customAttributes[0]);
	}

	public static Eq7mZyEAC6WUrr6jCgD smethod_1<Eq7mZyEAC6WUrr6jCgD>(this Enum enum_0) where Eq7mZyEAC6WUrr6jCgD : Attribute
	{
		object[] customAttributes = enum_0.GetType().GetMember(enum_0.ToString())[0].GetCustomAttributes(typeof(Eq7mZyEAC6WUrr6jCgD), false);
		if (customAttributes.Length == 0)
		{
			return default(Eq7mZyEAC6WUrr6jCgD);
		}
		return (Eq7mZyEAC6WUrr6jCgD)((object)customAttributes[0]);
	}
}
