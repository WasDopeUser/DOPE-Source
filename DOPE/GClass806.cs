using System;
using System.IO;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;

public class GClass806 : GClass805
{
	public GClass804<GClass808> method_0()
	{
		return (GClass804<GClass808>)this.vmethod_0();
	}

	public GClass806()
	{
		Class13.NP5bWyNzLwONS();
		this.random_0 = new Random();
		base..ctor();
		this.vmethod_1(new GClass804<GClass808>());
	}

	public override void vmethod_2(byte[] byte_0)
	{
		GClass807 gclass = new GClass807(GClass807.smethod_2("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157"), new BigInteger(65537), BigInteger.Zero);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_12(byte_0, memoryStream, 0U, (uint)byte_0.Length);
			byte_0 = memoryStream.ToArray();
		}
		BigInteger value = GClass807.smethod_0(byte_0);
		BigInteger modulus = GClass807.smethod_2("999d6c44ffd30467cd7e8bc70e095a8d08fb8fbfeee536fdfb2d43f99005ee3f6b529b4411395a56651422f449eb9ea3f7d48d8c443c06bd1387afe489a7c6c1");
		byte[] byte_ = BigInteger.ModPow(value, this.bigInteger_0, modulus).ToByteArray().Reverse<byte>().ToArray<byte>().Take(16).ToArray<byte>();
		this.method_0().method_0(byte_);
	}

	public override void vmethod_3(DollConfig dollConfig_0, Action action_0)
	{
		GClass808 i1JMkOw41TUC9YiQVej = GClass815.smethod_0(dollConfig_0);
		this.method_0().vmethod_1(i1JMkOw41TUC9YiQVej);
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
		BigInteger exponent = GClass807.smethod_0(array);
		BigInteger value = GClass807.smethod_2("4bf022d9780125620d16442953c60a4a97874e263c099e613eed290247240829d74fc0a31d84b686699a55651a1285f7cbcc936153a8c942e3d3a4c864832ad1");
		BigInteger modulus = GClass807.smethod_2("999d6c44ffd30467cd7e8bc70e095a8d08fb8fbfeee536fdfb2d43f99005ee3f6b529b4411395a56651422f449eb9ea3f7d48d8c443c06bd1387afe489a7c6c1");
		this.bigInteger_0 = exponent;
		return BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().ToArray<byte>();
	}

	private readonly Random random_0;

	private BigInteger bigInteger_0;
}
