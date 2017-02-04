[![video](https://i.ytimg.com/vi/UHEW-ZInr6A/hqdefault.jpg)](https://www.youtube.com/watch?v=UHEW-ZInr6A)

Prerequisites
=============
Visual Studio 2015 Update 3 with latest .NET Core tooling installed

-or-

Visual Studio 2017 RC (at least version from Jan 27)





Platform Support
================

Windows
-------

Should just work out of the box.

Window icons are not supported yet (for some weird reason we were using Windows.Forms/System.Drawing)


Linux
-----

SkiaSharp package doesn't have a precompiled Linux binary yet, but we have it built for Ubuntu:

https://1drv.ms/u/s!AguhICu8mgtrgvo1gE1BRIQh5PJXEg - libskia.so
https://files.gitter.im/AvaloniaUI/Avalonia/zsGE/libSkiaSharp.so - libSkiaSharp.so

Place those somewhere, `chmod +x` and then set `LD_LIBRARY_PATH` to that directory. When running a published version just copy these binaries to output directory.


For other Linux distros you need to build libSkiaSharp yourself or hope that those are compatible.


Mac
---

You need to get GTK3 binaries somewhere. I'm planning to check if it works with ones from `brew`, but haven't done that yet. 
We are planning to implement Quartz-backend in the future.