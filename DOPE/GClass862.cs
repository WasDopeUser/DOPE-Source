using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using PErkava;
using PErkava.Properties;
using Syroot.BinaryData;

public class GClass862 : INotifyPropertyChanged
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

	public GClass84<GClass787<GInterface7>> method_0()
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
			return this.bool_3;
		}
		set
		{
			this.method_3<bool>(ref this.bool_3, value, null, "IsAttached");
		}
	}

	protected void method_3<FPRHpJfqtWiycaWbRWX>(ref FPRHpJfqtWiycaWbRWX gparam_0, FPRHpJfqtWiycaWbRWX k5E40ffaVwXh7rPRhaU, string string_1 = null, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<FPRHpJfqtWiycaWbRWX>.Default.Equals(gparam_0, k5E40ffaVwXh7rPRhaU))
		{
			gparam_0 = k5E40ffaVwXh7rPRhaU;
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
		this.gclass91_0 = new GClass91();
		this.gclass84_0 = new GClass84<GClass787<GInterface7>>(null);
		this.gclass84_0.method_3("PROXY");
		this.method_10();
		this.method_11();
		this.bool_0 = false;
		this.gclass84_0.method_9(this.gclass91_0, new GClass787<GInterface7>());
		this.gclass91_0.Disconnected += this.method_5;
		this.gclass91_0.method_1(new GClass91.GClass92.GDelegate7(this.method_9));
		this.gclass91_0.Connect(tcpClient_0);
	}

	private void method_5(GClass91 gclass91_1, ErrorReason errorReason_0, Exception exception_0)
	{
		GameManager game = this.Game;
		int? num;
		if (game == null)
		{
			num = null;
		}
		else
		{
			DarkorbitAPI.CommonStructures.Settings settings = game.Settings;
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
			this.gclass91_0.method_8();
		}
		catch
		{
		}
	}

	private void method_6(GInterface0 ginterface0_0)
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

	private void method_7(GInterface0 ginterface0_0)
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

	public bool method_8()
	{
		IntPtr foregroundWindow = GClass857.GetForegroundWindow();
		this.method_2(foregroundWindow);
		this.Status = "Getting ready.";
		PErkava.concurrentDictionary_0[foregroundWindow] = this;
		try
		{
			bool flag = GClass856.smethod_1(foregroundWindow, new Action<int>(this.method_20));
			this.Status = "Patching result: " + (flag ? "success" : "FAIL");
			return flag;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + ex.StackTrace + ex.ToString());
		}
		return false;
	}

	private void method_9(GClass91 gclass91_1, BinaryStream binaryStream_0, byte[] byte_0, int int_0)
	{
		if (this.method_1() == IntPtr.Zero)
		{
			this.method_2(GClass857.GetForegroundWindow());
		}
		if (int_0 == 23 && Encoding.UTF8.GetString(byte_0).Contains("policy"))
		{
			byte[] bytes = Encoding.ASCII.GetBytes("<cross-domain-policy><allow-access-from domain=\"*\" to-ports=\"*\" /></cross-domain-policy>\0");
			gclass91_1.method_3().GetStream().Write(bytes, 0, bytes.Length);
			try
			{
				gclass91_1.method_8();
			}
			catch
			{
			}
			PErkava.concurrentDictionary_2[this.method_1()] = false;
			if (!this.method_8())
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
			GClass84<GClass787<GInterface7>> gclass = this.gclass84_0;
			if (gclass == null)
			{
				return;
			}
			gclass.method_12(binaryStream_0, byte_0, int_0);
			return;
		}
	}

	private void method_10()
	{
		if (this.commandDispatcher_0 == null)
		{
			this.commandDispatcher_0 = new CommandDispatcher();
			this.gclass84_0.method_1(new Action<GInterface0>(this.method_6));
			this.commandDispatcher_0.method_1<GClass279>(new Action<GClass279>(this.method_19));
			this.commandDispatcher_0.method_1<GClass253>(new Action<GClass253>(this.method_18));
			this.commandDispatcher_0.method_1<GClass215>(new Action<GClass215>(this.method_17));
			this.commandDispatcher_0.method_1<GClass241>(new Action<GClass241>(this.method_13));
			this.commandDispatcher_0.method_1<GClass146>(new Action<GClass146>(this.method_21));
			this.commandDispatcher_0.method_1<GClass238>(new Action<GClass238>(this.method_22));
			this.commandDispatcher_0.method_1<GClass147>(new Action<GClass147>(this.method_23));
			this.commandDispatcher_0.method_1<GClass161>(new Action<GClass161>(this.method_24));
			this.commandDispatcher_0.method_1<GClass163>(new Action<GClass163>(this.method_25));
			this.commandDispatcher_0.method_1<GClass172>(new Action<GClass172>(this.method_26));
		}
	}

	private void method_11()
	{
		if (this.commandDispatcher_1 == null)
		{
			this.commandDispatcher_1 = new CommandDispatcher();
			this.commandDispatcher_1.method_1<GClass262>(new Action<GClass262>(this.method_27));
			this.commandDispatcher_1.method_1<GClass216>(new Action<GClass216>(this.method_28));
			this.commandDispatcher_1.method_1<GClass280>(new Action<GClass280>(this.method_29));
			this.commandDispatcher_1.method_1<GClass254>(new Action<GClass254>(this.method_30));
			this.commandDispatcher_1.method_1<GClass269>(new Action<GClass269>(this.method_12));
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
					GClass84<GClass788> gclass = socket.method_5();
					if (gclass != null)
					{
						if ((d = gclass.method_0()) != null)
						{
							goto IL_CC;
						}
					}
				}
			}
		}
		d = new Action<GInterface0>(this.method_7);
		IL_CC:
		if (d != new Action<GInterface0>(this.method_7))
		{
			this.gameManager_0.Connection.Socket.method_5().method_1(new Action<GInterface0>(this.method_7));
			this.method_16();
		}
	}

	private void method_12(GClass269 gclass269_0)
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
				this.method_0().method_10(GClass90.smethod_2(num, false));
				this.method_0().method_10(GClass90.Log("Unmasked: " + ship.Name));
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

	private void method_13(GClass241 gclass241_0)
	{
		this.bool_2 = false;
		IPErkavaBotController iperkavaBotController;
		if (!PErkava.smethod_0().TryGetValue(gclass241_0.int_2, out iperkavaBotController))
		{
			return;
		}
		this.gameManager_0 = iperkavaBotController.Game;
		this.gameManager_0.Settings.MapHosts = PErkava.concurrentDictionary_3[iperkavaBotController.GameServer].method_1();
		if (!iperkavaBotController.AttachPErkava(gclass241_0))
		{
			return;
		}
		this.gameManager_0.Connection.ProxySocket = this.method_0();
		this.method_11();
		this.method_16();
	}

	private void method_14(GClass91 gclass91_1, ErrorReason errorReason_0, Exception exception_0 = null)
	{
		if (errorReason_0 != ErrorReason.VersionMismatch && this.gclass91_0.method_0())
		{
			this.gameManager_0.Start();
		}
	}

	private void method_15(GClass91 gclass91_1)
	{
	}

	private void method_16()
	{
		this.IsAttached = true;
		PErkava.concurrentDictionary_0[this.method_1()] = this;
	}

	private void method_17(GClass215 gclass215_0)
	{
		byte[] array = new byte[64];
		for (int i = 0; i < 64; i++)
		{
			array[i] = 55;
		}
		BigInteger value = GClass790.smethod_0(gclass215_0.byteArray_0.Memory.ToArray());
		BigInteger exponent = GClass790.smethod_0(array);
		BigInteger value2 = GClass790.smethod_2("34f624e980ce15a5e99c55d2a6220087c0f10917369e2ecc1e8238c7f96cf59ae90e60ca3e7f2076ea968ac95f0b156d5d6a07d833f2c4b390e4b43695161062");
		BigInteger modulus = GClass790.smethod_2("c9059b49d8f86ba0dc564bb627d87226b28cb259e2343c532383cbde7448e3b0b0cf89f03e7b4b6185b40235630af114e0c31b7985f2fe787a6fe081bddcfcfb");
		byte[] array2 = BigInteger.ModPow(value2, exponent, modulus).ToByteArray().Take(64).Reverse<byte>().ToArray<byte>();
		GClass790 gclass = new GClass790(GClass790.smethod_2("ef09b1bcec67808eeff374b1b51fb155edaac4fcc7a78ed75d5848d6e9eaabee41dec018bb5482d01acea8ce13688bfe33076dde70f06febb80cf3b7327953fb32c08889b815587ded2cdd056d0ec9965b894751848766c27fdee32c707b6fc9"), new BigInteger(65537), GClass790.smethod_2("0b7f1bdd4a41701d6fccf5bfd6463ff1320d148c53cdeb40d06c7e94578bc1d923b1e2eb4d9732f36f56a127c8272f1462f185708af8e56df795bc30c70a7ad52d12b950f35ae6f4103c738fccf485c31be178696560d39f1d9d71baeaed3941"));
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_11(array2, memoryStream, 0U, (uint)array2.Length);
			GClass216 ginterface0_ = new GClass216(new ByteArray(memoryStream.ToArray()));
			for (;;)
			{
				bool flag;
				if (PErkava.concurrentDictionary_2.TryGetValue(this.method_1(), out flag))
				{
					if (flag)
					{
						break;
					}
				}
				Thread.Sleep(500);
				this.gclass84_0.SendMessage(new GClass262());
			}
			this.gclass84_0.SendMessage(ginterface0_);
		}
		this.bool_0 = true;
		this.bool_2 = false;
		byte[] byte_ = BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().Take(16).ToArray<byte>();
		this.gclass84_0.method_4().method_0(byte_);
	}

	private void method_18(GClass253 gclass253_0)
	{
		GClass254 gclass = new GClass254(0, null);
		gclass.byteArray_0 = new ByteArray(Resources.payload);
		this.gclass84_0.SendMessage(gclass);
	}

	private void method_19(GClass279 gclass279_0)
	{
		GClass280 gclass = new GClass280(0, 146, 1, false);
		if (gclass.int_0 == gclass279_0.int_0 && gclass.int_1 == gclass279_0.int_1)
		{
			if (gclass.int_2 == gclass279_0.int_2)
			{
				gclass.bool_0 = true;
				goto IL_4A;
			}
		}
		gclass.bool_0 = false;
		IL_4A:
		if (!gclass.bool_0)
		{
			MessageBox.Show(string.Format("PErkava doesn't yet support this client version.\r\nLocal: {0}.{1}.{2}\r\nRemote: {3}.{4}.{5}", new object[]
			{
				gclass.int_0,
				gclass.int_1,
				gclass.int_2,
				gclass279_0.int_0,
				gclass279_0.int_1,
				gclass279_0.int_2
			}));
			return;
		}
		this.gclass84_0.SendMessage(gclass);
	}

	public GClass862()
	{
		Class13.nIxas2ezryi9b();
		this.random_0 = new Random();
		base..ctor();
	}

	[CompilerGenerated]
	private void method_20(int int_0)
	{
		this.Status = string.Format("Patching... {0}MB", int_0);
	}

	[CompilerGenerated]
	private void method_21(GClass146 gclass146_0)
	{
		this.bool_2 = false;
	}

	[CompilerGenerated]
	private void method_22(GClass238 gclass238_0)
	{
		this.bool_2 = false;
		this.gclass84_0.SendMessage(new GClass262());
	}

	[CompilerGenerated]
	private void method_23(GClass147 gclass147_0)
	{
		this.bool_2 = false;
		if (gclass147_0.string_0.StartsWith("!dope"))
		{
			this.bool_2 = false;
			string str = gclass147_0.string_0.Substring(5).Trim();
			this.Game.method_9(new GClass269("69|" + str));
			this.method_0().SendMessage(new GClass656());
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
		this.method_0().SendMessage(new GClass656());
	}

	[CompilerGenerated]
	private void method_24(GClass161 gclass161_0)
	{
		this.Game.Hero.method_4(gclass161_0.int_2, gclass161_0.int_1, gclass161_0.int_3, gclass161_0.int_0, this.Game.Hero.Speed);
	}

	[CompilerGenerated]
	private void method_25(GClass163 gclass163_0)
	{
		this.Game.Hero.Pet.Mode = (PetMode)gclass163_0.gclass258_0.Mode;
		this.Game.Hero.Pet.ModeExtra = gclass163_0.int_0;
	}

	[CompilerGenerated]
	private void method_26(GClass172 gclass172_0)
	{
		this.bool_2 = false;
		File.AppendAllLines("client.txt", new List<string>
		{
			gclass172_0.string_0 + "-type-" + gclass172_0.uint_0.ToString()
		});
	}

	[CompilerGenerated]
	private void method_27(GClass262 gclass262_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_28(GClass216 gclass216_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_29(GClass280 gclass280_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_30(GClass254 gclass254_0)
	{
		this.bool_1 = false;
	}

	private GClass91 gclass91_0;

	private GameManager gameManager_0;

	private GClass84<GClass787<GInterface7>> gclass84_0;

	private CommandDispatcher commandDispatcher_0;

	private CommandDispatcher commandDispatcher_1;

	[CompilerGenerated]
	private IntPtr intptr_0;

	private bool bool_0;

	private Random random_0;

	private bool bool_1;

	private bool bool_2;

	private string string_0;

	private bool bool_3;
}
