using System;
using System.IO;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;

public class GClass779 : GClass778
{
	public GClass777<GClass781> method_0()
	{
		return (GClass777<GClass781>)this.vmethod_0();
	}

	public GClass779()
	{
		Class8.xDph7tozmh5WD();
		this.random_0 = new Random();
		base..ctor();
		this.vmethod_1(new GClass777<GClass781>());
	}

	public override void vmethod_2(byte[] byte_0)
	{
		GClass780 gclass = new GClass780(GClass780.smethod_2("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157"), new BigInteger(65537), BigInteger.Zero);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_12(byte_0, memoryStream, 0U, (uint)byte_0.Length);
			byte_0 = memoryStream.ToArray();
		}
		BigInteger value = GClass780.smethod_0(byte_0);
		BigInteger modulus = GClass780.smethod_2("977fc15a826833231b431c2742e47b9afe9e3f176f6237f935ebd37bee9917b1f8ebfa31847e549553b1370c260c0f61f73f68999d204eb1633405d28caacf53");
		byte[] byte_ = BigInteger.ModPow(value, this.bigInteger_0, modulus).ToByteArray().Reverse<byte>().ToArray<byte>().Take(16).ToArray<byte>();
		this.method_0().method_0(byte_);
	}

	public override void vmethod_3(DollConfig dollConfig_0, Action action_0)
	{
		GClass781 eKFsudJrrsKBRN26L1K = GClass788.smethod_0(dollConfig_0);
		this.method_0().vmethod_1(eKFsudJrrsKBRN26L1K);
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
		BigInteger exponent = GClass780.smethod_0(array);
		BigInteger value = GClass780.smethod_2("88b16bfc9d286fc09a941c8c74f38d43d196b5ed62abe59d408127cc589f93e022e0c2a5de7ef1c6973391c67977b3c829565b4257e449d5a2d6382acc8797a4");
		BigInteger modulus = GClass780.smethod_2("977fc15a826833231b431c2742e47b9afe9e3f176f6237f935ebd37bee9917b1f8ebfa31847e549553b1370c260c0f61f73f68999d204eb1633405d28caacf53");
		this.bigInteger_0 = exponent;
		return BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().ToArray<byte>();
	}

	private readonly Random random_0;

	private BigInteger bigInteger_0;
}
