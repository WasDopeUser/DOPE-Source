using System;
using Newtonsoft.Json;

namespace DarkorbitAPI.CommonStructures
{
	[JsonObject]
	public class FlashSettings
	{
		public string lang { get; set; }

		public int userID { get; set; }

		public string sessionID { get; set; }

		public string basePath { get; set; }

		public int pid { get; set; }

		public string boardLink { get; set; }

		public string helpLink { get; set; }

		public string loadingClaim { get; set; }

		public string chatHost { get; set; }

		public string cdn { get; set; }

		public string useHash { get; set; }

		public string host { get; set; }

		public string browser { get; set; }

		public string fullscreen { get; set; }

		public string itemXmlHash { get; set; }

		public string resourcesXmlHash { get; set; }

		public string resources3dXmlHash { get; set; }

		public string resources3dparticlesXmlHash { get; set; }

		public string resourceachievementsXmlHash { get; set; }

		public string profileXmlHash { get; set; }

		public string languageXmlHash { get; set; }

		public string loadingscreenHash { get; set; }

		public string gameclientHash { get; set; }

		public string gameclientPath { get; set; }

		public string loadingscreenAssetsXmlHash { get; set; }

		public string crossdomainHash { get; set; }

		public string showAdvertisingHint { get; set; }

		public string gameclientAllowedInitDelay { get; set; }

		public string eventStreamContext { get; set; }

		public string requestScheme { get; set; }

		public string sharedImages { get; set; }

		public string useDeviceFonts { get; set; }

		public string String_0 { get; set; }

		public string theme { get; set; }

		public int factionID { get; set; }

		public string autoStartEnabled { get; set; }

		public int mapID { get; set; }

		public string newUser { get; set; }

		public string allowChat { get; set; }

		public FlashSettings()
		{
			Class13.lOBHd9Nzn7x2T();
			base..ctor();
		}
	}
}
