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


Mac OS X
---

Follow instructions from https://www.microsoft.com/net/core#macos
Note, that you need at least RC3 - https://go.microsoft.com/fwlink/?linkid=839635

After .NET Core SDK is installed, run `brew install gtk+3` to install GTK3. We are planning to implement Quartz-backend, so this step won't be needed in the future.

Then you should be able to run `dotnet restore` and `dotnet run`.