// attempt at trying to call C++ methods from C# as shown in this tutorial: https://stackoverflow.com/questions/9407616/how-to-write-my-c-function-so-i-can-call-it-from-c

// Also see: https://learn.microsoft.com/en-us/cpp/dotnet/calling-native-functions-from-managed-code?view=msvc-1704
// Another useful resource: https://learn.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-7.0
//using System;
using System.Runtime.InteropServices;

const string dllPath = "build/libwindow_test.dll";

[DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
extern static void show_dialog();

show_dialog();
