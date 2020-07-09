using System;

public static class GClass874
{
	public static bool Cooldown(this DateTime date, int ms)
	{
		return (DateTime.Now - date).TotalMilliseconds >= (double)ms;
	}

	public static bool Cooldown(this DateTimeOffset date, int ms)
	{
		return (DateTimeOffset.Now - date).TotalMilliseconds >= (double)ms;
	}

	public static bool smethod_0(this DateTimeOffset dateTimeOffset_0, int int_0)
	{
		DateTimeOffset now = DateTimeOffset.Now;
		return !(dateTimeOffset_0 > now) && (now - dateTimeOffset_0).TotalMilliseconds <= (double)int_0;
	}

	public static bool smethod_1(this DateTimeOffset dateTimeOffset_0, TimeSpan timeSpan_0)
	{
		DateTimeOffset now = DateTimeOffset.Now;
		return !(dateTimeOffset_0 > now) && now - dateTimeOffset_0 <= timeSpan_0;
	}
}
