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

public class GClass881 : INotifyPropertyChanged
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

	public GClass84<GClass804<GInterface7>> method_0()
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

	protected void method_3<vum8V6NI0quaOt7NlUg>(ref vum8V6NI0quaOt7NlUg gparam_0, vum8V6NI0quaOt7NlUg ISFxMXNX4jHqbEfUn3t, string string_1 = null, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<vum8V6NI0quaOt7NlUg>.Default.Equals(gparam_0, ISFxMXNX4jHqbEfUn3t))
		{
			gparam_0 = ISFxMXNX4jHqbEfUn3t;
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
		this.gclass84_0 = new GClass84<GClass804<GInterface7>>(null);
		this.gclass84_0.method_3("PROXY");
		this.method_10();
		this.method_11();
		this.bool_0 = false;
		this.gclass84_0.method_9(this.gclass91_0, new GClass804<GInterface7>());
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
		IntPtr foregroundWindow = GClass876.GetForegroundWindow();
		this.method_2(foregroundWindow);
		this.Status = "Getting ready.";
		PErkava.concurrentDictionary_0[foregroundWindow] = this;
		try
		{
			bool flag = GClass875.smethod_1(foregroundWindow, new Action<int>(this.method_20));
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
			this.method_2(GClass876.GetForegroundWindow());
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
			GClass84<GClass804<GInterface7>> gclass = this.gclass84_0;
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
			this.commandDispatcher_0.method_1<GClass283>(new Action<GClass283>(this.method_19));
			this.commandDispatcher_0.method_1<GClass254>(new Action<GClass254>(this.method_18));
			this.commandDispatcher_0.method_1<GClass216>(new Action<GClass216>(this.method_17));
			this.commandDispatcher_0.method_1<GClass242>(new Action<GClass242>(this.method_13));
			this.commandDispatcher_0.method_1<GClass146>(new Action<GClass146>(this.method_21));
			this.commandDispatcher_0.method_1<GClass239>(new Action<GClass239>(this.method_22));
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
			this.commandDispatcher_1.method_1<GClass266>(new Action<GClass266>(this.method_27));
			this.commandDispatcher_1.method_1<GClass217>(new Action<GClass217>(this.method_28));
			this.commandDispatcher_1.method_1<GClass284>(new Action<GClass284>(this.method_29));
			this.commandDispatcher_1.method_1<GClass255>(new Action<GClass255>(this.method_30));
			this.commandDispatcher_1.method_1<GClass273>(new Action<GClass273>(this.method_12));
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
					GClass84<GClass805> gclass = socket.method_5();
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

	private void method_12(GClass273 gclass273_0)
	{
		string[] array;
		if (GClass90.smethod_1(gclass273_0.string_0, out array, new string[]
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
		else if (GClass90.smethod_1(gclass273_0.string_0, out array, new string[]
		{
			"i"
		}))
		{
			this.bool_1 = false;
		}
	}

	private void method_13(GClass242 gclass242_0)
	{
		this.bool_2 = false;
		IPErkavaBotController iperkavaBotController;
		if (!PErkava.smethod_0().TryGetValue(gclass242_0.int_2, out iperkavaBotController))
		{
			return;
		}
		this.gameManager_0 = iperkavaBotController.Game;
		this.gameManager_0.Settings.MapHosts = PErkava.concurrentDictionary_3[iperkavaBotController.GameServer].method_1();
		if (!iperkavaBotController.AttachPErkava(gclass242_0))
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

	private void method_17(GClass216 gclass216_0)
	{
		byte[] array = new byte[64];
		for (int i = 0; i < 64; i++)
		{
			array[i] = 55;
		}
		BigInteger value = GClass807.smethod_0(gclass216_0.byteArray_0.Memory.ToArray());
		BigInteger exponent = GClass807.smethod_0(array);
		BigInteger value2 = GClass807.smethod_2("4bf022d9780125620d16442953c60a4a97874e263c099e613eed290247240829d74fc0a31d84b686699a55651a1285f7cbcc936153a8c942e3d3a4c864832ad1");
		BigInteger modulus = GClass807.smethod_2("999d6c44ffd30467cd7e8bc70e095a8d08fb8fbfeee536fdfb2d43f99005ee3f6b529b4411395a56651422f449eb9ea3f7d48d8c443c06bd1387afe489a7c6c1");
		byte[] array2 = BigInteger.ModPow(value2, exponent, modulus).ToByteArray().Take(64).Reverse<byte>().ToArray<byte>();
		GClass807 gclass = new GClass807(GClass807.smethod_2("ef09b1bcec67808eeff374b1b51fb155edaac4fcc7a78ed75d5848d6e9eaabee41dec018bb5482d01acea8ce13688bfe33076dde70f06febb80cf3b7327953fb32c08889b815587ded2cdd056d0ec9965b894751848766c27fdee32c707b6fc9"), new BigInteger(65537), GClass807.smethod_2("0b7f1bdd4a41701d6fccf5bfd6463ff1320d148c53cdeb40d06c7e94578bc1d923b1e2eb4d9732f36f56a127c8272f1462f185708af8e56df795bc30c70a7ad52d12b950f35ae6f4103c738fccf485c31be178696560d39f1d9d71baeaed3941"));
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_11(array2, memoryStream, 0U, (uint)array2.Length);
			GClass217 ginterface0_ = new GClass217(new ByteArray(memoryStream.ToArray()));
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
				this.gclass84_0.SendMessage(new GClass266());
			}
			this.gclass84_0.SendMessage(ginterface0_);
		}
		this.bool_0 = true;
		this.bool_2 = false;
		byte[] byte_ = BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().Take(16).ToArray<byte>();
		this.gclass84_0.method_4().method_0(byte_);
	}

	private void method_18(GClass254 gclass254_0)
	{
		GClass255 gclass = new GClass255(0, null);
		gclass.byteArray_0 = new ByteArray(Resources.payload);
		this.gclass84_0.SendMessage(gclass);
	}

	private void method_19(GClass283 gclass283_0)
	{
		GClass284 gclass = new GClass284(0, 134, 4, false);
		if (gclass.int_0 == gclass283_0.int_0 && gclass.int_1 == gclass283_0.int_1)
		{
			if (gclass.int_2 == gclass283_0.int_2)
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
				gclass283_0.int_0,
				gclass283_0.int_1,
				gclass283_0.int_2
			}));
			return;
		}
		this.gclass84_0.SendMessage(gclass);
	}

	public GClass881()
	{
		Class13.NP5bWyNzLwONS();
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
	private void method_22(GClass239 gclass239_0)
	{
		this.bool_2 = false;
		this.gclass84_0.SendMessage(new GClass266());
	}

	[CompilerGenerated]
	private void method_23(GClass147 gclass147_0)
	{
		this.bool_2 = false;
		if (gclass147_0.string_0.StartsWith("!dope"))
		{
			this.bool_2 = false;
			string str = gclass147_0.string_0.Substring(5).Trim();
			this.Game.method_9(new GClass273("69|" + str));
			this.method_0().SendMessage(new GClass672());
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
		GClass273 ginterface0_ = new GClass273(gclass147_0.string_0.Substring(3));
		ginterface.SendMessage(ginterface0_);
		this.method_0().SendMessage(new GClass672());
	}

	[CompilerGenerated]
	private void method_24(GClass161 gclass161_0)
	{
		this.Game.Hero.method_4(gclass161_0.int_1, gclass161_0.int_3, gclass161_0.int_0, gclass161_0.int_2, this.Game.Hero.Speed);
	}

	[CompilerGenerated]
	private void method_25(GClass163 gclass163_0)
	{
		this.Game.Hero.Pet.Mode = (PetMode)gclass163_0.gclass262_0.Mode;
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
	private void method_27(GClass266 gclass266_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_28(GClass217 gclass217_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_29(GClass284 gclass284_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_30(GClass255 gclass255_0)
	{
		this.bool_1 = false;
	}

	private GClass91 gclass91_0;

	private GameManager gameManager_0;

	private GClass84<GClass804<GInterface7>> gclass84_0;

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
