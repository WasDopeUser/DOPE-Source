using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DarkorbitAPI.CommonStructures;

public class GClass123 : IWebProxy
{
	public ICredentials Credentials { get; set; }

	public Uri GetProxy(Uri destination)
	{
		return this.uri_0;
	}

	public bool IsBypassed(Uri host)
	{
		return false;
	}

	[CompilerGenerated]
	public int method_0()
	{
		return this.int_0;
	}

	[CompilerGenerated]
	private void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	private GClass123.Class1 VeWpTaQsRm()
	{
		return GClass123.Class1.Instance;
	}

	public GClass123(ProxySettings[] proxySettings_1, int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (int_1 < 0 || int_1 > 65535)
		{
			throw new ArgumentOutOfRangeException("internalServerPort");
		}
		if (proxySettings_1 == null)
		{
			throw new ArgumentNullException("proxyList");
		}
		if (proxySettings_1.Length == 0)
		{
			throw new ArgumentException("proxyList is empty", "proxyList");
		}
		if (proxySettings_1.Any(new Func<ProxySettings, bool>(GClass123.<>c.<>c_0.TiMpAyCfsn)))
		{
			throw new ArgumentNullException("proxyList", "Proxy in proxyList is null");
		}
		this.proxySettings_0 = proxySettings_1;
		this.method_1(int_1);
		this.socket_0 = GClass123.smethod_4();
		this.socket_0.Bind(new IPEndPoint(IPAddress.Loopback, this.method_0()));
		if (this.method_0() == 0)
		{
			this.method_1(((IPEndPoint)this.socket_0.LocalEndPoint).Port);
		}
		this.uri_0 = new Uri("http://127.0.0.1:" + this.method_0().ToString());
		this.socket_0.Listen(8);
		this.socket_0.BeginAccept(new AsyncCallback(this.method_3), null);
	}

	public void method_2(ProxySettings[] proxySettings_1)
	{
		if (proxySettings_1 == null || proxySettings_1.Length == 0)
		{
			throw new ArgumentException("proxies");
		}
		this.proxySettings_0 = proxySettings_1;
	}

	private void method_3(IAsyncResult iasyncResult_0)
	{
		if (this.Stopped)
		{
			return;
		}
		Socket socket = null;
		try
		{
			socket = this.socket_0.EndAccept(iasyncResult_0);
		}
		catch
		{
		}
		try
		{
			this.socket_0.BeginAccept(new AsyncCallback(this.method_3), null);
		}
		catch
		{
			this.method_5();
		}
		if (socket != null)
		{
			this.method_4(socket);
		}
	}

	private void method_4(Socket socket_1)
	{
		Socket socket = null;
		bool flag = true;
		try
		{
			string string_;
			int num;
			string text;
			bool flag2;
			string string_2;
			byte[] array;
			if (GClass123.smethod_0(socket_1, out string_, out num, out text, out flag2, out string_2, out array))
			{
				try
				{
					socket = GClass123.smethod_4();
					socket.Connect(this.proxySettings_0[0].Host, this.proxySettings_0[0].Port);
				}
				catch (SocketException)
				{
					GClass123.smethod_3(socket_1, (GClass123.GEnum7)(-2147483644), "HTTP/1.1 ");
					flag = false;
				}
				catch (Exception)
				{
					GClass123.smethod_3(socket_1, (GClass123.GEnum7)(-2147483647), "HTTP/1.1 ");
					flag = false;
				}
				if (flag)
				{
					int i = 0;
					while (i < this.proxySettings_0.Length - 1)
					{
						ProxySettings proxySettings = this.proxySettings_0[i];
						ProxySettings proxySettings2 = this.proxySettings_0[i + 1];
						GClass123.GEnum7 genum = GClass123.Class3.smethod_0(socket, proxySettings2.Host, proxySettings2.Port, proxySettings);
						if (genum == (GClass123.GEnum7)0)
						{
							i++;
						}
						else
						{
							GClass123.smethod_3(socket_1, genum, text);
							flag = false;
							IL_CE:
							if (!flag)
							{
								goto IL_12E;
							}
							ProxySettings proxySettings3 = this.proxySettings_0.Last<ProxySettings>();
							genum = GClass123.Class3.smethod_0(socket, string_, num, proxySettings3);
							if (genum != (GClass123.GEnum7)0)
							{
								GClass123.smethod_3(socket_1, genum, text);
								flag = false;
								goto IL_12E;
							}
							if (flag2)
							{
								GClass123.smethod_2(socket_1, text + "200 Connection established\r\nProxy-Agent: HttpToSocksProxy\r\n\r\n");
								goto IL_12E;
							}
							GClass123.smethod_2(socket, string_2);
							if (array != null)
							{
								socket.Send(array, SocketFlags.None);
								goto IL_12E;
							}
							goto IL_12E;
						}
					}
					goto IL_CE;
				}
			}
			else
			{
				flag = false;
			}
			IL_12E:;
		}
		catch
		{
			flag = false;
			try
			{
				GClass123.smethod_3(socket_1, (GClass123.GEnum7)(-2147483647), "HTTP/1.1 ");
			}
			catch
			{
			}
		}
		finally
		{
			if (flag)
			{
				GClass123.Class2.smethod_1(socket, socket_1);
			}
			else
			{
				socket_1.smethod_1();
				socket.smethod_1();
			}
		}
	}

	private static bool smethod_0(Socket socket_1, out string string_0, out int int_1, out string string_1, out bool bool_1, out string string_2, out byte[] byte_0)
	{
		string_0 = null;
		int_1 = -1;
		string_1 = null;
		bool_1 = false;
		string_2 = null;
		string text;
		if (!GClass123.smethod_1(socket_1, out text, out byte_0))
		{
			return false;
		}
		List<string> list = text.Split(new char[]
		{
			'\n'
		}).Select(new Func<string, string>(GClass123.<>c.<>c_0.method_0)).Where(new Func<string, bool>(GClass123.<>c.<>c_0.method_1)).ToList<string>();
		string[] array = list[0].Split(new char[]
		{
			' '
		});
		if (array.Length != 3)
		{
			GClass123.smethod_3(socket_1, (GClass123.GEnum7)(-2147483648), "HTTP/1.1 ");
			return false;
		}
		string text2 = array[0];
		string_1 = array[2].Trim() + " ";
		bool_1 = text2.Equals("Connect", StringComparison.OrdinalIgnoreCase);
		string text3 = null;
		if (bool_1)
		{
			using (List<string>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text4 = enumerator.Current;
					int num = text4.IndexOf(':');
					if (num == -1)
					{
						GClass123.smethod_3(socket_1, (GClass123.GEnum7)(-2147483648), string_1);
						return false;
					}
					if (text4.Substring(0, num).Trim().Equals("Host", StringComparison.OrdinalIgnoreCase))
					{
						text3 = text4.Substring(num + 1).Trim();
						break;
					}
				}
				goto IL_2B1;
			}
			bool result;
			return result;
		}
		Uri uri = new Uri(array[1]);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(array[0]);
		stringBuilder.Append(' ');
		stringBuilder.Append(uri.PathAndQuery);
		stringBuilder.Append(uri.Fragment);
		stringBuilder.Append(' ');
		stringBuilder.Append(array[2]);
		for (int i = 1; i < list.Count; i++)
		{
			int num2 = list[i].IndexOf(':');
			if (num2 != -1)
			{
				string text5 = list[i].Substring(0, num2).Trim();
				if (text5.Equals("Host", StringComparison.OrdinalIgnoreCase))
				{
					text3 = list[i].Substring(num2 + 1).Trim();
					stringBuilder.Append("\r\n");
					stringBuilder.Append(list[i]);
				}
				else if (!text5.smethod_0())
				{
					stringBuilder.Append("\r\n");
					stringBuilder.Append(list[i]);
				}
			}
		}
		if (text3 == null)
		{
			stringBuilder.Append("\r\nHost: ");
			stringBuilder.Append(uri.Host);
		}
		stringBuilder.Append("\r\n\r\n");
		string_2 = stringBuilder.ToString();
		IL_2B1:
		int_1 = (bool_1 ? 443 : 80);
		if (string.IsNullOrEmpty(text3))
		{
			string text6 = array[1];
			string_0 = text6;
			int num3 = text6.LastIndexOf(':');
			if (num3 != -1)
			{
				if (int.TryParse(text6.Substring(num3 + 1), out int_1))
				{
					string_0 = text6.Substring(0, num3);
				}
				else
				{
					int_1 = (bool_1 ? 443 : 80);
				}
			}
		}
		else
		{
			int num4 = text3.LastIndexOf(':');
			if (num4 == -1)
			{
				string_0 = text3;
				string text7 = array[1];
				num4 = text7.LastIndexOf(':');
				if (num4 != -1 && !int.TryParse(text7.Substring(num4 + 1), out int_1))
				{
					int_1 = (bool_1 ? 443 : 80);
				}
			}
			else
			{
				string_0 = text3.Substring(0, num4);
				if (!int.TryParse(text3.Substring(num4 + 1), out int_1))
				{
					int_1 = (bool_1 ? 443 : 80);
				}
			}
		}
		return true;
	}

	private static bool smethod_1(Socket socket_1, out string string_0, out byte[] byte_0)
	{
		string_0 = null;
		byte_0 = null;
		byte[] array = new byte[8192];
		int num = 0;
		int num2 = 8192;
		while (num2 != 0)
		{
			int num3 = num;
			int num4 = socket_1.Receive(array, num, num2, SocketFlags.None);
			if (num4 == 0)
			{
				return false;
			}
			num += num4;
			num2 -= num4;
			int num5;
			if (array.LtmpSfVly7(Math.Max(0, num3 - 3), num, out num5))
			{
				string_0 = Encoding.ASCII.GetString(array, 0, num5);
				if (num != num5)
				{
					int num6 = num - num5;
					byte_0 = new byte[num6];
					Array.Copy(array, num5, byte_0, 0, num6);
				}
				return true;
			}
		}
		GClass123.smethod_3(socket_1, (GClass123.GEnum7)(-2147483648), "HTTP/1.1 ");
		return false;
	}

	private static void smethod_2(Socket socket_1, string string_0)
	{
		socket_1.Send(Encoding.UTF8.GetBytes(string_0));
	}

	private static void smethod_3(Socket socket_1, GClass123.GEnum7 genum7_0, string string_0 = "HTTP/1.1 ")
	{
		GClass123.smethod_2(socket_1, string_0 + "401 Unauthorized\r\n\r\n");
	}

	private static Socket smethod_4()
	{
		return new Socket(SocketType.Stream, ProtocolType.Tcp);
	}

	public void method_5()
	{
		if (this.Stopped)
		{
			return;
		}
		this.Stopped = true;
		this.socket_0.Close();
	}

	[CompilerGenerated]
	private ICredentials icredentials_0;

	[CompilerGenerated]
	private int int_0;

	private readonly Uri uri_0;

	private readonly Socket socket_0;

	private ProxySettings[] proxySettings_0;

	public bool bool_0;

	private bool Stopped;

	public enum GEnum7
	{

	}

	public enum GEnum8
	{

	}

	internal class Class1
	{
		public IPAddress method_0(string string_0)
		{
			IPAddress result = null;
			IPAddress result2;
			if (IPAddress.TryParse(string_0, out result2))
			{
				return result2;
			}
			try
			{
				result = Dns.GetHostAddresses(string_0).FirstOrDefault(new Func<IPAddress, bool>(GClass123.Class1.<>c.<>c_0.method_0));
			}
			catch (SocketException)
			{
			}
			return result;
		}

		public Class1()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static Class1()
		{
			Class13.xnk8ImWzpOt04();
			GClass123.Class1.Instance = new GClass123.Class1();
		}

		internal static GClass123.Class1 Instance;
	}

	internal class Class2
	{
		private Class2(Socket socket_1, Socket socket_2)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			this.Source = socket_1;
			this.socket_0 = socket_2;
			this.byte_0 = new byte[81920];
			this.socketAsyncEventArgs_0 = new SocketAsyncEventArgs
			{
				UserToken = this
			};
			this.uxYpvHnsuQ = new SocketAsyncEventArgs
			{
				UserToken = this
			};
			this.socketAsyncEventArgs_0.SetBuffer(this.byte_0, 0, this.byte_0.Length);
			this.uxYpvHnsuQ.SetBuffer(this.byte_0, 0, this.byte_0.Length);
			this.socketAsyncEventArgs_0.Completed += GClass123.Class2.smethod_0;
			this.uxYpvHnsuQ.Completed += GClass123.Class2.smethod_0;
			this.bool_0 = true;
		}

		private void method_0()
		{
			if (this.bool_1)
			{
				return;
			}
			this.bool_2 = true;
			this.bool_1 = true;
			this.class2_0.bool_2 = true;
			this.class2_0 = null;
			this.Source.smethod_1();
			this.socket_0.smethod_1();
			this.socketAsyncEventArgs_0.smethod_2();
			this.uxYpvHnsuQ.smethod_2();
			this.Source = (this.socket_0 = null);
			this.socketAsyncEventArgs_0 = (this.uxYpvHnsuQ = null);
			this.byte_0 = null;
		}

		private void method_1()
		{
			try
			{
				while (!this.bool_2)
				{
					if (this.bool_0)
					{
						this.bool_0 = false;
						this.int_0 = -1;
						if (this.Source.ReceiveAsync(this.socketAsyncEventArgs_0))
						{
							return;
						}
					}
					else
					{
						if (this.int_0 == -1)
						{
							this.Received = this.socketAsyncEventArgs_0.BytesTransferred;
							this.int_0 = 0;
							if (this.Received == 0)
							{
								this.bool_2 = true;
								continue;
							}
						}
						else
						{
							this.int_0 += this.uxYpvHnsuQ.BytesTransferred;
						}
						if (this.int_0 != this.Received)
						{
							this.uxYpvHnsuQ.SetBuffer(this.byte_0, this.int_0, this.Received - this.int_0);
							if (this.socket_0.SendAsync(this.uxYpvHnsuQ))
							{
								return;
							}
						}
						else
						{
							this.bool_0 = true;
						}
					}
				}
				this.method_0();
			}
			catch
			{
				this.method_0();
			}
		}

		private static void smethod_0(object sender, SocketAsyncEventArgs e)
		{
			(e.UserToken as GClass123.Class2).method_1();
		}

		public static void smethod_1(Socket socket_1, Socket socket_2)
		{
			GClass123.Class2 @class = new GClass123.Class2(socket_1, socket_2);
			GClass123.Class2 class2 = new GClass123.Class2(socket_2, socket_1);
			@class.class2_0 = class2;
			class2.class2_0 = @class;
			Task.Run(new Action(@class.method_1));
			Task.Run(new Action(class2.method_1));
		}

		private SocketAsyncEventArgs socketAsyncEventArgs_0;

		private SocketAsyncEventArgs uxYpvHnsuQ;

		private Socket Source;

		private Socket socket_0;

		private byte[] byte_0;

		public bool bool_0;

		private int Received;

		private int int_0;

		public GClass123.Class2 class2_0;

		private bool bool_1;

		private bool bool_2;
	}

	internal static class Class3
	{
		public static GClass123.GEnum7 smethod_0(Socket socket_0, string string_0, int int_0, ProxySettings proxySettings_0)
		{
			GClass123.Class1 instance = GClass123.Class1.Instance;
			GClass123.GEnum7 result;
			try
			{
				socket_0.Send(GClass123.Class3.smethod_1(proxySettings_0.User != null));
				byte[] array = new byte[255];
				if (socket_0.Receive(array) != 2)
				{
					result = (GClass123.GEnum7)(-2147483643);
				}
				else if (array[0] != 5)
				{
					result = (GClass123.GEnum7)(-2147483643);
				}
				else
				{
					if (array[1] == 2)
					{
						if (proxySettings_0.User == null)
						{
							return (GClass123.GEnum7)(-2147483643);
						}
						socket_0.Send(GClass123.Class3.smethod_3(proxySettings_0.User, proxySettings_0.Password));
						if (socket_0.Receive(array) != 2)
						{
							return (GClass123.GEnum7)(-2147483643);
						}
						if (array[0] != 1)
						{
							return (GClass123.GEnum7)(-2147483643);
						}
						if (array[1] != 0)
						{
							return (GClass123.GEnum7)(-2147483646);
						}
					}
					else if (array[1] != 0)
					{
						return (GClass123.GEnum7)(-2147483646);
					}
					if (instance != null && Class4.nMapjOjryE(string_0) == (Class4.Enum0)3)
					{
						IPAddress ipaddress = instance.method_0(string_0);
						if (ipaddress == null)
						{
							return (GClass123.GEnum7)4;
						}
						string_0 = ipaddress.ToString();
					}
					socket_0.Send(GClass123.Class3.smethod_2((GClass123.GEnum8)1, Class4.nMapjOjryE(string_0), string_0, int_0));
					int num = socket_0.Receive(array);
					if (num < 8)
					{
						result = (GClass123.GEnum7)(-2147483643);
					}
					else if (array[0] != 5)
					{
						result = (GClass123.GEnum7)(-2147483643);
					}
					else if (array[1] > 8)
					{
						result = (GClass123.GEnum7)(-2147483643);
					}
					else if (array[1] != 0)
					{
						result = (GClass123.GEnum7)array[1];
					}
					else if (array[2] != 0)
					{
						result = (GClass123.GEnum7)(-2147483643);
					}
					else if (array[3] != 1 && array[3] != 3 && array[3] != 4)
					{
						result = (GClass123.GEnum7)(-2147483643);
					}
					else
					{
						Class4.Enum0 @enum = (Class4.Enum0)array[3];
						if (@enum == (Class4.Enum0)1)
						{
							if (num != 10)
							{
								return (GClass123.GEnum7)(-2147483643);
							}
						}
						else if (@enum == (Class4.Enum0)4)
						{
							if (num != 22)
							{
								return (GClass123.GEnum7)(-2147483643);
							}
						}
						else
						{
							int num2 = (int)array[4];
							if (num != 7 + num2)
							{
								return (GClass123.GEnum7)(-2147483643);
							}
						}
						result = (GClass123.GEnum7)0;
					}
				}
			}
			catch (SocketException)
			{
				result = (GClass123.GEnum7)(-2147483644);
			}
			catch
			{
				result = (GClass123.GEnum7)(-2147483647);
			}
			return result;
		}

		private static byte[] smethod_1(bool bool_0)
		{
			byte[] array = new byte[bool_0 ? 4 : 3];
			array[0] = 5;
			array[1] = (bool_0 ? 2 : 1);
			array[2] = 0;
			if (bool_0)
			{
				array[3] = 2;
			}
			return array;
		}

		private static byte[] smethod_2(GClass123.GEnum8 genum8_0, Class4.Enum0 enum0_0, string string_0, int int_0)
		{
			byte[] array;
			int num;
			switch (enum0_0)
			{
			case (Class4.Enum0)1:
			case (Class4.Enum0)4:
				array = IPAddress.Parse(string_0).GetAddressBytes();
				num = array.Length;
				break;
			default:
				throw new ArgumentException("Unknown address type");
			case (Class4.Enum0)3:
			{
				byte[] bytes = Encoding.UTF8.GetBytes(string_0);
				num = 1 + bytes.Length;
				array = new byte[num];
				array[0] = (byte)bytes.Length;
				Array.Copy(bytes, 0, array, 1, bytes.Length);
				break;
			}
			}
			byte[] array2 = new byte[6 + num];
			array2[0] = 5;
			array2[1] = (byte)genum8_0;
			array2[3] = (byte)enum0_0;
			Array.Copy(array, 0, array2, 4, num);
			array2[array2.Length - 2] = (byte)(int_0 / 256);
			array2[array2.Length - 1] = (byte)(int_0 % 256);
			return array2;
		}

		public static byte[] smethod_3(string string_0, string string_1)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			if (bytes.Length > 255)
			{
				throw new ArgumentOutOfRangeException("Username is too long");
			}
			byte[] bytes2 = Encoding.UTF8.GetBytes(string_1);
			if (bytes2.Length > 255)
			{
				throw new ArgumentOutOfRangeException("Password is too long");
			}
			byte[] array = new byte[3 + bytes.Length + bytes2.Length];
			array[0] = 1;
			array[1] = (byte)bytes.Length;
			Array.Copy(bytes, 0, array, 2, bytes.Length);
			array[2 + bytes.Length] = (byte)bytes2.Length;
			Array.Copy(bytes2, 0, array, 3 + bytes.Length, bytes2.Length);
			return array;
		}
	}
}
