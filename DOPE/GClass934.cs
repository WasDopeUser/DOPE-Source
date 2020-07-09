using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class GClass934 : Interface0
{
	[CompilerGenerated]
	public Dictionary<string, GClass934.GClass935> method_0()
	{
		return this.dictionary_0;
	}

	public bool imethod_1()
	{
		try
		{
			GClass934.GClass935 gclass = new GClass934.GClass935("69.69.69.69", false);
			gclass.method_1();
			return gclass.lvkMuSgDho3(false);
		}
		catch
		{
		}
		return false;
	}

	public void EMJCLLSWGGV(HashSet<string> hashSet_0 = null)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (hashSet_0 != null)
			{
				using (HashSet<string>.Enumerator enumerator = hashSet_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						GClass934.GClass935 gclass;
						if (!this.method_0().TryGetValue(text, out gclass))
						{
							gclass = new GClass934.GClass935(text, false);
						}
						gclass.lvkMuSgDho3(true);
						this.method_0().Remove(text);
					}
					return;
				}
			}
			GClass934.GClass935 gclass2 = new GClass934.GClass935("127.0.0.1", false);
			this.EMJCLLSWGGV(gclass2.method_2());
		}
	}

	public void imethod_0(string[] string_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (string text in string_0)
			{
				GClass934.GClass935 gclass;
				if (!this.method_0().TryGetValue(text, out gclass))
				{
					gclass = (this.method_0()[text] = new GClass934.GClass935(text, false));
				}
				if (gclass.bool_0)
				{
					gclass.method_1();
				}
			}
		}
	}

	public GClass934()
	{
		Class13.lOBHd9Nzn7x2T();
		this.dictionary_0 = new Dictionary<string, GClass934.GClass935>();
		this.object_0 = new object();
		base..ctor();
	}

	[CompilerGenerated]
	private readonly Dictionary<string, GClass934.GClass935> dictionary_0;

	private readonly object object_0;

	public class GClass935
	{
		public GClass935(string string_1, bool bool_1 = false)
		{
			Class13.lOBHd9Nzn7x2T();
			this.string_0 = "";
			base..ctor();
			this.ipaddress_0 = IPAddress.Parse(string_1);
			this.bool_0 = true;
		}

		~GClass935()
		{
			if (!this.bool_0)
			{
				this.lvkMuSgDho3(false);
			}
		}

		public string method_0(string string_1)
		{
			Process process = new Process();
			this.string_0 = "";
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/c " + string_1,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				UseShellExecute = false
			};
			process.OutputDataReceived += this.method_4;
			process.Start();
			process.EnableRaisingEvents = true;
			process.BeginOutputReadLine();
			process.WaitForExit();
			return this.string_0;
		}

		public void method_1()
		{
			this.bool_0 = false;
			string text;
			if ((text = this.method_0(string.Concat(new string[]
			{
				"netsh int ip add addr ",
				this.method_3().ToString(),
				" ",
				this.ipaddress_0.ToString(),
				"/32 st=ac sk=tr"
			}))).Length <= 3)
			{
				return;
			}
			if (this.lvkMuSgDho3(true))
			{
				this.method_1();
				return;
			}
			text = text.Replace("\n", "").Replace("\r", "");
			if (text.ToLower().Contains("dhcp"))
			{
				this.method_0("netsh interface ip set dns \"Loopback Pseudo - Interface 1\" dhcp");
			}
			throw new Exception("An error ocurred, >" + text + "\n");
		}

		public bool lvkMuSgDho3(bool bool_1 = false)
		{
			if (this.bool_0 && !bool_1)
			{
				return true;
			}
			this.bool_0 = true;
			return this.method_0("netsh int ip delete addr " + this.method_3().ToString() + " " + this.ipaddress_0.ToString()).Length <= 3;
		}

		public HashSet<string> method_2()
		{
			HashSet<string> hashSet = new HashSet<string>();
			this.method_0("netsh int ip show ipaddresses " + this.method_3().ToString());
			foreach (object obj in Regex.Matches(this.string_0, "(?:\\d{1,3}\\.){3}\\d{1,3}"))
			{
				string value = ((Match)obj).Groups[0].Value;
				if (!(value == "127.0.0.1") && !value.StartsWith("192.168"))
				{
					hashSet.Add(value);
				}
			}
			return hashSet;
		}

		public int method_3()
		{
			return NetworkInterface.LoopbackInterfaceIndex;
		}

		private void method_4(object sender, DataReceivedEventArgs e)
		{
			this.string_0 = this.string_0 + e.Data + "\n";
		}

		public string string_0;

		public volatile bool bool_0;

		public IPAddress ipaddress_0;
	}
}
