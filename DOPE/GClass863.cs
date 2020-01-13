using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using PErkava;

public class GClass863
{
	[CompilerGenerated]
	public TcpListener method_0()
	{
		return this.tcpListener_0;
	}

	[CompilerGenerated]
	public void method_1(TcpListener tcpListener_1)
	{
		this.tcpListener_0 = tcpListener_1;
	}

	[CompilerGenerated]
	public Thread method_2()
	{
		return this.thread_0;
	}

	[CompilerGenerated]
	public void method_3(Thread thread_1)
	{
		this.thread_0 = thread_1;
	}

	public GClass863()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.method_1(new TcpListener(IPAddress.Any, 8080));
		this.method_3(new Thread(new ThreadStart(this.method_4)));
		this.method_2().IsBackground = true;
	}

	private void method_4()
	{
		try
		{
			this.method_0().Start();
		}
		catch
		{
			PErkava.IsSupported = false;
			return;
		}
		try
		{
			IL_17:
			TcpClient parameter = this.method_0().AcceptTcpClient();
			new Thread(new ParameterizedThreadStart(GClass863.<>c.<>c_0.method_0))
			{
				IsBackground = true
			}.Start(parameter);
		}
		catch
		{
		}
		goto IL_17;
	}

	public void Start()
	{
		this.method_2().Start();
	}

	[CompilerGenerated]
	private TcpListener tcpListener_0;

	[CompilerGenerated]
	private Thread thread_0;
}
