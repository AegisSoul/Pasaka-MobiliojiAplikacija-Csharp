using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;
using static Pasaka.Page10;
using XamarinFirebase.Droid;
using System;
using System.Text;
using System.IO;


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Pasaka.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Pasaka.Android")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: Xamarin.Forms.Dependency(typeof(WirteFileService))]
namespace XamarinFirebase.Droid
{
    public class WirteFileService : IWirteService
    {


        /*void IWirteService.wirteFile(string FileName, string Answer1, string Answer2, string Answer3, string Answer4, string Answer41, string Answer42, string Answer5, string Answer6, string Answer7, string Answer8)
        {
            string combinedinput = Answer1 + " " + Answer2 + " " + Answer3 + " " + Answer4 + " " + Answer41 + " " + Answer42 + " " + Answer5 + " " + Answer6 + " " + Answer7 + " " + Answer8;
            
            byte[] data = Encoding.UTF8.GetBytes(combinedinput);

            string DownloadsPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);

            string filePath = Path.Combine(DownloadsPath, FileName);
            File.WriteAllBytes(filePath, data);
        }*/
        void IWirteService.wirteFile(string FileName, string jsonData)
        {
            string DownloadsPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);

            string filePath = Path.Combine(DownloadsPath, FileName);

            if (File.Exists(filePath))
            {
                
                string existingData = File.ReadAllText(filePath);

                string updatedData = existingData + jsonData;

                File.WriteAllText(filePath, updatedData);
                Console.WriteLine(DownloadsPath + " Failas irasytas");
            }
            else
            {
                byte[] data = Encoding.UTF8.GetBytes(jsonData);
                File.WriteAllBytes(filePath, data);
            }
        }
    }
}
