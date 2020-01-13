using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class GClass124 : GInterface6
{
	public GClass124()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}

	public GClass124(TcpClient tcpClient_2)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (tcpClient_2 == null)
		{
			throw new ArgumentNullException("tcpClient");
		}
		this.tcpClient_1 = tcpClient_2;
	}

	public GClass124(string string_3)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("proxyHost");
		}
		this.string_0 = string_3;
		this.int_0 = 1080;
	}

	public GClass124(string string_3, int int_1)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("proxyHost");
		}
		if (int_1 <= 0 || int_1 > 65535)
		{
			throw new ArgumentOutOfRangeException("proxyPort", "port must be greater than zero and less than 65535");
		}
		this.string_0 = string_3;
		this.int_0 = int_1;
	}

	public GClass124(string string_3, string string_4, string string_5)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("proxyHost");
		}
		if (string_4 == null)
		{
			throw new ArgumentNullException("proxyUserName");
		}
		if (string_5 == null)
		{
			throw new ArgumentNullException("proxyPassword");
		}
		this.string_0 = string_3;
		this.int_0 = 1080;
		this.string_1 = string_4;
		this.string_2 = string_5;
	}

	public GClass124(string string_3, int int_1, string string_4, string string_5)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("proxyHost");
		}
		if (int_1 <= 0 || int_1 > 65535)
		{
			throw new ArgumentOutOfRangeException("proxyPort", "port must be greater than zero and less than 65535");
		}
		this.string_0 = string_3;
		this.int_0 = int_1;
		this.string_1 = string_4;
		this.string_2 = string_5;
	}

	public string imethod_0()
	{
		return this.string_0;
	}

	public void imethod_1(string string_3)
	{
		this.string_0 = string_3;
	}

	public int imethod_2()
	{
		return this.int_0;
	}

	public void imethod_3(int int_1)
	{
		this.int_0 = int_1;
	}

	public string hfoPmbYmhj9()
	{
		return "SOCKS5";
	}

	public string method_0()
	{
		return this.string_1;
	}

	public void method_1(string string_3)
	{
		this.string_1 = string_3;
	}

	public string method_2()
	{
		return this.string_2;
	}

	public void method_3(string string_3)
	{
		this.string_2 = string_3;
	}

	public TcpClient imethod_4()
	{
		return this.tcpClient_1;
	}

	public void imethod_5(TcpClient tcpClient_2)
	{
		this.tcpClient_1 = tcpClient_2;
	}

	public TcpClient imethod_6(string string_3, int int_1)
	{
		if (string.IsNullOrEmpty(string_3))
		{
			throw new ArgumentNullException("destinationHost");
		}
		if (int_1 > 0 && int_1 <= 65535)
		{
			try
			{
				if (this.tcpClient_1 == null)
				{
					if (string.IsNullOrEmpty(this.string_0))
					{
						throw new GException0("ProxyHost property must contain a value.");
					}
					if (this.int_0 <= 0 || this.int_0 > 65535)
					{
						throw new GException0("ProxyPort value must be greater than zero and less than 65535");
					}
					this.tcpClient_0 = new TcpClient();
					this.tcpClient_0.Connect(this.string_0, this.int_0);
				}
				else
				{
					this.tcpClient_0 = this.tcpClient_1;
				}
				this.method_4();
				this.method_5();
				this.method_9(1, string_3, int_1);
				TcpClient result = this.tcpClient_0;
				this.tcpClient_0 = null;
				return result;
			}
			catch (Exception exception_)
			{
				throw new GException0(string.Format(CultureInfo.InvariantCulture, "Connection to proxy failed.", Array.Empty<object>()), exception_);
			}
		}
		throw new ArgumentOutOfRangeException("destinationPort", "port must be greater than zero and less than 65535");
	}

	private void method_4()
	{
		if (this.string_1 != null && this.string_2 != null)
		{
			this.enum2_0 = (GClass124.Enum2)1;
			return;
		}
		this.enum2_0 = GClass124.Enum2.None;
	}

	private void method_5()
	{
		NetworkStream stream = this.tcpClient_0.GetStream();
		byte[] array = new byte[]
		{
			5,
			2,
			0,
			2
		};
		stream.Write(array, 0, array.Length);
		byte[] array2 = new byte[2];
		stream.Read(array2, 0, array2.Length);
		byte b = array2[1];
		if (b == 255)
		{
			this.tcpClient_0.Close();
			throw new GException0("The proxy destination does not accept the supported proxy client authentication methods.");
		}
		if (b == 2 && this.enum2_0 == GClass124.Enum2.None)
		{
			this.tcpClient_0.Close();
			throw new GException0("The proxy destination requires a username and password for authentication.  If you received this error attempting to connect to the Tor network provide an string empty value for ProxyUserName and ProxyPassword.");
		}
		if (b == 2)
		{
			byte[] array3 = new byte[this.string_1.Length + this.string_2.Length + 3];
			array3[0] = 1;
			array3[1] = (byte)this.string_1.Length;
			Array.Copy(Encoding.ASCII.GetBytes(this.string_1), 0, array3, 2, this.string_1.Length);
			array3[this.string_1.Length + 2] = (byte)this.string_2.Length;
			Array.Copy(Encoding.ASCII.GetBytes(this.string_2), 0, array3, this.string_1.Length + 3, this.string_2.Length);
			stream.Write(array3, 0, array3.Length);
			byte[] array4 = new byte[2];
			stream.Read(array4, 0, array4.Length);
			if (array4[1] != 0)
			{
				this.tcpClient_0.Close();
				throw new GException0("Proxy authentification failure!  The proxy server has reported that the userid and/or password is not valid.");
			}
		}
	}

	private byte method_6(string string_3)
	{
		IPAddress ipaddress = null;
		if (!IPAddress.TryParse(string_3, out ipaddress))
		{
			return 3;
		}
		AddressFamily addressFamily = ipaddress.AddressFamily;
		if (addressFamily == AddressFamily.InterNetwork)
		{
			return 1;
		}
		if (addressFamily != AddressFamily.InterNetworkV6)
		{
			throw new GException0(string.Format(CultureInfo.InvariantCulture, "The host addess {0} of type '{1}' is not a supported address type.  The supported types are InterNetwork and InterNetworkV6.", string_3, Enum.GetName(typeof(AddressFamily), ipaddress.AddressFamily)));
		}
		return 4;
	}

	private byte[] method_7(byte byte_0, string string_3)
	{
		switch (byte_0)
		{
		case 1:
		case 4:
			return IPAddress.Parse(string_3).GetAddressBytes();
		default:
			return null;
		case 3:
		{
			byte[] array = new byte[string_3.Length + 1];
			array[0] = Convert.ToByte(string_3.Length);
			Encoding.ASCII.GetBytes(string_3).CopyTo(array, 1);
			return array;
		}
		}
	}

	private byte[] method_8(int int_1)
	{
		return new byte[]
		{
			Convert.ToByte(int_1 / 256),
			Convert.ToByte(int_1 % 256)
		};
	}

	private void method_9(byte byte_0, string string_3, int int_1)
	{
		NetworkStream stream = this.tcpClient_0.GetStream();
		byte b = this.method_6(string_3);
		byte[] array = this.method_7(b, string_3);
		Array array2 = this.method_8(int_1);
		byte[] array3 = new byte[4 + array.Length + 2];
		array3[0] = 5;
		array3[1] = byte_0;
		array3[2] = 0;
		array3[3] = b;
		array.CopyTo(array3, 4);
		array2.CopyTo(array3, 4 + array.Length);
		stream.Write(array3, 0, array3.Length);
		byte[] array4 = new byte[255];
		stream.Read(array4, 0, array4.Length);
		if (array4[1] != 0)
		{
			this.method_10(array4, string_3, int_1);
		}
	}

	private void method_10(byte[] byte_0, string string_3, int int_1)
	{
		byte b = byte_0[1];
		switch (byte_0[3])
		{
		case 1:
		{
			byte[] array = new byte[4];
			for (int i = 0; i < 4; i++)
			{
				array[i] = byte_0[i + 4];
			}
			new IPAddress(array).ToString();
			BitConverter.ToInt16(new byte[]
			{
				byte_0[9],
				byte_0[8]
			}, 0);
			break;
		}
		case 3:
		{
			int num = Convert.ToInt32(byte_0[4]);
			byte[] array2 = new byte[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = byte_0[j + 5];
			}
			Encoding.ASCII.GetString(array2);
			BitConverter.ToInt16(new byte[]
			{
				byte_0[6 + num],
				byte_0[5 + num]
			}, 0);
			break;
		}
		case 4:
		{
			byte[] array3 = new byte[16];
			for (int k = 0; k < 16; k++)
			{
				array3[k] = byte_0[k + 4];
			}
			new IPAddress(array3).ToString();
			BitConverter.ToInt16(new byte[]
			{
				byte_0[21],
				byte_0[20]
			}, 0);
			break;
		}
		}
		string text;
		switch (b)
		{
		case 1:
			text = "a general socks destination failure occurred";
			break;
		case 2:
			text = "the connection is not allowed by proxy destination rule set";
			break;
		case 3:
			text = "the network was unreachable";
			break;
		case 4:
			text = "the host was unreachable";
			break;
		case 5:
			text = "the connection was refused by the remote network";
			break;
		case 6:
			text = "the time to live (TTL) has expired";
			break;
		case 7:
			text = "the command issued by the proxy client is not supported by the proxy destination";
			break;
		case 8:
			text = "the address type specified is not supported";
			break;
		default:
			text = string.Format(CultureInfo.InvariantCulture, "an unknown SOCKS reply with the code value '{0}' was received", b.ToString(CultureInfo.InvariantCulture));
			break;
		}
		string text2 = (byte_0 != null) ? GClass124.smethod_0(byte_0) : "";
		throw new GException0(string.Format(CultureInfo.InvariantCulture, "proxy error: {0} for destination host {1} port number {2}.  Server response (hex): {3}.", new object[]
		{
			text,
			string_3,
			int_1,
			text2
		}));
	}

	public static string smethod_0(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		return GClass124.smethod_3(byte_0, false, byte_0.Length);
	}

	public static string smethod_1(byte byte_0)
	{
		byte[] array = new byte[]
		{
			byte_0
		};
		return GClass124.smethod_3(array, false, array.Length);
	}

	public static string smethod_2(byte[] byte_0, bool bool_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		return GClass124.smethod_3(byte_0, bool_0, byte_0.Length);
	}

	public static string smethod_3(byte[] byte_0, bool bool_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("data");
		}
		StringBuilder stringBuilder = new StringBuilder(int_1 * 2);
		int num = byte_0.Length;
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append(byte_0[i].ToString("x").PadLeft(2, '0'));
			if (bool_0 && i < num - 1)
			{
				stringBuilder.Append(':');
			}
		}
		return stringBuilder.ToString();
	}

	private string string_0;

	private int int_0;

	private string string_1;

	private string string_2;

	private GClass124.Enum2 enum2_0;

	private TcpClient tcpClient_0;

	private TcpClient tcpClient_1;

	private enum Enum2
	{
		None
	}
}
