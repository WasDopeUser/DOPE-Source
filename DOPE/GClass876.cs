using System;
using System.Management;
using System.Runtime.InteropServices;

public static class GClass876
{
	[DllImport("User32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("User32.dll", SetLastError = true)]
	public static extern uint GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern void GetSystemInfo(out GClass876.GStruct1 gstruct1_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GClass876.GStruct2 gstruct2_0, uint uint_0);

	[DllImport("kernel32.dll", EntryPoint = "VirtualQueryEx", SetLastError = true)]
	public static extern int VirtualQueryEx_1(IntPtr intptr_0, IntPtr intptr_1, out GClass876.GStruct3 gstruct3_0, uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, ref int int_1);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, ref int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process([In] IntPtr intptr_0, out bool bool_0);

	public static bool smethod_0(IntPtr intptr_0)
	{
		bool flag;
		return !Environment.Is64BitOperatingSystem || ((Environment.OSVersion.Version.Major > 5 || (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1)) && (GClass876.IsWow64Process(intptr_0, out flag) && flag));
	}

	public static bool smethod_1()
	{
		return !Environment.Is64BitProcess;
	}

	public static GClass876.GStruct3 smethod_2(IntPtr intptr_0, IntPtr intptr_1, out int int_0)
	{
		int_0 = 0;
		GClass876.GStruct3 result = default(GClass876.GStruct3);
		if (GClass876.smethod_1())
		{
			GClass876.GStruct2 gstruct = default(GClass876.GStruct2);
			if (GClass876.VirtualQueryEx(intptr_0, intptr_1, out gstruct, (uint)Marshal.SizeOf(typeof(GClass876.GStruct2))) != 0)
			{
				result.intptr_1 = gstruct.intptr_1;
				result.int_0 = gstruct.int_0;
				result.intptr_0 = gstruct.intptr_0;
				result.int_1 = gstruct.int_2;
				result.long_0 = (long)gstruct.int_1;
				result.State = gstruct.State;
				result.int_2 = gstruct.int_3;
				return result;
			}
			int_0 = Marshal.GetLastWin32Error();
		}
		else
		{
			if (GClass876.VirtualQueryEx_1(intptr_0, intptr_1, out result, (uint)Marshal.SizeOf(typeof(GClass876.GStruct3))) != 0)
			{
				return result;
			}
			int_0 = Marshal.GetLastWin32Error();
		}
		return result;
	}

	public static string smethod_3(uint uint_0)
	{
		string text = null;
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(string.Format("SELECT CommandLine FROM Win32_Process WHERE ProcessId = {0}", uint_0)))
		{
			ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
			if (enumerator.MoveNext())
			{
				object obj = enumerator.Current["CommandLine"];
				text = ((obj != null) ? obj.ToString() : null);
			}
		}
		if (text == null)
		{
			return "";
		}
		return text;
	}

	public struct GStruct1
	{
		public ushort ushort_0;

		private ushort ushort_1;

		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	public struct GStruct2
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;

		public int State;

		public int int_2;

		public int int_3;
	}

	public struct GStruct3
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public uint uint_0;

		public long long_0;

		public int State;

		public int int_1;

		public int int_2;

		public uint uint_1;
	}
}
