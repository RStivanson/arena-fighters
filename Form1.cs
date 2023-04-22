// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Form1
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
  public class Form1 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;

    [DebuggerNonUserCode]
    public Form1() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Cursor = Cursors.Hand;
      Label label1_1 = this.Label1;
      Point point1 = new Point(309, 112);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(277, 52);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = componentResourceManager.GetString("Label1.Text");
      this.Label2.AutoSize = true;
      this.Label2.BackColor = Color.Transparent;
      this.Label2.Cursor = Cursors.Hand;
      Label label2_1 = this.Label2;
      point1 = new Point(361, 205);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(166, 52);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 1;
      this.Label2.Text = componentResourceManager.GetString("Label2.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) ArenaFighters.My.Resources.Resources.Untitled_1;
      size1 = new Size(619, 549);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Arena Fighters!";
      this.ResumeLayout(false);
      this.PerformLayout();
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

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Label2_Click);
        if (this._Label2 != null)
          this._Label2.Click -= eventHandler;
        this._Label2 = value;
        if (this._Label2 == null)
          return;
        this._Label2.Click += eventHandler;
      }
    }

    private void Label2_Click(object sender, EventArgs e)
    {
      About about = new About();
      MyProject.Forms.About.Show();
      int num = (int) about.ShowDialog((IWin32Window) this);
    }

    private void Label1_Click(object sender, EventArgs e)
    {
      this.Hide();
      MyProject.Forms.Outside.Show();
    }
  }
}
