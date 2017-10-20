using Microsoft.VisualStudio.Shell;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("HelloVsToolWindow")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("HelloVsToolWindow")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

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
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Provide Codebase
[assembly: ProvideCodeBase(AssemblyName = "MahApps.Metro", Version = "1.5.0.23", CodeBase = "$PackageFolder$\\MahApps.Metro.dll")]
[assembly: ProvideCodeBase(AssemblyName = "MahApps.Metro.IconPacks", Version = "1.9.1.0", CodeBase = "$PackageFolder$\\MahApps.Metro.IconPacks.dll")]
[assembly: ProvideCodeBase(AssemblyName = "HelloVsToolWindow.Control", Version = "1.0.0.0", CodeBase = "$PackageFolder$\\HelloVsToolWindow.Control.dll")]
[assembly: ProvideCodeBase(AssemblyName = "Prism", Version = "6.3.0.0", CodeBase = "$PackageFolder$\\Prism.dll")]
[assembly: ProvideCodeBase(AssemblyName = "Prism.Wpf", Version = "6.3.0.0", CodeBase = "$PackageFolder$\\Prism.Wpf.dll")]
