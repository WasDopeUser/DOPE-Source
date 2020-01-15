using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

internal static class Class4
{
	public static bool smethod_0(this byte[] byte_0, int int_0, int int_1, out int int_2)
	{
		bool flag = false;
		for (int_2 = int_0; int_2 < int_1; int_2++)
		{
			if (byte_0[int_2] == 10)
			{
				if (flag)
				{
					int_2++;
					return true;
				}
				flag = true;
			}
			else if (byte_0[int_2] != 13)
			{
				flag = false;
			}
		}
		return false;
	}

	public static bool smethod_1(this string string_1)
	{
		return Class4.string_0.Contains(string_1, StringComparer.OrdinalIgnoreCase);
	}

	public static Class4.Enum0 smethod_2(string string_1)
	{
		IPAddress ipaddress;
		if (!IPAddress.TryParse(string_1, out ipaddress))
		{
			return (Class4.Enum0)3;
		}
		if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
		{
			return (Class4.Enum0)1;
		}
		return (Class4.Enum0)4;
	}

	public static void smethod_3(this Socket socket_0)
	{
		if (socket_0 == null)
		{
			return;
		}
		if (socket_0.Connected)
		{
			try
			{
				socket_0.Shutdown(SocketShutdown.Send);
			}
			catch
			{
			}
		}
		try
		{
			socket_0.Close();
		}
		catch
		{
		}
	}

	public static void smethod_4(this SocketAsyncEventArgs socketAsyncEventArgs_0)
	{
		if (socketAsyncEventArgs_0 == null)
		{
			return;
		}
		try
		{
			socketAsyncEventArgs_0.UserToken = null;
			socketAsyncEventArgs_0.AcceptSocket = null;
			socketAsyncEventArgs_0.Dispose();
		}
		catch
		{
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	static Class4()
	{
		Class13.nIxas2ezryi9b();
		Class4.string_0 = new string[]
		{
			"CONNECTION",
			"KEEP-ALIVE",
			"PROXY-AUTHENTICATE",
			"PROXY-AUTHORIZATION",
			"TE",
			"TRAILER",
			"TRANSFER-ENCODING",
			"UPGRADE"
		};
	}

	private static readonly string[] string_0;

	internal enum Enum0
	{

	}

	internal enum Enum1
	{

	}
}
