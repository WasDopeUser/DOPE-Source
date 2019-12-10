using System;
using System.Runtime.InteropServices;

namespace DarkorbitAPI.Licensing
{
	[Guid("A81F4FBB-877D-42C5-A1BE-D8799D542ECA")]
	public interface IDopeServiceProxy
	{
		string Key { get; }

		ICoreDopeService Service { get; }
	}
}
