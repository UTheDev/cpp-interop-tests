#include "WindowTest.hpp"
#include <windows.h>

void WindowTest::show_dialog()
{
    int message_result = MessageBox(
        NULL,
        L"hi",
        L"hi",
        MB_OK
    );
}