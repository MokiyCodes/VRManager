using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OculusManager
{
  internal static class Program
  {
    private static readonly string[] Files = {
      // Kernel Mode Elevation, as to allow killing Oculus Services if they move to kernel mode drivers
      // Kept for future usage, currently unused.
      //"https://github.com/MokiyCodes/PSTools/releases/latest/download/PsExec.exe",
      //"https://gist.githubusercontent.com/MokiyCodes/eb7662c4c9f3d296fb56b7ac3593c2a9/raw/admintokernel.ps1",

      // Bunifu
      "https://cdn.discordapp.com/attachments/926118863677050900/929055058790842388/Bunifu_UI_v1.5.3.dll",
    };
    private static readonly WebClient client = new WebClient();
    public static readonly string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      AdminRelauncher();
      foreach (string file in Files)
      {
        string[] v = file.Split('/');
        string output = v.Last();
        client.DownloadFile(file,Path.Combine(assemblyPath, output));
      }
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Overlay());
    }

    private static void AdminRelauncher()
    {
      if (!IsRunAsAdmin())
      {
        ProcessStartInfo proc = new ProcessStartInfo();
        proc.UseShellExecute = true;
        proc.WorkingDirectory = Environment.CurrentDirectory;
        proc.FileName = Assembly.GetEntryAssembly().CodeBase;

        proc.Verb = "runas";

        try
        {
          Process.Start(proc);
          Application.ExitThread();
        }
        catch (Exception ex)
        {
          Console.WriteLine("This program must be run as an administrator! \n\n" + ex.ToString());
        }
      }
    }

    private static bool IsRunAsAdmin()
    {
      WindowsIdentity id = WindowsIdentity.GetCurrent();
      WindowsPrincipal principal = new WindowsPrincipal(id);

      return principal.IsInRole(WindowsBuiltInRole.Administrator);
    }
  }
}
