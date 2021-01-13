using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

namespace Extension_Form
{
	static public class Extension_Form
	{
		static public string GetFileVersionString(this Form form)
		{
			var assembly = Assembly.GetEntryAssembly();
			var location = assembly.Location;
			var fileVersionInfo = FileVersionInfo.GetVersionInfo(location);

			return fileVersionInfo.FileVersion;
		}
	}
}

