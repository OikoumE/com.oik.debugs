using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Debugs
{
    //TODO make package && git
    public static void Log(object message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Debug.Log($"[{Path.GetFileName(sourceFilePath)}:{sourceLineNumber} - {memberName}] {message}");
    }

    public static void LogError(object message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Debug.LogError($"[{Path.GetFileName(sourceFilePath)}:{sourceLineNumber} - {memberName}] {message}");
    }

    public static void LogWarning(object message,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Debug.LogWarning($"[{Path.GetFileName(sourceFilePath)}:{sourceLineNumber} - {memberName}] {message}");
    }

    public static void Log(object message, Object context,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Debug.Log($"[{Path.GetFileName(sourceFilePath)}:{sourceLineNumber} - {memberName}] {message}", context);
    }

    public static void LogError(object message, Object context,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Debug.LogError($"[{Path.GetFileName(sourceFilePath)}:{sourceLineNumber} - {memberName}] {message}", context);
    }

    public static void LogWarning(object message, Object context,
        [CallerMemberName] string memberName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerLineNumber] int sourceLineNumber = 0
    )
    {
        Debug.LogWarning($"[{Path.GetFileName(sourceFilePath)}:{sourceLineNumber} - {memberName}] {message}", context);
    }
}