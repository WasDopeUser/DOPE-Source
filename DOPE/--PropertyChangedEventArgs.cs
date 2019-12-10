using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class <>PropertyChangedEventArgs
{
	internal static readonly PropertyChangedEventArgs All = new PropertyChangedEventArgs("All");

	internal static readonly PropertyChangedEventArgs BotControllers = new PropertyChangedEventArgs("BotControllers");

	internal static readonly PropertyChangedEventArgs Children = new PropertyChangedEventArgs("Children");

	internal static readonly PropertyChangedEventArgs Command = new PropertyChangedEventArgs("Command");

	internal static readonly PropertyChangedEventArgs CommandById = new PropertyChangedEventArgs("CommandById");

	internal static readonly PropertyChangedEventArgs Commands = new PropertyChangedEventArgs("Commands");

	internal static readonly PropertyChangedEventArgs Controller = new PropertyChangedEventArgs("Controller");

	internal static readonly PropertyChangedEventArgs CountReceived = new PropertyChangedEventArgs("CountReceived");

	internal static readonly PropertyChangedEventArgs CountSent = new PropertyChangedEventArgs("CountSent");

	internal static readonly PropertyChangedEventArgs CountTotal = new PropertyChangedEventArgs("CountTotal");

	internal static readonly PropertyChangedEventArgs DisconnectReason = new PropertyChangedEventArgs("DisconnectReason");

	internal static readonly PropertyChangedEventArgs Enabled = new PropertyChangedEventArgs("Enabled");

	internal static readonly PropertyChangedEventArgs Filtered = new PropertyChangedEventArgs("Filtered");

	internal static readonly PropertyChangedEventArgs FilterReceived = new PropertyChangedEventArgs("FilterReceived");

	internal static readonly PropertyChangedEventArgs Id = new PropertyChangedEventArgs("Id");

	internal static readonly PropertyChangedEventArgs JumpToLast = new PropertyChangedEventArgs("JumpToLast");

	internal static readonly PropertyChangedEventArgs Name = new PropertyChangedEventArgs("Name");

	internal static readonly PropertyChangedEventArgs NewKey = new PropertyChangedEventArgs("NewKey");

	internal static readonly PropertyChangedEventArgs Received = new PropertyChangedEventArgs("Received");

	internal static readonly PropertyChangedEventArgs RS = new PropertyChangedEventArgs("RS");

	internal static readonly PropertyChangedEventArgs SearchText = new PropertyChangedEventArgs("SearchText");

	internal static readonly PropertyChangedEventArgs Selected = new PropertyChangedEventArgs("Selected");

	internal static readonly PropertyChangedEventArgs Server = new PropertyChangedEventArgs("Server");

	internal static readonly PropertyChangedEventArgs Sid = new PropertyChangedEventArgs("Sid");

	internal static readonly PropertyChangedEventArgs Timestamp = new PropertyChangedEventArgs("Timestamp");

	internal static readonly PropertyChangedEventArgs UserAgent = new PropertyChangedEventArgs("UserAgent");

	internal static readonly PropertyChangedEventArgs Value = new PropertyChangedEventArgs("Value");
}
