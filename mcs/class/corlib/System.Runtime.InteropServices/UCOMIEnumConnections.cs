//
// System.Runtime.InteropServices.UCOMIEnumConnections.cs
//
// Author:
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//

using System;

namespace System.Runtime.InteropServices
{
	[Guid ("b196b287-bab4-101a-b69c-00aa00341d07")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	public interface UCOMIEnumConnections
	{
		void Clone (ref UCOMIEnumConnections ppenum);
		int Next (int celt, out CONNECTDATA[] rgelt, ref int pceltFetched);
		void Reset ();
		int Skip (int celt);
	}
}
