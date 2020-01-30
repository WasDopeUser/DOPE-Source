using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class Settings
	{
		public FlashSettings FlashSettings { get; set; }

		public int MapId { get; internal set; }

		public string UserAgent { get; set; }

		public bool Use3D { get; set; }

		public bool IsClient { get; set; }

		public string UIString { get; set; }

		public Settings()
		{
			Class13.Gj4N3WdzaR1LY();
			this.FlashSettings = new FlashSettings();
			this.IsClient = true;
			this.MapHosts = new Dictionary<int, string>();
			this.SpacemapConfig = new DarkOrbitWebAPI.spacemap();
			base..ctor();
		}

		public Dictionary<int, string> MapHosts;

		public DarkOrbitWebAPI.spacemap SpacemapConfig;
	}
}
