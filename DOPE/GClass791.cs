using System;
using System.IO;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;

public class GClass791 : GClass790
{
	public GClass789<GClass793> method_0()
	{
		return (GClass789<GClass793>)this.vmethod_0();
	}

	public GClass791()
	{
		Class13.igxcIukzfpare();
		this.random_0 = new Random();
		base..ctor();
		this.vmethod_1(new GClass789<GClass793>());
	}

	public override void vmethod_2(byte[] byte_0)
	{
		GClass792 gclass = new GClass792(GClass792.smethod_2("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157"), new BigInteger(65537), BigInteger.Zero);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_12(byte_0, memoryStream, 0U, (uint)byte_0.Length);
			byte_0 = memoryStream.ToArray();
		}
		BigInteger value = GClass792.smethod_0(byte_0);
		BigInteger modulus = GClass792.smethod_2("f4db1a8eef1f84dd06b889e6f2078c96a96b2dda6c79d1a2a28e5c9e196e3977303519266977fa527ce37dc41f9164cc3bf569f583b1297fcafc7be92cf0be6d");
		byte[] byte_ = BigInteger.ModPow(value, this.bigInteger_0, modulus).ToByteArray().Reverse<byte>().ToArray<byte>().Take(16).ToArray<byte>();
		this.method_0().method_0(byte_);
	}

	public override void vmethod_3(DollConfig dollConfig_0, Action action_0)
	{
		GClass793 meIr9DB4lDEaS0WTWUX = GClass800.smethod_0(dollConfig_0);
		this.method_0().vmethod_1(meIr9DB4lDEaS0WTWUX);
		if (action_0 != null)
		{
			action_0();
		}
	}

	public override byte[] vmethod_4()
	{
		byte[] array = new byte[64];
		array[0] = 87;
		for (int i = 1; i < 64; i++)
		{
			array[i] = (byte)this.random_0.Next(1, 256);
		}
		BigInteger exponent = GClass792.smethod_0(array);
		BigInteger value = GClass792.smethod_2("4539d8b1a1fd8a705804d533d8fa7317a25c0824ad545d5bad76f45865d24ca4e19778eb5ed50f3e1ed0951f8ebc90cb5fab6ea0e8772fc2012ccd990974f0ff");
		BigInteger modulus = GClass792.smethod_2("f4db1a8eef1f84dd06b889e6f2078c96a96b2dda6c79d1a2a28e5c9e196e3977303519266977fa527ce37dc41f9164cc3bf569f583b1297fcafc7be92cf0be6d");
		this.bigInteger_0 = exponent;
		return BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().ToArray<byte>();
	}

	private readonly Random random_0;

	private BigInteger bigInteger_0;
}
