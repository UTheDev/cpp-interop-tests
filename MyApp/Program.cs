// See https://aka.ms/new-console-template for more information

// Also see: https://learn.microsoft.com/en-us/cpp/dotnet/calling-native-functions-from-managed-code?view=msvc-1704
// Another useful resource: https://learn.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.dllimportattribute?view=net-7.0
using System;
using System.Runtime.InteropServices;

const string dllPath = "lib/libwindow_test.dll";

[DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
extern static void show_dialog();

show_dialog();
