using System;
using System.IO;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;

public class GClass790 : GClass789
{
	public GClass788<GClass792> method_0()
	{
		return (GClass788<GClass792>)this.vmethod_0();
	}

	public GClass790()
	{
		Class13.Gj4N3WdzaR1LY();
		this.random_0 = new Random();
		base..ctor();
		this.vmethod_1(new GClass788<GClass792>());
	}

	public override void vmethod_2(byte[] byte_0)
	{
		GClass791 gclass = new GClass791(GClass791.smethod_2("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157"), new BigInteger(65537), BigInteger.Zero);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_12(byte_0, memoryStream, 0U, (uint)byte_0.Length);
			byte_0 = memoryStream.ToArray();
		}
		BigInteger value = GClass791.smethod_0(byte_0);
		BigInteger modulus = GClass791.smethod_2("9cce462cfbf3984cc160c90f73c767bf94f0e41b2dfcc88a981ecc8089075077916e71507dad5272f41ac83ebb73eb78cad7cf381ebd2a2170211564ba05d8af");
		byte[] byte_ = BigInteger.ModPow(value, this.bigInteger_0, modulus).ToByteArray().Reverse<byte>().ToArray<byte>().Take(16).ToArray<byte>();
		this.method_0().method_0(byte_);
	}

	public override void vmethod_3(DollConfig dollConfig_0, Action action_0)
	{
		GClass792 tqjt5uNlFvvN2gjI5rB = GClass799.smethod_0(dollConfig_0);
		this.method_0().vmethod_1(tqjt5uNlFvvN2gjI5rB);
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
		BigInteger exponent = GClass791.smethod_0(array);
		BigInteger value = GClass791.smethod_2("8abb0fba15a87dcf63686b96a362824eb85283942aa5b42e971543063a03e6f389bf3abcf4b4eb85430a699e0f3969e60dec9819bc81cc3ac905fbc8a90eb46b");
		BigInteger modulus = GClass791.smethod_2("9cce462cfbf3984cc160c90f73c767bf94f0e41b2dfcc88a981ecc8089075077916e71507dad5272f41ac83ebb73eb78cad7cf381ebd2a2170211564ba05d8af");
		this.bigInteger_0 = exponent;
		return BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().ToArray<byte>();
	}

	private readonly Random random_0;

	private BigInteger bigInteger_0;
}
