using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class GClass928
{
	[DllImport("user32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumChildWindows(IntPtr intptr_1, GClass928.Delegate0 delegate0_0, IntPtr intptr_2);

	public GClass928(IntPtr intptr_1)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.intptr_0 = intptr_1;
	}

	public List<IntPtr> method_0()
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		IntPtr intptr_ = GCHandle.ToIntPtr(value);
		try
		{
			GClass928.Delegate0 delegate0_ = new GClass928.Delegate0(this.method_1);
			GClass928.EnumChildWindows(this.intptr_0, delegate0_, intptr_);
		}
		finally
		{
			value.Free();
		}
		return list;
	}

	private bool method_1(IntPtr intptr_1, IntPtr intptr_2)
	{
		GCHandle gchandle = GCHandle.FromIntPtr(intptr_2);
		if (gchandle.Target == null)
		{
			return false;
		}
		(gchandle.Target as List<IntPtr>).Add(intptr_1);
		return true;
	}

	private IntPtr intptr_0;

	private delegate bool Delegate0(IntPtr hwnd, IntPtr lParam);
}
