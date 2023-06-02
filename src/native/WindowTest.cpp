#include "WindowTest.hpp"
#include <windows.h>

void show_dialog()
{
    int message_result = MessageBox(
        NULL,
        LPSTR("hi"),
        LPSTR("hi"),
        MB_OK
    );
}