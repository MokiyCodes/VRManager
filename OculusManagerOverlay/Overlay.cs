using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace VRManager
{
  public partial class Overlay : Form
  {
    private string[] OculusProcessNames =
    {
      "OculusClient",
      "OVRRedir",
      "OVRServer_x64",
      "OVRServiceLauncher",
      "VirtualDesktop.Service",
      "VirtualDesktop.Streamer"
    };

    private string CountText;
    public Overlay()
    {
      InitializeComponent();
      UpdateCount.Start();
      CountText = ProcessCount.Text;
      TopMost = true;
    }

    private void bunifuCustomLabel1_Click(object sender, EventArgs e)
    {

    }

    private void Exit_Click(object sender, EventArgs e)
    {
      HasBeenClosed = true;
      Application.ExitThread();
    }
    private List<Process> GetProcesses()
    {

      Process[] allProcesses = Process.GetProcesses();
      List<Process> OculusProcesses = new List<Process>();
      foreach (Process process in allProcesses)
      {
        foreach (string processName in OculusProcessNames)
        {
          if (process.ProcessName.ToLower() == processName.ToLower())
          {
            OculusProcesses.Add(process);
          }
        }
      }
      return OculusProcesses;
    }
    private int GetLength(List<Process> item)
    {
      int length = 0;
      foreach (dynamic item2 in item)
      {
        length++;
      };
      return length;
    }
    private void UpdateCount_Tick(object sender, EventArgs e)
    {
      ProcessCount.Text = CountText.Replace("COUNT", GetLength(GetProcesses()).ToString());
    }

    private void Overlay_Enter(object sender, EventArgs e)
    {

    }

    private void Overlay_Activated(object sender, EventArgs e)
    {
      Opacity = 1;
    }

    private bool HasBeenClosed = false;

    private void Overlay_Deactivate(object sender, EventArgs e)
    {
      System.Threading.Thread.Sleep(125);
      if (!IsDisposed && Opacity == 1 && Visible && !HasBeenClosed) Opacity = 0.6;
    }

    private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
    {
      HasBeenClosed = true;
    }

    private void Kill_Click(object sender, EventArgs e)
    {
      GetProcesses().ForEach(process =>
      {
        process.Kill();
      });
    }
  }
}
