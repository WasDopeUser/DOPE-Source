using System;
using System.Numerics;
using System.Security.Cryptography;

namespace DarkorbitAPI.CommonStructures
{
	public static class GClass815
	{
		public static byte[] smethod_0(this RSACryptoServiceProvider rsacryptoServiceProvider_0, byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("data");
			}
			if (rsacryptoServiceProvider_0.PublicOnly)
			{
				throw new InvalidOperationException("Private key is not loaded");
			}
			int num = rsacryptoServiceProvider_0.KeySize / 8 - 6;
			if (byte_0.Length > num)
			{
				throw new ArgumentOutOfRangeException("data", string.Format("Maximum data length for the current key size ({0} bits) is {1} bytes (current length: {2} bytes)", rsacryptoServiceProvider_0.KeySize, num, byte_0.Length));
			}
			BigInteger value = GClass815.smethod_2(GClass815.smethod_3(byte_0));
			RSAParameters rsaparameters = rsacryptoServiceProvider_0.ExportParameters(true);
			BigInteger exponent = GClass815.smethod_2(rsaparameters.D);
			BigInteger modulus = GClass815.smethod_2(rsaparameters.Modulus);
			return BigInteger.ModPow(value, exponent, modulus).ToByteArray();
		}

		public static byte[] smethod_1(this RSACryptoServiceProvider rsacryptoServiceProvider_0, byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("cipherData");
			}
			BigInteger value = new BigInteger(byte_0);
			RSAParameters rsaparameters = rsacryptoServiceProvider_0.ExportParameters(false);
			BigInteger exponent = GClass815.smethod_2(rsaparameters.Exponent);
			BigInteger modulus = GClass815.smethod_2(rsaparameters.Modulus);
			byte[] array = BigInteger.ModPow(value, exponent, modulus).ToByteArray();
			byte[] array2 = new byte[array.Length - 1];
			Array.Copy(array, array2, array2.Length);
			array2 = GClass815.smethod_4(array2);
			Array.Reverse(array2);
			return array2;
		}

		private static BigInteger smethod_2(byte[] byte_0)
		{
			byte[] array = (byte[])byte_0.Clone();
			Array.Reverse(array);
			byte[] array2 = new byte[array.Length + 1];
			Array.Copy(array, array2, array.Length);
			return new BigInteger(array2);
		}

		private static byte[] smethod_3(byte[] byte_0)
		{
			Random random = new Random();
			byte[] array = new byte[4];
			random.NextBytes(array);
			array[0] = (array[0] | 128);
			byte[] array2 = new byte[byte_0.Length + 4];
			Array.Copy(array, array2, 4);
			Array.Copy(byte_0, 0, array2, 4, byte_0.Length);
			return array2;
		}

		private static byte[] smethod_4(byte[] byte_0)
		{
			byte[] array = new byte[byte_0.Length - 4];
			Array.Copy(byte_0, array, array.Length);
			return array;
		}
	}
}
