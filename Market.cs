// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Market
// Assembly: Arena Fighters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC6B005-E91F-4E91-B085-E39357C10E21
// Assembly location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.exe
// XML documentation location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.xml

using ArenaFighters.My;
using Microsoft.VisualBasic;
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
  public class Market : Form
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
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("HP10")]
    private Button _HP10;
    [AccessedThroughProperty("EP100")]
    private Button _EP100;
    [AccessedThroughProperty("EP50")]
    private Button _EP50;
    [AccessedThroughProperty("EP10")]
    private Button _EP10;
    [AccessedThroughProperty("HP100")]
    private Button _HP100;
    [AccessedThroughProperty("HP50")]
    private Button _HP50;
    [AccessedThroughProperty("Nuke")]
    private Button _Nuke;
    [AccessedThroughProperty("Pokeball")]
    private Button _Pokeball;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Button9")]
    private Button _Button9;
    [AccessedThroughProperty("Button10")]
    private Button _Button10;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("Gold1")]
    private Label _Gold1;

    [DebuggerNonUserCode]
    public Market()
    {
      this.Load += new EventHandler(this.Market_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Market));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.Label12 = new Label();
      this.Label13 = new Label();
      this.Label14 = new Label();
      this.Label15 = new Label();
      this.HP10 = new Button();
      this.EP100 = new Button();
      this.EP50 = new Button();
      this.EP10 = new Button();
      this.HP100 = new Button();
      this.HP50 = new Button();
      this.Nuke = new Button();
      this.Pokeball = new Button();
      this.Label16 = new Label();
      this.Label17 = new Label();
      this.Button9 = new Button();
      this.Button10 = new Button();
      this.Label18 = new Label();
      this.Gold1 = new Label();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.BackColor = SystemColors.ActiveCaptionText;
      this.Label1.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.Control;
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 251);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(55, 23);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Nuke";
      this.Label2.AutoSize = true;
      this.Label2.BackColor = SystemColors.ActiveCaptionText;
      this.Label2.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = SystemColors.Control;
      Label label2_1 = this.Label2;
      point1 = new Point(12, 192);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(179, 23);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Energy Potion +100";
      this.Label3.AutoSize = true;
      this.Label3.BackColor = SystemColors.ActiveCaptionText;
      this.Label3.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.Control;
      Label label3_1 = this.Label3;
      point1 = new Point(12, 169);
      Point point4 = point1;
      label3_1.Location = point4;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(166, 23);
      Size size4 = size1;
      label3_2.Size = size4;
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Energy potion +50";
      this.Label4.AutoSize = true;
      this.Label4.BackColor = SystemColors.ActiveCaptionText;
      this.Label4.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.Control;
      Label label4_1 = this.Label4;
      point1 = new Point(12, 146);
      Point point5 = point1;
      label4_1.Location = point5;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(168, 23);
      Size size5 = size1;
      label4_2.Size = size5;
      this.Label4.TabIndex = 3;
      this.Label4.Text = "Energy Potion +25";
      this.Label5.AutoSize = true;
      this.Label5.BackColor = SystemColors.ActiveCaptionText;
      this.Label5.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.Control;
      Label label5_1 = this.Label5;
      point1 = new Point(12, 102);
      Point point6 = point1;
      label5_1.Location = point6;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(176, 23);
      Size size6 = size1;
      label5_2.Size = size6;
      this.Label5.TabIndex = 4;
      this.Label5.Text = "Health Potion +100";
      this.Label6.AutoSize = true;
      this.Label6.BackColor = SystemColors.ActiveCaptionText;
      this.Label6.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = SystemColors.Control;
      Label label6_1 = this.Label6;
      point1 = new Point(12, 79);
      Point point7 = point1;
      label6_1.Location = point7;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(165, 23);
      Size size7 = size1;
      label6_2.Size = size7;
      this.Label6.TabIndex = 5;
      this.Label6.Text = "Health Potion +50";
      this.Label7.AutoSize = true;
      this.Label7.BackColor = SystemColors.ActiveCaptionText;
      this.Label7.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label7.ForeColor = SystemColors.Control;
      Label label7_1 = this.Label7;
      point1 = new Point(12, 56);
      Point point8 = point1;
      label7_1.Location = point8;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(165, 23);
      Size size8 = size1;
      label7_2.Size = size8;
      this.Label7.TabIndex = 6;
      this.Label7.Text = "Health Potion +10";
      this.Label8.AutoSize = true;
      this.Label8.Font = new Font("Zombie-Noize", 36f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = SystemColors.ButtonFace;
      Label label8_1 = this.Label8;
      point1 = new Point(152, 9);
      Point point9 = point1;
      label8_1.Location = point9;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(140, 47);
      Size size9 = size1;
      label8_2.Size = size9;
      this.Label8.TabIndex = 7;
      this.Label8.Text = nameof (Market);
      this.Label9.AutoSize = true;
      this.Label9.BackColor = SystemColors.ActiveCaptionText;
      this.Label9.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = SystemColors.Control;
      Label label9_1 = this.Label9;
      point1 = new Point(205, 146);
      Point point10 = point1;
      label9_1.Location = point10;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(43, 23);
      Size size10 = size1;
      label9_2.Size = size10;
      this.Label9.TabIndex = 8;
      this.Label9.Text = "$20";
      this.Label10.AutoSize = true;
      this.Label10.BackColor = SystemColors.ActiveCaptionText;
      this.Label10.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = SystemColors.Control;
      Label label10_1 = this.Label10;
      point1 = new Point(205, 169);
      Point point11 = point1;
      label10_1.Location = point11;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(54, 23);
      Size size11 = size1;
      label10_2.Size = size11;
      this.Label10.TabIndex = 9;
      this.Label10.Text = "$100";
      this.Label11.AutoSize = true;
      this.Label11.BackColor = SystemColors.ActiveCaptionText;
      this.Label11.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = SystemColors.Control;
      Label label11_1 = this.Label11;
      point1 = new Point(205, 192);
      Point point12 = point1;
      label11_1.Location = point12;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(54, 23);
      Size size12 = size1;
      label11_2.Size = size12;
      this.Label11.TabIndex = 10;
      this.Label11.Text = "$200";
      this.Label12.AutoSize = true;
      this.Label12.BackColor = SystemColors.ActiveCaptionText;
      this.Label12.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = SystemColors.Control;
      Label label12_1 = this.Label12;
      point1 = new Point(205, 251);
      Point point13 = point1;
      label12_1.Location = point13;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(65, 23);
      Size size13 = size1;
      label12_2.Size = size13;
      this.Label12.TabIndex = 11;
      this.Label12.Text = "$2000";
      this.Label13.AutoSize = true;
      this.Label13.BackColor = SystemColors.ActiveCaptionText;
      this.Label13.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label13.ForeColor = SystemColors.Control;
      Label label13_1 = this.Label13;
      point1 = new Point(205, 102);
      Point point14 = point1;
      label13_1.Location = point14;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(54, 23);
      Size size14 = size1;
      label13_2.Size = size14;
      this.Label13.TabIndex = 12;
      this.Label13.Text = "$100";
      this.Label14.AutoSize = true;
      this.Label14.BackColor = SystemColors.ActiveCaptionText;
      this.Label14.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label14.ForeColor = SystemColors.Control;
      Label label14_1 = this.Label14;
      point1 = new Point(205, 79);
      Point point15 = point1;
      label14_1.Location = point15;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(43, 23);
      Size size15 = size1;
      label14_2.Size = size15;
      this.Label14.TabIndex = 13;
      this.Label14.Text = "$50";
      this.Label15.AutoSize = true;
      this.Label15.BackColor = SystemColors.ActiveCaptionText;
      this.Label15.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label15.ForeColor = SystemColors.Control;
      Label label15_1 = this.Label15;
      point1 = new Point(205, 56);
      Point point16 = point1;
      label15_1.Location = point16;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(43, 23);
      Size size16 = size1;
      label15_2.Size = size16;
      this.Label15.TabIndex = 14;
      this.Label15.Text = "$10";
      Button hp10_1 = this.HP10;
      point1 = new Point(272, 56);
      Point point17 = point1;
      hp10_1.Location = point17;
      this.HP10.Name = "HP10";
      Button hp10_2 = this.HP10;
      size1 = new Size(118, 25);
      Size size17 = size1;
      hp10_2.Size = size17;
      this.HP10.TabIndex = 15;
      this.HP10.Text = "Buy";
      this.HP10.UseVisualStyleBackColor = true;
      Button ep100_1 = this.EP100;
      point1 = new Point(272, 193);
      Point point18 = point1;
      ep100_1.Location = point18;
      this.EP100.Name = "EP100";
      Button ep100_2 = this.EP100;
      size1 = new Size(118, 25);
      Size size18 = size1;
      ep100_2.Size = size18;
      this.EP100.TabIndex = 16;
      this.EP100.Text = "Buy";
      this.EP100.UseVisualStyleBackColor = true;
      Button ep50_1 = this.EP50;
      point1 = new Point(272, 170);
      Point point19 = point1;
      ep50_1.Location = point19;
      this.EP50.Name = "EP50";
      Button ep50_2 = this.EP50;
      size1 = new Size(118, 25);
      Size size19 = size1;
      ep50_2.Size = size19;
      this.EP50.TabIndex = 17;
      this.EP50.Text = "Buy";
      this.EP50.UseVisualStyleBackColor = true;
      Button ep10_1 = this.EP10;
      point1 = new Point(272, 147);
      Point point20 = point1;
      ep10_1.Location = point20;
      this.EP10.Name = "EP10";
      Button ep10_2 = this.EP10;
      size1 = new Size(118, 25);
      Size size20 = size1;
      ep10_2.Size = size20;
      this.EP10.TabIndex = 18;
      this.EP10.Text = "Buy";
      this.EP10.UseVisualStyleBackColor = true;
      Button hp100_1 = this.HP100;
      point1 = new Point(272, 103);
      Point point21 = point1;
      hp100_1.Location = point21;
      this.HP100.Name = "HP100";
      Button hp100_2 = this.HP100;
      size1 = new Size(118, 25);
      Size size21 = size1;
      hp100_2.Size = size21;
      this.HP100.TabIndex = 19;
      this.HP100.Text = "Buy";
      this.HP100.UseVisualStyleBackColor = true;
      Button hp50_1 = this.HP50;
      point1 = new Point(272, 80);
      Point point22 = point1;
      hp50_1.Location = point22;
      this.HP50.Name = "HP50";
      Button hp50_2 = this.HP50;
      size1 = new Size(118, 25);
      Size size22 = size1;
      hp50_2.Size = size22;
      this.HP50.TabIndex = 20;
      this.HP50.Text = "Buy";
      this.HP50.UseVisualStyleBackColor = true;
      Button nuke1 = this.Nuke;
      point1 = new Point(272, 249);
      Point point23 = point1;
      nuke1.Location = point23;
      this.Nuke.Name = "Nuke";
      Button nuke2 = this.Nuke;
      size1 = new Size(118, 25);
      Size size23 = size1;
      nuke2.Size = size23;
      this.Nuke.TabIndex = 21;
      this.Nuke.Text = "Buy";
      this.Nuke.UseVisualStyleBackColor = true;
      Button pokeball1 = this.Pokeball;
      point1 = new Point(272, 283);
      Point point24 = point1;
      pokeball1.Location = point24;
      this.Pokeball.Name = "Pokeball";
      Button pokeball2 = this.Pokeball;
      size1 = new Size(118, 25);
      Size size24 = size1;
      pokeball2.Size = size24;
      this.Pokeball.TabIndex = 24;
      this.Pokeball.Text = "Buy";
      this.Pokeball.UseVisualStyleBackColor = true;
      this.Label16.AutoSize = true;
      this.Label16.BackColor = SystemColors.ActiveCaptionText;
      this.Label16.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label16.ForeColor = SystemColors.Control;
      Label label16_1 = this.Label16;
      point1 = new Point(205, 285);
      Point point25 = point1;
      label16_1.Location = point25;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(54, 23);
      Size size25 = size1;
      label16_2.Size = size25;
      this.Label16.TabIndex = 23;
      this.Label16.Text = "$500";
      this.Label17.AutoSize = true;
      this.Label17.BackColor = SystemColors.ActiveCaptionText;
      this.Label17.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label17.ForeColor = SystemColors.Control;
      Label label17_1 = this.Label17;
      point1 = new Point(12, 285);
      Point point26 = point1;
      label17_1.Location = point26;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(83, 23);
      Size size26 = size1;
      label17_2.Size = size26;
      this.Label17.TabIndex = 22;
      this.Label17.Text = "Pokeball";
      this.Button9.ForeColor = SystemColors.ActiveCaptionText;
      Button button9_1 = this.Button9;
      point1 = new Point(39, 334);
      Point point27 = point1;
      button9_1.Location = point27;
      this.Button9.Name = "Button9";
      Button button9_2 = this.Button9;
      size1 = new Size(73, 25);
      Size size27 = size1;
      button9_2.Size = size27;
      this.Button9.TabIndex = 67;
      this.Button9.Text = "Inventory";
      this.Button9.UseVisualStyleBackColor = true;
      this.Button10.ForeColor = SystemColors.ActiveCaptionText;
      Button button10_1 = this.Button10;
      point1 = new Point(118, 334);
      Point point28 = point1;
      button10_1.Location = point28;
      this.Button10.Name = "Button10";
      Button button10_2 = this.Button10;
      size1 = new Size(73, 25);
      Size size28 = size1;
      button10_2.Size = size28;
      this.Button10.TabIndex = 68;
      this.Button10.Text = "Ok";
      this.Button10.UseVisualStyleBackColor = true;
      this.Label18.AutoSize = true;
      this.Label18.BackColor = SystemColors.ActiveCaptionText;
      this.Label18.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label18.ForeColor = SystemColors.Control;
      Label label18_1 = this.Label18;
      point1 = new Point(205, 333);
      Point point29 = point1;
      label18_1.Location = point29;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(64, 23);
      Size size29 = size1;
      label18_2.Size = size29;
      this.Label18.TabIndex = 69;
      this.Label18.Text = "Gold -";
      this.Gold1.AutoSize = true;
      this.Gold1.BackColor = SystemColors.ActiveCaptionText;
      this.Gold1.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Gold1.ForeColor = SystemColors.Control;
      Label gold1_1 = this.Gold1;
      point1 = new Point(275, 333);
      Point point30 = point1;
      gold1_1.Location = point30;
      this.Gold1.Name = "Gold1";
      Label gold1_2 = this.Gold1;
      size1 = new Size(0, 23);
      Size size30 = size1;
      gold1_2.Size = size30;
      this.Gold1.TabIndex = 70;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(402, 371);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Gold1);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.Button10);
      this.Controls.Add((Control) this.Button9);
      this.Controls.Add((Control) this.Pokeball);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.Nuke);
      this.Controls.Add((Control) this.HP50);
      this.Controls.Add((Control) this.HP100);
      this.Controls.Add((Control) this.EP10);
      this.Controls.Add((Control) this.EP50);
      this.Controls.Add((Control) this.EP100);
      this.Controls.Add((Control) this.HP10);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.Label13);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Market);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Market);
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

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal virtual Label Label9
    {
      [DebuggerNonUserCode] get => this._Label9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal virtual Label Label11
    {
      [DebuggerNonUserCode] get => this._Label11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
    }

    internal virtual Label Label12
    {
      [DebuggerNonUserCode] get => this._Label12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
    }

    internal virtual Label Label13
    {
      [DebuggerNonUserCode] get => this._Label13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
    }

    internal virtual Label Label14
    {
      [DebuggerNonUserCode] get => this._Label14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
    }

    internal virtual Label Label15
    {
      [DebuggerNonUserCode] get => this._Label15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
    }

    internal virtual Button HP10
    {
      [DebuggerNonUserCode] get => this._HP10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._HP10 != null)
          this._HP10.Click -= eventHandler;
        this._HP10 = value;
        if (this._HP10 == null)
          return;
        this._HP10.Click += eventHandler;
      }
    }

    internal virtual Button EP100
    {
      [DebuggerNonUserCode] get => this._EP100;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._EP100 != null)
          this._EP100.Click -= eventHandler;
        this._EP100 = value;
        if (this._EP100 == null)
          return;
        this._EP100.Click += eventHandler;
      }
    }

    internal virtual Button EP50
    {
      [DebuggerNonUserCode] get => this._EP50;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._EP50 != null)
          this._EP50.Click -= eventHandler;
        this._EP50 = value;
        if (this._EP50 == null)
          return;
        this._EP50.Click += eventHandler;
      }
    }

    internal virtual Button EP10
    {
      [DebuggerNonUserCode] get => this._EP10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._EP10 != null)
          this._EP10.Click -= eventHandler;
        this._EP10 = value;
        if (this._EP10 == null)
          return;
        this._EP10.Click += eventHandler;
      }
    }

    internal virtual Button HP100
    {
      [DebuggerNonUserCode] get => this._HP100;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        if (this._HP100 != null)
          this._HP100.Click -= eventHandler;
        this._HP100 = value;
        if (this._HP100 == null)
          return;
        this._HP100.Click += eventHandler;
      }
    }

    internal virtual Button HP50
    {
      [DebuggerNonUserCode] get => this._HP50;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        if (this._HP50 != null)
          this._HP50.Click -= eventHandler;
        this._HP50 = value;
        if (this._HP50 == null)
          return;
        this._HP50.Click += eventHandler;
      }
    }

    internal virtual Button Nuke
    {
      [DebuggerNonUserCode] get => this._Nuke;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button7_Click);
        if (this._Nuke != null)
          this._Nuke.Click -= eventHandler;
        this._Nuke = value;
        if (this._Nuke == null)
          return;
        this._Nuke.Click += eventHandler;
      }
    }

    internal virtual Button Pokeball
    {
      [DebuggerNonUserCode] get => this._Pokeball;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button8_Click);
        if (this._Pokeball != null)
          this._Pokeball.Click -= eventHandler;
        this._Pokeball = value;
        if (this._Pokeball == null)
          return;
        this._Pokeball.Click += eventHandler;
      }
    }

    internal virtual Label Label16
    {
      [DebuggerNonUserCode] get => this._Label16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
    }

    internal virtual Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal virtual Button Button9
    {
      [DebuggerNonUserCode] get => this._Button9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button9_Click);
        if (this._Button9 != null)
          this._Button9.Click -= eventHandler;
        this._Button9 = value;
        if (this._Button9 == null)
          return;
        this._Button9.Click += eventHandler;
      }
    }

    internal virtual Button Button10
    {
      [DebuggerNonUserCode] get => this._Button10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button10_Click);
        if (this._Button10 != null)
          this._Button10.Click -= eventHandler;
        this._Button10 = value;
        if (this._Button10 == null)
          return;
        this._Button10.Click += eventHandler;
      }
    }

    internal virtual Label Label18
    {
      [DebuggerNonUserCode] get => this._Label18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
    }

    internal virtual Label Gold1
    {
      [DebuggerNonUserCode] get => this._Gold1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Gold1 = value;
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      int num = (int) new Inventory().ShowDialog((IWin32Window) this);
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Outside.Show();
      this.Close();
    }

    private void Market_Load(object sender, EventArgs e)
    {
      this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(0) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 50)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(51) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 250)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(251) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 500)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(501) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 1000)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(1001) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 2500)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(2501) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 5000)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(5001) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 10000)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(10001) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 20000)
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      else if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(20001) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) < 50000)
      {
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      }
      else
      {
        if (-(Operators.CompareString(MyProject.Forms.Data.ExpData.ToolTipText, Conversions.ToString(50001) + MyProject.Forms.Data.ExpData.ToolTipText, false) > 0 ? 1 : 0) >= 100000)
          return;
        MyProject.Forms.Data.LevelData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.LevelData.ToolTipText) + 1.0);
      }
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 500.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.PokeData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.PokeData.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 500.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 2000.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.NukeData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.NukeData.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 2000.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 100.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.HP100Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP100Data.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 100.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 50.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.HP50Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP50Data.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 50.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 10.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.HP10Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP10Data.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 10.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 20.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.EP10Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP10Data.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 20.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 100.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.EP50data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP50data.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 100.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 200.0 <= -1.0)
      {
        int num = (int) Interaction.MsgBox((object) "You do not have enough gold to buy that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
      else
      {
        MyProject.Forms.Data.EP100Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP100Data.ToolTipText) + 1.0);
        MyProject.Forms.Data.GoldData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.GoldData.ToolTipText) - 200.0);
        this.Gold1.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      }
    }
  }
}
