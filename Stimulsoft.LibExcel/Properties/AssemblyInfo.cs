// Copyright (C) 2003-2026 Stimulsoft.
// Licensed under the GNU Lesser General Public License, version 3.
// Based on ExcelLibrary, see VENDORING.md in the root of the repository.

using System;
using System.Reflection;
using System.Security;

[assembly: AssemblyTitle("LibExcel.dll")]
[assembly: AssemblyDescription("Excel library based on ExcelLibrary, licensed under the GNU LGPL v3")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Stimulsoft")]
[assembly: AssemblyProduct("Stimulsoft Reports")]
[assembly: AssemblyCopyright("Copyright (C) 2006-2013 ExcelLibrary authors, Copyright (C) 2003-2026 Stimulsoft")]
[assembly: AssemblyTrademark("Stimulsoft")]
[assembly: AssemblyCulture("")]
[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(true)]
[assembly: AssemblyDelaySign(false)]
// When changing the LibExcel version, also update project dependencies and NuGet metadata.
[assembly: AssemblyVersion("2026.4.1")]

[assembly: SecurityRules(SecurityRuleSet.Level1)]