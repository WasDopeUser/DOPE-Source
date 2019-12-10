using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass91
{
	public bool method_0()
	{
		TcpClient tcpClient = this.method_3();
		bool? flag;
		if (tcpClient == null)
		{
			flag = null;
		}
		else
		{
			Socket client = tcpClient.Client;
			flag = ((client != null) ? new bool?(client.Connected) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	public event GClass91.GClass92.GDelegate6 Disconnected;

	public event GClass91.GClass92.GDelegate5 Connected;

	[CompilerGenerated]
	public void method_1(GClass91.GClass92.GDelegate7 gdelegate7_1)
	{
		GClass91.GClass92.GDelegate7 gdelegate = this.gdelegate7_0;
		GClass91.GClass92.GDelegate7 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass91.GClass92.GDelegate7 value = (GClass91.GClass92.GDelegate7)Delegate.Combine(gdelegate2, gdelegate7_1);
			gdelegate = Interlocked.CompareExchange<GClass91.GClass92.GDelegate7>(ref this.gdelegate7_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public void method_2(GClass91.GClass92.GDelegate7 gdelegate7_1)
	{
		GClass91.GClass92.GDelegate7 gdelegate = this.gdelegate7_0;
		GClass91.GClass92.GDelegate7 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GClass91.GClass92.GDelegate7 value = (GClass91.GClass92.GDelegate7)Delegate.Remove(gdelegate2, gdelegate7_1);
			gdelegate = Interlocked.CompareExchange<GClass91.GClass92.GDelegate7>(ref this.gdelegate7_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public TcpClient method_3()
	{
		return this.tcpClient_0;
	}

	[CompilerGenerated]
	private void method_4(TcpClient tcpClient_1)
	{
		this.tcpClient_0 = tcpClient_1;
	}

	[CompilerGenerated]
	public Thread method_5()
	{
		return this.OioNuhLrqs;
	}

	[CompilerGenerated]
	private void method_6(Thread thread_0)
	{
		this.OioNuhLrqs = thread_0;
	}

	public GClass91()
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.method_6(new Thread(new ThreadStart(this.method_9)));
		this.method_5().IsBackground = true;
	}

	public static void smethod_0(Socket socket_0)
	{
		TcpClient tcpClient = new TcpClient("8.8.8.8", 53);
		socket_0.Bind(new IPEndPoint(((IPEndPoint)tcpClient.Client.LocalEndPoint).Address, 0));
		tcpClient.Close();
	}

	public void method_7(string string_0, int int_0, bool bool_0 = true)
	{
		this.method_10();
		this.method_4(new TcpClient());
		if (bool_0)
		{
			this.method_3().Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			GClass91.smethod_0(this.method_3().Client);
		}
		try
		{
			this.method_3().Connect(string_0, int_0);
		}
		catch (Exception exception)
		{
			GClass91.GClass92.GDelegate6 disconnected = this.Disconnected;
			if (disconnected != null)
			{
				disconnected(this, ErrorReason.ConnectionLost, exception);
			}
			return;
		}
		this.method_6(new Thread(new ThreadStart(this.method_9)));
		this.method_5().IsBackground = true;
		this.method_5().Start();
	}

	public void method_8(TcpClient tcpClient_1)
	{
		this.method_10();
		this.method_4(tcpClient_1);
		this.method_6(new Thread(new ThreadStart(this.method_9)));
		this.method_5().IsBackground = true;
		this.method_5().Start();
	}

	private void method_9()
	{
		try
		{
			TcpClient tcpClient = this.method_3();
			if (tcpClient == null || tcpClient.Client == null)
			{
				return;
			}
			GClass91.GClass92.GDelegate5 connected = this.Connected;
			if (connected != null)
			{
				connected(this);
			}
			if (tcpClient == null || !tcpClient.Connected)
			{
				GClass91.GClass92.GDelegate6 disconnected = this.Disconnected;
				if (disconnected != null)
				{
					disconnected(this, ErrorReason.ConnectionLost, null);
				}
				return;
			}
			NetworkStream stream = tcpClient.GetStream();
			byte[] array = new byte[4096];
			using (MemoryStream memoryStream = new MemoryStream(array))
			{
				using (BinaryStream binaryStream = memoryStream.smethod_2(true))
				{
					for (;;)
					{
						TcpClient tcpClient2 = this.method_3();
						if (tcpClient2 == null)
						{
							goto IL_120;
						}
						bool flag = tcpClient2.Connected;
						IL_70:
						if (!flag)
						{
							break;
						}
						try
						{
							memoryStream.Position = 0L;
							int num = stream.Read(array, (int)memoryStream.Position, (int)(4096L - memoryStream.Position));
							if (num == 0)
							{
								GClass91.GClass92.GDelegate6 disconnected2 = this.Disconnected;
								if (disconnected2 != null)
								{
									disconnected2(this, ErrorReason.ConnectionLost, new Exception("Socket has been closed"));
								}
								return;
							}
							Stream stream2 = binaryStream;
							memoryStream.Position = 0L;
							stream2.Position = 0L;
							GClass91.GClass92.GDelegate7 gdelegate = this.gdelegate7_0;
							if (gdelegate != null)
							{
								gdelegate(this, binaryStream, array, num);
							}
							continue;
						}
						catch (Exception exception)
						{
							GClass91.GClass92.GDelegate6 disconnected3 = this.Disconnected;
							if (disconnected3 != null)
							{
								disconnected3(this, ErrorReason.ConnectionLost, exception);
							}
							return;
						}
						IL_120:
						flag = false;
						goto IL_70;
					}
				}
			}
		}
		catch
		{
		}
		GClass91.GClass92.GDelegate6 disconnected4 = this.Disconnected;
		if (disconnected4 == null)
		{
			return;
		}
		disconnected4(this, ErrorReason.ConnectionLost, null);
	}

	public void method_10()
	{
		try
		{
			TcpClient tcpClient = this.method_3();
			if (tcpClient != null)
			{
				tcpClient.Close();
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private GClass91.GClass92.GDelegate7 gdelegate7_0;

	[CompilerGenerated]
	private TcpClient tcpClient_0;

	[CompilerGenerated]
	private Thread OioNuhLrqs;

	public static class GClass92
	{
		public delegate void GDelegate5(GClass91 client);

		public delegate void GDelegate6(GClass91 client, ErrorReason reason, Exception exception = null);

		public delegate void GDelegate7(GClass91 client, BinaryStream buffer, byte[] internalBuffer, int read);
	}
}
