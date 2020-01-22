using System;
using System.Reflection;

internal class Class12
{
	internal static void K9oSWFPPJ5gNu(int typemdt)
	{
		Type type = Class12.ProqjcloQrX.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class12.ProqjcloQrX.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class12()
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class12()
	{
		Class13.plZSWFPzBWWEZ();
		Class12.ProqjcloQrX = typeof(Class12).Assembly.ManifestModule;
	}

	internal static Module ProqjcloQrX;

	internal delegate void Delegate1(object o);
}
