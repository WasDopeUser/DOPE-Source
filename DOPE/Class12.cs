﻿using System;
using System.Reflection;

internal class Class12
{
	internal static void Q9AN3Wddrwmut(int typemdt)
	{
		Type type = Class12.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class12.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class12()
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class12()
	{
		Class13.Gj4N3WdzaR1LY();
		Class12.module_0 = typeof(Class12).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate1(object o);
}
