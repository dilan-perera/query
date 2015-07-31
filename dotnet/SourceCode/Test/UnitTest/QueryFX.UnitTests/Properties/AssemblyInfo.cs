#region License

/*
 * 
 * Copyright © 2015 The QueryFX Team
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *  
*/

#endregion

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
[assembly: Guid("0f435ce1-c8b4-4369-be40-c9f1f0b42267")]

[assembly: AssemblyTitle("QueryFX.UnitTests")]
[assembly: AssemblyDescription("Contains unit tests for QueryFX API functionality.")]
