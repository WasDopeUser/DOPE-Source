using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

public static class GClass785
{
	static GClass785()
	{
		Class13.igxcIukzfpare();
		GClass785.httpClient_0 = new HttpClient();
		GClass785.httpClient_0.DefaultRequestHeaders.ConnectionClose = new bool?(true);
	}

	public static bool smethod_0(int int_0, int int_1, string string_0, out DateTimeOffset dateTimeOffset_0, out GClass785.GEnum9 genum9_0, string string_1 = "basic")
	{
		genum9_0 = GClass785.GEnum9.Unknown;
		dateTimeOffset_0 = DateTimeOffset.MaxValue;
		bool result3;
		try
		{
			bool is64BitProcess = Environment.Is64BitProcess;
			string text = string.Format("{0}", DateTime.Now.Ticks);
			HttpResponseMessage result = GClass785.httpClient_0.PostAsync(string.Format("https://powerofdark.space/license/verify/{0}/", string_1), new FormUrlEncodedContent(new Dictionary<string, string>
			{
				{
					"ServerId",
					string.Format("{0}", int_0)
				},
				{
					"UserId",
					string.Format("{0}", int_1)
				},
				{
					"x64",
					is64BitProcess.ToString() ?? ""
				},
				{
					"Token",
					text
				},
				{
					"Key",
					string_0
				},
				{
					"Extra",
					"v2"
				}
			})).Result;
			IEnumerable<string> source;
			if (result.Headers.TryGetValues("X-Signature", out source) && result.IsSuccessStatusCode)
			{
				string result2 = result.Content.ReadAsStringAsync().Result;
				byte[] byte_ = GClass792.smethod_1(source.First<string>());
				Dictionary<string, string> dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(result2);
				byte[] byte_2 = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(result2));
				if (dictionary["Token"] != text)
				{
					result3 = false;
				}
				else if (!GClass785.UhYsxDjCgl(byte_2, byte_))
				{
					result3 = false;
				}
				else
				{
					genum9_0 = (GClass785.GEnum9)int.Parse(dictionary["LicenseState"]);
					result3 = (genum9_0 == (GClass785.GEnum9)1);
				}
			}
			else
			{
				result3 = false;
			}
		}
		catch
		{
			result3 = false;
		}
		return result3;
	}

	private static bool UhYsxDjCgl(byte[] byte_0, byte[] byte_1)
	{
		bool result;
		using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider())
		{
			RSAParameters parameters = new RSAParameters
			{
				Exponent = new byte[]
				{
					1,
					0,
					1
				}
			};
			parameters.Modulus = GClass792.smethod_1("b8b8d2efed5992f8b89285b2367bfcdb28d1b781b7b852af87221c0db9ecb1bc4f1ad601b9bb931647f48aa9a91467334ddca081beecd915775ba38da95bff4d50b1ff5790d3c5a6f024688185e59362722570520f646e2c6dab3af3b2b736c585c49231f6300051a5238d3d80ea6653e4ecb3904dea8c364fe1936df9629a26db9a30f538cdd61414b6112df43038f66c73df802990f341d34fadeb447918c695748b0eac9f55d3ece99868506f616861e897cd062cae57b2e3ae1737adb4b9042e2902453c4a5946029fe53928f19fe7c9928f990a4e6ee01105a1d300e2aabab995b3dd7333e9564e9212938a6422a5e706710fce47ca78f3e62168faaea9");
			rsacryptoServiceProvider.ImportParameters(parameters);
			result = rsacryptoServiceProvider.VerifyHash(byte_0, byte_1, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
		}
		return result;
	}

	public static readonly HttpClient httpClient_0;

	public enum GEnum9
	{
		Unknown
	}
}
