# Vendoring of ExcelLibrary

LibExcel is a modified copy of ExcelLibrary, a .NET library for reading and writing Excel 97-2003 (BIFF8)
files. This file is the notice of the changes required by the GNU Lesser General Public License, version 3.

## Origin

- Project: [ExcelLibrary](https://code.google.com/archive/p/excellibrary) by Liu Junfeng and contributors
  (see `Stimulsoft.LibExcel/Office/Excel/readme.txt`).
- License: GNU Lesser General Public License, version 3. The original project carries the text in
  `src/COPYING.LESSER` and the GNU General Public License, version 3, in `src/COPYING`, both added by the
  project owner on 2009-02-13. No "any later version" permission is given. Both texts are reproduced in
  [LICENSE.md](LICENSE.md).
- Source: the folder `src/ExcelLibrary` at the last revision of the project, commit
  `ffb7fc96263590163d949a1169c6eec702465400` of 2013-03-01, as kept in the mirror
  [google-code-export/excellibrary](https://github.com/google-code-export/excellibrary) (Google Code itself
  is read-only).

## What is taken without changes

All the code of the library: the 170 source files in `CodeLib`, `Office` and `DataSetHelper.cs`, and
`Office/Excel/readme.txt`. Namespaces (`ExcelLibrary.*`, `QiHe.CodeLib`) and type names are the original
ones.

## What was changed

1. `ExcelLibrary.csproj` is replaced with `Stimulsoft.LibExcel.csproj`: an SDK-style project for
   .NET Framework 4.6.2 and .NET 6.0 instead of .NET Framework 2.0, the assembly is named `LibExcel`
   instead of `ExcelLibrary` and is signed with a strong name. Compiler warnings about CLS compliance
   and about `BinaryFormatter` (used by `BinFile` in `CodeLib/FileIO.cs`) are turned off, as are the
   .NET code analyzers.
   For .NET 6.0 and newer `CodeLib/FileSelector.cs` is not compiled: its file dialogs need Windows Forms.
   The library itself uses neither `FileSelector` nor `BinFile`, so on all frameworks it reads the same
   files in the same way.
2. `Properties/AssemblyInfo.cs` is rewritten: title, description, company, product, copyright and version
   are set by Stimulsoft (the version follows the releases of Stimulsoft products), the attributes
   `AllowPartiallyTrustedCallers`, `CLSCompliant(true)` and `SecurityRules(Level1)` are added, the
   attributes `ComVisible`, `Guid`, `AssemblyFileVersion` and `InternalsVisibleTo("ExcelLibrary.Test")`
   are removed.

Not taken from the original: the solution `ExcelLibrary.sln`, the projects `ExcelLibrary.Test`,
`ExcelLibrary.Tool` and `ExcelLibrary.WinForm`, the folders `bin` and `lib`.

## Dates of the changes

- 2019-06-23 and earlier: the assembly is renamed to `LibExcel`, built for .NET Framework 4.0 and signed
  with a strong name; this is the earliest date recorded in Stimulsoft repositories, the copy was made
  before it.
- 2026-04-17: .NET Framework 4.5.2, version 2026.2.1.
- 2026-09-09: .NET Framework 4.6.2, version 2026.4.1.
- 2026-10-06: the copy is moved to this repository, the project is converted to the SDK style, the
  description and copyright of the assembly are corrected, the license texts are added.
- 2026-10-07: .NET 6.0 is added.
