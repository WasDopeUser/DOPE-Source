﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;

public class GClass866 : Interface0
{
	private static z4JKPx4PxgIAEw5am3F smethod_0<z4JKPx4PxgIAEw5am3F>(ManagementObject managementObject_0, string string_0)
	{
		GClass866.<>c__DisplayClass0_0<z4JKPx4PxgIAEw5am3F> CS$<>8__locals1 = new GClass866.<>c__DisplayClass0_0<z4JKPx4PxgIAEw5am3F>();
		CS$<>8__locals1.property = string_0;
		PropertyData propertyData = managementObject_0.Properties.Cast<PropertyData>().FirstOrDefault(new Func<PropertyData, bool>(CS$<>8__locals1.method_0));
		return (z4JKPx4PxgIAEw5am3F)((object)((propertyData != null) ? propertyData.Value : null));
	}

	public static bool smethod_1(string string_0, TimeSpan timeSpan_0)
	{
		if (string_0 == "99999999235959.000000:000")
		{
			return false;
		}
		bool result;
		try
		{
			result = (ManagementDateTimeConverter.ToTimeSpan(string_0) <= timeSpan_0);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public bool imethod_2()
	{
		try
		{
			ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\standardcimv2");
			new ManagementClass(scope, new ManagementPath("MSFT_NetIPAddress"), new ObjectGetOptions());
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(scope, new ObjectQuery("SELECT * FROM MSFT_NetIPAddress")).Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public void imethod_0(HashSet<string> hashSet_0 = null)
	{
		ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\standardcimv2");
		new ManagementClass(scope, new ManagementPath("MSFT_NetIPAddress"), new ObjectGetOptions());
		foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(scope, new ObjectQuery("SELECT * FROM MSFT_NetIPAddress")).Get())
		{
			ManagementObject managementObject = (ManagementObject)managementBaseObject;
			string item = GClass866.smethod_0<string>(managementObject, "IPAddress");
			if ((long)NetworkInterface.LoopbackInterfaceIndex == (long)((ulong)GClass866.smethod_0<uint>(managementObject, "InterfaceIndex")) & (GClass866.smethod_1(GClass866.smethod_0<string>(managementObject, "PreferredLifetime"), TimeSpan.FromHours(24.0)) && (hashSet_0 == null || hashSet_0.Contains(item))))
			{
				managementObject.Delete();
			}
		}
	}

	public void imethod_1(string[] string_0)
	{
		HashSet<string> hashSet = new HashSet<string>(string_0);
		ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\standardcimv2");
		ManagementClass managementClass = new ManagementClass(scope, new ManagementPath("MSFT_NetIPAddress"), new ObjectGetOptions());
		foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(scope, new ObjectQuery("SELECT * FROM MSFT_NetIPAddress")).Get())
		{
			string item = GClass866.smethod_0<string>((ManagementObject)managementBaseObject, "IPAddress");
			hashSet.Remove(item);
		}
		ManagementBaseObject methodParameters = managementClass.GetMethodParameters("Create");
		methodParameters["InterfaceIndex"] = NetworkInterface.LoopbackInterfaceIndex;
		methodParameters["PreferredLifetime"] = ManagementDateTimeConverter.ToDmtfTimeInterval(TimeSpan.FromHours(24.0));
		foreach (string value in hashSet)
		{
			methodParameters["IPAddress"] = value;
			managementClass.InvokeMethod("Create", methodParameters, null);
		}
	}

	public GClass866()
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
	}
}
