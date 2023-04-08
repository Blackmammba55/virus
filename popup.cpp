#include <windows.h>

int main() {
    for (int i = 0; i < 10000; i++) { // 10000 is the number of times the message box will appear
        MessageBox(NULL, "Hello you have been trolled!", "Popup Window", MB_OK);
    }
    return 0;
}

// this spams the user with a message box 10000 times
//please use this responsibly

// Language: c++
