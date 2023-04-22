// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Inventory
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
  public class Inventory : Form
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
    [AccessedThroughProperty("nukeamount")]
    private Label _nukeamount;
    [AccessedThroughProperty("HP100amount")]
    private Label _HP100amount;
    [AccessedThroughProperty("EP100amount")]
    private Label _EP100amount;
    [AccessedThroughProperty("HP50amount")]
    private Label _HP50amount;
    [AccessedThroughProperty("EP50amount")]
    private Label _EP50amount;
    [AccessedThroughProperty("HP10amount")]
    private Label _HP10amount;
    [AccessedThroughProperty("EP10amount")]
    private Label _EP10amount;
    [AccessedThroughProperty("Levelnumber")]
    private Label _Levelnumber;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Goldamount")]
    private Label _Goldamount;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("pokeamount")]
    private Label _pokeamount;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    [DebuggerNonUserCode]
    public Inventory()
    {
      this.Load += new EventHandler(this.Inventory_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Inventory));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.nukeamount = new Label();
      this.HP100amount = new Label();
      this.EP100amount = new Label();
      this.HP50amount = new Label();
      this.EP50amount = new Label();
      this.HP10amount = new Label();
      this.EP10amount = new Label();
      this.Levelnumber = new Label();
      this.Label7 = new Label();
      this.Goldamount = new Label();
      this.Label15 = new Label();
      this.pokeamount = new Label();
      this.Label17 = new Label();
      this.Label18 = new Label();
      this.Label19 = new Label();
      this.Label20 = new Label();
      this.Label21 = new Label();
      this.Label22 = new Label();
      this.Label23 = new Label();
      this.Label5 = new Label();
      this.Label6 = new Label();
      this.SuspendLayout();
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Comic Sans MS", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label1_1 = this.Label1;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      label1_1.Location = point2;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      Size size1 = new Size(239, 49);
      Size size2 = size1;
      label1_2.Size = size2;
      this.Label1.TabIndex = 0;
      this.Label1.Text = "INVENTORY";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(146, 58);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(105, 20);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Energy Potions";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label3_1 = this.Label3;
      point1 = new Point(17, 58);
      Point point4 = point1;
      label3_1.Location = point4;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(103, 20);
      Size size4 = size1;
      label3_2.Size = size4;
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Health Potions";
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label4_1 = this.Label4;
      point1 = new Point(17, 149);
      Point point5 = point1;
      label4_1.Location = point5;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(50, 20);
      Size size5 = size1;
      label4_2.Size = size5;
      this.Label4.TabIndex = 4;
      this.Label4.Text = "Nukes";
      this.nukeamount.AutoSize = true;
      this.nukeamount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label nukeamount1 = this.nukeamount;
      point1 = new Point(73, 149);
      Point point6 = point1;
      nukeamount1.Location = point6;
      this.nukeamount.Name = "nukeamount";
      Label nukeamount2 = this.nukeamount;
      size1 = new Size(18, 20);
      Size size6 = size1;
      nukeamount2.Size = size6;
      this.nukeamount.TabIndex = 6;
      this.nukeamount.Text = "0";
      this.HP100amount.AutoSize = true;
      this.HP100amount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label hp100amount1 = this.HP100amount;
      point1 = new Point(59, 118);
      Point point7 = point1;
      hp100amount1.Location = point7;
      this.HP100amount.Name = "HP100amount";
      Label hp100amount2 = this.HP100amount;
      size1 = new Size(18, 20);
      Size size7 = size1;
      hp100amount2.Size = size7;
      this.HP100amount.TabIndex = 8;
      this.HP100amount.Text = "0";
      this.EP100amount.AutoSize = true;
      this.EP100amount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label ep100amount1 = this.EP100amount;
      point1 = new Point(188, 118);
      Point point8 = point1;
      ep100amount1.Location = point8;
      this.EP100amount.Name = "EP100amount";
      Label ep100amount2 = this.EP100amount;
      size1 = new Size(18, 20);
      Size size8 = size1;
      ep100amount2.Size = size8;
      this.EP100amount.TabIndex = 7;
      this.EP100amount.Text = "0";
      this.HP50amount.AutoSize = true;
      this.HP50amount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label hp50amount1 = this.HP50amount;
      point1 = new Point(59, 98);
      Point point9 = point1;
      hp50amount1.Location = point9;
      this.HP50amount.Name = "HP50amount";
      Label hp50amount2 = this.HP50amount;
      size1 = new Size(18, 20);
      Size size9 = size1;
      hp50amount2.Size = size9;
      this.HP50amount.TabIndex = 10;
      this.HP50amount.Text = "0";
      this.EP50amount.AutoSize = true;
      this.EP50amount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label ep50amount1 = this.EP50amount;
      point1 = new Point(188, 98);
      Point point10 = point1;
      ep50amount1.Location = point10;
      this.EP50amount.Name = "EP50amount";
      Label ep50amount2 = this.EP50amount;
      size1 = new Size(18, 20);
      Size size10 = size1;
      ep50amount2.Size = size10;
      this.EP50amount.TabIndex = 9;
      this.EP50amount.Text = "0";
      this.HP10amount.AutoSize = true;
      this.HP10amount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label hp10amount1 = this.HP10amount;
      point1 = new Point(59, 78);
      Point point11 = point1;
      hp10amount1.Location = point11;
      this.HP10amount.Name = "HP10amount";
      Label hp10amount2 = this.HP10amount;
      size1 = new Size(15, 20);
      Size size11 = size1;
      hp10amount2.Size = size11;
      this.HP10amount.TabIndex = 12;
      this.HP10amount.Text = "1";
      this.EP10amount.AutoSize = true;
      this.EP10amount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label ep10amount1 = this.EP10amount;
      point1 = new Point(188, 78);
      Point point12 = point1;
      ep10amount1.Location = point12;
      this.EP10amount.Name = "EP10amount";
      Label ep10amount2 = this.EP10amount;
      size1 = new Size(15, 20);
      Size size12 = size1;
      ep10amount2.Size = size12;
      this.EP10amount.TabIndex = 11;
      this.EP10amount.Text = "1";
      this.Levelnumber.AutoSize = true;
      this.Levelnumber.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label levelnumber1 = this.Levelnumber;
      point1 = new Point(202, 189);
      Point point13 = point1;
      levelnumber1.Location = point13;
      this.Levelnumber.Name = "Levelnumber";
      Label levelnumber2 = this.Levelnumber;
      size1 = new Size(15, 20);
      Size size13 = size1;
      levelnumber2.Size = size13;
      this.Levelnumber.TabIndex = 14;
      this.Levelnumber.Text = "1";
      this.Label7.AutoSize = true;
      this.Label7.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label7_1 = this.Label7;
      point1 = new Point(146, 189);
      Point point14 = point1;
      label7_1.Location = point14;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(33, 20);
      Size size14 = size1;
      label7_2.Size = size14;
      this.Label7.TabIndex = 13;
      this.Label7.Text = "Exp.";
      this.Goldamount.AutoSize = true;
      this.Goldamount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label goldamount1 = this.Goldamount;
      point1 = new Point(202, 149);
      Point point15 = point1;
      goldamount1.Location = point15;
      this.Goldamount.Name = "Goldamount";
      Label goldamount2 = this.Goldamount;
      size1 = new Size(26, 20);
      Size size15 = size1;
      goldamount2.Size = size15;
      this.Goldamount.TabIndex = 16;
      this.Goldamount.Text = "20";
      this.Label15.AutoSize = true;
      this.Label15.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label15_1 = this.Label15;
      point1 = new Point(146, 149);
      Point point16 = point1;
      label15_1.Location = point16;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(38, 20);
      Size size16 = size1;
      label15_2.Size = size16;
      this.Label15.TabIndex = 15;
      this.Label15.Text = "Gold";
      this.pokeamount.AutoSize = true;
      this.pokeamount.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label pokeamount1 = this.pokeamount;
      point1 = new Point(96, 169);
      Point point17 = point1;
      pokeamount1.Location = point17;
      this.pokeamount.Name = "pokeamount";
      Label pokeamount2 = this.pokeamount;
      size1 = new Size(18, 20);
      Size size17 = size1;
      pokeamount2.Size = size17;
      this.pokeamount.TabIndex = 18;
      this.pokeamount.Text = "0";
      this.Label17.AutoSize = true;
      this.Label17.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label17_1 = this.Label17;
      point1 = new Point(17, 169);
      Point point18 = point1;
      label17_1.Location = point18;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(73, 20);
      Size size18 = size1;
      label17_2.Size = size18;
      this.Label17.TabIndex = 17;
      this.Label17.Text = "Pokeballs";
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label18_1 = this.Label18;
      point1 = new Point(17, 78);
      Point point19 = point1;
      label18_1.Location = point19;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(33, 20);
      Size size19 = size1;
      label18_2.Size = size19;
      this.Label18.TabIndex = 24;
      this.Label18.Text = "+10";
      this.Label19.AutoSize = true;
      this.Label19.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label19_1 = this.Label19;
      point1 = new Point(146, 78);
      Point point20 = point1;
      label19_1.Location = point20;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(35, 20);
      Size size20 = size1;
      label19_2.Size = size20;
      this.Label19.TabIndex = 23;
      this.Label19.Text = "+25";
      this.Label20.AutoSize = true;
      this.Label20.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label20_1 = this.Label20;
      point1 = new Point(17, 98);
      Point point21 = point1;
      label20_1.Location = point21;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(36, 20);
      Size size21 = size1;
      label20_2.Size = size21;
      this.Label20.TabIndex = 22;
      this.Label20.Text = "+50";
      this.Label21.AutoSize = true;
      this.Label21.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label21_1 = this.Label21;
      point1 = new Point(146, 98);
      Point point22 = point1;
      label21_1.Location = point22;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(36, 20);
      Size size22 = size1;
      label21_2.Size = size22;
      this.Label21.TabIndex = 21;
      this.Label21.Text = "+50";
      this.Label22.AutoSize = true;
      this.Label22.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label22_1 = this.Label22;
      point1 = new Point(17, 118);
      Point point23 = point1;
      label22_1.Location = point23;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(42, 20);
      Size size23 = size1;
      label22_2.Size = size23;
      this.Label22.TabIndex = 20;
      this.Label22.Text = "+100";
      this.Label23.AutoSize = true;
      this.Label23.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label23_1 = this.Label23;
      point1 = new Point(146, 118);
      Point point24 = point1;
      label23_1.Location = point24;
      this.Label23.Name = "Label23";
      Label label23_2 = this.Label23;
      size1 = new Size(42, 20);
      Size size24 = size1;
      label23_2.Size = size24;
      this.Label23.TabIndex = 19;
      this.Label23.Text = "+100";
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label5_1 = this.Label5;
      point1 = new Point(146, 169);
      Point point25 = point1;
      label5_1.Location = point25;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(43, 20);
      Size size25 = size1;
      label5_2.Size = size25;
      this.Label5.TabIndex = 26;
      this.Label5.Text = "Level";
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label label6_1 = this.Label6;
      point1 = new Point(202, 169);
      Point point26 = point1;
      label6_1.Location = point26;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(15, 20);
      Size size26 = size1;
      label6_2.Size = size26;
      this.Label6.TabIndex = 25;
      this.Label6.Text = "1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      size1 = new Size(261, 214);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label18);
      this.Controls.Add((Control) this.Label19);
      this.Controls.Add((Control) this.Label20);
      this.Controls.Add((Control) this.Label21);
      this.Controls.Add((Control) this.Label22);
      this.Controls.Add((Control) this.Label23);
      this.Controls.Add((Control) this.pokeamount);
      this.Controls.Add((Control) this.Label17);
      this.Controls.Add((Control) this.Goldamount);
      this.Controls.Add((Control) this.Label15);
      this.Controls.Add((Control) this.Levelnumber);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.HP10amount);
      this.Controls.Add((Control) this.EP10amount);
      this.Controls.Add((Control) this.HP50amount);
      this.Controls.Add((Control) this.EP50amount);
      this.Controls.Add((Control) this.HP100amount);
      this.Controls.Add((Control) this.EP100amount);
      this.Controls.Add((Control) this.nukeamount);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.ForeColor = SystemColors.ButtonFace;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Inventory);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Inventory);
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

    internal virtual Label nukeamount
    {
      [DebuggerNonUserCode] get => this._nukeamount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._nukeamount = value;
    }

    internal virtual Label HP100amount
    {
      [DebuggerNonUserCode] get => this._HP100amount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP100amount = value;
    }

    internal virtual Label EP100amount
    {
      [DebuggerNonUserCode] get => this._EP100amount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP100amount = value;
    }

    internal virtual Label HP50amount
    {
      [DebuggerNonUserCode] get => this._HP50amount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP50amount = value;
    }

    internal virtual Label EP50amount
    {
      [DebuggerNonUserCode] get => this._EP50amount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP50amount = value;
    }

    internal virtual Label HP10amount
    {
      [DebuggerNonUserCode] get => this._HP10amount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP10amount = value;
    }

    internal virtual Label EP10amount
    {
      [DebuggerNonUserCode] get => this._EP10amount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP10amount = value;
    }

    internal virtual Label Levelnumber
    {
      [DebuggerNonUserCode] get => this._Levelnumber;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Levelnumber = value;
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Label Goldamount
    {
      [DebuggerNonUserCode] get => this._Goldamount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Goldamount = value;
    }

    internal virtual Label Label15
    {
      [DebuggerNonUserCode] get => this._Label15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
    }

    internal virtual Label pokeamount
    {
      [DebuggerNonUserCode] get => this._pokeamount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pokeamount = value;
    }

    internal virtual Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal virtual Label Label18
    {
      [DebuggerNonUserCode] get => this._Label18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
    }

    internal virtual Label Label19
    {
      [DebuggerNonUserCode] get => this._Label19;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
    }

    internal virtual Label Label20
    {
      [DebuggerNonUserCode] get => this._Label20;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
    }

    internal virtual Label Label21
    {
      [DebuggerNonUserCode] get => this._Label21;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
    }

    internal virtual Label Label22
    {
      [DebuggerNonUserCode] get => this._Label22;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
    }

    internal virtual Label Label23
    {
      [DebuggerNonUserCode] get => this._Label23;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
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

    private void Inventory_Load(object sender, EventArgs e)
    {
      this.HP10amount.Text = "x" + MyProject.Forms.Data.HP10Data.ToolTipText;
      this.HP50amount.Text = "x" + MyProject.Forms.Data.HP50Data.ToolTipText;
      this.HP100amount.Text = "x" + MyProject.Forms.Data.HP100Data.ToolTipText;
      this.EP10amount.Text = "x" + MyProject.Forms.Data.EP10Data.ToolTipText;
      this.EP50amount.Text = "x" + MyProject.Forms.Data.EP50data.ToolTipText;
      this.EP100amount.Text = "x" + MyProject.Forms.Data.EP100Data.ToolTipText;
      this.nukeamount.Text = "x" + MyProject.Forms.Data.NukeData.ToolTipText;
      this.pokeamount.Text = "x" + MyProject.Forms.Data.PokeData.ToolTipText;
      this.Goldamount.Text = MyProject.Forms.Data.GoldData.ToolTipText;
      this.Levelnumber.Text = MyProject.Forms.Data.ExpData.ToolTipText;
      this.Label6.Text = MyProject.Forms.Data.LevelData.ToolTipText;
    }
  }
}
