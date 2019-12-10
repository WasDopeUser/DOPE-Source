using System;

namespace DarkorbitAPI.CommonStructures
{
	public enum ErrorReason
	{
		Unknown,
		VersionMismatch,
		ConnectionLost,
		Timeout,
		GracefullyDisconnected,
		ConnectionOverridden,
		NoLicense,
		RemoteServiceFailure,
		CantLogin,
		LoggedOut
	}
}
