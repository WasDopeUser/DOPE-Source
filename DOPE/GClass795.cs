using System;

public static class GClass795
{
	public static bool Cooldown(this DateTime date, int ms)
	{
		return (DateTime.Now - date).TotalMilliseconds >= (double)ms;
	}

	public static bool Cooldown(this DateTimeOffset date, int ms)
	{
		return (DateTimeOffset.Now - date).TotalMilliseconds >= (double)ms;
	}
}
