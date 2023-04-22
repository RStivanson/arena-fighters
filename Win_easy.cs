// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Win_easy
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
  public class Win_easy : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    private Random rndGold;
    private Random rndExp;
    private int numberGold;
    private int numberExp;

    [DebuggerNonUserCode]
    public Win_easy()
    {
      this.Load += new EventHandler(this.Form3_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Win_easy));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Button1 = new Button();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.Yellow;
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(243, 55);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "You Won!";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(21, 132);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(59, 23);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Gold -";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(21, 155);
      Point point4 = point1;
      label3_1.Location = point4;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(62, 23);
      Size size4 = size1;
      label3_2.Size = size4;
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Exp. -";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Comic Sans MS", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(63, 105);
      Point point5 = point1;
      label4_1.Location = point5;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(168, 27);
      Size size5 = size1;
      label4_2.Size = size5;
      this.Label4.TabIndex = 3;
      this.Label4.Text = "You have gained;";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label5_1 = this.Label5;
      point1 = new Point(89, 132);
      Point point6 = point1;
      label5_1.Location = point6;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(30, 23);
      Size size6 = size1;
      label5_2.Size = size6;
      this.Label5.TabIndex = 4;
      this.Label5.Text = "--";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label6_1 = this.Label6;
      point1 = new Point(89, 155);
      Point point7 = point1;
      label6_1.Location = point7;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(30, 23);
      Size size7 = size1;
      label6_2.Size = size7;
      this.Label6.TabIndex = 5;
      this.Label6.Text = "--";
      this.Button1.ForeColor = SystemColors.ActiveCaptionText;
      Button button1_1 = this.Button1;
      point1 = new Point(182, 180);
      Point point8 = point1;
      button1_1.Location = point8;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(75, 23);
      Size size8 = size1;
      button1_2.Size = size8;
      this.Button1.TabIndex = 6;
      this.Button1.Text = "Ok";
      this.Button1.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(269, 214);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.ForeColor = SystemColors.ButtonHighlight;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Win_easy);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Win";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

    private void Form3_Load(object sender, EventArgs e)
    {
      this.rndGold = new Random();
      this.rndExp = new Random();
      if (MyProject.Forms.Difficulty.CheckBox1.Checked)
      {
        this.numberGold = this.rndGold.Next(10, 70);
        this.Label5.Text = this.numberGold.ToString();
        this.numberExp = this.rndExp.Next(10, 30);
        this.Label6.Text = this.numberExp.ToString();
      }
      else if (MyProject.Forms.Difficulty.CheckBox2.Checked)
      {
        this.numberGold = this.rndGold.Next(71, 120);
        this.Label5.Text = this.numberGold.ToString();
        this.numberExp = this.rndExp.Next(30, 50);
        this.Label6.Text = this.numberExp.ToString();
      }
      else
      {
        if (!MyProject.Forms.Difficulty.CheckBox3.Checked)
          return;
        this.numberGold = this.rndGold.Next(250, 500);
        this.Label5.Text = this.numberGold.ToString();
        this.rndExp = new Random();
        this.numberExp = this.rndExp.Next(50, 70);
        this.Label6.Text = this.numberExp.ToString();
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) + (double) this.numberGold);
      MyProject.Forms.Data.ExpData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.ExpData.ToolTipText) + (double) this.numberExp);
      MyProject.Forms.Outside.Show();
      MyProject.Forms.Outside.ShowInTaskbar = true;
      this.Close();
      MyProject.Forms.Arena.Close();
      MyProject.Forms.Difficulty.Close();
    }
  }
}
