// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Lose
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
  public class Lose : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;

    [DebuggerNonUserCode]
    public Lose() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Lose));
      this.Label1 = new Label();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(236, 55);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "You Lost!";
      this.Button1.ForeColor = Color.Black;
      Button button1_1 = this.Button1;
      point1 = new Point(173, 67);
      Point point3 = point1;
      button1_1.Location = point3;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(75, 23);
      Size size3 = size1;
      button1_2.Size = size3;
      this.Button1.TabIndex = 1;
      this.Button1.Text = "Ok";
      this.Button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(258, 105);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Label1);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Lose);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Loser!";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

    private void Button1_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.Arena.Close();
      MyProject.Forms.Difficulty.Close();
      MyProject.Forms.Outside.ShowInTaskbar = true;
      MyProject.Forms.Outside.Show();
    }
  }
}
