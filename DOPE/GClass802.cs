using System;

public class GClass802
{
	public GClass802(byte[] byte_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = 0;
		this.int_0 = 0;
		if (byte_0 != null)
		{
			this.method_0(byte_0);
		}
	}

	public void method_0(byte[] byte_0)
	{
		this.State = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			this.State[i] = (byte)i;
		}
		int num = 0;
		i = 0;
		int num2 = num;
		while (i < 256)
		{
			num2 = (num2 + (int)this.State[i] + (int)byte_0[i % byte_0.Length] & 255);
			int num3 = (int)this.State[i];
			this.State[i] = this.State[num2];
			this.State[num2] = (byte)(num3 & 255);
			i++;
		}
		this.int_1 = 0;
		this.int_0 = 0;
	}

	public uint method_1()
	{
		this.int_0 = (this.int_0 + 1 & 255);
		this.int_1 = (this.int_1 + (int)this.State[this.int_0] & 255);
		int num = (int)this.State[this.int_0];
		this.State[this.int_0] = this.State[this.int_1];
		this.State[this.int_1] = (byte)(num & 255);
		return (uint)this.State[num + (int)this.State[this.int_0] & 255];
	}

	public void method_2(byte[] byte_0, int int_2, int int_3)
	{
		if (this.State == null)
		{
			return;
		}
		uint num = 0U;
		while ((ulong)num < (ulong)((long)int_3))
		{
			byte_0[(int)(checked((IntPtr)(unchecked((ulong)num + (ulong)((long)int_2)))))] = (byte)(((uint)byte_0[(int)(checked((IntPtr)(unchecked((ulong)num + (ulong)((long)int_2)))))] ^ this.method_1()) & 255U);
			num += 1U;
		}
	}

	public byte[] State;

	public int int_0;

	public int int_1;
}
