using System;

namespace DarkorbitAPI.CommonStructures
{
	public class ProxySettings
	{
		public string User { get; set; }

		public string Password { get; set; }

		public string Host { get; set; }

		public int Port { get; set; }

		public ProxySettings(string string_0, string string_1, string string_2, int int_0)
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor();
			this.User = string_0;
			this.Password = string_1;
			this.Host = string_2;
			this.Port = int_0;
		}

		public override string ToString()
		{
			if (this.User != null)
			{
				return string.Format("{0}:{1}@{2}:{3}", new object[]
				{
					this.User,
					this.Password,
					this.Host,
					this.Port
				});
			}
			return string.Format("{0}:{1}", this.Host, this.Port);
		}

		public static ProxySettings smethod_0(string string_0)
		{
			if (string.IsNullOrEmpty(string_0))
			{
				return null;
			}
			string_0 = string_0.Trim();
			int num = string_0.LastIndexOf("@");
			string string_ = null;
			string string_2 = null;
			int int_ = 0;
			string[] array;
			if (num > -1 && string_0.Length > num + 1)
			{
				array = string_0.Substring(0, num).Split(new char[]
				{
					':'
				});
				if (array.Length == 2)
				{
					string_ = array[0];
					string_2 = array[1];
				}
				string_0 = string_0.Substring(num + 1);
			}
			array = string_0.Split(new char[]
			{
				':'
			});
			if (array.Length == 2 && int.TryParse(array[1], out int_))
			{
				return new ProxySettings(string_, string_2, array[0], int_);
			}
			return null;
		}
	}
}
