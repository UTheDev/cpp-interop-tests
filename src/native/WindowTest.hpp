// attempt at trying to call C++ methods from C# as shown in this tutorial: https://stackoverflow.com/questions/9407616/how-to-write-my-c-function-so-i-can-call-it-from-c

#ifndef WINDOW_TEST
#define WINDOW_TEST

/**
 * @brief Displays a dialog on a device running Windows
 * 
 */
extern "C"
__declspec(dllexport)
void
__cdecl
show_dialog();

#endif
