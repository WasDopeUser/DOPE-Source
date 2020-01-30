using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using PErkava;

public static class GClass857
{
	public static IEnumerable<IntPtr> smethod_0(GClass856 gclass856_0, GClass858.GStruct3 gstruct3_0, byte[] byte_0)
	{
		goto IL_23;
		for (;;)
		{
			IEnumerator<int> enumerator;
			long pos;
			long left;
			long toRead;
			IntPtr from;
			try
			{
				IL_133:
				if (!enumerator.MoveNext())
				{
					goto JumpOutOfTryFinally-3;
				}
				goto IL_1A1;
				IL_23:
				int bufferSize = (int)Math.Min(gstruct3_0.long_0, (long)Math.Max(1048576, byte_0.Length * 4));
				byte[] buf = new byte[bufferSize];
				pos = 0L;
				left = gstruct3_0.long_0;
				GClass861 kmp = new GClass861(byte_0);
				Debug.WriteLine(gstruct3_0.long_0);
				goto IL_18B;
				IL_B2:
				toRead = Math.Min((long)bufferSize, left);
				from = (IntPtr)((long)gstruct3_0.intptr_0 + pos);
				if (!gclass856_0.method_8(from, buf, (int)toRead))
				{
					goto IL_1D1;
				}
				enumerator = kmp.method_4(buf).GetEnumerator();
				goto IL_133;
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			goto JumpOutOfTryFinally-3;
			IL_18B:
			if (left <= 0L)
			{
				break;
			}
			goto IL_B2;
			IL_1A1:
			int num = enumerator.Current;
			yield return new IntPtr((long)from + (long)num);
			continue;
			JumpOutOfTryFinally-3:
			enumerator = null;
			left -= toRead;
			pos += toRead;
			pos -= (long)(byte_0.Length - 1);
			goto IL_18B;
		}
		IL_1D1:
		yield break;
		yield break;
	}

	public static bool smethod_1(IntPtr intptr_0, Action<int> action_0 = null)
	{
		List<IntPtr> list = new GClass859(intptr_0).method_0();
		uint num;
		GClass858.GetWindowThreadProcessId(intptr_0, out num);
		Process processById = Process.GetProcessById((int)num);
		list.Reverse();
		List<uint> list2 = list.Select(new Func<IntPtr, uint>(GClass857.<>c.<>c_0.method_0)).ToList<uint>();
		list2.Add(num);
		if (processById.ProcessName.StartsWith("chrome"))
		{
			list2 = Process.GetProcessesByName("chrome").Select(new Func<Process, uint>(GClass857.<>c.<>c_0.method_1)).ToList<uint>();
			List<uint> list3 = new List<uint>();
			foreach (uint num2 in list2)
			{
				string text = GClass858.smethod_3(num2);
				if (text != null && text.Contains("flash"))
				{
					list3.Add(num2);
					Debug.WriteLine(string.Format("Found chrome flash player @{0:X2}", num2));
				}
			}
			list2 = list3;
		}
		list2 = list2.GroupBy(new Func<uint, uint>(GClass857.<>c.<>c_0.method_2)).Select(new Func<IGrouping<uint, uint>, uint>(GClass857.<>c.<>c_0.method_3)).ToList<uint>();
		bool flag = false;
		long num3 = 0L;
		foreach (uint int_ in list2)
		{
			GClass856 gclass = new GClass856((int)int_);
			if (!gclass.method_6())
			{
				MessageBox.Show("Your browser is compiled for different architecture. Please use the " + (GClass858.smethod_1() ? "64" : "32") + "-bit version of PErkava.");
				return false;
			}
			foreach (GClass858.GStruct3 gstruct in gclass.method_4())
			{
				foreach (IntPtr intptr_ in GClass857.smethod_0(gclass, gstruct, Encoding.UTF8.GetBytes("cc0306d7b0f0c671000bd655485744417a868b29dd77619e42b51f70c28e67d0bbc2caf9dd364cb0419217bcfba86c33735b543fae2b666059b59c631955962afa1f97e0f49f92bf1a5463ae89c751a661e0485c2ec6e011634abfb4a4142157")))
				{
					flag = true;
					gclass.method_7(intptr_, Encoding.UTF8.GetBytes("ef09b1bcec67808eeff374b1b51fb155edaac4fcc7a78ed75d5848d6e9eaabee41dec018bb5482d01acea8ce13688bfe33076dde70f06febb80cf3b7327953fb32c08889b815587ded2cdd056d0ec9965b894751848766c27fdee32c707b6fc9"));
				}
				num3 += gstruct.long_0;
				if (action_0 != null)
				{
					action_0((int)(num3 / 1024L / 1024L));
				}
			}
			if (flag)
			{
				PErkava.hashSet_0.Add((uint)gclass.method_0());
			}
		}
		return flag;
	}
}
