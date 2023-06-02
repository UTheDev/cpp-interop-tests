// attempt at trying to call C++ methods from C# as shown in this tutorial: https://stackoverflow.com/questions/9407616/how-to-write-my-c-function-so-i-can-call-it-from-c

using System;

namespace Hi {
    private static const string dllPath = "";

    [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl)]
    public extern static void show_dialog();

    public static void Main(string[] args) {
        // moment of truth
        show_dialog();
    }
}