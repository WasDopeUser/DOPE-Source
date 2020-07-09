using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using PErkava;
using Syroot.BinaryData;

public class GClass932 : INotifyPropertyChanged
{
	public GameManager Game
	{
		get
		{
			return this.gameManager_0;
		}
	}

	public GClass88 Server
	{
		get
		{
			GameManager gameManager = this.gameManager_0;
			if (gameManager == null)
			{
				return null;
			}
			ConnectionManager connection = gameManager.Connection;
			if (connection == null)
			{
				return null;
			}
			return connection.Server;
		}
	}

	public GClass84<GClass857> method_0()
	{
		return this.gclass84_0;
	}

	[CompilerGenerated]
	public IntPtr method_1()
	{
		return this.intptr_0;
	}

	[CompilerGenerated]
	private void method_2(IntPtr intptr_1)
	{
		this.intptr_0 = intptr_1;
	}

	public event PropertyChangedEventHandler PropertyChanged;

	public string Status
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.method_3<string>(ref this.string_0, value, null, "Status");
		}
	}

	public bool IsAttached
	{
		get
		{
			return this.bool_4;
		}
		set
		{
			this.method_3<bool>(ref this.bool_4, value, null, "IsAttached");
		}
	}

	protected void method_3<wgfPWM2JMwNLj5dWPFs>(ref wgfPWM2JMwNLj5dWPFs gparam_0, wgfPWM2JMwNLj5dWPFs zPfoni2nhRCrGR1tEPu, string string_1 = null, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<wgfPWM2JMwNLj5dWPFs>.Default.Equals(gparam_0, zPfoni2nhRCrGR1tEPu))
		{
			gparam_0 = zPfoni2nhRCrGR1tEPu;
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(name));
			}
			if (string_1 != null)
			{
				PropertyChangedEventHandler propertyChanged2 = this.PropertyChanged;
				if (propertyChanged2 == null)
				{
					return;
				}
				propertyChanged2(this, new PropertyChangedEventArgs(string_1));
			}
		}
	}

	public void method_4(TcpClient tcpClient_0)
	{
		this.bEyMqhdnuGd = new GClass91();
		this.gclass84_0 = new GClass84<GClass857>(null);
		this.gclass84_0.method_3("PROXY");
		this.method_11();
		this.method_12();
		this.bool_0 = false;
		this.bool_3 = true;
		this.gclass84_0.method_8(this.bEyMqhdnuGd, new GClass857());
		this.bEyMqhdnuGd.Connected += this.method_5;
		this.bEyMqhdnuGd.Disconnected += this.method_6;
		this.bEyMqhdnuGd.method_1(new GClass91.GClass92.GDelegate7(this.method_10));
		this.bEyMqhdnuGd.Connect(tcpClient_0);
	}

	private void method_5(GClass91 gclass91_0)
	{
		this.bool_3 = true;
	}

	private void method_6(GClass91 gclass91_0, ErrorReason errorReason_0, Exception exception_0)
	{
		GameManager game = this.Game;
		int? num;
		if (game == null)
		{
			num = null;
		}
		else
		{
			Settings settings = game.Settings;
			if (settings == null)
			{
				num = null;
			}
			else
			{
				FlashSettings flashSettings = settings.FlashSettings;
				num = ((flashSettings != null) ? new int?(flashSettings.userID) : null);
			}
		}
		int? num2 = num;
		IPErkavaBotController iperkavaBotController;
		if (!PErkava.smethod_0().TryGetValue(num2 ?? -1, out iperkavaBotController))
		{
			return;
		}
		this.gameManager_0.Connection.Socket.method_5().method_1(new Action<GInterface0>(GClass82.smethod_3));
		iperkavaBotController.DetachPErkava();
		this.gclass84_0.method_1(null);
		try
		{
			this.bEyMqhdnuGd.method_8();
		}
		catch
		{
		}
	}

	private void method_7(GInterface0 ginterface0_0)
	{
		this.bool_2 = true;
		this.commandDispatcher_0.method_0(ginterface0_0);
		if (this.bool_0 && this.bool_2)
		{
			GameManager gameManager = this.gameManager_0;
			if (gameManager == null)
			{
				return;
			}
			gameManager.Connection.SendMessage(ginterface0_0);
		}
	}

	private void method_8(GInterface0 ginterface0_0)
	{
		GClass82.smethod_3(ginterface0_0);
		if (this.bool_0 && this.gameManager_0.Connection.IsAuthenticated)
		{
			this.bool_1 = true;
			this.commandDispatcher_1.method_0(ginterface0_0);
			if (this.bool_1)
			{
				this.gclass84_0.SendMessage(ginterface0_0);
			}
		}
	}

	public bool method_9()
	{
		IntPtr foregroundWindow = GClass927.GetForegroundWindow();
		this.method_2(foregroundWindow);
		this.Status = "Getting ready.";
		PErkava.concurrentDictionary_0[foregroundWindow] = this;
		try
		{
			this.Status = "Patching result: " + "success";
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + ex.StackTrace + ex.ToString());
		}
		return false;
	}

	private void method_10(GClass91 gclass91_0, BinaryStream binaryStream_0, byte[] byte_0, int int_0)
	{
		if (this.method_1() == IntPtr.Zero)
		{
			this.method_2(GClass927.GetForegroundWindow());
		}
		if (int_0 == 23 && Encoding.UTF8.GetString(byte_0).Contains("policy"))
		{
			byte[] bytes = Encoding.ASCII.GetBytes("<cross-domain-policy><allow-access-from domain=\"*\" to-ports=\"*\" /></cross-domain-policy>\0");
			gclass91_0.method_3().GetStream().Write(bytes, 0, bytes.Length);
			try
			{
				gclass91_0.method_8();
			}
			catch
			{
			}
			PErkava.concurrentDictionary_2[this.method_1()] = false;
			if (!this.method_9())
			{
				Debug.WriteLine("Patching failed");
				MessageBox.Show("Could not patch the client. This could mean that PErkava doesn't yet support this client version.");
				return;
			}
			PErkava.concurrentDictionary_2[this.method_1()] = true;
			return;
		}
		else
		{
			if (this.bool_3)
			{
				this.bool_3 = false;
				int_0--;
				long position = binaryStream_0.Position;
				binaryStream_0.Position = position + 1L;
			}
			GClass84<GClass857> gclass = this.gclass84_0;
			if (gclass == null)
			{
				return;
			}
			gclass.method_10(binaryStream_0, byte_0, int_0);
			return;
		}
	}

	private void method_11()
	{
		if (this.commandDispatcher_0 == null)
		{
			this.commandDispatcher_0 = new CommandDispatcher();
			this.gclass84_0.method_1(new Action<GInterface0>(this.method_7));
			this.commandDispatcher_0.method_1<GClass279>(new Action<GClass279>(this.method_17));
			this.commandDispatcher_0.method_1<GClass239>(new Action<GClass239>(this.method_14));
			this.commandDispatcher_0.method_1<GClass146>(new Action<GClass146>(this.method_18));
			this.commandDispatcher_0.method_1<GClass236>(new Action<GClass236>(this.method_19));
			this.commandDispatcher_0.method_1<GClass147>(new Action<GClass147>(this.method_20));
			this.commandDispatcher_0.method_1<GClass161>(new Action<GClass161>(this.method_21));
			this.commandDispatcher_0.method_1<GClass163>(new Action<GClass163>(this.method_22));
			this.commandDispatcher_0.method_1<GClass172>(new Action<GClass172>(this.method_23));
		}
	}

	private void method_12()
	{
		if (this.commandDispatcher_1 == null)
		{
			this.commandDispatcher_1 = new CommandDispatcher();
			this.commandDispatcher_1.method_1<GClass261>(new Action<GClass261>(this.method_24));
			this.commandDispatcher_1.method_1<GClass280>(new Action<GClass280>(this.method_25));
			this.commandDispatcher_1.method_1<GClass269>(new Action<GClass269>(this.method_13));
		}
		GameManager gameManager = this.gameManager_0;
		Action<GInterface0> d;
		if (gameManager != null)
		{
			ConnectionManager connection = gameManager.Connection;
			if (connection != null)
			{
				GClass93 socket = connection.Socket;
				if (socket != null)
				{
					GClass84<GClass854> gclass = socket.method_5();
					if (gclass != null)
					{
						if ((d = gclass.method_0()) != null)
						{
							goto IL_9E;
						}
					}
				}
			}
		}
		d = new Action<GInterface0>(this.method_8);
		IL_9E:
		if (d != new Action<GInterface0>(this.method_8))
		{
			this.gameManager_0.Connection.Socket.method_5().method_1(new Action<GInterface0>(this.method_8));
			this.method_16();
		}
	}

	private void method_13(GClass269 gclass269_0)
	{
		string[] array;
		if (GClass90.smethod_1(gclass269_0.string_0, out array, new string[]
		{
			"n",
			"INV"
		}))
		{
			int num = int.Parse(array[0]);
			Ship ship = this.Game.Map.method_4(num);
			if (array[1] == "1" && ship != null && num != this.Game.Hero.Id)
			{
				this.bool_1 = false;
				this.method_0().method_9(GClass90.smethod_2(num, false));
				this.method_0().method_9(GClass90.Log("Unmasked: " + ship.Name));
				return;
			}
		}
		else if (GClass90.smethod_1(gclass269_0.string_0, out array, new string[]
		{
			"i"
		}))
		{
			this.bool_1 = false;
		}
	}

	private void method_14(GClass239 gclass239_0)
	{
		this.bool_2 = false;
		IPErkavaBotController iperkavaBotController;
		if (!PErkava.smethod_0().TryGetValue(gclass239_0.int_0, out iperkavaBotController))
		{
			return;
		}
		this.gameManager_0 = iperkavaBotController.Game;
		this.gameManager_0.Settings.MapHosts = PErkava.concurrentDictionary_3[iperkavaBotController.GameServer].method_1();
		if (!iperkavaBotController.AttachPErkava(gclass239_0))
		{
			return;
		}
		this.gameManager_0.Connection.ProxySocket = this.method_0();
		this.method_12();
		this.method_16();
	}

	private void method_15(GClass91 gclass91_0, ErrorReason errorReason_0, Exception exception_0 = null)
	{
		if (errorReason_0 != ErrorReason.VersionMismatch && this.bEyMqhdnuGd.method_0())
		{
			this.gameManager_0.Start();
		}
	}

	private void method_16()
	{
		this.IsAttached = true;
		PErkava.concurrentDictionary_0[this.method_1()] = this;
	}

	private void method_17(GClass279 gclass279_0)
	{
		GClass280 gclass = new GClass280("99e62eb0ce99bc68ab3912dae14869ba", false);
		if (gclass279_0.string_0 != "99e62eb0ce99bc68ab3912dae14869ba")
		{
			gclass.bool_0 = false;
		}
		else
		{
			gclass.bool_0 = true;
		}
		if (!gclass.bool_0)
		{
			MessageBox.Show("PErkava doesn't yet support this client version.\r\nLocal: " + gclass.string_0 + "\r\nRemote: " + gclass279_0.string_0);
			return;
		}
		this.bool_0 = true;
		this.gclass84_0.SendMessage(gclass);
	}

	public GClass932()
	{
		Class13.lOBHd9Nzn7x2T();
		this.random_0 = new Random();
		this.bool_3 = true;
		base..ctor();
	}

	[CompilerGenerated]
	private void method_18(GClass146 gclass146_0)
	{
		this.bool_2 = false;
	}

	[CompilerGenerated]
	private void method_19(GClass236 gclass236_0)
	{
		this.bool_2 = false;
		this.gclass84_0.SendMessage(new GClass261());
	}

	[CompilerGenerated]
	private void method_20(GClass147 gclass147_0)
	{
		this.bool_2 = false;
		if (gclass147_0.string_0.StartsWith("!dope"))
		{
			this.bool_2 = false;
			string str = gclass147_0.string_0.Substring(5).Trim();
			this.Game.method_9(new GClass269("69|" + str));
			return;
		}
		GInterface5 ginterface = null;
		if (gclass147_0.string_0.StartsWith("!!>"))
		{
			ginterface = this.Game.Connection;
		}
		else if (gclass147_0.string_0.StartsWith("!!<"))
		{
			ginterface = this.method_0();
		}
		if (ginterface == null)
		{
			this.bool_2 = true;
			return;
		}
		GClass269 ginterface0_ = new GClass269(gclass147_0.string_0.Substring(3));
		ginterface.SendMessage(ginterface0_);
	}

	[CompilerGenerated]
	private void method_21(GClass161 gclass161_0)
	{
		this.Game.Hero.method_5(gclass161_0.int_0, gclass161_0.int_3, gclass161_0.int_2, gclass161_0.int_1, this.Game.Hero.Speed);
	}

	[CompilerGenerated]
	private void method_22(GClass163 gclass163_0)
	{
		this.Game.Hero.Pet.Mode = (PetMode)gclass163_0.gclass257_0.Mode;
		this.Game.Hero.Pet.ModeExtra = gclass163_0.int_0;
	}

	[CompilerGenerated]
	private void method_23(GClass172 gclass172_0)
	{
		this.bool_2 = false;
		File.AppendAllLines("client.txt", new List<string>
		{
			gclass172_0.string_0 + "-type-" + gclass172_0.int_0.ToString()
		});
	}

	[CompilerGenerated]
	private void method_24(GClass261 gclass261_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_25(GClass280 gclass280_0)
	{
		this.bool_1 = false;
	}

	private GClass91 bEyMqhdnuGd;

	private GameManager gameManager_0;

	private GClass84<GClass857> gclass84_0;

	private CommandDispatcher commandDispatcher_0;

	private CommandDispatcher commandDispatcher_1;

	[CompilerGenerated]
	private IntPtr intptr_0;

	private bool bool_0;

	private Random random_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private string string_0;

	private bool bool_4;
}
