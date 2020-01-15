using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GClass860
{
	[CompilerGenerated]
	public int[] method_0()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	private void method_1(int[] int_1)
	{
		this.int_0 = int_1;
	}

	[CompilerGenerated]
	public byte[] method_2()
	{
		return this.byte_0;
	}

	[CompilerGenerated]
	private void method_3(byte[] byte_1)
	{
		this.byte_0 = byte_1;
	}

	private void Fill(byte[] s, int[] k)
	{
		int i = 0;
		for (int j = 1; j < s.Length; j++)
		{
			while (i > 0)
			{
				if (s[j] == s[i])
				{
					break;
				}
				i = k[i - 1];
			}
			if (s[j] == s[i])
			{
				i++;
			}
			k[j] = i;
		}
	}

	public IEnumerable<int> method_4(byte[] byte_1)
	{
		GClass860.<Match>d__9 <Match>d__ = new GClass860.<Match>d__9(-2);
		<Match>d__.<>4__this = this;
		<Match>d__.<>3__q = byte_1;
		return <Match>d__;
	}

	public GClass860(byte[] byte_1)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.method_3(byte_1);
		this.method_1(new int[byte_1.Length]);
		this.Fill(byte_1, this.method_0());
	}

	[CompilerGenerated]
	private int[] int_0;

	[CompilerGenerated]
	private byte[] byte_0;
}
