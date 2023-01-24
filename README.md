# CsUWP

CsUWP was an experiment designed to show how you can make an UWP application using modern .NET Runtime versions.

Classic UWP .NET applications typically use the Microsoft.NETCore.UniversalWindowsPlatform runtime which is a fork of CoreRT. Said fork got unmaintained over time, and eventually led to incompatibilities with newer .NET libraries.

## How it works

The standard .NET UWP Project templates in Visual Studio and the Windows SDK make use of MSBuild tasks in order to build an UWP app.

A typical UWP app template is composed of an "App" class, extending the Application WinRT type, alonside a xaml file, and a single MainPage.

Behind the scenes, when compiling such project, xaml files get converted into auto generated code, by a Xaml build task (*.g.cs), and an auto generated main class gets generated which instancize the application class and starts your application.

The way CsUWP works is no different, _except_ we cannot make use of the build tasks for this Proof of Concept, and instead copy directly the automatically generated code for proof of concept purposes. Auto generating the cs files is an exercise left for the reader interested in this subject (Microsoft.Windows.UI.Xaml.Build.Tasks.dll)

## Workarounding .NET dropping support for native WinRT interop

With .NET 5 .NET Removed support for built in WinRT support in .NET, leading to the creation of the cswinrt package, aiming to automatically generate code and interop helpers to make it easier to work with WinRT apis via .NET Core applications. Said nuget package worked at the time (and likely still today) with most of the WinRT apis _except_ most under Windows.UI.Xaml (which is what we need to use here, as we do not use WinUI 3).

Forcing the generation of such projections is not possible via the standard cswinrt tooling, and further interop helpers are unavailable as well for making INotifyPropertyChanged among other .NET interfaces work out of the box with Windows.UI.Xaml

A modified CsWinRT tooling was used for this Proof of Concept and is made available independently here: https://github.com/gus33000/CsWinRT/tree/wux (check the wux branch)

I will point out this fork is way behind main, and CsWinRT may now have better support for generating types. There is an ongoing issue on adding proper support for WinUI types which you can read through here: https://github.com/microsoft/CsWinRT/issues/723

## Generating the PRI

Generating the default PRI as well as the APPX package for that matter is also normally automated by a specific build task, but it's trivial enough to add a few commands for this PoC to generate both.

If you plan on reproducing this for experimentation purposes, you may have to create a standard UWP project first with your code to make it easier to generate the automatically generated code, and then transfer these files (typically placed under a directory named ```obj``` in the .NET Core project

## License

This entire repository is licensed under the MIT license, see LICENSE.md for more information.
This repository does make use of sample code provided through default UWP templates by Microsoft Corporation, and also makes use of code from CsWinRT also provided under the MIT license at https://github.com/microsoft/CsWinRT/
