using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class GClass838
{
	[CompilerGenerated]
	public int method_0()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	private void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	[CompilerGenerated]
	public IntPtr method_2()
	{
		return this.intptr_2;
	}

	[CompilerGenerated]
	private void method_3(IntPtr intptr_3)
	{
		this.intptr_2 = intptr_3;
	}

	[CompilerGenerated]
	public List<GClass840.GStruct2> method_4()
	{
		return this.list_0;
	}

	[CompilerGenerated]
	private void method_5(List<GClass840.GStruct2> list_1)
	{
		this.list_0 = list_1;
	}

	public GClass838(int int_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.method_1(int_1);
	}

	public bool method_6()
	{
		this.method_5(new List<GClass840.GStruct2>());
		GClass840.GStruct0 gstruct = default(GClass840.GStruct0);
		GClass840.GetSystemInfo(out gstruct);
		this.intptr_0 = gstruct.intptr_0;
		this.intptr_1 = gstruct.intptr_1;
		long num = (long)this.intptr_0;
		long num2 = (long)this.intptr_1;
		IntPtr intPtr;
		this.method_3(intPtr = GClass840.OpenProcess(5176, false, this.method_0()));
		IntPtr intPtr2 = intPtr;
		GClass840.GStruct2 gstruct2 = default(GClass840.GStruct2);
		if (GClass840.smethod_0(intPtr2))
		{
			num2 = Math.Min(2147483647L, num2);
		}
		this.intptr_1 = (IntPtr)num2;
		int num3 = 0;
		while (num < num2)
		{
			int num4;
			gstruct2 = GClass840.smethod_2(intPtr2, this.intptr_0, out num4);
			if (num4 == 0)
			{
				if (gstruct2.int_1 == 4 && gstruct2.State == 4096)
				{
					this.method_4().Add(gstruct2);
				}
				num += gstruct2.long_0;
				this.intptr_0 = new IntPtr(num);
				num3++;
			}
			else
			{
				if (num3 == 0)
				{
					throw new Win32Exception(num4);
				}
				return true;
			}
		}
		return true;
	}

	public bool method_7(IntPtr intptr_3, byte[] byte_0)
	{
		int num = 0;
		return GClass840.WriteProcessMemory(this.method_2(), intptr_3, byte_0, byte_0.Length, ref num);
	}

	public bool method_8(IntPtr intptr_3, byte[] byte_0, int int_1)
	{
		int num = 0;
		return GClass840.ReadProcessMemory(this.method_2(), intptr_3, byte_0, int_1, ref num);
	}

	[CompilerGenerated]
	private int int_0;

	private IntPtr intptr_0;

	private IntPtr intptr_1;

	[CompilerGenerated]
	private IntPtr intptr_2;

	[CompilerGenerated]
	private List<GClass840.GStruct2> list_0;
}
