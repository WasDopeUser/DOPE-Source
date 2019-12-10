using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class GClass90
{
	public static Dictionary<string, string> smethod_0(string string_0)
	{
		string pattern = "{w:(.+?),v:(.+?)}";
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (object obj in Regex.Matches(string_0, pattern))
		{
			Match match = (Match)obj;
			dictionary[match.Groups[1].Value] = match.Groups[2].Value;
		}
		return dictionary;
	}

	public static bool smethod_1(string string_0, out string[] string_1, params string[] args)
	{
		string[] array = string_0.Split(new char[]
		{
			'|'
		});
		string_1 = null;
		int num = 0;
		int num2 = 0;
		while (num < args.Length && num + 1 < array.Length)
		{
			if (!(array[num + 1] == args[num]))
			{
				return false;
			}
			num2++;
			num++;
		}
		if (num2 == args.Length)
		{
			string_1 = array.Skip(num2 + 1).ToArray<string>();
		}
		return num2 == args.Length;
	}

	public static string smethod_2(int int_0, bool bool_0)
	{
		return string.Format("0|n|INV|{0}|{1}", int_0, bool_0 ? 1 : 0);
	}

	public static string Log(string text)
	{
		return "0|A|STD|" + text;
	}
}
