using System;
using System.IO;
using System.Linq;
using System.Numerics;
using DarkorbitAPI.CommonStructures;

public class GClass855 : GClass854
{
	public GClass853<GClass859> method_0()
	{
		return (GClass853<GClass859>)this.vmethod_0();
	}

	public GClass855()
	{
		Class13.lOBHd9Nzn7x2T();
		this.random_0 = new Random();
		base..ctor();
		this.vmethod_1(new GClass853<GClass859>());
	}

	public override void vmethod_2(byte[] byte_0)
	{
		GClass858 gclass = new GClass858(GClass858.smethod_2("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157"), new BigInteger(65537), BigInteger.Zero);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_12(byte_0, memoryStream, 0U, (uint)byte_0.Length);
			byte_0 = memoryStream.ToArray();
		}
		BigInteger value = GClass858.smethod_0(byte_0);
		BigInteger modulus = GClass858.smethod_2("f0550ebfc21e0672738bdbe1aa5c8d4429b198803080e82cfcfef856fea9034b07fc92b787604f4ba375afee98fa61332cc1396694dcad4306a13bb86fe53f89");
		byte[] byte_ = BigInteger.ModPow(value, this.bigInteger_0, modulus).ToByteArray().Reverse<byte>().ToArray<byte>().Take(16).ToArray<byte>();
		this.method_0().method_0(byte_);
	}

	public override void vmethod_3(DollConfig dollConfig_0, Action action_0)
	{
		GClass859 dj305OTR3fqbj8iFe = GClass866.smethod_0(dollConfig_0);
		this.method_0().vmethod_1(dj305OTR3fqbj8iFe);
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
		BigInteger exponent = GClass858.smethod_0(array);
		BigInteger value = GClass858.smethod_2("3ba3fbfbbd62e5157c285ec65e4fd155039290adca28e46ba0f402c4dafdfa16fcfe26fb8e448fd3af608e4097c9d6a89f0a91b72c6166af77d1e46b139e7ff2");
		BigInteger modulus = GClass858.smethod_2("f0550ebfc21e0672738bdbe1aa5c8d4429b198803080e82cfcfef856fea9034b07fc92b787604f4ba375afee98fa61332cc1396694dcad4306a13bb86fe53f89");
		this.bigInteger_0 = exponent;
		return BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().ToArray<byte>();
	}

	private readonly Random random_0;

	private BigInteger bigInteger_0;
}
