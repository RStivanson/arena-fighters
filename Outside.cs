// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Outside
// Assembly: Arena Fighters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC6B005-E91F-4E91-B085-E39357C10E21
// Assembly location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.exe
// XML documentation location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.xml

using ArenaFighters.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ArenaFighters
{
  [DesignerGenerated]
  public class Outside : Form
  {
    private IContainer components;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("PictureBox2")]
    private PictureBox _PictureBox2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    private NotifyIcon ni;

    public Outside()
    {
      this.ni = new NotifyIcon();
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Outside));
      this.PictureBox1 = new PictureBox();
      this.PictureBox2 = new PictureBox();
      this.Label1 = new Label();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      this.SuspendLayout();
      this.PictureBox1.BackColor = Color.Transparent;
      this.PictureBox1.Cursor = Cursors.Hand;
      PictureBox pictureBox1_1 = this.PictureBox1;
      Point point1 = new Point(39, 180);
      Point point2 = point1;
      pictureBox1_1.Location = point2;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      Size size1 = new Size(157, 156);
      Size size2 = size1;
      pictureBox1_2.Size = size2;
      this.PictureBox1.TabIndex = 0;
      this.PictureBox1.TabStop = false;
      this.PictureBox2.BackColor = Color.Transparent;
      this.PictureBox2.Cursor = Cursors.Hand;
      PictureBox pictureBox2_1 = this.PictureBox2;
      point1 = new Point(322, 136);
      Point point3 = point1;
      pictureBox2_1.Location = point3;
      this.PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = this.PictureBox2;
      size1 = new Size(96, 200);
      Size size3 = size1;
      pictureBox2_2.Size = size3;
      this.PictureBox2.TabIndex = 1;
      this.PictureBox2.TabStop = false;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Cursor = Cursors.Hand;
      this.Label1.Font = new Font("28 Days Later", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(490, 9);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(48, 18);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Menu";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) ArenaFighters.My.Resources.Resources._33333;
      size1 = new Size(550, 405);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.PictureBox2);
      this.Controls.Add((Control) this.PictureBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Outside);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Outside);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
        if (this._PictureBox1 != null)
          this._PictureBox1.Click -= eventHandler;
        this._PictureBox1 = value;
        if (this._PictureBox1 == null)
          return;
        this._PictureBox1.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox2
    {
      [DebuggerNonUserCode] get => this._PictureBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PictureBox2_Click);
        if (this._PictureBox2 != null)
          this._PictureBox2.Click -= eventHandler;
        this._PictureBox2 = value;
        if (this._PictureBox2 == null)
          return;
        this._PictureBox2.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label1_Click);
        if (this._Label1 != null)
          this._Label1.Click -= eventHandler;
        this._Label1 = value;
        if (this._Label1 == null)
          return;
        this._Label1.Click += eventHandler;
      }
    }

    private void Label1_Click(object sender, EventArgs e)
    {
      Exit_Menu exitMenu = new Exit_Menu();
      MyProject.Forms.Arena.Close();
      int num = (int) exitMenu.ShowDialog((IWin32Window) this);
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Difficulty.Show();
      this.Hide();
      this.ShowInTaskbar = false;
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      int num = (int) new Market().ShowDialog((IWin32Window) this);
    }
  }
}
