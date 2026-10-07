# Library for reading Excel files

This repository contains the source code of the optional library for reading Excel 97-2003 files (XLS) in Stimulsoft products. This library is compatible with products [Reports.WEB](https://www.stimulsoft.com/en/products/reports-web), [Reports.NET](https://www.stimulsoft.com/en/products/reports-net) and [Reports.WPF](https://www.stimulsoft.com/en/products/reports-wpf), as well as with [Ultimate](https://www.stimulsoft.com/en/products/ultimate), which includes these products. The following frameworks are supported: .NET Framework 4.6.2 and .NET 6.0, as well as all newer frameworks compatible with these.

The products read XLS files in the Excel data source with their own built-in reader, so this library is not required. It is an alternative reader: when the library is installed, the products use it instead of the built-in one. Install it if you prefer the reader used by earlier versions of the products, or if some XLS file is read better by it.

# How to use

To use the library, it is enough to install the NuGet package listed below in your project. To use the source codes, you can clone this repository and connect the source codes to your project.

[NuGet](https://www.nuget.org/packages/Stimulsoft.LibExcel)

The library is loaded by the products dynamically, no direct reference is required. The products look for `Stimulsoft.LibExcel.dll` or `LibExcel.dll` next to them, so the library can be replaced with your own build of these sources. When neither is found, the built-in reader is used.

[LGPL-3.0 License](LICENSE.md)

# What is inside

The library is a copy of [ExcelLibrary](https://code.google.com/archive/p/excellibrary) by Liu Junfeng and contributors, distributed under the GNU Lesser General Public License, version 3. See [VENDORING.md](VENDORING.md) for the details of what was taken and which changes were made to the original sources.
