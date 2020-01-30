using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

public class GClass791
{
	[CompilerGenerated]
	public BigInteger method_0()
	{
		return this.bigInteger_0;
	}

	[CompilerGenerated]
	public void method_1(BigInteger bigInteger_3)
	{
		this.bigInteger_0 = bigInteger_3;
	}

	[CompilerGenerated]
	public BigInteger method_2()
	{
		return this.bigInteger_1;
	}

	[CompilerGenerated]
	public void method_3(BigInteger bigInteger_3)
	{
		this.bigInteger_1 = bigInteger_3;
	}

	[CompilerGenerated]
	public BigInteger method_4()
	{
		return this.bigInteger_2;
	}

	[CompilerGenerated]
	public void method_5(BigInteger bigInteger_3)
	{
		this.bigInteger_2 = bigInteger_3;
	}

	public static BigInteger smethod_0(byte[] byte_0)
	{
		byte[] array = (byte[])byte_0.Clone();
		Array.Reverse(array);
		int num = (array[array.Length - 1] == 0) ? 0 : 1;
		byte[] array2 = new byte[array.Length + num];
		Array.Copy(array, array2, array.Length);
		return new BigInteger(array2);
	}

	public static byte[] smethod_1(string string_0)
	{
		if (string_0.Length % 2 != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", string_0));
		}
		byte[] array = new byte[string_0.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			string s = string_0.Substring(i * 2, 2);
			array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return array;
	}

	public static BigInteger smethod_2(string string_0)
	{
		return GClass791.smethod_0(GClass791.smethod_1(string_0));
	}

	public GClass791(BigInteger bigInteger_3, BigInteger bigInteger_4, BigInteger bigInteger_5)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.method_1(bigInteger_3);
		this.method_3(bigInteger_4);
		this.method_5(bigInteger_5);
	}

	protected BigInteger method_6(BigInteger bigInteger_3)
	{
		return BigInteger.ModPow(bigInteger_3, this.method_2(), this.method_0());
	}

	protected BigInteger method_7(BigInteger bigInteger_3)
	{
		return BigInteger.ModPow(bigInteger_3, this.method_4(), this.method_0());
	}

	private void method_8(Func<BigInteger, BigInteger> func_0, byte[] byte_0, Stream stream_0, uint uint_0, uint uint_1)
	{
		Func<BigInteger, uint, byte[]> func = new Func<BigInteger, uint, byte[]>(this.method_14);
		uint arg = (uint)this.method_13();
		uint num = uint_0 + uint_1;
		for (uint num2 = uint_0; num2 < num; num2 += uint_1)
		{
			BigInteger arg2 = GClass791.smethod_0(byte_0.Skip((int)uint_0).Take((int)uint_1).ToArray<byte>());
			BigInteger arg3 = func_0(arg2);
			byte[] array = func(arg3, arg).ToArray<byte>();
			stream_0.Write(array, 0, array.Length);
		}
	}

	private void method_9(Func<BigInteger, BigInteger> func_0, byte[] byte_0, Stream stream_0, uint uint_0, uint uint_1)
	{
		uint num = (uint)this.method_13();
		uint num2 = uint_0 + uint_1;
		for (uint num3 = uint_0; num3 < num2; num3 += num)
		{
			BigInteger arg = GClass791.smethod_0(this.method_10(byte_0, (int)num2, (int)num, (int)num3));
			byte[] array = func_0(arg).ToByteArray();
			for (int i = (int)(num - 1U); i >= 0; i--)
			{
				stream_0.WriteByte(array[i]);
			}
		}
	}

	private byte[] method_10(byte[] byte_0, int int_0, int int_1, int int_2)
	{
		byte[] array = new byte[int_1];
		int_0 = Math.Min(int_0, Math.Min(byte_0.Length, int_2 + int_1 - 11));
		int num = int_0 - 1;
		while (num >= int_2 && int_1 > 11)
		{
			array[--int_1] = byte_0[num--];
		}
		array[--int_1] = 0;
		while (int_1 > 2)
		{
			byte b;
			for (b = 0; b == 0; b = byte.MaxValue)
			{
			}
			array[--int_1] = b;
		}
		array[--int_1] = 1;
		array[--int_1] = 0;
		return array;
	}

	public void method_11(byte[] byte_0, Stream stream_0, uint uint_0, uint uint_1)
	{
		this.method_9(new Func<BigInteger, BigInteger>(this.method_7), byte_0, stream_0, uint_0, uint_1);
	}

	public void method_12(byte[] byte_0, Stream stream_0, uint uint_0, uint uint_1)
	{
		this.method_8(new Func<BigInteger, BigInteger>(this.method_6), byte_0, stream_0, uint_0, uint_1);
	}

	public int method_13()
	{
		return this.method_0().ToByteArray().Reverse<byte>().SkipWhile(new Func<byte, bool>(GClass791.<>c.<>c_0.method_0)).Count<byte>();
	}

	protected byte[] method_14(BigInteger bigInteger_3, uint uint_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = 0;
		byte[] array = bigInteger_3.ToByteArray().Reverse<byte>().ToArray<byte>();
		while (num < array.Length && array[num] == 0)
		{
			num++;
		}
		if ((long)(array.Length - num) == (long)((ulong)(uint_0 - 1U)) && array[num] <= 2)
		{
			num++;
			while (array[num] != 0)
			{
				if (++num >= array.Length)
				{
					throw new InvalidOperationException();
				}
			}
			while (++num < array.Length)
			{
				memoryStream.WriteByte(array[num]);
			}
			memoryStream.Position = 0L;
			return memoryStream.ToArray();
		}
		throw new InvalidOperationException();
	}

	[CompilerGenerated]
	private BigInteger bigInteger_0;

	[CompilerGenerated]
	private BigInteger bigInteger_1;

	[CompilerGenerated]
	private BigInteger bigInteger_2;
}
