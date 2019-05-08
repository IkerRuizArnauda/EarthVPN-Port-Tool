// Iker Ruiz Arnauda 2013
using System;
using System.Net;
using System.Drawing;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace EarthVPNDynamicPortTool
{
    public partial class MainForm : Form
   {
      //Move form without borders
      [DllImportAttribute("user32.dll")]
      public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
      [DllImportAttribute("user32.dll")]
      public static extern bool ReleaseCapture();
      public const int WM_NCLBUTTONDOWN = 0xA1;
      public const int HT_CAPTION = 0x2;

      //Properties
      private string FoundIp { get; set; }
      private string FoundPort { get; set; }
      private string NetworkIp { get; set; }
      private NetworkInterface EarthInterface { get; set; }
      private System.Windows.Forms.Timer ScanInterface = new System.Windows.Forms.Timer();


      private BackgroundWorker ProcessThread = new BackgroundWorker();

      public MainForm()
      {
         InitializeComponent();
         ScanInterface.Interval = 3000;
         ScanInterface.Tick += ScanInterface_Tick;
         ProcessThread.DoWork += ProcessThread_DoWork;
         ProcessThread.RunWorkerCompleted += ProcessThread_RunWorkerCompleted;
      }

      private void ScanInterface_Tick(object sender, EventArgs e)
      {
         if (EarthInterface != null)
         {
            try
            {
               Console.WriteLine(EarthInterface.GetIPProperties().UnicastAddresses[0].Address.ToString());
            }
            catch (Exception)
            {
               notifyIcon1.Visible = true;
               notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
               notifyIcon1.BalloonTipText = "Disconnected from EarthVPN.";
               notifyIcon1.BalloonTipTitle = "EarthVPN";
               notifyIcon1.ShowBalloonTip(100);
               ProcessThread.RunWorkerAsync();
               ScanInterface.Stop();
            }
         }
      }

      private void ProcessThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         pboxRefreshMask.Visible = false;
      }

      private void ProcessThread_DoWork(object sender, DoWorkEventArgs e)
      {
         this.Invoke(new Action(() => 
         {
            lblError.Visible = false; 
            lblSuccess.Visible = false; 
            pboxRefreshBtn.Visible = false;
            pboxRefreshMask.Visible = true;
         }));

         Thread.Sleep(1000);
         this.Invoke(new Action(() =>
              {
                 txtCurrentIP.Enabled = true;

                 FoundIp = FindEarthVPNIp();
                 if (FoundIp != null && NetworkIp != null)
                 {
                    txtCurrentIP.Text = FoundIp;
                    if (FindEarthVPNPort() && FoundPort != null)
                    {
                       txtCurrentPort.ForeColor = Color.Lime;
                       txtCurrentPort.Text = FoundPort;
                       txtCurrentIP.Enabled = false;
                       lblNetStatusValue.ForeColor = Color.Lime;
                       lblNetStatusValue.Text = "Connected";
                       pboxRefreshBtn.Select();
                       lblSuccess.Visible = true;
                       //ScanInterface.Enabled = true;
                       //ScanInterface.Start();
                    }
                    else
                    {
                       txtCurrentPort.ForeColor = Color.Yellow;
                       lblSuccess.Visible = false;
                       lblNetStatusValue.ForeColor = Color.Yellow;
                       lblNetStatusValue.Text = "Not Connected";
                       txtCurrentIP.Text = "n/a";
                       txtCurrentPort.Text = "n/a";
                       lblError.Visible = true;
                    }
                 }
                 else
                 {
                    txtCurrentPort.ForeColor = Color.Yellow;
                    lblSuccess.Visible = false;
                    lblNetStatusValue.ForeColor = Color.Yellow;
                    lblNetStatusValue.Text = "Not Connected";
                    txtCurrentIP.Text = "n/a";
                    txtCurrentPort.Text = "n/a";
                    lblError.Visible = true;
                 }
                 pboxRefreshBtn.Visible = true;
              }));       
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         pboxRefreshBtn.Select();
         //ProcessThread.RunWorkerAsync();
      }

      private bool FindEarthVPNPort()
      {
         var _portPrefix = "";
         try
         {           
            AvailableNetworks.Networks.TryGetValue(NetworkIp, out _portPrefix);
            var _lastFour = FoundIp.Split('.').GetValue(3).ToString().Length > 2 ? FoundIp.Split('.').GetValue(3).ToString() : "0" + FoundIp.Split('.').GetValue(3).ToString();
            _portPrefix += _lastFour;
         }
         catch
         {
            return false;
         }
         FoundPort = _portPrefix;
         return true;
      }

      private string FindEarthVPNIp()
      {
         String returnValue = "";
         /*foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
         {
               foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
               {
                  if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                  {
                     if (ip.Address.VerifyEarthVpnIp())
                     {
                        EarthInterface = ni;
                        returnValue = ip.Address.ToString();
                        NetworkIp = returnValue.Remove(returnValue.LastIndexOf('.'));
                        break;
                     }
                  }
               }
               break;
         }*/

         IPHostEntry Client = Dns.GetHostEntry(Dns.GetHostName());
         foreach (IPAddress InterfaceIp in Client.AddressList)
         {
            if (InterfaceIp.AddressFamily == AddressFamily.InterNetwork)
            {
               if (InterfaceIp.VerifyEarthVpnIp())
               {
                  returnValue = InterfaceIp.ToString();
                  NetworkIp = returnValue.Remove(returnValue.LastIndexOf('.'));
                  break;
               }
            }
         }
         return returnValue;
      }

      private void btnRefresh_Click(object sender, EventArgs e)
      {
         ProcessThread.RunWorkerAsync();
      }

      private void pictureBox2_Click(object sender, EventArgs e)
      {
         Clipboard.SetText(txtCurrentPort.Text);
      }

      private void pboxRefreshBtn_MouseEnter(object sender, EventArgs e)
      {
         pboxRefreshBtn.Image = Properties.Resources.Refresh_Hover;
      }

      private void pboxRefreshBtn_MouseLeave(object sender, EventArgs e)
      {
         pboxRefreshBtn.Image = Properties.Resources.Refresh_Normal;
      }

      private void pboxRefreshBtn_Click(object sender, EventArgs e)
      {
         if(!ProcessThread.IsBusy)
            ProcessThread.RunWorkerAsync();
      }

      private void pboxCloseBtn_MouseEnter(object sender, EventArgs e)
      {
         pboxCloseBtn.Image = Properties.Resources.Close_Hover;
      }

      private void pboxCloseBtn_MouseLeave(object sender, EventArgs e)
      {
         pboxCloseBtn.Image = Properties.Resources.Close_Normal;
      }

      private void pboxCloseBtn_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void MainPanel_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
         {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
         }
      }

      private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
         {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
         }
      }

      private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
         {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
         }
      }

      private void pboxMinimizeBtn_MouseEnter(object sender, EventArgs e)
      {
         pboxMinimizeBtn.Image = Properties.Resources.Minimize_Hover;
      }

      private void pboxMinimizeBtn_MouseLeave(object sender, EventArgs e)
      {
         pboxMinimizeBtn.Image = Properties.Resources.Minimize_Normal;
      }

      private void pboxMinimizeBtn_Click(object sender, EventArgs e)
      {
         notifyIcon1.Visible = true;
         notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
         notifyIcon1.BalloonTipText = "Dynamic Port Tool will keep running minimized.";
         notifyIcon1.BalloonTipTitle = "EarthVPN";
         notifyIcon1.ShowBalloonTip(100);
         this.Hide();
      }

      private void notifyIcon1_DoubleClick(object sender, EventArgs e)
      {
         this.Show();
      }

      private void txtCurrentIP_Enter(object sender, EventArgs e)
      {
         pboxRefreshMask.Select();
      }

      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         notifyIcon1.Dispose();
      }
   }

   public static class IPAddressExtension
   {
      public static bool VerifyEarthVpnIp(this IPAddress InterfaceIp)
      {
         var ip = InterfaceIp.ToString();
         //Debug.WriteLine("Verifying IP: {0}", InterfaceIp);
         if (AvailableNetworks.Networks.ContainsKey(ip.Remove(ip.LastIndexOf('.'))))
         {
            //Debug.WriteLine("Found valid network: " + ip);
            return true;
         }
         else
            return false;
      }
   }
}
