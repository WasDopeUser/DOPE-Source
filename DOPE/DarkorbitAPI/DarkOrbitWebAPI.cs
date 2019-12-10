using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DarkorbitAPI.CommonStructures;
using Newtonsoft.Json;

namespace DarkorbitAPI
{
	public class DarkOrbitWebAPI : INotifyPropertyChanged
	{
		static DarkOrbitWebAPI()
		{
			Class8.xDph7tozmh5WD();
			DarkOrbitWebAPI.randomizer = new Random();
			DarkOrbitWebAPI.place_bet_btn = "BID";
			DarkOrbitWebAPI.ServerInstances = null;
			ServicePointManager.DnsRefreshTimeout = (int)TimeSpan.FromMinutes(1.0).TotalMilliseconds;
		}

		public string Sid
		{
			[CompilerGenerated]
			get
			{
				return this.<Sid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Sid>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Sid>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_84);
			}
		}

		public string Uid
		{
			[CompilerGenerated]
			get
			{
				return this.<Uid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Uid>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Uid>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_89);
			}
		}

		public DarkOrbitWebAPI.GalaxyGatesInfo GgInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<GgInfo>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<GgInfo>k__BackingField, value))
				{
					return;
				}
				this.<GgInfo>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_20);
			}
		}

		public EquipmentAPI Equipment
		{
			[CompilerGenerated]
			get
			{
				return this.<Equipment>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Equipment>k__BackingField, value))
				{
					return;
				}
				this.<Equipment>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_15);
			}
		}

		public GClass78 Skylab { get; }

		public string UserName
		{
			[CompilerGenerated]
			get
			{
				return this.<UserName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<UserName>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<UserName>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_91);
			}
		}

		public string Server
		{
			[CompilerGenerated]
			get
			{
				return this.<Server>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Server>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Server>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_80);
			}
		}

		public bool IsLoggedIn
		{
			[CompilerGenerated]
			get
			{
				return this.<IsLoggedIn>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<IsLoggedIn>k__BackingField == value)
				{
					return;
				}
				this.<IsLoggedIn>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.IsLoggedIn);
			}
		}

		public string ForcedUserAgent
		{
			[CompilerGenerated]
			get
			{
				return this.<ForcedUserAgent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<ForcedUserAgent>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<ForcedUserAgent>k__BackingField = value;
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_90);
				this.<>OnPropertyChanged(Class1.propertyChangedEventArgs_17);
			}
		}

		public string UserAgent
		{
			get
			{
				GameManager game = this.Game;
				string result;
				if (game != null)
				{
					Settings settings = game.Settings;
					if (settings != null)
					{
						if ((result = settings.UserAgent) != null)
						{
							return result;
						}
					}
				}
				result = (this.ForcedUserAgent ?? "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
				return result;
			}
		}

		public GameManager Game { get; }

		public DarkOrbitWebAPI(GameManager game)
		{
			Class8.xDph7tozmh5WD();
			this.BootyArray = new string[3];
			this.HourAuctionItems = new List<DarkOrbitWebAPI.Item>();
			this.MyOffers = new List<DarkOrbitWebAPI.Item>();
			this.ReloadToken = "";
			base..ctor();
			this.Game = game;
			this.Cookies = new CookieContainer();
			HttpClientHandler httpClientHandler = new HttpClientHandler
			{
				CookieContainer = this.Cookies,
				AllowAutoRedirect = true,
				AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate),
				UseCookies = true
			};
			try
			{
				httpClientHandler.MaxConnectionsPerServer = 1000;
			}
			catch (NotImplementedException)
			{
			}
			this._handler = httpClientHandler;
			this.Http = new HttpClient(httpClientHandler, true);
			this.Http.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
			{
				MaxAge = new TimeSpan?(TimeSpan.Zero)
			};
			this.Http.DefaultRequestHeaders.ConnectionClose = new bool?(true);
			this.Http.DefaultRequestHeaders.UserAgent.ParseAdd(this.UserAgent);
			this.Equipment = new EquipmentAPI(this);
			this.Skylab = new GClass78(this);
		}

		public bool CheckLoggedIn()
		{
			return this.CheckedLoggedIn(this.Get(GClass801.smethod_0(this.Server, null), null).Content);
		}

		private IDictionary<string, string> GetValues(object data)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (data != null)
			{
				foreach (object obj in TypeDescriptor.GetProperties(data))
				{
					PropertyDescriptor propertyDescriptor = (PropertyDescriptor)obj;
					object value = propertyDescriptor.GetValue(data);
					dictionary.Add(propertyDescriptor.Name, (value != null) ? value.ToString() : null);
				}
			}
			return dictionary;
		}

		public bool CheckedLoggedIn(string src)
		{
			bool result;
			try
			{
				this.Uid = this.GetUID(src);
				goto IL_17;
			}
			catch
			{
				result = false;
			}
			return result;
			IL_17:
			return !string.IsNullOrEmpty(this.Uid);
		}

		public async Task<DarkOrbitWebAPI.Response> PostAsync(string sUrl, IDictionary<string, string> data, string referer = "https://darkorbit.com", Action<FormUrlEncodedContent> conf = null)
		{
			DateTime now = DateTime.Now;
			Uri uri = new Uri(sUrl);
			FormUrlEncodedContent formUrlEncodedContent = new FormUrlEncodedContent(data);
			HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, sUrl);
			httpRequestMessage.Content = formUrlEncodedContent;
			httpRequestMessage.Headers.Referrer = new Uri(referer);
			httpRequestMessage.Headers.UserAgent.ParseAdd(this.UserAgent);
			if (conf != null)
			{
				conf(formUrlEncodedContent);
			}
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.Http.SendAsync(httpRequestMessage).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			HttpResponseMessage result = taskAwaiter.GetResult();
			HttpResponseMessage response = result;
			response.EnsureSuccessStatusCode();
			TaskAwaiter<string> taskAwaiter3 = response.Content.ReadAsStringAsync().GetAwaiter();
			if (!taskAwaiter3.IsCompleted)
			{
				await taskAwaiter3;
				TaskAwaiter<string> taskAwaiter4;
				taskAwaiter3 = taskAwaiter4;
				taskAwaiter4 = default(TaskAwaiter<string>);
			}
			string result2 = taskAwaiter3.GetResult();
			string reloadToken = this.GetReloadToken(result2);
			if (reloadToken.Length > 2)
			{
				string reloadToken2 = this.ReloadToken;
				lock (reloadToken2)
				{
					this.ReloadToken = reloadToken;
				}
			}
			return new DarkOrbitWebAPI.Response(uri, result2, response);
		}

		public DarkOrbitWebAPI.Response Post(string sUrl, IDictionary<string, string> data, string referer = "https://darkorbit.com", Action<FormUrlEncodedContent> conf = null)
		{
			return this.PostAsync(sUrl, data, referer, conf).GetAwaiter().GetResult();
		}

		public async Task<DarkOrbitWebAPI.Response> GetAsync(string sUrl, Action<HttpRequestMessage> config = null)
		{
			Uri uri = new Uri(sUrl);
			HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, sUrl);
			httpRequestMessage.Headers.UserAgent.ParseAdd(this.UserAgent);
			if (config != null)
			{
				config(httpRequestMessage);
			}
			TaskAwaiter<HttpResponseMessage> taskAwaiter = this.Http.SendAsync(httpRequestMessage).GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				TaskAwaiter<HttpResponseMessage> taskAwaiter2;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			}
			HttpResponseMessage result = taskAwaiter.GetResult();
			HttpResponseMessage response = result;
			TaskAwaiter<string> taskAwaiter3 = response.Content.ReadAsStringAsync().GetAwaiter();
			if (!taskAwaiter3.IsCompleted)
			{
				await taskAwaiter3;
				TaskAwaiter<string> taskAwaiter4;
				taskAwaiter3 = taskAwaiter4;
				taskAwaiter4 = default(TaskAwaiter<string>);
			}
			string result2 = taskAwaiter3.GetResult();
			string reloadToken = this.GetReloadToken(result2);
			if (reloadToken.Length > 2)
			{
				string reloadToken2 = this.ReloadToken;
				lock (reloadToken2)
				{
					this.ReloadToken = reloadToken;
				}
			}
			return new DarkOrbitWebAPI.Response(uri, result2, response);
		}

		public DarkOrbitWebAPI.Response Get(string url, Action<HttpRequestMessage> config = null)
		{
			return this.GetAsync(url, config).GetAwaiter().GetResult();
		}

		public static string StringBetween(string content, string strStart, string strEnd)
		{
			string result;
			try
			{
				int length = strStart.Length;
				string text = string.Empty;
				int num = content.IndexOf(strStart, 0);
				int num2 = content.IndexOf(strEnd, num + length);
				if (num != -1 && num2 != -1)
				{
					text = content.Substring(num + length, num2 - (num + length));
				}
				result = text;
			}
			catch
			{
				result = Convert.ToString(false);
			}
			return result;
		}

		public static string StringRegExp(string content, string regstring)
		{
			string result = "";
			Match match = Regex.Match(content, regstring, RegexOptions.Multiline);
			if (match.Groups.Count > 1)
			{
				result = match.Groups[1].Value;
			}
			return result;
		}

		public void FillServerInstances()
		{
			if (!this.IsLoggedIn)
			{
				return;
			}
			MatchCollection matchCollection = Regex.Matches(JsonConvert.DeserializeObject<DarkOrbitWebAPI.ServerInstanceList>(this.Post(GClass801.smethod_5(this.Server), new Dictionary<string, string>
			{
				{
					"command",
					"getInstanceList"
				}
			}, "https://darkorbit.com", null).Content).code, "tr\\s+id=\"serverSelection_ini_(\\d+)\".*?target=\\\".*?\\/\\/(.+?)\\.");
			if (matchCollection.Count != 0)
			{
				DarkOrbitWebAPI.ServerInstances = matchCollection.Cast<Match>().ToDictionary((Match t) => int.Parse(t.Groups[1].Value), (Match t) => t.Groups[2].Value);
				string.Join(",", from t in DarkOrbitWebAPI.ServerInstances
				select t.Value);
				string.Join(",", from t in DarkOrbitWebAPI.ServerInstances
				select string.Format("{{{0}, \"{1}\"}}", t.Key, t.Value));
			}
		}

		public bool LoginBySid(string sid, string server, bool skipCheck = false)
		{
			this.Server = server;
			CookieCollection cookieCollection = new CookieCollection();
			cookieCollection.Add(new Cookie("dosid", sid, "/", server + ".darkorbit.com"));
			this.Cookies = new CookieContainer();
			this.Cookies.Add(cookieCollection);
			this._handler.CookieContainer = this.Cookies;
			bool isLoggedIn;
			if (isLoggedIn = (skipCheck || this.CheckLoggedIn()))
			{
				this.Sid = sid;
			}
			return this.IsLoggedIn = isLoggedIn;
		}

		public bool Login(string username, string password, string server)
		{
			DarkOrbitWebAPI.<>c__DisplayClass80_0 CS$<>8__locals1 = new DarkOrbitWebAPI.<>c__DisplayClass80_0();
			CS$<>8__locals1.username = username;
			CS$<>8__locals1.server = server;
			CS$<>8__locals1.<>4__this = this;
			this.IsLoggedIn = false;
			CS$<>8__locals1.server = CS$<>8__locals1.server.ToLower();
			this.Server = CS$<>8__locals1.server;
			string text = GClass801.vZhiielSeJt(CS$<>8__locals1.server);
			CS$<>8__locals1.reqs = 0;
			DarkOrbitWebAPI.Response response = this.Get(text, null);
			CS$<>8__locals1.token = DarkOrbitWebAPI.StringBetween(response.Content, "bgcdw_login_form\" action=\"", "\"").Replace("amp;", "");
			string text2 = CS$<>8__locals1.token.Split(new string[]
			{
				"token="
			}, StringSplitOptions.None)[1];
			int.Parse(DarkOrbitWebAPI.StringBetween(CS$<>8__locals1.token, "authUser=", "&"));
			CS$<>8__locals1.resp = null;
			try
			{
				CS$<>8__locals1.resp = this.Post(CS$<>8__locals1.token, new Dictionary<string, string>
				{
					{
						"username",
						CS$<>8__locals1.username
					},
					{
						"password",
						password
					}
				}, "https://darkorbit.com", null);
				CS$<>8__locals1.method_1();
				string text3 = CS$<>8__locals1.resp.Data.RequestMessage.RequestUri.Host.Split(new char[]
				{
					'.'
				})[0].Trim();
				if (((text3 != null) ? text3.ToLower() : null) != this.Server)
				{
					CS$<>8__locals1.resp = this.Post(GClass801.smethod_5(text3), new Dictionary<string, string>
					{
						{
							"command",
							"getInstanceList"
						}
					}, "https://darkorbit.com", null);
					Match match = Regex.Matches(JsonConvert.DeserializeObject<DarkOrbitWebAPI.ServerInstanceList>(CS$<>8__locals1.resp.Content).code, "tr\\s+id=\"serverSelection_ini_\\d+\".*?target=\\\"(.+?)\\\"").Cast<Match>().FirstOrDefault((Match t) => t.Groups[1].Value.Contains("//" + CS$<>8__locals1.<>4__this.Server + "."));
					if (match == null)
					{
						this.IsLoggedIn = false;
						return false;
					}
					CS$<>8__locals1.resp = this.Get(match.Groups[1].Value, null);
				}
				string content = CS$<>8__locals1.resp.Content;
				this.UserName = this.GetLocalUsername(content);
				this.Uid = this.GetUID(content);
			}
			catch (Exception)
			{
				this.IsLoggedIn = false;
			}
			this.IsLoggedIn = !string.IsNullOrWhiteSpace(this.Uid);
			if (CS$<>8__locals1.resp != null && !this.IsLoggedIn)
			{
				CS$<>8__locals1.method_0(CS$<>8__locals1.resp);
			}
			if (this.IsLoggedIn)
			{
				if (string.IsNullOrWhiteSpace(this.UserName))
				{
					this.UserName = string.Concat(new string[]
					{
						"<",
						CS$<>8__locals1.username,
						"_",
						CS$<>8__locals1.server,
						">"
					});
				}
				this.Sid = this.Cookies.GetCookies(new Uri(text)).Cast<Cookie>().FirstOrDefault<Cookie>().Value;
				if (DarkOrbitWebAPI.ServerInstances == null)
				{
					this.FillServerInstances();
				}
			}
			return this.IsLoggedIn;
		}

		public string[] GetBootys(string content)
		{
			this.Get("https://" + this.Server + ".darkorbit.bigpoint.com/indexInternal.es.php?action=internalDock", null);
			string text = DarkOrbitWebAPI.StringRegExp(content, "<span title=" + '"'.ToString() + "(\\d) ");
			string text2 = DarkOrbitWebAPI.StringRegExp(content, "<span title=" + '"'.ToString() + "(\\d) ");
			string text3 = DarkOrbitWebAPI.StringRegExp(content, "<span title=" + '"'.ToString() + "(\\d) ");
			this.BootyArray[0] = text;
			this.BootyArray[1] = text2;
			this.BootyArray[2] = text3;
			return this.BootyArray;
		}

		public string GetMainInfos(string content)
		{
			this.Get("https://" + this.Server + ".darkorbit.bigpoint.com/indexInternal.es?action=internalStart", null);
			return DarkOrbitWebAPI.StringBetween(content, string.Concat(new string[]
			{
				"class=",
				'"'.ToString(),
				"userInfo_right",
				'"'.ToString(),
				">"
			}), "</div><br");
		}

		public string GetHangarInfos(string content)
		{
			this.Get("https://" + this.Server + ".darkorbit.bigpoint.com/indexInternal.es?action=internalDock", null);
			return DarkOrbitWebAPI.StringBetween(content, string.Concat(new string[]
			{
				"<td class=",
				'"'.ToString(),
				"values",
				'"'.ToString(),
				">"
			}), "</td>");
		}

		public string GetUID(string content)
		{
			return DarkOrbitWebAPI.StringRegExp(content, "\"uid\":\\s?(.+?),");
		}

		public string GetSID(string content)
		{
			return DarkOrbitWebAPI.StringRegExp(content, "'dosid=(.*?)'");
		}

		public FlashSettings GetFlashSettings()
		{
			return this.GetFlashSettings(this.Get(GClass801.VjTiiXgArTe(this.Server), null).Content);
		}

		public FlashSettings GetFlashSettings(string content)
		{
			return JsonConvert.DeserializeObject<FlashSettings>(DarkOrbitWebAPI.StringRegExp(content, "flashembed\\(\\\"container\\\", \\{.+?}, ({.+?})\\);"));
		}

		public string GetCredits(string content)
		{
			return DarkOrbitWebAPI.StringBetween(content, string.Concat(new string[]
			{
				"class=",
				'"'.ToString(),
				"header_money",
				'"'.ToString(),
				">"
			}), "</div>").Replace(" ", "");
		}

		public string GetUri(string content)
		{
			return DarkOrbitWebAPI.StringBetween(content, ";" + '"'.ToString() + " >", "</a>").Trim(new char[]
			{
				Convert.ToChar(">")
			}).Replace(" ", "");
		}

		public Dictionary<int, string> GetMapHosts()
		{
			return this.GetMapHosts(this.Get(GClass801.Maps(this.Server), null).Content);
		}

		public async Task<Dictionary<int, string>> GetMapHostsAsync()
		{
			DarkOrbitWebAPI.Response response = await this.GetAsync(GClass801.Maps(this.Server), null);
			return this.GetMapHosts(response.Content);
		}

		public Dictionary<int, string> GetMapHosts(string content)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(DarkOrbitWebAPI.maps));
			Dictionary<int, string> result;
			using (StringReader stringReader = new StringReader(content))
			{
				result = ((DarkOrbitWebAPI.maps)xmlSerializer.Deserialize(stringReader)).map.ToDictionary((DarkOrbitWebAPI.mapsMap t) => (int)t.id, (DarkOrbitWebAPI.mapsMap t) => t.gameserverIP);
			}
			return result;
		}

		public DarkOrbitWebAPI.spacemap GetSpacemapConfig()
		{
			return this.GetSpacemapConfig(this.Get(GClass801.smethod_1(), null).Content);
		}

		public DarkOrbitWebAPI.spacemap GetSpacemapConfig(string content)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(DarkOrbitWebAPI.spacemap));
			DarkOrbitWebAPI.spacemap result;
			using (StringReader stringReader = new StringReader(content))
			{
				result = (DarkOrbitWebAPI.spacemap)xmlSerializer.Deserialize(stringReader);
			}
			return result;
		}

		public string method_0()
		{
			return this.Get(GClass801.smethod_8(), null).Content;
		}

		public DarkOrbitWebAPI.GalaxyGatesInfo GetGalaxyGatesInfo()
		{
			if (!this.IsLoggedIn)
			{
				return null;
			}
			DarkOrbitWebAPI.Response response = this.Get(GClass801.smethod_3(this.Server, this.Uid, this.Sid, "init"), delegate(HttpRequestMessage msg)
			{
				msg.Headers.Add("X-Requested-With", "ShockwaveFlash/32.0.0.270");
			});
			return this.GetGalaxyGatesInfo(response.Content);
		}

		public DarkOrbitWebAPI.GalaxyGatesInfo GetGalaxyGatesInfo(string content)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(DarkOrbitWebAPI.GalaxyGatesInfo));
			DarkOrbitWebAPI.GalaxyGatesInfo result;
			using (StringReader stringReader = new StringReader(content))
			{
				try
				{
					result = (this.GgInfo = (DarkOrbitWebAPI.GalaxyGatesInfo)xmlSerializer.Deserialize(stringReader));
					return result;
				}
				catch
				{
				}
				result = null;
			}
			return result;
		}

		public string EncodeUserName(string str)
		{
			foreach (object obj in new Regex("([^a-zA-Z0-9 -])").Matches(str))
			{
				Match match = (Match)obj;
				str = str.Replace(match.Value, this.Encode(match.Value));
			}
			return str;
		}

		public string Encode(string string0)
		{
			byte[] bytes = new UTF8Encoding().GetBytes(string0);
			string text = "";
			foreach (byte b in bytes)
			{
				text = text + "%" + BitConverter.ToString(new byte[]
				{
					b
				});
			}
			return text;
		}

		public bool IsPremium(string content)
		{
			return content.Contains("<div id=\"header_is_premium\">");
		}

		public void Logout()
		{
			this.Get(GClass801.cyUiibiduUs(this.Server), null);
		}

		private static int ParseNumber(string str)
		{
			string text = Regex.Replace(str, "[^0-9]+", "");
			if (text.Length == 0)
			{
				return 0;
			}
			return int.Parse(text);
		}

		private static int ParseNumber(string str, bool ZeroIfNone)
		{
			if (str == "-" && ZeroIfNone)
			{
				return 0;
			}
			return int.Parse(Regex.Replace(str, "[^0-9]+", ""));
		}

		private static int GetFullPrice(int PremiumPrice)
		{
			return PremiumPrice * 100 / 95;
		}

		public string Bid(int credits, DarkOrbitWebAPI.Item item, DarkOrbitWebAPI.AuctionType Type = DarkOrbitWebAPI.AuctionType.hour)
		{
			new StringBuilder();
			string reloadToken = this.ReloadToken;
			string reloadToken2;
			lock (reloadToken)
			{
				reloadToken2 = this.ReloadToken;
			}
			new
			{
				efWctowUhL0QyKDkHQy = "hour",
				lm76cxwpjDC2PZixGKi = "bid",
				YMurYSwI1Xn08pPbpj7 = item.lootId,
				LnDr9Tw2OajyOyO7NfR = item.itemId,
				tyQlxlwEy1ocYbPEvTN = credits,
				tc33sywbNwcsBChP8mJ = DarkOrbitWebAPI.place_bet_btn,
				xCPjZiwueteLia83BZY = reloadToken2
			};
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"auctionType",
					"hour"
				},
				{
					"subAction",
					"bid"
				},
				{
					"lootId",
					item.lootId
				},
				{
					"itemId",
					item.itemId
				},
				{
					"credits",
					credits.ToString()
				},
				{
					"auction_buy_button",
					DarkOrbitWebAPI.place_bet_btn
				},
				{
					"reloadToken",
					reloadToken2
				}
			};
			string content = this.Post(GClass801.smethod_0(this.Server, "internalAuction") + "&reloadToken=" + reloadToken2, data, GClass801.smethod_0(this.Server, "internalAuction"), null).Content;
			item.Credits = credits;
			return content;
		}

		public TimeSpan GetAuctionCountdown(DarkOrbitWebAPI.Response content, DarkOrbitWebAPI.AuctionType type = DarkOrbitWebAPI.AuctionType.hour)
		{
			Match match = new Regex("counter" + type.ToString() + ".*?second.*?(\\d+).*?minute.*?(\\d+).*?hour.*?(\\d+).*?day.*?(\\d+)", RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(content.Content);
			if (!match.Success)
			{
				return new TimeSpan(0, 59, 20);
			}
			int seconds = int.Parse(match.Groups[1].Value);
			int minutes = int.Parse(match.Groups[2].Value);
			int hours = int.Parse(match.Groups[3].Value);
			int days = int.Parse(match.Groups[4].Value);
			return new TimeSpan(days, hours, minutes, seconds);
		}

		public string GetAuctionPlaceString(string content)
		{
			return DarkOrbitWebAPI.place_bet_btn = new Regex("id=\"auction_place_bid\".*?value=\"(.*?)\"").Match(content).Groups[1].Value;
		}

		public List<DarkOrbitWebAPI.Item> GetWonItems(string content, DarkOrbitWebAPI.AuctionType Type = DarkOrbitWebAPI.AuctionType.hour)
		{
			List<DarkOrbitWebAPI.Item> list = new List<DarkOrbitWebAPI.Item>();
			string input = DarkOrbitWebAPI.StringBetween(content, "<tbody class=\"auction_item_wrapper auction_history_wrapper\"", "</tbody>");
			Regex regex = new Regex("<tr .*? itemGroup=\"(.*?)\">.*?<td.*?<\\/td>.*?<td class=\"auction_history_name_col\">(.*?)<\\/td>.*?<td class=\"auction_history_type\">.*?<\\/td>.*?<td class=\"auction_history_winner\".*?title=\"(.*?)\">.*?<\\/td>.*?<td class=\"auction_history_current\">(.*?)<\\/td>.*?<\\/tr>", RegexOptions.Singleline);
			int num = 0;
			foreach (object obj in regex.Matches(input))
			{
				Match match = (Match)obj;
				if (num > this.HourAuctionItems.Count<DarkOrbitWebAPI.Item>())
				{
					break;
				}
				if (match.Groups[3].Value.StartsWith(this.GetLocalUsername(content)))
				{
					string name = match.Groups[2].Value.Trim().Replace("\n", "").Replace("\r", "");
					list.Add(this.HourAuctionItems.FirstOrDefault((DarkOrbitWebAPI.Item x) => x.Name == name));
					Console.WriteLine("Won {0} for {1}", name, DarkOrbitWebAPI.ParseNumber(match.Groups[4].Value, true));
				}
				num++;
			}
			return list;
		}

		public bool BuyItem(string category, string itemId, int amount = 1, int level = -1, string selectedName = "")
		{
			new
			{
				lUrcJXw1pPLKh7ZeRoT = "purchase",
				rUgwAHwmPijYHi1gdV4 = category,
				HEHeTWwoJbSHi3ttKiA = itemId,
				yqh0j3wBMmAw16r8uhc = amount,
				ovHJCnwGq8bGKZ0niSc = level,
				pu4oXKwJygqseIMNXgX = selectedName
			};
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"action",
					"purchase"
				},
				{
					"category",
					category
				},
				{
					"itemId",
					itemId
				},
				{
					"amount",
					amount.ToString()
				},
				{
					"level",
					level.ToString()
				},
				{
					"selectedName",
					selectedName
				}
			};
			return this.Post(GClass801.smethod_2(this.Server), data, "https://darkorbit.com", null).Content.Contains("result: \"success\"");
		}

		public bool BuyCloak()
		{
			return this.BuyItem("special", "equipment_extra_cpu_cl04k-xs", 1, -1, "");
		}

		public string GetLocalUsername(string content)
		{
			Regex regex = new Regex("<div id=\\\"homeUserContent\">.*?<img.*? alt=\\\"(.*?)\" id=\\\"pilotAvatar\"", RegexOptions.Singleline);
			return this.UserName = regex.Match(content).Groups[1].Value;
		}

		public string GetReloadToken(string content)
		{
			Match match = new Regex("&reloadToken=(.+?)\"", RegexOptions.Singleline).Match(content);
			if (match.Groups.Count > 1)
			{
				return match.Groups[1].Value;
			}
			match = Regex.Match(content, "name=\"reloadToken\" value=\"(.+?)\"");
			if (match.Groups.Count > 1)
			{
				return match.Groups[1].Value;
			}
			return "";
		}

		public static CookieCollection GetAllCookies(CookieContainer cookieJar)
		{
			CookieCollection cookieCollection = new CookieCollection();
			Hashtable hashtable = (Hashtable)cookieJar.GetType().InvokeMember("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, cookieJar, new object[0]);
			foreach (object obj in hashtable.Keys)
			{
				string text = (string)obj;
				if (text[0] == '.')
				{
					text = text.Substring(1);
				}
				foreach (object obj2 in ((SortedList)hashtable[obj].GetType().InvokeMember("m_list", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, hashtable[obj], new object[0])).Keys)
				{
					string uriString = "https://" + text + (string)obj2;
					cookieCollection.Add(cookieJar.GetCookies(new Uri(uriString)));
				}
			}
			return cookieCollection;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		public string[] BootyArray;

		public List<DarkOrbitWebAPI.Item> HourAuctionItems;

		public List<DarkOrbitWebAPI.Item> MyOffers;

		public string ReloadToken;

		private static Random randomizer;

		public static string place_bet_btn;

		public readonly HttpClient Http;

		private readonly HttpClientHandler _handler;

		public CookieContainer Cookies;

		public static Dictionary<int, string> ServerInstances;

		public class Response
		{
			public Response(Uri uri, string response, HttpResponseMessage data)
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
				this.Uri = uri;
				this.Content = response;
				this.Data = data;
			}

			public Uri Uri;

			public string Content;

			public HttpResponseMessage Data;
		}

		public class Credentials
		{
			public Credentials(string Username, string Password, string server, bool Auto, bool IsTemplate = false)
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
				this.Username = Username;
				this.Password = Password;
				this.Automatic = Auto;
				this.IsTemplate = IsTemplate;
				this.Server = server;
			}

			protected Credentials()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			public string Username;

			public string Password;

			public string Server;

			public bool Automatic;

			public bool IsTemplate;
		}

		public class BasicItem
		{
			public BasicItem(string Name, DarkOrbitWebAPI.ItemType type, string itemId, string lootId, int Uridium, int Credits)
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
				this.Name = Name;
				this.Type = type;
				this.itemId = itemId;
				this.lootId = lootId;
				this.Uridium = Uridium;
				this.Credits = Credits;
			}

			protected BasicItem()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			public int Uridium;

			public string lootId;

			public DarkOrbitWebAPI.ItemType Type;

			public string itemId;

			public int Credits;

			public string Name;
		}

		public class Item : DarkOrbitWebAPI.BasicItem
		{
			public Item(string Name, DarkOrbitWebAPI.ItemType Type, string itemId, string lootId, int Uridium, int Credits, int LocalCredits, string Winner, string Image, bool Winning = false)
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
				this.Type = Type;
				this.itemId = itemId;
				this.lootId = lootId;
				this.Uridium = Uridium;
				this.Credits = Credits;
				this.Winning = Winning;
				this.Name = Name;
				this.LocalCredits = LocalCredits;
				this.Winner = Winner;
				this.Image = Image;
			}

			protected Item()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			public bool Winning;

			public int LocalCredits;

			public string Winner;

			public string Image;
		}

		public enum ItemType
		{
			battery,
			rocket,
			generator,
			extra,
			booster,
			special,
			ship,
			shipdesign,
			weapon,
			module
		}

		public enum AuctionType
		{
			hour,
			day,
			week
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[XmlRoot("jumpgate")]
		[Serializable]
		public class GalaxyGatesInfo
		{
			public string mode
			{
				get
				{
					return this.modeField;
				}
				set
				{
					this.modeField = value;
				}
			}

			public long money
			{
				get
				{
					return this.moneyField;
				}
				set
				{
					this.moneyField = value;
				}
			}

			public long samples
			{
				get
				{
					return this.samplesField;
				}
				set
				{
					this.samplesField = value;
				}
			}

			public int spinamount_selected
			{
				get
				{
					return this.spinamount_selectedField;
				}
				set
				{
					this.spinamount_selectedField = value;
				}
			}

			public DarkOrbitWebAPI.jumpgateEnergy_cost energy_cost
			{
				get
				{
					return this.energy_costField;
				}
				set
				{
					this.energy_costField = value;
				}
			}

			public int hadesGateDialog
			{
				get
				{
					return this.hadesGateDialogField;
				}
				set
				{
					this.hadesGateDialogField = value;
				}
			}

			[XmlArrayItem("multiplier", IsNullable = false)]
			public DarkOrbitWebAPI.jumpgateMultiplier[] multipliers
			{
				get
				{
					return this.multipliersField;
				}
				set
				{
					this.multipliersField = value;
				}
			}

			[XmlArrayItem("probability", IsNullable = false)]
			public DarkOrbitWebAPI.jumpgateProbability[] probabilities
			{
				get
				{
					return this.probabilitiesField;
				}
				set
				{
					this.probabilitiesField = value;
				}
			}

			[XmlArrayItem("gate", IsNullable = false)]
			public DarkOrbitWebAPI.jumpgateGate[] gates
			{
				get
				{
					return this.gatesField;
				}
				set
				{
					this.gatesField = value;
				}
			}

			[XmlArrayItem("spinamount", IsNullable = false)]
			[XmlArray]
			public int[] spinamounts
			{
				get
				{
					return this.spinamountsField;
				}
				set
				{
					this.spinamountsField = value;
				}
			}

			public int spinOnSale
			{
				get
				{
					return this.spinOnSaleField;
				}
				set
				{
					this.spinOnSaleField = value;
				}
			}

			public int spinSalePercentage
			{
				get
				{
					return this.spinSalePercentageField;
				}
				set
				{
					this.spinSalePercentageField = value;
				}
			}

			public int galaxyGateDay
			{
				get
				{
					return this.galaxyGateDayField;
				}
				set
				{
					this.galaxyGateDayField = value;
				}
			}

			public int bonusRewardsDay
			{
				get
				{
					return this.bonusRewardsDayField;
				}
				set
				{
					this.bonusRewardsDayField = value;
				}
			}

			public int GetGateId(GEnum5 type)
			{
				if (type <= (GEnum5)55)
				{
					if (type == GEnum5.None)
					{
						return 0;
					}
					switch (type)
					{
					case (GEnum5)51:
						return 1;
					case (GEnum5)52:
						return 2;
					case (GEnum5)53:
						return 3;
					case (GEnum5)55:
						return 4;
					}
				}
				else
				{
					switch (type)
					{
					case (GEnum5)70:
						return 5;
					case (GEnum5)71:
						return 6;
					case (GEnum5)72:
					case (GEnum5)73:
						break;
					case (GEnum5)74:
						return 7;
					case (GEnum5)75:
						return 8;
					case (GEnum5)76:
						return 12;
					default:
						if (type == (GEnum5)300)
						{
							return 19;
						}
						if (type == (GEnum5)2048)
						{
							return 13;
						}
						break;
					}
				}
				return 0;
			}

			public DarkOrbitWebAPI.jumpgateGate GetGate(GEnum5 type)
			{
				int id = this.GetGateId(type);
				return this.gates.FirstOrDefault((DarkOrbitWebAPI.jumpgateGate t) => t.id == id);
			}

			public DarkOrbitWebAPI.jumpgateGate GetGate(int id)
			{
				return this.gates.FirstOrDefault((DarkOrbitWebAPI.jumpgateGate t) => t.id == id);
			}

			public GalaxyGatesInfo()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string modeField;

			private long moneyField;

			private long samplesField;

			private int spinamount_selectedField;

			private DarkOrbitWebAPI.jumpgateEnergy_cost energy_costField;

			private int hadesGateDialogField;

			private DarkOrbitWebAPI.jumpgateMultiplier[] multipliersField;

			private DarkOrbitWebAPI.jumpgateProbability[] probabilitiesField;

			private DarkOrbitWebAPI.jumpgateGate[] gatesField;

			private int[] spinamountsField;

			private int spinOnSaleField;

			private int spinSalePercentageField;

			private int galaxyGateDayField;

			private int bonusRewardsDayField;
		}

		[XmlType(AnonymousType = true)]
		[DesignerCategory("code")]
		[Serializable]
		public class jumpgateEnergy_cost
		{
			[XmlAttribute]
			public string mode
			{
				get
				{
					return this.modeField;
				}
				set
				{
					this.modeField = value;
				}
			}

			[XmlText]
			public int Value
			{
				get
				{
					return this.valueField;
				}
				set
				{
					this.valueField = value;
				}
			}

			public jumpgateEnergy_cost()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string modeField;

			private int valueField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[Serializable]
		public class jumpgateMultiplier
		{
			[XmlAttribute]
			public string mode
			{
				get
				{
					return this.modeField;
				}
				set
				{
					this.modeField = value;
				}
			}

			[XmlAttribute]
			public int value
			{
				get
				{
					return this.valueField;
				}
				set
				{
					this.valueField = value;
				}
			}

			[XmlAttribute]
			public int state
			{
				get
				{
					return this.stateField;
				}
				set
				{
					this.stateField = value;
				}
			}

			public jumpgateMultiplier()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string modeField;

			private int valueField;

			private int stateField;
		}

		[XmlType(AnonymousType = true)]
		[DesignerCategory("code")]
		[Serializable]
		public class jumpgateProbability
		{
			[XmlElement("cat")]
			public DarkOrbitWebAPI.jumpgateProbabilityCat[] cat
			{
				get
				{
					return this.catField;
				}
				set
				{
					this.catField = value;
				}
			}

			[XmlAttribute]
			public string mode
			{
				get
				{
					return this.modeField;
				}
				set
				{
					this.modeField = value;
				}
			}

			public jumpgateProbability()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private DarkOrbitWebAPI.jumpgateProbabilityCat[] catField;

			private string modeField;
		}

		[XmlType(AnonymousType = true)]
		[DesignerCategory("code")]
		[Serializable]
		public class jumpgateProbabilityCat
		{
			[XmlAttribute]
			public string id
			{
				get
				{
					return this.idField;
				}
				set
				{
					this.idField = value;
				}
			}

			[XmlAttribute]
			public int percentage
			{
				get
				{
					return this.percentageField;
				}
				set
				{
					this.percentageField = value;
				}
			}

			public jumpgateProbabilityCat()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string idField;

			private int percentageField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[Serializable]
		public class jumpgateGate
		{
			[XmlElement("gatebuilders")]
			public DarkOrbitWebAPI.jumpgateGateGatebuilders[] gatebuilders
			{
				get
				{
					return this.gatebuildersField;
				}
				set
				{
					this.gatebuildersField = value;
				}
			}

			[XmlAttribute]
			public int total
			{
				get
				{
					return this.totalField;
				}
				set
				{
					this.totalField = value;
				}
			}

			[XmlAttribute]
			public int current
			{
				get
				{
					return this.currentField;
				}
				set
				{
					this.currentField = value;
				}
			}

			public string Parts
			{
				get
				{
					return string.Format("{0}/{1}", this.current, this.total);
				}
			}

			public string Wave
			{
				get
				{
					return string.Format("{0}/{1}", this.currentWave, this.totalWave);
				}
			}

			[XmlAttribute]
			public int id
			{
				get
				{
					return this.idField;
				}
				set
				{
					this.idField = value;
				}
			}

			[XmlAttribute]
			public bool prepared
			{
				get
				{
					return this.preparedField;
				}
				set
				{
					this.preparedField = value;
				}
			}

			[XmlAttribute]
			public int totalWave
			{
				get
				{
					return this.totalWaveField;
				}
				set
				{
					this.totalWaveField = value;
				}
			}

			[XmlAttribute]
			public int currentWave
			{
				get
				{
					return this.currentWaveField;
				}
				set
				{
					this.currentWaveField = value;
				}
			}

			[XmlAttribute]
			public string state
			{
				get
				{
					return this.stateField;
				}
				set
				{
					this.stateField = value;
				}
			}

			[XmlAttribute]
			public int livesLeft
			{
				get
				{
					return this.livesLeftField;
				}
				set
				{
					this.livesLeftField = value;
				}
			}

			[XmlAttribute]
			public int lifePrice
			{
				get
				{
					return this.lifePriceField;
				}
				set
				{
					this.lifePriceField = value;
				}
			}

			public jumpgateGate()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private DarkOrbitWebAPI.jumpgateGateGatebuilders[] gatebuildersField;

			private int totalField;

			private int currentField;

			private int idField;

			private bool preparedField;

			private int totalWaveField;

			private int currentWaveField;

			private string stateField;

			private int livesLeftField;

			private int lifePriceField;
		}

		[XmlType(AnonymousType = true)]
		[DesignerCategory("code")]
		[Serializable]
		public class jumpgateGateGatebuilders
		{
			[XmlAttribute]
			public string name
			{
				get
				{
					return this.nameField;
				}
				set
				{
					this.nameField = value;
				}
			}

			[XmlAttribute]
			public int current
			{
				get
				{
					return this.currentField;
				}
				set
				{
					this.currentField = value;
				}
			}

			[XmlAttribute]
			public int total
			{
				get
				{
					return this.totalField;
				}
				set
				{
					this.totalField = value;
				}
			}

			public jumpgateGateGatebuilders()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string nameField;

			private int currentField;

			private int totalField;
		}

		[XmlType(AnonymousType = true)]
		[XmlRoot("jumpgate")]
		[DesignerCategory("code")]
		[Serializable]
		public class GalaxyGatesInfoUpdate
		{
			public string mode
			{
				get
				{
					return this.modeField;
				}
				set
				{
					this.modeField = value;
				}
			}

			public long money
			{
				get
				{
					return this.moneyField;
				}
				set
				{
					this.moneyField = value;
				}
			}

			public long samples
			{
				get
				{
					return this.samplesField;
				}
				set
				{
					this.samplesField = value;
				}
			}

			public byte spinamount_selected
			{
				get
				{
					return this.spinamount_selectedField;
				}
				set
				{
					this.spinamount_selectedField = value;
				}
			}

			public DarkOrbitWebAPI.jumpgateEnergy_cost energy_cost
			{
				get
				{
					return this.energy_costField;
				}
				set
				{
					this.energy_costField = value;
				}
			}

			public byte hadesGateDialog
			{
				get
				{
					return this.hadesGateDialogField;
				}
				set
				{
					this.hadesGateDialogField = value;
				}
			}

			[XmlArrayItem("multiplier", IsNullable = false)]
			public DarkOrbitWebAPI.jumpgateMultiplier[] multipliers
			{
				get
				{
					return this.multipliersField;
				}
				set
				{
					this.multipliersField = value;
				}
			}

			[XmlArrayItem("item", IsNullable = false)]
			public DarkOrbitWebAPI.jumpgateItem[] items
			{
				get
				{
					return this.itemsField;
				}
				set
				{
					this.itemsField = value;
				}
			}

			public byte spinOnSale
			{
				get
				{
					return this.spinOnSaleField;
				}
				set
				{
					this.spinOnSaleField = value;
				}
			}

			public byte spinSalePercentage
			{
				get
				{
					return this.spinSalePercentageField;
				}
				set
				{
					this.spinSalePercentageField = value;
				}
			}

			public byte galaxyGateDay
			{
				get
				{
					return this.galaxyGateDayField;
				}
				set
				{
					this.galaxyGateDayField = value;
				}
			}

			public byte bonusRewardsDay
			{
				get
				{
					return this.bonusRewardsDayField;
				}
				set
				{
					this.bonusRewardsDayField = value;
				}
			}

			public GalaxyGatesInfoUpdate()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string modeField;

			private long moneyField;

			private long samplesField;

			private byte spinamount_selectedField;

			private DarkOrbitWebAPI.jumpgateEnergy_cost energy_costField;

			private byte hadesGateDialogField;

			private DarkOrbitWebAPI.jumpgateMultiplier[] multipliersField;

			private DarkOrbitWebAPI.jumpgateItem[] itemsField;

			private byte spinOnSaleField;

			private byte spinSalePercentageField;

			private byte galaxyGateDayField;

			private byte bonusRewardsDayField;
		}

		[XmlType(AnonymousType = true)]
		[DesignerCategory("code")]
		[Serializable]
		public class jumpgateItem
		{
			[XmlAttribute]
			public string type
			{
				get
				{
					return this.typeField;
				}
				set
				{
					this.typeField = value;
				}
			}

			[XmlAttribute]
			public bool duplicate
			{
				get
				{
					return this.duplicateField;
				}
				set
				{
					this.duplicateField = value;
				}
			}

			[XmlIgnore]
			public bool duplicateSpecified
			{
				get
				{
					return this.duplicateFieldSpecified;
				}
				set
				{
					this.duplicateFieldSpecified = value;
				}
			}

			[XmlAttribute]
			public long date
			{
				get
				{
					return this.dateField;
				}
				set
				{
					this.dateField = value;
				}
			}

			[XmlAttribute]
			public int gate_id
			{
				get
				{
					return this.gate_idField;
				}
				set
				{
					this.gate_idField = value;
				}
			}

			[XmlIgnore]
			public bool gate_idSpecified
			{
				get
				{
					return this.gate_idFieldSpecified;
				}
				set
				{
					this.gate_idFieldSpecified = value;
				}
			}

			[XmlAttribute]
			public int part_id
			{
				get
				{
					return this.part_idField;
				}
				set
				{
					this.part_idField = value;
				}
			}

			[XmlIgnore]
			public bool part_idSpecified
			{
				get
				{
					return this.part_idFieldSpecified;
				}
				set
				{
					this.part_idFieldSpecified = value;
				}
			}

			[XmlAttribute]
			public int amount
			{
				get
				{
					return this.amountField;
				}
				set
				{
					this.amountField = value;
				}
			}

			[XmlAttribute]
			public int current
			{
				get
				{
					return this.currentField;
				}
				set
				{
					this.currentField = value;
				}
			}

			[XmlAttribute]
			public int total
			{
				get
				{
					return this.totalField;
				}
				set
				{
					this.totalField = value;
				}
			}

			[XmlIgnore]
			public bool amountSpecified
			{
				get
				{
					return this.amountFieldSpecified;
				}
				set
				{
					this.amountFieldSpecified = value;
				}
			}

			[XmlIgnore]
			public string state
			{
				get
				{
					return this.stateField;
				}
				set
				{
					this.stateField = value;
				}
			}

			public jumpgateItem()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string typeField;

			private bool duplicateField;

			private bool duplicateFieldSpecified;

			private long dateField;

			private int gate_idField;

			private bool gate_idFieldSpecified;

			private int part_idField;

			private bool part_idFieldSpecified;

			private int amountField;

			private bool amountFieldSpecified;

			private int currentField;

			private int totalField;

			private string stateField;
		}

		[JsonObject]
		public class ServerInstanceList
		{
			public string code { get; set; }

			public string result { get; set; }

			public ServerInstanceList()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[XmlRoot(Namespace = "", IsNullable = false)]
		[Serializable]
		public class maps
		{
			[XmlElement("map")]
			public DarkOrbitWebAPI.mapsMap[] map
			{
				get
				{
					return this.mapField;
				}
				set
				{
					this.mapField = value;
				}
			}

			public maps()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private DarkOrbitWebAPI.mapsMap[] mapField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[Serializable]
		public class mapsMap
		{
			public string gameserverIP
			{
				get
				{
					return this.gameserverIPField;
				}
				set
				{
					this.gameserverIPField = value;
				}
			}

			[XmlAttribute]
			public ushort id
			{
				get
				{
					return this.idField;
				}
				set
				{
					this.idField = value;
				}
			}

			public mapsMap()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private string gameserverIPField;

			private ushort idField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[XmlRoot(Namespace = "", IsNullable = false)]
		[Serializable]
		public class spacemap
		{
			[XmlArrayItem("jumpgate", IsNullable = false)]
			public DarkOrbitWebAPI.spacemapJumpgate[] jumpgates
			{
				get
				{
					return this.jumpgatesField;
				}
				set
				{
					this.jumpgatesField = value;
				}
			}

			[XmlArrayItem("map", IsNullable = false)]
			public DarkOrbitWebAPI.spacemapMap[] npcs
			{
				get
				{
					return this.npcsField;
				}
				set
				{
					this.npcsField = value;
				}
			}

			public spacemap()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private DarkOrbitWebAPI.spacemapJumpgate[] jumpgatesField;

			private DarkOrbitWebAPI.spacemapMap[] npcsField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[Serializable]
		public class spacemapJumpgate
		{
			public DarkOrbitWebAPI.spacemapJumpgatePosition position
			{
				get
				{
					return this.positionField;
				}
				set
				{
					this.positionField = value;
				}
			}

			public string faction
			{
				get
				{
					return this.factionField;
				}
				set
				{
					this.factionField = value;
				}
			}

			public bool visibleOwnFaction
			{
				get
				{
					return this.visibleOwnFactionField;
				}
				set
				{
					this.visibleOwnFactionField = value;
				}
			}

			public ushort leadsToMap
			{
				get
				{
					return this.leadsToMapField;
				}
				set
				{
					this.leadsToMapField = value;
				}
			}

			public string labelPosition
			{
				get
				{
					return this.labelPositionField;
				}
				set
				{
					this.labelPositionField = value;
				}
			}

			[XmlAttribute]
			public uint key
			{
				get
				{
					return this.keyField;
				}
				set
				{
					this.keyField = value;
				}
			}

			[XmlAttribute]
			public ushort @ref
			{
				get
				{
					return this.refField;
				}
				set
				{
					this.refField = value;
				}
			}

			public spacemapJumpgate()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private DarkOrbitWebAPI.spacemapJumpgatePosition positionField;

			private string factionField;

			private bool visibleOwnFactionField;

			private ushort leadsToMapField;

			private string labelPositionField;

			private uint keyField;

			private ushort refField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[Serializable]
		public class spacemapJumpgatePosition
		{
			[XmlAttribute]
			public ushort x
			{
				get
				{
					return this.xField;
				}
				set
				{
					this.xField = value;
				}
			}

			[XmlAttribute]
			public byte y
			{
				get
				{
					return this.yField;
				}
				set
				{
					this.yField = value;
				}
			}

			public spacemapJumpgatePosition()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private ushort xField;

			private byte yField;
		}

		[DesignerCategory("code")]
		[XmlType(AnonymousType = true)]
		[Serializable]
		public class spacemapMap
		{
			[XmlElement("npc")]
			public DarkOrbitWebAPI.spacemapMapNpc[] npc
			{
				get
				{
					return this.npcField;
				}
				set
				{
					this.npcField = value;
				}
			}

			[XmlAttribute]
			public ushort @ref
			{
				get
				{
					return this.refField;
				}
				set
				{
					this.refField = value;
				}
			}

			public spacemapMap()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private DarkOrbitWebAPI.spacemapMapNpc[] npcField;

			private ushort refField;
		}

		[XmlType(AnonymousType = true)]
		[DesignerCategory("code")]
		[Serializable]
		public class spacemapMapNpc
		{
			[XmlAttribute]
			public byte id
			{
				get
				{
					return this.idField;
				}
				set
				{
					this.idField = value;
				}
			}

			public spacemapMapNpc()
			{
				Class8.xDph7tozmh5WD();
				base..ctor();
			}

			private byte idField;
		}
	}
}
