namespace VRManager
{
  partial class Overlay
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
      this.Round = new Bunifu.Framework.UI.BunifuElipse(this.components);
      this.DragWindow = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.Exit = new Bunifu.Framework.UI.BunifuFlatButton();
      this.IconBox = new System.Windows.Forms.PictureBox();
      this.Kill = new Bunifu.Framework.UI.BunifuFlatButton();
      this.yeet = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.ProcessCount = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.DragCount = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.DragIcon = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.DragTitle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.DragDescription = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.UpdateCount = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
      this.SuspendLayout();
      // 
      // Round
      // 
      this.Round.ElipseRadius = 5;
      this.Round.TargetControl = this;
      // 
      // DragWindow
      // 
      this.DragWindow.Fixed = true;
      this.DragWindow.Horizontal = true;
      this.DragWindow.TargetControl = this;
      this.DragWindow.Vertical = true;
      // 
      // Title
      // 
      this.Title.Font = new System.Drawing.Font("Poppins Light", 16F);
      this.Title.ForeColor = System.Drawing.Color.White;
      this.Title.Location = new System.Drawing.Point(64, 13);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(349, 32);
      this.Title.TabIndex = 0;
      this.Title.Text = "VR Manager";
      // 
      // Exit
      // 
      this.Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
      this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.Exit.BorderRadius = 0;
      this.Exit.ButtonText = "Exit VR Manager";
      this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Exit.DisabledColor = System.Drawing.Color.Gray;
      this.Exit.Iconcolor = System.Drawing.Color.Transparent;
      this.Exit.Iconimage = null;
      this.Exit.Iconimage_right = null;
      this.Exit.Iconimage_right_Selected = null;
      this.Exit.Iconimage_Selected = null;
      this.Exit.IconMarginLeft = 0;
      this.Exit.IconMarginRight = 0;
      this.Exit.IconRightVisible = true;
      this.Exit.IconRightZoom = 0D;
      this.Exit.IconVisible = true;
      this.Exit.IconZoom = 90D;
      this.Exit.IsTab = false;
      this.Exit.Location = new System.Drawing.Point(267, 95);
      this.Exit.Name = "Exit";
      this.Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
      this.Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
      this.Exit.OnHoverTextColor = System.Drawing.Color.White;
      this.Exit.selected = false;
      this.Exit.Size = new System.Drawing.Size(134, 48);
      this.Exit.TabIndex = 2;
      this.Exit.Text = "Exit VR Manager";
      this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.Exit.Textcolor = System.Drawing.Color.White;
      this.Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Exit.Click += new System.EventHandler(this.Exit_Click);
      // 
      // IconBox
      // 
      this.IconBox.ErrorImage = global::VRManager.Properties.Resources.oculus_manager_light;
      this.IconBox.Image = global::VRManager.Properties.Resources.oculus_manager_light_2;
      this.IconBox.ImageLocation = "";
      this.IconBox.InitialImage = global::VRManager.Properties.Resources.oculus_manager_light;
      this.IconBox.Location = new System.Drawing.Point(0, 13);
      this.IconBox.Name = "IconBox";
      this.IconBox.Size = new System.Drawing.Size(64, 64);
      this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.IconBox.TabIndex = 3;
      this.IconBox.TabStop = false;
      // 
      // Kill
      // 
      this.Kill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.Kill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.Kill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.Kill.BorderRadius = 0;
      this.Kill.ButtonText = "Kill VR";
      this.Kill.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Kill.DisabledColor = System.Drawing.Color.Gray;
      this.Kill.Iconcolor = System.Drawing.Color.Transparent;
      this.Kill.Iconimage = ((System.Drawing.Image)(resources.GetObject("Kill.Iconimage")));
      this.Kill.Iconimage_right = null;
      this.Kill.Iconimage_right_Selected = null;
      this.Kill.Iconimage_Selected = null;
      this.Kill.IconMarginLeft = 0;
      this.Kill.IconMarginRight = 0;
      this.Kill.IconRightVisible = true;
      this.Kill.IconRightZoom = 0D;
      this.Kill.IconVisible = true;
      this.Kill.IconZoom = 90D;
      this.Kill.IsTab = false;
      this.Kill.Location = new System.Drawing.Point(12, 95);
      this.Kill.Name = "Kill";
      this.Kill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
      this.Kill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
      this.Kill.OnHoverTextColor = System.Drawing.Color.White;
      this.Kill.selected = false;
      this.Kill.Size = new System.Drawing.Size(134, 48);
      this.Kill.TabIndex = 1;
      this.Kill.Text = "Kill VR";
      this.Kill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Kill.Textcolor = System.Drawing.Color.White;
      this.Kill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Kill.Click += new System.EventHandler(this.Kill_Click);
      // 
      // yeet
      // 
      this.yeet.Font = new System.Drawing.Font("Poppins Light", 10F);
      this.yeet.ForeColor = System.Drawing.Color.White;
      this.yeet.Location = new System.Drawing.Point(70, 45);
      this.yeet.Name = "yeet";
      this.yeet.Size = new System.Drawing.Size(343, 32);
      this.yeet.TabIndex = 4;
      this.yeet.Text = "Manage your VR Processes with ease";
      this.yeet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.yeet.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
      // 
      // ProcessCount
      // 
      this.ProcessCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
      this.ProcessCount.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ProcessCount.Font = new System.Drawing.Font("Poppins Light", 10F);
      this.ProcessCount.ForeColor = System.Drawing.Color.White;
      this.ProcessCount.Location = new System.Drawing.Point(0, 146);
      this.ProcessCount.Name = "ProcessCount";
      this.ProcessCount.Size = new System.Drawing.Size(413, 25);
      this.ProcessCount.TabIndex = 5;
      this.ProcessCount.Text = "VR Processes: COUNT";
      this.ProcessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // DragCount
      // 
      this.DragCount.Fixed = true;
      this.DragCount.Horizontal = true;
      this.DragCount.TargetControl = this.ProcessCount;
      this.DragCount.Vertical = true;
      // 
      // DragIcon
      // 
      this.DragIcon.Fixed = true;
      this.DragIcon.Horizontal = true;
      this.DragIcon.TargetControl = this.IconBox;
      this.DragIcon.Vertical = true;
      // 
      // DragTitle
      // 
      this.DragTitle.Fixed = true;
      this.DragTitle.Horizontal = true;
      this.DragTitle.TargetControl = this.Title;
      this.DragTitle.Vertical = true;
      // 
      // DragDescription
      // 
      this.DragDescription.Fixed = true;
      this.DragDescription.Horizontal = true;
      this.DragDescription.TargetControl = this.yeet;
      this.DragDescription.Vertical = true;
      // 
      // UpdateCount
      // 
      this.UpdateCount.Enabled = true;
      this.UpdateCount.Interval = 250;
      this.UpdateCount.Tick += new System.EventHandler(this.UpdateCount_Tick);
      // 
      // Overlay
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
      this.ClientSize = new System.Drawing.Size(413, 171);
      this.Controls.Add(this.ProcessCount);
      this.Controls.Add(this.yeet);
      this.Controls.Add(this.IconBox);
      this.Controls.Add(this.Exit);
      this.Controls.Add(this.Kill);
      this.Controls.Add(this.Title);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Overlay";
      this.Text = "VRManager";
      this.TopMost = true;
      this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
      this.Activated += new System.EventHandler(this.Overlay_Activated);
      this.Deactivate += new System.EventHandler(this.Overlay_Deactivate);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
      this.Enter += new System.EventHandler(this.Overlay_Enter);
      ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Bunifu.Framework.UI.BunifuElipse Round;
    private Bunifu.Framework.UI.BunifuDragControl DragWindow;
    private Bunifu.Framework.UI.BunifuFlatButton Exit;
    private Bunifu.Framework.UI.BunifuFlatButton Kill;
    private Bunifu.Framework.UI.BunifuCustomLabel Title;
    private System.Windows.Forms.PictureBox IconBox;
    private Bunifu.Framework.UI.BunifuCustomLabel yeet;
    private Bunifu.Framework.UI.BunifuCustomLabel ProcessCount;
    private Bunifu.Framework.UI.BunifuDragControl DragCount;
    private Bunifu.Framework.UI.BunifuDragControl DragIcon;
    private Bunifu.Framework.UI.BunifuDragControl DragTitle;
    private Bunifu.Framework.UI.BunifuDragControl DragDescription;
    private System.Windows.Forms.Timer UpdateCount;
  }
}

