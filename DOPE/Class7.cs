using System;
using System.Reflection;

internal class Class7
{
	internal static void AcFh7toojmCD6(int typemdt)
	{
		Type type = Class7.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class7.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class7()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class7()
	{
		Class8.xDph7tozmh5WD();
		Class7.module_0 = typeof(Class7).Assembly.ManifestModule;
	}

	internal static Module module_0;

	internal delegate void Delegate1(object o);
}
