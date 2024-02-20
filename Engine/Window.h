#pragma once
#include <sys/inotify.h>

class Window {

public:
    Window();
    // odpala okno
    bool init();
    // zamyka okno
    bool release();
    ~Window();

};

