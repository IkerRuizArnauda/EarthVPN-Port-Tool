namespace EarthVPNDynamicPortTool
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.pboxMinimizeBtn = new System.Windows.Forms.PictureBox();
         this.pboxCloseBtn = new System.Windows.Forms.PictureBox();
         this.pboxCopyClipBtn = new System.Windows.Forms.PictureBox();
         this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
         this.MainPanel = new System.Windows.Forms.Panel();
         this.lblSuccess = new System.Windows.Forms.Label();
         this.lblError = new System.Windows.Forms.Label();
         this.lblNetStatusValue = new System.Windows.Forms.Label();
         this.lblNetStatus = new System.Windows.Forms.Label();
         this.pboxTopBanner = new System.Windows.Forms.PictureBox();
         this.pboxRefreshMask = new System.Windows.Forms.PictureBox();
         this.pboxRefreshBtn = new System.Windows.Forms.PictureBox();
         this.pboxLogo = new System.Windows.Forms.PictureBox();
         this.txtCurrentPort = new System.Windows.Forms.Label();
         this.txtCurrentIP = new System.Windows.Forms.TextBox();
         this.lblCurrentPort = new System.Windows.Forms.Label();
         this.lblCurrentIP = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizeBtn)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxCloseBtn)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxCopyClipBtn)).BeginInit();
         this.MainPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pboxTopBanner)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxRefreshMask)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxRefreshBtn)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
         this.SuspendLayout();
         // 
         // pboxMinimizeBtn
         // 
         this.pboxMinimizeBtn.BackColor = System.Drawing.Color.Transparent;
         this.pboxMinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.pboxMinimizeBtn.Image = global::EarthVPNDynamicPortTool.Properties.Resources.Minimize_Normal;
         this.pboxMinimizeBtn.Location = new System.Drawing.Point(182, 0);
         this.pboxMinimizeBtn.Name = "pboxMinimizeBtn";
         this.pboxMinimizeBtn.Size = new System.Drawing.Size(24, 24);
         this.pboxMinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pboxMinimizeBtn.TabIndex = 14;
         this.pboxMinimizeBtn.TabStop = false;
         this.toolTip1.SetToolTip(this.pboxMinimizeBtn, "Minimize");
         this.pboxMinimizeBtn.Click += new System.EventHandler(this.pboxMinimizeBtn_Click);
         this.pboxMinimizeBtn.MouseEnter += new System.EventHandler(this.pboxMinimizeBtn_MouseEnter);
         this.pboxMinimizeBtn.MouseLeave += new System.EventHandler(this.pboxMinimizeBtn_MouseLeave);
         // 
         // pboxCloseBtn
         // 
         this.pboxCloseBtn.BackColor = System.Drawing.Color.Transparent;
         this.pboxCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.pboxCloseBtn.Image = global::EarthVPNDynamicPortTool.Properties.Resources.Close_Normal;
         this.pboxCloseBtn.Location = new System.Drawing.Point(208, 0);
         this.pboxCloseBtn.Name = "pboxCloseBtn";
         this.pboxCloseBtn.Size = new System.Drawing.Size(24, 24);
         this.pboxCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pboxCloseBtn.TabIndex = 13;
         this.pboxCloseBtn.TabStop = false;
         this.toolTip1.SetToolTip(this.pboxCloseBtn, "Close");
         this.pboxCloseBtn.Click += new System.EventHandler(this.pboxCloseBtn_Click);
         this.pboxCloseBtn.MouseEnter += new System.EventHandler(this.pboxCloseBtn_MouseEnter);
         this.pboxCloseBtn.MouseLeave += new System.EventHandler(this.pboxCloseBtn_MouseLeave);
         // 
         // pboxCopyClipBtn
         // 
         this.pboxCopyClipBtn.BackColor = System.Drawing.Color.Transparent;
         this.pboxCopyClipBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.pboxCopyClipBtn.Image = global::EarthVPNDynamicPortTool.Properties.Resources.Clipboard;
         this.pboxCopyClipBtn.Location = new System.Drawing.Point(201, 184);
         this.pboxCopyClipBtn.Name = "pboxCopyClipBtn";
         this.pboxCopyClipBtn.Size = new System.Drawing.Size(16, 16);
         this.pboxCopyClipBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pboxCopyClipBtn.TabIndex = 7;
         this.pboxCopyClipBtn.TabStop = false;
         this.toolTip1.SetToolTip(this.pboxCopyClipBtn, "Copy Port to Clipboard");
         this.pboxCopyClipBtn.Click += new System.EventHandler(this.pictureBox2_Click);
         // 
         // notifyIcon1
         // 
         this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
         this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
         this.notifyIcon1.Text = "EarthVPN Port Forwarding Tool";
         this.notifyIcon1.Visible = true;
         this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
         // 
         // MainPanel
         // 
         this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(92)))), ((int)(((byte)(124)))));
         this.MainPanel.BackgroundImage = global::EarthVPNDynamicPortTool.Properties.Resources.BG;
         this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.MainPanel.Controls.Add(this.lblSuccess);
         this.MainPanel.Controls.Add(this.lblError);
         this.MainPanel.Controls.Add(this.lblNetStatusValue);
         this.MainPanel.Controls.Add(this.lblNetStatus);
         this.MainPanel.Controls.Add(this.pboxMinimizeBtn);
         this.MainPanel.Controls.Add(this.pboxCloseBtn);
         this.MainPanel.Controls.Add(this.pboxTopBanner);
         this.MainPanel.Controls.Add(this.pboxRefreshMask);
         this.MainPanel.Controls.Add(this.pboxRefreshBtn);
         this.MainPanel.Controls.Add(this.pboxCopyClipBtn);
         this.MainPanel.Controls.Add(this.pboxLogo);
         this.MainPanel.Controls.Add(this.txtCurrentPort);
         this.MainPanel.Controls.Add(this.txtCurrentIP);
         this.MainPanel.Controls.Add(this.lblCurrentPort);
         this.MainPanel.Controls.Add(this.lblCurrentIP);
         this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MainPanel.Location = new System.Drawing.Point(0, 0);
         this.MainPanel.Name = "MainPanel";
         this.MainPanel.Size = new System.Drawing.Size(235, 322);
         this.MainPanel.TabIndex = 1;
         this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
         // 
         // lblSuccess
         // 
         this.lblSuccess.AutoSize = true;
         this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
         this.lblSuccess.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSuccess.ForeColor = System.Drawing.Color.Lime;
         this.lblSuccess.Location = new System.Drawing.Point(88, 254);
         this.lblSuccess.Name = "lblSuccess";
         this.lblSuccess.Size = new System.Drawing.Size(52, 15);
         this.lblSuccess.TabIndex = 11;
         this.lblSuccess.Text = "Success!";
         this.lblSuccess.Visible = false;
         // 
         // lblError
         // 
         this.lblError.AutoSize = true;
         this.lblError.BackColor = System.Drawing.Color.Transparent;
         this.lblError.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblError.ForeColor = System.Drawing.Color.Yellow;
         this.lblError.Location = new System.Drawing.Point(15, 254);
         this.lblError.Name = "lblError";
         this.lblError.Size = new System.Drawing.Size(204, 15);
         this.lblError.TabIndex = 10;
         this.lblError.Text = "Unable to detect EarthVPN network!";
         this.lblError.Visible = false;
         // 
         // lblNetStatusValue
         // 
         this.lblNetStatusValue.AutoSize = true;
         this.lblNetStatusValue.BackColor = System.Drawing.Color.Transparent;
         this.lblNetStatusValue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNetStatusValue.ForeColor = System.Drawing.Color.Yellow;
         this.lblNetStatusValue.Location = new System.Drawing.Point(103, 214);
         this.lblNetStatusValue.Name = "lblNetStatusValue";
         this.lblNetStatusValue.Size = new System.Drawing.Size(89, 15);
         this.lblNetStatusValue.TabIndex = 16;
         this.lblNetStatusValue.Text = "Not Connected";
         // 
         // lblNetStatus
         // 
         this.lblNetStatus.AutoSize = true;
         this.lblNetStatus.BackColor = System.Drawing.Color.Transparent;
         this.lblNetStatus.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNetStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
         this.lblNetStatus.Location = new System.Drawing.Point(15, 214);
         this.lblNetStatus.Name = "lblNetStatus";
         this.lblNetStatus.Size = new System.Drawing.Size(87, 14);
         this.lblNetStatus.TabIndex = 15;
         this.lblNetStatus.Text = "Network Status:";
         // 
         // pboxTopBanner
         // 
         this.pboxTopBanner.BackColor = System.Drawing.Color.Transparent;
         this.pboxTopBanner.Dock = System.Windows.Forms.DockStyle.Top;
         this.pboxTopBanner.Image = global::EarthVPNDynamicPortTool.Properties.Resources.Top_Normal_02;
         this.pboxTopBanner.Location = new System.Drawing.Point(0, 0);
         this.pboxTopBanner.Name = "pboxTopBanner";
         this.pboxTopBanner.Size = new System.Drawing.Size(233, 25);
         this.pboxTopBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pboxTopBanner.TabIndex = 12;
         this.pboxTopBanner.TabStop = false;
         this.pboxTopBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
         // 
         // pboxRefreshMask
         // 
         this.pboxRefreshMask.BackColor = System.Drawing.Color.Transparent;
         this.pboxRefreshMask.Cursor = System.Windows.Forms.Cursors.Hand;
         this.pboxRefreshMask.Image = global::EarthVPNDynamicPortTool.Properties.Resources.Refreshing;
         this.pboxRefreshMask.Location = new System.Drawing.Point(14, 280);
         this.pboxRefreshMask.Name = "pboxRefreshMask";
         this.pboxRefreshMask.Size = new System.Drawing.Size(208, 29);
         this.pboxRefreshMask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pboxRefreshMask.TabIndex = 9;
         this.pboxRefreshMask.TabStop = false;
         this.pboxRefreshMask.Visible = false;
         // 
         // pboxRefreshBtn
         // 
         this.pboxRefreshBtn.BackColor = System.Drawing.Color.Transparent;
         this.pboxRefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.pboxRefreshBtn.Image = global::EarthVPNDynamicPortTool.Properties.Resources.Refresh_Normal;
         this.pboxRefreshBtn.Location = new System.Drawing.Point(18, 280);
         this.pboxRefreshBtn.Name = "pboxRefreshBtn";
         this.pboxRefreshBtn.Size = new System.Drawing.Size(199, 30);
         this.pboxRefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pboxRefreshBtn.TabIndex = 8;
         this.pboxRefreshBtn.TabStop = false;
         this.pboxRefreshBtn.Click += new System.EventHandler(this.pboxRefreshBtn_Click);
         this.pboxRefreshBtn.MouseEnter += new System.EventHandler(this.pboxRefreshBtn_MouseEnter);
         this.pboxRefreshBtn.MouseLeave += new System.EventHandler(this.pboxRefreshBtn_MouseLeave);
         // 
         // pboxLogo
         // 
         this.pboxLogo.BackColor = System.Drawing.Color.Transparent;
         this.pboxLogo.Image = global::EarthVPNDynamicPortTool.Properties.Resources.LogoLetters;
         this.pboxLogo.Location = new System.Drawing.Point(42, 38);
         this.pboxLogo.Name = "pboxLogo";
         this.pboxLogo.Size = new System.Drawing.Size(150, 89);
         this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         this.pboxLogo.TabIndex = 6;
         this.pboxLogo.TabStop = false;
         this.pboxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
         // 
         // txtCurrentPort
         // 
         this.txtCurrentPort.AutoSize = true;
         this.txtCurrentPort.BackColor = System.Drawing.Color.Transparent;
         this.txtCurrentPort.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCurrentPort.ForeColor = System.Drawing.Color.Yellow;
         this.txtCurrentPort.Location = new System.Drawing.Point(103, 181);
         this.txtCurrentPort.Name = "txtCurrentPort";
         this.txtCurrentPort.Size = new System.Drawing.Size(27, 18);
         this.txtCurrentPort.TabIndex = 5;
         this.txtCurrentPort.Text = "n/a";
         // 
         // txtCurrentIP
         // 
         this.txtCurrentIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
         this.txtCurrentIP.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.txtCurrentIP.Enabled = false;
         this.txtCurrentIP.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtCurrentIP.Location = new System.Drawing.Point(104, 149);
         this.txtCurrentIP.MaxLength = 15;
         this.txtCurrentIP.Name = "txtCurrentIP";
         this.txtCurrentIP.ReadOnly = true;
         this.txtCurrentIP.Size = new System.Drawing.Size(113, 23);
         this.txtCurrentIP.TabIndex = 0;
         this.txtCurrentIP.Text = "n/a";
         this.txtCurrentIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.txtCurrentIP.Enter += new System.EventHandler(this.txtCurrentIP_Enter);
         // 
         // lblCurrentPort
         // 
         this.lblCurrentPort.AutoSize = true;
         this.lblCurrentPort.BackColor = System.Drawing.Color.Transparent;
         this.lblCurrentPort.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCurrentPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
         this.lblCurrentPort.Location = new System.Drawing.Point(15, 184);
         this.lblCurrentPort.Name = "lblCurrentPort";
         this.lblCurrentPort.Size = new System.Drawing.Size(85, 14);
         this.lblCurrentPort.TabIndex = 2;
         this.lblCurrentPort.Text = "Forwarded Port:";
         // 
         // lblCurrentIP
         // 
         this.lblCurrentIP.AutoSize = true;
         this.lblCurrentIP.BackColor = System.Drawing.Color.Transparent;
         this.lblCurrentIP.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCurrentIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
         this.lblCurrentIP.Location = new System.Drawing.Point(15, 153);
         this.lblCurrentIP.Name = "lblCurrentIP";
         this.lblCurrentIP.Size = new System.Drawing.Size(61, 14);
         this.lblCurrentIP.TabIndex = 1;
         this.lblCurrentIP.Text = "IP Address:";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(235, 322);
         this.ControlBox = false;
         this.Controls.Add(this.MainPanel);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "EarthVPN - Dynamic Port Forwarding Tool";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
         this.Load += new System.EventHandler(this.MainForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pboxMinimizeBtn)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxCloseBtn)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxCopyClipBtn)).EndInit();
         this.MainPanel.ResumeLayout(false);
         this.MainPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pboxTopBanner)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxRefreshMask)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxRefreshBtn)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel MainPanel;
      private System.Windows.Forms.Label lblCurrentIP;
      private System.Windows.Forms.TextBox txtCurrentIP;
      private System.Windows.Forms.Label lblCurrentPort;
      private System.Windows.Forms.Label txtCurrentPort;
      private System.Windows.Forms.PictureBox pboxLogo;
      private System.Windows.Forms.PictureBox pboxCopyClipBtn;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.PictureBox pboxRefreshBtn;
      private System.Windows.Forms.PictureBox pboxRefreshMask;
      private System.Windows.Forms.Label lblError;
      private System.Windows.Forms.Label lblSuccess;
      private System.Windows.Forms.PictureBox pboxTopBanner;
      private System.Windows.Forms.PictureBox pboxCloseBtn;
      private System.Windows.Forms.PictureBox pboxMinimizeBtn;
      private System.Windows.Forms.NotifyIcon notifyIcon1;
      private System.Windows.Forms.Label lblNetStatus;
      private System.Windows.Forms.Label lblNetStatusValue;
   }
}

