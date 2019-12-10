using System;
using System.Linq;
using System.Reflection;

public static class GClass85
{
	public static object smethod_0(Type type_0)
	{
		ConstructorInfo[] constructors = type_0.GetTypeInfo().GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		for (int i = 0; i < constructors.Length; i++)
		{
			ParameterInfo[] parameters = constructors[i].GetParameters();
			if (!parameters.Any(new Func<ParameterInfo, bool>(GClass85.<>c.<>c_0.method_0)))
			{
				return Activator.CreateInstance(type_0, parameters.Select(new Func<ParameterInfo, object>(GClass85.<>c.<>c_0.method_1)).ToArray<object>());
			}
		}
		return null;
	}
}
