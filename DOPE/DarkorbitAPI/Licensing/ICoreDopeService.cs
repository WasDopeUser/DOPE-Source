using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DarkorbitAPI.CommonStructures;

namespace DarkorbitAPI.Licensing
{
	[Guid("6C1E72DB-C905-4030-8921-26987842F09C")]
	public interface ICoreDopeService
	{
		Task<DollConfig> GetDoll(string checksum, byte[] data, string userId, int serverId);

		Task<bool> IsDollKnown(string checksum);
	}
}
