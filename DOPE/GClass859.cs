using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;

public class GClass859 : GClass858
{
	[CompilerGenerated]
	public GClass866 method_0()
	{
		return this.CuwwwlBrwbH;
	}

	[CompilerGenerated]
	private void method_1(GClass866 gclass866_1)
	{
		this.CuwwwlBrwbH = gclass866_1;
	}

	[CompilerGenerated]
	public GClass866 method_2()
	{
		return this.gclass866_0;
	}

	[CompilerGenerated]
	private void method_3(GClass866 gclass866_1)
	{
		this.gclass866_0 = gclass866_1;
	}

	public override void imethod_2()
	{
	}

	public override void imethod_1(byte[] byte_0, int int_0, int int_1)
	{
		byte[] array = new byte[int_1];
		byte[] array2 = new byte[int_1];
		Buffer.BlockCopy(byte_0, int_0, array, 0, int_1);
		using (MemoryStream memoryStream = new MemoryStream(array))
		{
			using (MemoryStream memoryStream2 = new MemoryStream(array2))
			{
				ByteArray byteArray_ = new ByteArray(memoryStream);
				ByteArray byteArray_2 = new ByteArray(memoryStream2);
				this.method_2().vmethod_0(byteArray_, byteArray_2);
				Buffer.BlockCopy(array2, 0, byte_0, int_0, int_1);
			}
		}
	}

	public override void imethod_0(byte[] byte_0, int int_0, int int_1)
	{
		byte[] array = new byte[int_1];
		byte[] array2 = new byte[int_1];
		Buffer.BlockCopy(byte_0, int_0, array, 0, int_1);
		using (MemoryStream memoryStream = new MemoryStream(array))
		{
			using (MemoryStream memoryStream2 = new MemoryStream(array2))
			{
				ByteArray byteArray_ = new ByteArray(memoryStream);
				ByteArray byteArray_2 = new ByteArray(memoryStream2);
				this.method_0().vmethod_0(byteArray_, byteArray_2);
				Buffer.BlockCopy(array2, 0, byte_0, int_0, int_1);
			}
		}
	}

	public override void Init(List<byte[]> list_0)
	{
		if (list_0.Count != 2)
		{
			throw new Exception();
		}
		ByteArray byteArray = new ByteArray(list_0[0]);
		ByteArray byteArray2 = new ByteArray(list_0[1]);
		this.method_1(new GClass866(new ByteArray(byteArray), new ByteArray(byteArray2)));
		this.method_3(new GClass866(byteArray, byteArray2));
	}

	public GClass859()
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
	}

	[CompilerGenerated]
	private GClass866 CuwwwlBrwbH;

	[CompilerGenerated]
	private GClass866 gclass866_0;
}
