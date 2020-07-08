using System;
using System.Reflection;

internal class Class12
{
	internal static void Ft08ImWWNOvaU(int typemdt)
	{
		Type type = Class12.hwawxLyrTxV.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class12.hwawxLyrTxV.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class12()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class12()
	{
		Class13.xnk8ImWzpOt04();
		Class12.hwawxLyrTxV = typeof(Class12).Assembly.ManifestModule;
	}

	internal static Module hwawxLyrTxV;

	internal delegate void Delegate1(object o);
}
