using System;

public static class GClass2
{
	public static void smethod_0(object object_0)
	{
		IDisposable disposable = object_0 as IDisposable;
		if (disposable != null)
		{
			disposable.Dispose();
		}
	}
}
