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
using chuvRxphSdnfhBmwTy3;
using DarkorbitAPI;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;
using PErkava;
using PErkava.Properties;
using Syroot.BinaryData;

public class GClass845 : INotifyPropertyChanged
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

	public GClass84<GClass777<GInterface6>> method_0()
	{
		return this.gclass84_0;
	}

	[CompilerGenerated]
	public IntPtr wtAiPbPvAe2()
	{
		return this.intptr_0;
	}

	[CompilerGenerated]
	private void method_1(IntPtr intptr_1)
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
			this.method_2<string>(ref this.string_0, value, null, "Status");
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
			this.method_2<bool>(ref this.bool_3, value, null, "IsAttached");
		}
	}

	protected void method_2<VyEAxMkTlcfKt5IiFbY>(ref VyEAxMkTlcfKt5IiFbY gparam_0, VyEAxMkTlcfKt5IiFbY lrmq1DkdmjnyEayZUC8, string string_1 = null, [CallerMemberName] string name = null)
	{
		if (!EqualityComparer<VyEAxMkTlcfKt5IiFbY>.Default.Equals(gparam_0, lrmq1DkdmjnyEayZUC8))
		{
			gparam_0 = lrmq1DkdmjnyEayZUC8;
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

	public void method_3(TcpClient tcpClient_0)
	{
		this.gclass91_0 = new GClass91();
		this.gclass84_0 = new GClass84<GClass777<GInterface6>>(null);
		this.gclass84_0.method_3("PROXY");
		this.method_9();
		this.method_10();
		this.bool_0 = false;
		this.gclass84_0.method_9(this.gclass91_0, new GClass777<GInterface6>());
		this.gclass91_0.Disconnected += this.method_4;
		this.gclass91_0.method_1(new GClass91.GClass92.GDelegate7(this.method_8));
		this.gclass91_0.method_8(tcpClient_0);
	}

	private void method_4(GClass91 gclass91_1, ErrorReason errorReason_0, Exception exception_0)
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
		this.gameManager_0.Connection.Socket.method_4().method_1(new Action<GInterface0>(GClass82.smethod_3));
		iperkavaBotController.DetachPErkava();
		this.gclass84_0.method_1(null);
		try
		{
			this.gclass91_0.method_10();
		}
		catch
		{
		}
	}

	private void method_5(GInterface0 ginterface0_0)
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

	private void method_6(GInterface0 ginterface0_0)
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

	public bool method_7()
	{
		IntPtr foregroundWindow = GClass840.GetForegroundWindow();
		this.method_1(foregroundWindow);
		this.Status = "Getting ready.";
		PErkava.concurrentDictionary_0[foregroundWindow] = this;
		try
		{
			bool flag = GClass839.smethod_1(foregroundWindow, new Action<int>(this.method_19));
			this.Status = "Patching result: " + (flag ? "success" : "FAIL");
			return flag;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + ex.StackTrace + ex.ToString());
		}
		return false;
	}

	private void method_8(GClass91 gclass91_1, BinaryStream binaryStream_0, byte[] byte_0, int int_0)
	{
		if (this.wtAiPbPvAe2() == IntPtr.Zero)
		{
			this.method_1(GClass840.GetForegroundWindow());
		}
		if (int_0 == 23 && Encoding.UTF8.GetString(byte_0).Contains("policy"))
		{
			byte[] bytes = Encoding.ASCII.GetBytes("<cross-domain-policy><allow-access-from domain=\"*\" to-ports=\"*\" /></cross-domain-policy>\0");
			gclass91_1.method_3().GetStream().Write(bytes, 0, bytes.Length);
			try
			{
				gclass91_1.method_10();
			}
			catch
			{
			}
			PErkava.concurrentDictionary_2[this.wtAiPbPvAe2()] = false;
			if (!this.method_7())
			{
				Debug.WriteLine("Patching failed");
				MessageBox.Show("Could not patch the client. This could mean that PErkava doesn't yet support this client version.");
				return;
			}
			PErkava.concurrentDictionary_2[this.wtAiPbPvAe2()] = true;
			return;
		}
		else
		{
			GClass84<GClass777<GInterface6>> gclass = this.gclass84_0;
			if (gclass == null)
			{
				return;
			}
			gclass.method_12(binaryStream_0, byte_0, int_0);
			return;
		}
	}

	private void method_9()
	{
		if (this.commandDispatcher_0 == null)
		{
			this.commandDispatcher_0 = new CommandDispatcher();
			this.gclass84_0.method_1(new Action<GInterface0>(this.method_5));
			this.commandDispatcher_0.method_1<GClass265>(new Action<GClass265>(this.method_18));
			this.commandDispatcher_0.method_1<GClass239>(new Action<GClass239>(this.method_17));
			this.commandDispatcher_0.method_1<GClass205>(new Action<GClass205>(this.method_16));
			this.commandDispatcher_0.method_1<GClass228>(new Action<GClass228>(this.method_12));
			this.commandDispatcher_0.method_1<GClass142>(new Action<GClass142>(this.method_20));
			this.commandDispatcher_0.method_1<GClass226>(new Action<GClass226>(this.method_21));
			this.commandDispatcher_0.method_1<GClass143>(new Action<GClass143>(this.method_22));
			this.commandDispatcher_0.method_1<GClass157>(new Action<GClass157>(this.method_23));
			this.commandDispatcher_0.method_1<GClass159>(new Action<GClass159>(this.method_24));
			this.commandDispatcher_0.method_1<GClass168>(new Action<GClass168>(this.method_25));
		}
	}

	private void method_10()
	{
		if (this.commandDispatcher_1 == null)
		{
			this.commandDispatcher_1 = new CommandDispatcher();
			this.commandDispatcher_1.method_1<GClass248>(new Action<GClass248>(this.method_26));
			this.commandDispatcher_1.method_1<GClass206>(new Action<GClass206>(this.method_27));
			this.commandDispatcher_1.method_1<GClass266>(new Action<GClass266>(this.method_28));
			this.commandDispatcher_1.method_1<GClass240>(new Action<GClass240>(this.method_29));
			this.commandDispatcher_1.method_1<GClass255>(new Action<GClass255>(this.method_11));
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
					GClass84<GClass778> gclass = socket.method_4();
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
		d = new Action<GInterface0>(this.method_6);
		IL_CC:
		if (d != new Action<GInterface0>(this.method_6))
		{
			this.gameManager_0.Connection.Socket.method_4().method_1(new Action<GInterface0>(this.method_6));
			this.method_15();
		}
	}

	private void method_11(GClass255 gclass255_0)
	{
		string[] array;
		if (GClass90.smethod_1(gclass255_0.string_0, out array, new string[]
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
		else if (GClass90.smethod_1(gclass255_0.string_0, out array, new string[]
		{
			"i"
		}))
		{
			this.bool_1 = false;
		}
	}

	private void method_12(GClass228 gclass228_0)
	{
		this.bool_2 = false;
		IPErkavaBotController iperkavaBotController;
		if (!PErkava.smethod_0().TryGetValue(gclass228_0.int_2, out iperkavaBotController))
		{
			return;
		}
		this.gameManager_0 = iperkavaBotController.Game;
		this.gameManager_0.Settings.MapHosts = PErkava.concurrentDictionary_3[iperkavaBotController.GameServer].method_1();
		if (!iperkavaBotController.AttachPErkava(gclass228_0))
		{
			return;
		}
		this.gameManager_0.Connection.ProxySocket = this.method_0();
		this.method_10();
		this.method_15();
	}

	private void method_13(GClass91 gclass91_1, ErrorReason errorReason_0, Exception exception_0 = null)
	{
		if (errorReason_0 != ErrorReason.VersionMismatch && this.gclass91_0.method_0())
		{
			this.gameManager_0.Start();
		}
	}

	private void method_14(GClass91 gclass91_1)
	{
	}

	private void method_15()
	{
		this.IsAttached = true;
		PErkava.concurrentDictionary_0[this.wtAiPbPvAe2()] = this;
	}

	private void method_16(GClass205 gclass205_0)
	{
		byte[] array = new byte[64];
		for (int i = 0; i < 64; i++)
		{
			array[i] = 55;
		}
		BigInteger value = GClass780.smethod_0(gclass205_0.byteArray_0.Memory.ToArray());
		BigInteger exponent = GClass780.smethod_0(array);
		BigInteger value2 = GClass780.smethod_2("88b16bfc9d286fc09a941c8c74f38d43d196b5ed62abe59d408127cc589f93e022e0c2a5de7ef1c6973391c67977b3c829565b4257e449d5a2d6382acc8797a4");
		BigInteger modulus = GClass780.smethod_2("977fc15a826833231b431c2742e47b9afe9e3f176f6237f935ebd37bee9917b1f8ebfa31847e549553b1370c260c0f61f73f68999d204eb1633405d28caacf53");
		byte[] array2 = BigInteger.ModPow(value2, exponent, modulus).ToByteArray().Take(64).Reverse<byte>().ToArray<byte>();
		GClass780 gclass = new GClass780(GClass780.smethod_2("ef09b1bcec67808eeff374b1b51fb155edaac4fcc7a78ed75d5848d6e9eaabee41dec018bb5482d01acea8ce13688bfe33076dde70f06febb80cf3b7327953fb32c08889b815587ded2cdd056d0ec9965b894751848766c27fdee32c707b6fc9"), new BigInteger(65537), GClass780.smethod_2("0b7f1bdd4a41701d6fccf5bfd6463ff1320d148c53cdeb40d06c7e94578bc1d923b1e2eb4d9732f36f56a127c8272f1462f185708af8e56df795bc30c70a7ad52d12b950f35ae6f4103c738fccf485c31be178696560d39f1d9d71baeaed3941"));
		using (MemoryStream memoryStream = new MemoryStream())
		{
			gclass.method_11(array2, memoryStream, 0U, (uint)array2.Length);
			GClass206 ginterface0_ = new GClass206(new ByteArray(memoryStream.ToArray()));
			for (;;)
			{
				bool flag;
				if (PErkava.concurrentDictionary_2.TryGetValue(this.wtAiPbPvAe2(), out flag))
				{
					if (flag)
					{
						break;
					}
				}
				Thread.Sleep(500);
				this.gclass84_0.SendMessage(new GClass248());
			}
			this.gclass84_0.SendMessage(ginterface0_);
		}
		this.bool_0 = true;
		this.bool_2 = false;
		byte[] byte_ = BigInteger.ModPow(value, exponent, modulus).ToByteArray().Reverse<byte>().Take(16).ToArray<byte>();
		this.gclass84_0.method_4().method_0(byte_);
	}

	private void method_17(GClass239 gclass239_0)
	{
		GClass240 gclass = new GClass240(0, null);
		gclass.byteArray_0 = new ByteArray(Resources.payload);
		this.gclass84_0.SendMessage(gclass);
	}

	private void method_18(GClass265 gclass265_0)
	{
		GClass266 gclass = new GClass266(0, 145, 1, false);
		if (gclass.int_0 == gclass265_0.int_0 && gclass.int_1 == gclass265_0.int_1)
		{
			if (gclass.int_2 == gclass265_0.int_2)
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
				gclass265_0.int_0,
				gclass265_0.int_1,
				gclass265_0.int_2
			}));
			return;
		}
		this.gclass84_0.SendMessage(gclass);
	}

	public GClass845()
	{
		Class8.xDph7tozmh5WD();
		this.random_0 = new Random();
		base..ctor();
	}

	[CompilerGenerated]
	private void method_19(int int_0)
	{
		this.Status = string.Format("Patching... {0}MB", int_0);
	}

	[CompilerGenerated]
	private void method_20(GClass142 gclass142_0)
	{
		this.bool_2 = false;
	}

	[CompilerGenerated]
	private void method_21(GClass226 gclass226_0)
	{
		this.bool_2 = false;
		this.gclass84_0.SendMessage(new GClass248());
	}

	[CompilerGenerated]
	private void method_22(GClass143 gclass143_0)
	{
		this.bool_2 = false;
		if (gclass143_0.string_0.StartsWith("!dope"))
		{
			this.bool_2 = false;
			string str = gclass143_0.string_0.Substring(5).Trim();
			this.Game.method_9(new GClass255("69|" + str));
			this.method_0().SendMessage(new GClass645());
			return;
		}
		GInterface5 ginterface = null;
		if (gclass143_0.string_0.StartsWith("!!>"))
		{
			ginterface = this.Game.Connection;
		}
		else if (gclass143_0.string_0.StartsWith("!!<"))
		{
			ginterface = this.method_0();
		}
		if (ginterface == null)
		{
			this.bool_2 = true;
			return;
		}
		GClass255 ginterface0_ = new GClass255(gclass143_0.string_0.Substring(3));
		ginterface.SendMessage(ginterface0_);
		this.method_0().SendMessage(new GClass645());
	}

	[CompilerGenerated]
	private void method_23(GClass157 gclass157_0)
	{
		this.Game.Hero.method_5(gclass157_0.int_3, gclass157_0.int_1, gclass157_0.int_2, gclass157_0.int_0, this.Game.Hero.Speed);
	}

	[CompilerGenerated]
	private void method_24(GClass159 gclass159_0)
	{
		this.Game.Hero.Pet.Mode = (PetMode)gclass159_0.gclass244_0.Mode;
	}

	[CompilerGenerated]
	private void method_25(GClass168 gclass168_0)
	{
		this.bool_2 = false;
		File.AppendAllLines("client.txt", new List<string>
		{
			gclass168_0.string_0 + "-type-" + gclass168_0.uint_0
		});
	}

	[CompilerGenerated]
	private void method_26(GClass248 gclass248_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_27(GClass206 gclass206_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_28(GClass266 gclass266_0)
	{
		this.bool_1 = false;
	}

	[CompilerGenerated]
	private void method_29(GClass240 gclass240_0)
	{
		this.bool_1 = false;
	}

	private GClass91 gclass91_0;

	private GameManager gameManager_0;

	private GClass84<GClass777<GInterface6>> gclass84_0;

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
