// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Exit_Menu
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
  public class Exit_Menu : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;

    [DebuggerNonUserCode]
    public Exit_Menu() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Exit_Menu));
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.Button3 = new Button();
      this.SuspendLayout();
      this.Button1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = SystemColors.ActiveCaptionText;
      Button button1_1 = this.Button1;
      Point point1 = new Point(12, 12);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(166, 49);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Return to Game";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = SystemColors.ActiveCaptionText;
      Button button2_1 = this.Button2;
      point1 = new Point(12, 67);
      Point point3 = point1;
      button2_1.Location = point3;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(166, 49);
      Size size3 = size1;
      button2_2.Size = size3;
      this.Button2.TabIndex = 1;
      this.Button2.Text = "Main Menu";
      this.Button2.UseVisualStyleBackColor = true;
      this.Button3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Button3.ForeColor = SystemColors.ActiveCaptionText;
      Button button3_1 = this.Button3;
      point1 = new Point(14, 122);
      Point point4 = point1;
      button3_1.Location = point4;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(166, 49);
      Size size4 = size1;
      button3_2.Size = size4;
      this.Button3.TabIndex = 2;
      this.Button3.Text = "Exit";
      this.Button3.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(192, 186);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.ForeColor = SystemColors.Control;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Exit_Menu);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Menu";
      this.ResumeLayout(false);
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

    internal virtual Button Button3
    {
      [DebuggerNonUserCode] get => this._Button3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Outside.Close();
      this.Close();
      MyProject.Forms.Lose.Close();
      MyProject.Forms.Inventory.Close();
      MyProject.Forms.Win_easy.Close();
      MyProject.Forms.Data.Close();
      MyProject.Forms.Arena.Close();
      MyProject.Forms.Market.Close();
      MyProject.Forms.Form1.Show();
    }

    private void Button3_Click(object sender, EventArgs e) => MyProject.Forms.Form1.Close();

    private void Button1_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.Outside.Show();
    }
  }
}
