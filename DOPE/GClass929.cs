using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public sealed class GClass929 : IDisposable
{
	[DllImport("User32.dll")]
	private static extern bool RegisterHotKey(IntPtr intptr_0, int int_1, uint uint_0, uint uint_1);

	[DllImport("User32.dll")]
	private static extern bool UnregisterHotKey(IntPtr intptr_0, int int_1);

	public GClass929()
	{
		Class13.lOBHd9Nzn7x2T();
		this.window_0 = new GClass929.Window();
		base..ctor();
		this.window_0.method_0(new EventHandler<GEventArgs0>(this.method_3));
	}

	public void method_0(GEnum13 genum13_0, Keys keys_0)
	{
		this.int_0++;
		if (!GClass929.RegisterHotKey(this.window_0.Handle, this.int_0, (uint)genum13_0, (uint)keys_0))
		{
			throw new InvalidOperationException("Couldn’t register the hot key.");
		}
	}

	[CompilerGenerated]
	public void method_1(EventHandler<GEventArgs0> eventHandler_1)
	{
		EventHandler<GEventArgs0> eventHandler = this.eventHandler_0;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	[CompilerGenerated]
	public void method_2(EventHandler<GEventArgs0> eventHandler_1)
	{
		EventHandler<GEventArgs0> eventHandler = this.eventHandler_0;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	public void Dispose()
	{
		for (int i = this.int_0; i > 0; i--)
		{
			GClass929.UnregisterHotKey(this.window_0.Handle, i);
		}
		this.window_0.Dispose();
	}

	[CompilerGenerated]
	private void method_3(object sender, GEventArgs0 e)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, e);
		}
	}

	private GClass929.Window window_0;

	private int int_0;

	[CompilerGenerated]
	private EventHandler<GEventArgs0> eventHandler_0;

	private class Window : NativeWindow, IDisposable
	{
		public Window()
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor();
			this.CreateHandle(new CreateParams());
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == GClass929.Window.int_0)
			{
				Keys keys_ = (Keys)((int)m.LParam >> 16 & 65535);
				GEnum13 genum13_ = (GEnum13)((int)m.LParam & 65535);
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, new GEventArgs0(genum13_, keys_));
				}
			}
		}

		[CompilerGenerated]
		public void method_0(EventHandler<GEventArgs0> eventHandler_1)
		{
			EventHandler<GEventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		public void KamMwicMtn3(EventHandler<GEventArgs0> eventHandler_1)
		{
			EventHandler<GEventArgs0> eventHandler = this.eventHandler_0;
			EventHandler<GEventArgs0> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_1);
				eventHandler = Interlocked.CompareExchange<EventHandler<GEventArgs0>>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		public void Dispose()
		{
			this.DestroyHandle();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static Window()
		{
			Class13.lOBHd9Nzn7x2T();
			GClass929.Window.int_0 = 786;
		}

		private static int int_0;

		[CompilerGenerated]
		private EventHandler<GEventArgs0> eventHandler_0;
	}
}
