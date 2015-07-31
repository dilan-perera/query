#region Imports

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("QueryFX")]
[assembly: AssemblyProduct("QueryFX")]
[assembly: AssemblyCopyright("Copyright © The QueryFX Team, 2015")]
[assembly: AssemblyTrademark("QueryFX is a trademark of the QueryFX team.")]
[assembly: AssemblyCulture("en")]

#if DEBUG
    [assembly: AssemblyConfiguration("Debug")]
#else
    [assembly: AssemblyConfiguration("Release")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(true)]
[assembly: CLSCompliant(true)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.1.0")]
[assembly: AssemblyFileVersion("1.0.1.0")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("bfd9a37f-5a8c-4d4d-a2a1-017ff77c9a6f")]

[assembly: AssemblyTitle("QueryFX.UnitTests.AdoNet")]
[assembly: AssemblyDescription("Contains unit tests for QueryFX functionality based on ADO.NET.")]
