// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Difficulty
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
  public class Difficulty : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;
    [AccessedThroughProperty("CheckBox2")]
    private CheckBox _CheckBox2;
    [AccessedThroughProperty("CheckBox3")]
    private CheckBox _CheckBox3;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("ni")]
    private NotifyIcon _ni;

    public Difficulty()
    {
      this.Load += new EventHandler(this.Difficulty_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Difficulty));
      this.Button1 = new Button();
      this.Label1 = new Label();
      this.CheckBox1 = new CheckBox();
      this.CheckBox2 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.Button2 = new Button();
      this.SuspendLayout();
      this.Button1.ForeColor = SystemColors.ActiveCaptionText;
      Button button1_1 = this.Button1;
      Point point1 = new Point(117, 116);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(75, 23);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Ok";
      this.Button1.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Raavi", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      point1 = new Point(54, 9);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(84, 31);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 1;
      this.Label1.Text = nameof (Difficulty);
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.Font = new Font("Perpetua Titling MT", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      CheckBox checkBox1_1 = this.CheckBox1;
      point1 = new Point(12, 43);
      Point point4 = point1;
      checkBox1_1.Location = point4;
      this.CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = this.CheckBox1;
      size1 = new Size(57, 19);
      Size size4 = size1;
      checkBox1_2.Size = size4;
      this.CheckBox1.TabIndex = 2;
      this.CheckBox1.Text = "Easy";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.CheckBox2.AutoSize = true;
      this.CheckBox2.Font = new Font("Perpetua Titling MT", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      CheckBox checkBox2_1 = this.CheckBox2;
      point1 = new Point(12, 68);
      Point point5 = point1;
      checkBox2_1.Location = point5;
      this.CheckBox2.Name = "CheckBox2";
      CheckBox checkBox2_2 = this.CheckBox2;
      size1 = new Size(64, 19);
      Size size5 = size1;
      checkBox2_2.Size = size5;
      this.CheckBox2.TabIndex = 3;
      this.CheckBox2.Text = "Hard";
      this.CheckBox2.UseVisualStyleBackColor = true;
      this.CheckBox3.AutoSize = true;
      this.CheckBox3.Font = new Font("Perpetua Titling MT", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      CheckBox checkBox3_1 = this.CheckBox3;
      point1 = new Point(12, 93);
      Point point6 = point1;
      checkBox3_1.Location = point6;
      this.CheckBox3.Name = "CheckBox3";
      CheckBox checkBox3_2 = this.CheckBox3;
      size1 = new Size(96, 19);
      Size size6 = size1;
      checkBox3_2.Size = size6;
      this.CheckBox3.TabIndex = 4;
      this.CheckBox3.Text = "Impossible";
      this.CheckBox3.UseVisualStyleBackColor = true;
      this.Button2.ForeColor = SystemColors.ActiveCaptionText;
      Button button2_1 = this.Button2;
      point1 = new Point(36, 116);
      Point point7 = point1;
      button2_1.Location = point7;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(75, 23);
      Size size7 = size1;
      button2_2.Size = size7;
      this.Button2.TabIndex = 5;
      this.Button2.Text = "Cancel";
      this.Button2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(204, 151);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.CheckBox3);
      this.Controls.Add((Control) this.CheckBox2);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button1);
      this.ForeColor = SystemColors.ButtonHighlight;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Difficulty);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Difficulty);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get => this._Button1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual CheckBox CheckBox1
    {
      [DebuggerNonUserCode] get => this._CheckBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
        if (this._CheckBox1 != null)
          this._CheckBox1.CheckedChanged -= eventHandler;
        this._CheckBox1 = value;
        if (this._CheckBox1 == null)
          return;
        this._CheckBox1.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox2
    {
      [DebuggerNonUserCode] get => this._CheckBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox2_CheckedChanged);
        if (this._CheckBox2 != null)
          this._CheckBox2.CheckedChanged -= eventHandler;
        this._CheckBox2 = value;
        if (this._CheckBox2 == null)
          return;
        this._CheckBox2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox3
    {
      [DebuggerNonUserCode] get => this._CheckBox3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox3_CheckedChanged);
        if (this._CheckBox3 != null)
          this._CheckBox3.CheckedChanged -= eventHandler;
        this._CheckBox3 = value;
        if (this._CheckBox3 == null)
          return;
        this._CheckBox3.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button Button2
    {
      [DebuggerNonUserCode] get => this._Button2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual NotifyIcon ni
    {
      [DebuggerNonUserCode] get => this._ni;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ni = value;
    }

    private void Difficulty_Load(object sender, EventArgs e)
    {
      this.CheckBox1.Checked = false;
      this.CheckBox1.Checked = false;
      this.CheckBox1.Checked = false;
      this.Button1.Enabled = false;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.Arena.ShowDialog((IWin32Window) this);
    }

    private void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.CheckBox3.Checked)
        return;
      this.CheckBox2.Checked = false;
      this.CheckBox1.Checked = false;
      this.Button1.Enabled = true;
    }

    private void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.CheckBox2.Checked)
        return;
      this.CheckBox3.Checked = false;
      this.CheckBox1.Checked = false;
      this.Button1.Enabled = true;
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.CheckBox1.Checked)
        return;
      this.CheckBox2.Checked = false;
      this.CheckBox3.Checked = false;
      this.Button1.Enabled = true;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.Outside.Show();
    }
  }
}
