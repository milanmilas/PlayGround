// Type: Bid
// Assembly: System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.dll

using System;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

[ComVisible(false)]
internal static class Bid
{
    internal static bool TraceOn { get; }
    internal static bool ScopeOn { get; }
    internal static bool AdvancedOn { get; }
    internal static IntPtr NoData { get; }
    internal static IntPtr ID { get; }
    internal static bool IsInitialized { get; }
    internal static IntPtr DefaultCmdSpace { get; }
    internal static bool IsOn(Bid.ApiGroup flag);
    internal static void PutStr(string str);
    internal static void Trace(string strConst);
    internal static void TraceEx(uint flags, string strConst);
    internal static void Trace(string fmtPrintfW, string a1);
    internal static void TraceEx(uint flags, string fmtPrintfW, string a1);
    internal static void ScopeLeave(ref IntPtr hScp);
    internal static void ScopeEnter(out IntPtr hScp, string strConst);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2);
    internal static void TraceBin(string constStrHeader, byte[] buff, ushort length);
    internal static void TraceBinEx(byte[] buff, ushort length);
    internal static Bid.ApiGroup SetApiGroupBits(Bid.ApiGroup mask, Bid.ApiGroup bits);
    internal static bool AddMetaText(string metaStr);

    [Conditional("DEBUG")]
    internal static void DTRACE(string strConst);

    [Conditional("DEBUG")]
    internal static void DTRACE(string clrFormatString, params object[] args);

    [Conditional("DEBUG")]
    internal static void DASSERT(bool condition);

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    internal static void PoolerTrace(string fmtPrintfW, int a1);

    internal static void PoolerTrace(string fmtPrintfW, int a1, int a2);
    internal static void PoolerTrace(string fmtPrintfW, int a1, int a2, int a3);
    internal static void PoolerTrace(string fmtPrintfW, int a1, int a2, int a3, int a4);
    internal static void PoolerTrace(string fmtPrintfW, int a1, Exception a2);
    internal static void PoolerScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, string fmtPrintfW2);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, string fmtPrintfW2, string fmtPrintfW3);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, string fmtPrintfW2);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, string fmtPrintfW2, string fmtPrintfW3, string fmtPrintfW4);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, string fmtPrintfW2, int a2);
    internal static void NotificationsScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, string fmtPrintfW2, string fmtPrintfW3, int a4);
    internal static void NotificationsTrace(string fmtPrintfW);
    internal static void NotificationsTrace(string fmtPrintfW, string fmtPrintfW2);
    internal static void NotificationsTrace(string fmtPrintfW, int a1);
    internal static void NotificationsTrace(string fmtPrintfW, bool a1);
    internal static void NotificationsTrace(string fmtPrintfW, string fmtPrintfW2, int a1);
    internal static void NotificationsTrace(string fmtPrintfW, int a1, string fmtPrintfW2);
    internal static void NotificationsTrace(string fmtPrintfW, int a1, int a2);
    internal static void NotificationsTrace(string fmtPrintfW, int a1, bool a2);
    internal static void NotificationsTrace(string fmtPrintfW, string a1, string a2);
    internal static void NotificationsTrace(string fmtPrintfW, string fmtPrintfW2, string fmtPrintfW3, int a1);
    internal static void NotificationsTrace(string fmtPrintfW, bool a1, string fmtPrintfW2, string fmtPrintfW3, string fmtPrintfW4);
    internal static void NotificationsTrace(string fmtPrintfW, int a1, string fmtPrintfW2, string fmtPrintfW3, string fmtPrintfW4);

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    internal static void TraceSqlReturn(string fmtPrintfW, ODBC32.RetCode a1);

    internal static void TraceSqlReturn(string fmtPrintfW, ODBC32.RetCode a1, string a2);

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    internal static void Trace(string fmtPrintfW, OleDbHResult a1);

    internal static void Trace(string fmtPrintfW, OleDbHResult a1, string a2);
    internal static void Trace(string fmtPrintfW, OleDbHResult a1, IntPtr a2);
    internal static void Trace(string fmtPrintfW, OleDbHResult a1, int a2);
    internal static void Trace(string fmtPrintfW, string a1, string a2);
    internal static void Trace(string fmtPrintfW, int a1, string a2, bool a3);
    internal static void Trace(string fmtPrintfW, int a1, int a2, string a3, string a4, int a5);
    internal static void Trace(string fmtPrintfW, int a1, int a2, long a3, uint a4, int a5, uint a6, uint a7);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, Guid a2);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, string a2, int a3);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, bool a2, int a3);

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    internal static void Trace(string fmtPrintfW, int a1, string a2);

    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    internal static void Trace(string fmtPrintfW, IntPtr a1);

    internal static void Trace(string fmtPrintfW, int a1);
    internal static void Trace(string fmtPrintfW, int a1, int a2);
    internal static void Trace(string fmtPrintfW, int a1, IntPtr a2, IntPtr a3);
    internal static void Trace(string fmtPrintfW, int a1, IntPtr a2);
    internal static void Trace(string fmtPrintfW, int a1, string a2, string a3);
    internal static void Trace(string fmtPrintfW, int a1, string a2, int a3);
    internal static void Trace(string fmtPrintfW, int a1, string a2, string a3, int a4);
    internal static void Trace(string fmtPrintfW, int a1, int a2, int a3, string a4, string a5, int a6);
    internal static void Trace(string fmtPrintfW, int a1, int a2, int a3);
    internal static void Trace(string fmtPrintfW, int a1, bool a2);
    internal static void Trace(string fmtPrintfW, int a1, int a2, int a3, int a4);
    internal static void Trace(string fmtPrintfW, int a1, int a2, bool a3);
    internal static void Trace(string fmtPrintfW, int a1, int a2, int a3, int a4, int a5, int a6, int a7);
    internal static void Trace(string fmtPrintfW, int a1, string a2, int a3, int a4, bool a5);
    internal static void Trace(string fmtPrintfW, int a1, long a2);
    internal static void Trace(string fmtPrintfW, int a1, int a2, long a3);
    internal static void Trace(string fmtPrintfW, int a1, string a2, string a3, string a4, int a5, long a6);
    internal static void Trace(string fmtPrintfW, int a1, long a2, int a3, int a4);
    internal static void Trace(string fmtPrintfW, int a1, int a2, long a3, int a4);
    internal static void Trace(string fmtPrintfW, int a1, int a2, int a3, int a4, string a5, string a6, string a7, int a8);
    internal static void Trace(string fmtPrintfW, int a1, int a2, string a3, string a4);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, string a2);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, bool a2);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2, string a3);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, string a2, bool a3);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2, bool a3);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2, int a3, string a4);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2, int a3);
    internal static void ScopeEnter(out IntPtr hScp, string fmtPrintfW, int a1, int a2, bool a3, int a4);

    #region Nested type: ApiGroup

    internal enum ApiGroup : uint
    {
        Off = 0,
        Default = 1,
        Trace = 2,
        Scope = 4,
        Perf = 8,
        Resource = 16,
        Memory = 32,
        StatusOk = 64,
        Advanced = 128,
        MaskBid = 4095,
        Pooling = 4096,
        Dependency = 8192,
        StateDump = 16384,
        MaskUser = 4294963200,
        MaskAll = 4294967295,
    }

    #endregion
}
