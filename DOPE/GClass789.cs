using System;
using System.IO;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;

public class GClass789 : GClass788
{
	public GClass787<GClass791> method_0()
	{
		return (GClass787<GClass791>)this.vmethod_0();
	}

	public GClass789()
	{
		Class13.tMHx78BzgCM8j();
		this.random_0 = new Random();
		base..ctor();
		this.vmethod_1(new GClass787<GClass791>());
	}

	public override void vmethod_2(byte[] byte_0)
	{
		GClass790 gclass = new GClass790(GClass790.smethod_2("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157"), new BigInteger(65537), BigInteger.Zero);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_12(byte_0, memoryStream, 0U, (uint)byte_0.Length);
			byte_0 = memoryStream.ToArray();
		}
		BigInteger value = GClass790.smethod_0(byte_0);
		BigInteger modulus = GClass790.smethod_2("c9059b49d8f86ba0dc564bb627d87226b28cb259e2343c532383cbde7448e3b0b0cf89f03e7b4b6185b40235630af114e0c31b7985f2fe787a6fe081bddcfcfb");
		byte[] byte_ = BigInteger.ModPow(value, this.bigInteger_0, modulus).ToByteArray().Reverse<byte>().ToArray<byte>().Take(16).ToArray<byte>();
		this.method_0().method_0(byte_);
	}

	public override void vmethod_3(DollConfig dollConfig_0, Action action_0)
	{
		GClass791 jwNOHKEZg8RoacT6pGw = GClass798.smethod_0(dollConfig_0);
		this.method_0().vmethod_1(jwNOHKEZg8RoacT6pGw);
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
		BigInteger exponent = GClass790.smethod_0(array);
		BigInteger value = GClass790.smethod_2("34f624e980ce15a5e99c55d2a6220087c0f10917369e2ecc1e8238c7f96cf59ae90e60ca3e7f2076ea968ac95f0b156d5d6a07d833f2c4b390e4b43695161062");
		BigInteger modulus = GClass790.smethod_2("c9059b49d8f86ba0dc564bb627d87226b28cb259e2343c532383cbde7448e3b0b0cf89f03e7b4b6185b40235630af114e0c31b7985f2fe787a6fe081bddcfcfb");
		this.bigInteger_0 = exponent;
		return BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().ToArray<byte>();
	}

	private readonly Random random_0;

	private BigInteger bigInteger_0;
}
