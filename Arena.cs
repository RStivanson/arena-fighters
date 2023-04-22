// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Arena
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
  public class Arena : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Stick_Left_Kick")]
    private PictureBox _Stick_Left_Kick;
    [AccessedThroughProperty("Stick_left_Superpunch")]
    private PictureBox _Stick_left_Superpunch;
    [AccessedThroughProperty("Stick_left_Stance")]
    private PictureBox _Stick_left_Stance;
    [AccessedThroughProperty("Stick_Nuke")]
    private PictureBox _Stick_Nuke;
    [AccessedThroughProperty("Stick_left_Fireball")]
    private PictureBox _Stick_left_Fireball;
    [AccessedThroughProperty("Stick_Right_Kick")]
    private PictureBox _Stick_Right_Kick;
    [AccessedThroughProperty("Stick_right_SuperPunch")]
    private PictureBox _Stick_right_SuperPunch;
    [AccessedThroughProperty("Stick_Right_Stance")]
    private PictureBox _Stick_Right_Stance;
    [AccessedThroughProperty("Stick_Right_SuperKick")]
    private PictureBox _Stick_Right_SuperKick;
    [AccessedThroughProperty("Stick_Right_FireBall")]
    private PictureBox _Stick_Right_FireBall;
    [AccessedThroughProperty("Stick_left_Superkick")]
    private PictureBox _Stick_left_Superkick;
    [AccessedThroughProperty("PictureBox13")]
    private PictureBox _PictureBox13;
    [AccessedThroughProperty("PictureBox14")]
    private PictureBox _PictureBox14;
    [AccessedThroughProperty("PictureBox15")]
    private PictureBox _PictureBox15;
    [AccessedThroughProperty("PictureBox16")]
    private PictureBox _PictureBox16;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("FireBall")]
    private Button _FireBall;
    [AccessedThroughProperty("Kick")]
    private Button _Kick;
    [AccessedThroughProperty("SuperKick")]
    private Button _SuperKick;
    [AccessedThroughProperty("Punch")]
    private Button _Punch;
    [AccessedThroughProperty("Nuke")]
    private Button _Nuke;
    [AccessedThroughProperty("SuperPunch")]
    private Button _SuperPunch;
    [AccessedThroughProperty("Stick_Left_Punch")]
    private PictureBox _Stick_Left_Punch;
    [AccessedThroughProperty("Stick_Right_Punch")]
    private PictureBox _Stick_Right_Punch;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Energy1")]
    private ProgressBar _Energy1;
    [AccessedThroughProperty("Health2")]
    private ProgressBar _Health2;
    [AccessedThroughProperty("Energy2")]
    private ProgressBar _Energy2;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Health10")]
    private Label _Health10;
    [AccessedThroughProperty("Health50")]
    private Label _Health50;
    [AccessedThroughProperty("Health100")]
    private Label _Health100;
    [AccessedThroughProperty("Energy10")]
    private Label _Energy10;
    [AccessedThroughProperty("Energy50")]
    private Label _Energy50;
    [AccessedThroughProperty("Energy100")]
    private Label _Energy100;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    [AccessedThroughProperty("Button5")]
    private Button _Button5;
    [AccessedThroughProperty("Button6")]
    private Button _Button6;
    [AccessedThroughProperty("Button7")]
    private Button _Button7;
    [AccessedThroughProperty("Button8")]
    private Button _Button8;
    [AccessedThroughProperty("Button10")]
    private Button _Button10;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("NukeAmount")]
    private Label _NukeAmount;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Poke")]
    private Label _Poke;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Op_Attack")]
    private Timer _Op_Attack;
    [AccessedThroughProperty("Health1")]
    private ProgressBar _Health1;
    [AccessedThroughProperty("HP_checker")]
    private Timer _HP_checker;
    private Random rnd;
    private int number;
    private int number1;
    private int number2;
    private Random pokeball_catch;
    private int Pokeball_caught;

    [DebuggerNonUserCode]
    public Arena()
    {
      this.Load += new EventHandler(this.Arena_Load);
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Arena));
      this.Button1 = new Button();
      this.FireBall = new Button();
      this.Kick = new Button();
      this.SuperKick = new Button();
      this.Punch = new Button();
      this.Nuke = new Button();
      this.SuperPunch = new Button();
      this.Button2 = new Button();
      this.Label1 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.Energy1 = new ProgressBar();
      this.Health2 = new ProgressBar();
      this.Energy2 = new ProgressBar();
      this.Health1 = new ProgressBar();
      this.Label2 = new Label();
      this.Label6 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label10 = new Label();
      this.Label7 = new Label();
      this.Label11 = new Label();
      this.Label12 = new Label();
      this.Health10 = new Label();
      this.Health50 = new Label();
      this.Health100 = new Label();
      this.Energy10 = new Label();
      this.Energy50 = new Label();
      this.Energy100 = new Label();
      this.Button3 = new Button();
      this.Button4 = new Button();
      this.Button5 = new Button();
      this.Button6 = new Button();
      this.Button7 = new Button();
      this.Button8 = new Button();
      this.Button10 = new Button();
      this.NukeAmount = new Label();
      this.Label14 = new Label();
      this.Poke = new Label();
      this.Label16 = new Label();
      this.PictureBox1 = new PictureBox();
      this.Stick_Right_Punch = new PictureBox();
      this.Stick_Left_Punch = new PictureBox();
      this.PictureBox16 = new PictureBox();
      this.PictureBox15 = new PictureBox();
      this.PictureBox14 = new PictureBox();
      this.PictureBox13 = new PictureBox();
      this.Stick_left_Superkick = new PictureBox();
      this.Stick_Right_FireBall = new PictureBox();
      this.Stick_Right_SuperKick = new PictureBox();
      this.Stick_Right_Stance = new PictureBox();
      this.Stick_right_SuperPunch = new PictureBox();
      this.Stick_Right_Kick = new PictureBox();
      this.Stick_left_Fireball = new PictureBox();
      this.Stick_Nuke = new PictureBox();
      this.Stick_left_Stance = new PictureBox();
      this.Stick_left_Superpunch = new PictureBox();
      this.Stick_Left_Kick = new PictureBox();
      this.Op_Attack = new Timer(this.components);
      this.HP_checker = new Timer(this.components);
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      ((ISupportInitialize) this.Stick_Right_Punch).BeginInit();
      ((ISupportInitialize) this.Stick_Left_Punch).BeginInit();
      ((ISupportInitialize) this.PictureBox16).BeginInit();
      ((ISupportInitialize) this.PictureBox15).BeginInit();
      ((ISupportInitialize) this.PictureBox14).BeginInit();
      ((ISupportInitialize) this.PictureBox13).BeginInit();
      ((ISupportInitialize) this.Stick_left_Superkick).BeginInit();
      ((ISupportInitialize) this.Stick_Right_FireBall).BeginInit();
      ((ISupportInitialize) this.Stick_Right_SuperKick).BeginInit();
      ((ISupportInitialize) this.Stick_Right_Stance).BeginInit();
      ((ISupportInitialize) this.Stick_right_SuperPunch).BeginInit();
      ((ISupportInitialize) this.Stick_Right_Kick).BeginInit();
      ((ISupportInitialize) this.Stick_left_Fireball).BeginInit();
      ((ISupportInitialize) this.Stick_Nuke).BeginInit();
      ((ISupportInitialize) this.Stick_left_Stance).BeginInit();
      ((ISupportInitialize) this.Stick_left_Superpunch).BeginInit();
      ((ISupportInitialize) this.Stick_Left_Kick).BeginInit();
      this.SuspendLayout();
      this.Button1.ForeColor = SystemColors.ActiveCaptionText;
      Button button1_1 = this.Button1;
      Point point1 = new Point(570, 22);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(104, 33);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 16;
      this.Button1.Text = "Main Menu";
      this.Button1.UseVisualStyleBackColor = true;
      this.FireBall.ForeColor = SystemColors.ActiveCaptionText;
      Button fireBall1 = this.FireBall;
      point1 = new Point(119, 416);
      Point point3 = point1;
      fireBall1.Location = point3;
      this.FireBall.Name = "FireBall";
      Button fireBall2 = this.FireBall;
      size1 = new Size(85, 40);
      Size size3 = size1;
      fireBall2.Size = size3;
      this.FireBall.TabIndex = 19;
      this.FireBall.Text = "  Fire Ball    \r\n-15 Energy";
      this.FireBall.UseVisualStyleBackColor = true;
      this.Kick.ForeColor = SystemColors.ActiveCaptionText;
      Button kick1 = this.Kick;
      point1 = new Point(119, 364);
      Point point4 = point1;
      kick1.Location = point4;
      this.Kick.Name = "Kick";
      Button kick2 = this.Kick;
      size1 = new Size(85, 40);
      Size size4 = size1;
      kick2.Size = size4;
      this.Kick.TabIndex = 20;
      this.Kick.Text = "Kick\r\n-2 Energy";
      this.Kick.UseVisualStyleBackColor = true;
      this.SuperKick.ForeColor = SystemColors.ActiveCaptionText;
      Button superKick1 = this.SuperKick;
      point1 = new Point(12, 416);
      Point point5 = point1;
      superKick1.Location = point5;
      this.SuperKick.Name = "SuperKick";
      Button superKick2 = this.SuperKick;
      size1 = new Size(85, 40);
      Size size5 = size1;
      superKick2.Size = size5;
      this.SuperKick.TabIndex = 21;
      this.SuperKick.Text = "Super Kick\r\n-10 Energy";
      this.SuperKick.UseVisualStyleBackColor = true;
      this.Punch.ForeColor = SystemColors.ActiveCaptionText;
      Button punch1 = this.Punch;
      point1 = new Point(12, 364);
      Point point6 = point1;
      punch1.Location = point6;
      this.Punch.Name = "Punch";
      Button punch2 = this.Punch;
      size1 = new Size(85, 40);
      Size size6 = size1;
      punch2.Size = size6;
      this.Punch.TabIndex = 22;
      this.Punch.Text = "Punch\r\n-2 Energy";
      this.Punch.UseVisualStyleBackColor = true;
      this.Nuke.ForeColor = SystemColors.ActiveCaptionText;
      Button nuke1 = this.Nuke;
      point1 = new Point(221, 416);
      Point point7 = point1;
      nuke1.Location = point7;
      this.Nuke.Name = "Nuke";
      Button nuke2 = this.Nuke;
      size1 = new Size(85, 40);
      Size size7 = size1;
      nuke2.Size = size7;
      this.Nuke.TabIndex = 24;
      this.Nuke.Text = "Nuke\r\n";
      this.Nuke.UseVisualStyleBackColor = true;
      this.SuperPunch.ForeColor = SystemColors.ActiveCaptionText;
      Button superPunch1 = this.SuperPunch;
      point1 = new Point(221, 364);
      Point point8 = point1;
      superPunch1.Location = point8;
      this.SuperPunch.Name = "SuperPunch";
      Button superPunch2 = this.SuperPunch;
      size1 = new Size(85, 40);
      Size size8 = size1;
      superPunch2.Size = size8;
      this.SuperPunch.TabIndex = 25;
      this.SuperPunch.Text = "Super Punch\r\n-10 Energy";
      this.SuperPunch.UseVisualStyleBackColor = true;
      this.Button2.ForeColor = SystemColors.ActiveCaptionText;
      Button button2_1 = this.Button2;
      point1 = new Point(12, 12);
      Point point9 = point1;
      button2_1.Location = point9;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(73, 25);
      Size size9 = size1;
      button2_2.Size = size9;
      this.Button2.TabIndex = 28;
      this.Button2.Text = "Forfeit";
      this.Button2.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.BackColor = Color.Transparent;
      this.Label1.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = SystemColors.ActiveCaptionText;
      Label label1_1 = this.Label1;
      point1 = new Point(12, 84);
      Point point10 = point1;
      label1_1.Location = point10;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(51, 19);
      Size size10 = size1;
      label1_2.Size = size10;
      this.Label1.TabIndex = 35;
      this.Label1.Text = "Health";
      this.Label3.AutoSize = true;
      this.Label3.BackColor = Color.Transparent;
      this.Label3.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = SystemColors.ActiveCaptionText;
      Label label3_1 = this.Label3;
      point1 = new Point(12, 112);
      Point point11 = point1;
      label3_1.Location = point11;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(51, 19);
      Size size11 = size1;
      label3_2.Size = size11;
      this.Label3.TabIndex = 37;
      this.Label3.Text = "Energy";
      this.Label4.AutoSize = true;
      this.Label4.BackColor = Color.Transparent;
      this.Label4.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = SystemColors.ActiveCaptionText;
      Label label4_1 = this.Label4;
      point1 = new Point(640, 112);
      Point point12 = point1;
      label4_1.Location = point12;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(51, 19);
      Size size12 = size1;
      label4_2.Size = size12;
      this.Label4.TabIndex = 38;
      this.Label4.Text = "Energy";
      this.Label5.AutoSize = true;
      this.Label5.BackColor = Color.Transparent;
      this.Label5.Font = new Font("Comic Sans MS", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = SystemColors.ActiveCaptionText;
      Label label5_1 = this.Label5;
      point1 = new Point(640, 84);
      Point point13 = point1;
      label5_1.Location = point13;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(51, 19);
      Size size13 = size1;
      label5_2.Size = size13;
      this.Label5.TabIndex = 39;
      this.Label5.Text = "Health";
      ProgressBar energy1_1 = this.Energy1;
      point1 = new Point(69, 117);
      Point point14 = point1;
      energy1_1.Location = point14;
      this.Energy1.Name = "Energy1";
      ProgressBar energy1_2 = this.Energy1;
      size1 = new Size(257, 14);
      Size size14 = size1;
      energy1_2.Size = size14;
      this.Energy1.TabIndex = 40;
      this.Energy1.Value = 100;
      ProgressBar health2_1 = this.Health2;
      point1 = new Point(377, 89);
      Point point15 = point1;
      health2_1.Location = point15;
      this.Health2.Name = "Health2";
      this.Health2.RightToLeft = RightToLeft.Yes;
      this.Health2.RightToLeftLayout = true;
      ProgressBar health2_2 = this.Health2;
      size1 = new Size(257, 14);
      Size size15 = size1;
      health2_2.Size = size15;
      this.Health2.Step = 100;
      this.Health2.TabIndex = 42;
      this.Health2.Value = 100;
      ProgressBar energy2_1 = this.Energy2;
      point1 = new Point(377, 117);
      Point point16 = point1;
      energy2_1.Location = point16;
      this.Energy2.Name = "Energy2";
      this.Energy2.RightToLeft = RightToLeft.Yes;
      this.Energy2.RightToLeftLayout = true;
      ProgressBar energy2_2 = this.Energy2;
      size1 = new Size(257, 14);
      Size size16 = size1;
      energy2_2.Size = size16;
      this.Energy2.TabIndex = 43;
      this.Energy2.Value = 100;
      ProgressBar health1_1 = this.Health1;
      point1 = new Point(69, 89);
      Point point17 = point1;
      health1_1.Location = point17;
      this.Health1.Name = "Health1";
      ProgressBar health1_2 = this.Health1;
      size1 = new Size(257, 14);
      Size size17 = size1;
      health1_2.Size = size17;
      this.Health1.TabIndex = 44;
      this.Health1.Value = 100;
      this.Label2.AutoSize = true;
      this.Label2.BackColor = Color.Black;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label2_1 = this.Label2;
      point1 = new Point(563, 363);
      Point point18 = point1;
      label2_1.Location = point18;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(113, 16);
      Size size18 = size1;
      label2_2.Size = size18;
      this.Label2.TabIndex = 45;
      this.Label2.Text = "Energy Potions";
      this.Label6.AutoSize = true;
      this.Label6.BackColor = Color.Black;
      this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label6_1 = this.Label6;
      point1 = new Point(415, 363);
      Point point19 = point1;
      label6_1.Location = point19;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(109, 16);
      Size size19 = size1;
      label6_2.Size = size19;
      this.Label6.TabIndex = 46;
      this.Label6.Text = "Health Potions";
      this.Label8.AutoSize = true;
      this.Label8.BackColor = Color.Black;
      this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label8_1 = this.Label8;
      point1 = new Point(415, 440);
      Point point20 = point1;
      label8_1.Location = point20;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(40, 16);
      Size size20 = size1;
      label8_2.Size = size20;
      this.Label8.TabIndex = 48;
      this.Label8.Text = "+100";
      this.Label9.AutoSize = true;
      this.Label9.BackColor = Color.Black;
      this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label9_1 = this.Label9;
      point1 = new Point(415, 413);
      Point point21 = point1;
      label9_1.Location = point21;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(32, 16);
      Size size21 = size1;
      label9_2.Size = size21;
      this.Label9.TabIndex = 49;
      this.Label9.Text = "+50";
      this.Label10.AutoSize = true;
      this.Label10.BackColor = Color.Black;
      this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label10_1 = this.Label10;
      point1 = new Point(415, 387);
      Point point22 = point1;
      label10_1.Location = point22;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(32, 16);
      Size size22 = size1;
      label10_2.Size = size22;
      this.Label10.TabIndex = 50;
      this.Label10.Text = "+10";
      this.Label7.AutoSize = true;
      this.Label7.BackColor = Color.Black;
      this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label7_1 = this.Label7;
      point1 = new Point(563, 387);
      Point point23 = point1;
      label7_1.Location = point23;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(32, 16);
      Size size23 = size1;
      label7_2.Size = size23;
      this.Label7.TabIndex = 53;
      this.Label7.Text = "+25";
      this.Label11.AutoSize = true;
      this.Label11.BackColor = Color.Black;
      this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label11_1 = this.Label11;
      point1 = new Point(563, 413);
      Point point24 = point1;
      label11_1.Location = point24;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(32, 16);
      Size size24 = size1;
      label11_2.Size = size24;
      this.Label11.TabIndex = 52;
      this.Label11.Text = "+50";
      this.Label12.AutoSize = true;
      this.Label12.BackColor = Color.Black;
      this.Label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label12_1 = this.Label12;
      point1 = new Point(563, 440);
      Point point25 = point1;
      label12_1.Location = point25;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(40, 16);
      Size size25 = size1;
      label12_2.Size = size25;
      this.Label12.TabIndex = 51;
      this.Label12.Text = "+100";
      this.Health10.AutoSize = true;
      this.Health10.BackColor = Color.Black;
      this.Health10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label health10_1 = this.Health10;
      point1 = new Point(461, 387);
      Point point26 = point1;
      health10_1.Location = point26;
      this.Health10.Name = "Health10";
      Label health10_2 = this.Health10;
      size1 = new Size(25, 16);
      Size size26 = size1;
      health10_2.Size = size26;
      this.Health10.TabIndex = 56;
      this.Health10.Text = "x--";
      this.Health50.AutoSize = true;
      this.Health50.BackColor = Color.Black;
      this.Health50.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label health50_1 = this.Health50;
      point1 = new Point(461, 413);
      Point point27 = point1;
      health50_1.Location = point27;
      this.Health50.Name = "Health50";
      Label health50_2 = this.Health50;
      size1 = new Size(25, 16);
      Size size27 = size1;
      health50_2.Size = size27;
      this.Health50.TabIndex = 55;
      this.Health50.Text = "x--";
      this.Health100.AutoSize = true;
      this.Health100.BackColor = Color.Black;
      this.Health100.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label health100_1 = this.Health100;
      point1 = new Point(461, 440);
      Point point28 = point1;
      health100_1.Location = point28;
      this.Health100.Name = "Health100";
      Label health100_2 = this.Health100;
      size1 = new Size(25, 16);
      Size size28 = size1;
      health100_2.Size = size28;
      this.Health100.TabIndex = 54;
      this.Health100.Text = "x--";
      this.Energy10.AutoSize = true;
      this.Energy10.BackColor = Color.Black;
      this.Energy10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label energy10_1 = this.Energy10;
      point1 = new Point(609, 387);
      Point point29 = point1;
      energy10_1.Location = point29;
      this.Energy10.Name = "Energy10";
      Label energy10_2 = this.Energy10;
      size1 = new Size(25, 16);
      Size size29 = size1;
      energy10_2.Size = size29;
      this.Energy10.TabIndex = 59;
      this.Energy10.Text = "x--";
      this.Energy50.AutoSize = true;
      this.Energy50.BackColor = Color.Black;
      this.Energy50.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label energy50_1 = this.Energy50;
      point1 = new Point(609, 413);
      Point point30 = point1;
      energy50_1.Location = point30;
      this.Energy50.Name = "Energy50";
      Label energy50_2 = this.Energy50;
      size1 = new Size(25, 16);
      Size size30 = size1;
      energy50_2.Size = size30;
      this.Energy50.TabIndex = 58;
      this.Energy50.Text = "x--";
      this.Energy100.AutoSize = true;
      this.Energy100.BackColor = Color.Black;
      this.Energy100.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label energy100_1 = this.Energy100;
      point1 = new Point(609, 440);
      Point point31 = point1;
      energy100_1.Location = point31;
      this.Energy100.Name = "Energy100";
      Label energy100_2 = this.Energy100;
      size1 = new Size(25, 16);
      Size size31 = size1;
      energy100_2.Size = size31;
      this.Energy100.TabIndex = 57;
      this.Energy100.Text = "x--";
      this.Button3.ForeColor = SystemColors.ActiveCaptionText;
      Button button3_1 = this.Button3;
      point1 = new Point(492, 411);
      Point point32 = point1;
      button3_1.Location = point32;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(45, 23);
      Size size32 = size1;
      button3_2.Size = size32;
      this.Button3.TabIndex = 60;
      this.Button3.Text = "Use";
      this.Button3.UseVisualStyleBackColor = true;
      this.Button4.ForeColor = SystemColors.ActiveCaptionText;
      Button button4_1 = this.Button4;
      point1 = new Point(492, 382);
      Point point33 = point1;
      button4_1.Location = point33;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(45, 23);
      Size size33 = size1;
      button4_2.Size = size33;
      this.Button4.TabIndex = 61;
      this.Button4.Text = "Use";
      this.Button4.UseVisualStyleBackColor = true;
      this.Button5.ForeColor = SystemColors.ActiveCaptionText;
      Button button5_1 = this.Button5;
      point1 = new Point(492, 440);
      Point point34 = point1;
      button5_1.Location = point34;
      this.Button5.Name = "Button5";
      Button button5_2 = this.Button5;
      size1 = new Size(45, 23);
      Size size34 = size1;
      button5_2.Size = size34;
      this.Button5.TabIndex = 62;
      this.Button5.Text = "Use";
      this.Button5.UseVisualStyleBackColor = true;
      this.Button6.ForeColor = SystemColors.ActiveCaptionText;
      Button button6_1 = this.Button6;
      point1 = new Point(640, 439);
      Point point35 = point1;
      button6_1.Location = point35;
      this.Button6.Name = "Button6";
      Button button6_2 = this.Button6;
      size1 = new Size(45, 23);
      Size size35 = size1;
      button6_2.Size = size35;
      this.Button6.TabIndex = 65;
      this.Button6.Text = "Use";
      this.Button6.UseVisualStyleBackColor = true;
      this.Button7.ForeColor = SystemColors.ActiveCaptionText;
      Button button7_1 = this.Button7;
      point1 = new Point(640, 381);
      Point point36 = point1;
      button7_1.Location = point36;
      this.Button7.Name = "Button7";
      Button button7_2 = this.Button7;
      size1 = new Size(45, 23);
      Size size36 = size1;
      button7_2.Size = size36;
      this.Button7.TabIndex = 64;
      this.Button7.Text = "Use";
      this.Button7.UseVisualStyleBackColor = true;
      this.Button8.ForeColor = SystemColors.ActiveCaptionText;
      Button button8_1 = this.Button8;
      point1 = new Point(640, 410);
      Point point37 = point1;
      button8_1.Location = point37;
      this.Button8.Name = "Button8";
      Button button8_2 = this.Button8;
      size1 = new Size(45, 23);
      Size size37 = size1;
      button8_2.Size = size37;
      this.Button8.TabIndex = 63;
      this.Button8.Text = "Use";
      this.Button8.UseVisualStyleBackColor = true;
      this.Button10.ForeColor = SystemColors.ActiveCaptionText;
      Button button10_1 = this.Button10;
      point1 = new Point(312, 364);
      Point point38 = point1;
      button10_1.Location = point38;
      this.Button10.Name = "Button10";
      Button button10_2 = this.Button10;
      size1 = new Size(86, 38);
      Size size38 = size1;
      button10_2.Size = size38;
      this.Button10.TabIndex = 67;
      this.Button10.Text = "Throw Pokeball";
      this.Button10.UseVisualStyleBackColor = true;
      this.NukeAmount.AutoSize = true;
      this.NukeAmount.BackColor = Color.Black;
      this.NukeAmount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label nukeAmount1 = this.NukeAmount;
      point1 = new Point(365, 421);
      Point point39 = point1;
      nukeAmount1.Location = point39;
      this.NukeAmount.Name = "NukeAmount";
      Label nukeAmount2 = this.NukeAmount;
      size1 = new Size(21, 13);
      Size size39 = size1;
      nukeAmount2.Size = size39;
      this.NukeAmount.TabIndex = 70;
      this.NukeAmount.Text = "x--";
      this.Label14.AutoSize = true;
      this.Label14.BackColor = Color.Black;
      this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label14_1 = this.Label14;
      point1 = new Point(309, 421);
      Point point40 = point1;
      label14_1.Location = point40;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(41, 13);
      Size size40 = size1;
      label14_2.Size = size40;
      this.Label14.TabIndex = 69;
      this.Label14.Text = " Nuke";
      this.Poke.AutoSize = true;
      this.Poke.BackColor = Color.Black;
      this.Poke.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label poke1 = this.Poke;
      point1 = new Point(365, 439);
      Point point41 = point1;
      poke1.Location = point41;
      this.Poke.Name = "Poke";
      Label poke2 = this.Poke;
      size1 = new Size(21, 13);
      Size size41 = size1;
      poke2.Size = size41;
      this.Poke.TabIndex = 72;
      this.Poke.Text = "x--";
      this.Label16.AutoSize = true;
      this.Label16.BackColor = Color.Black;
      this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      Label label16_1 = this.Label16;
      point1 = new Point(309, 439);
      Point point42 = point1;
      label16_1.Location = point42;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(56, 13);
      Size size42 = size1;
      label16_2.Size = size42;
      this.Label16.TabIndex = 71;
      this.Label16.Text = "Pokeball";
      this.PictureBox1.BackColor = Color.Transparent;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(12, 208);
      Point point43 = point1;
      pictureBox1_1.Location = point43;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(100, 150);
      Size size43 = size1;
      pictureBox1_2.Size = size43;
      this.PictureBox1.TabIndex = 68;
      this.PictureBox1.TabStop = false;
      this.Stick_Right_Punch.BackColor = Color.Transparent;
      this.Stick_Right_Punch.Image = (Image) componentResourceManager.GetObject("Stick_Right_Punch.Image");
      PictureBox stickRightPunch1 = this.Stick_Right_Punch;
      point1 = new Point(12, 208);
      Point point44 = point1;
      stickRightPunch1.Location = point44;
      this.Stick_Right_Punch.Name = "Stick_Right_Punch";
      PictureBox stickRightPunch2 = this.Stick_Right_Punch;
      size1 = new Size(100, 150);
      Size size44 = size1;
      stickRightPunch2.Size = size44;
      this.Stick_Right_Punch.TabIndex = 27;
      this.Stick_Right_Punch.TabStop = false;
      this.Stick_Left_Punch.BackColor = Color.Transparent;
      this.Stick_Left_Punch.Image = (Image) componentResourceManager.GetObject("Stick_Left_Punch.Image");
      PictureBox stickLeftPunch1 = this.Stick_Left_Punch;
      point1 = new Point(588, 208);
      Point point45 = point1;
      stickLeftPunch1.Location = point45;
      this.Stick_Left_Punch.Name = "Stick_Left_Punch";
      PictureBox stickLeftPunch2 = this.Stick_Left_Punch;
      size1 = new Size(100, 150);
      Size size45 = size1;
      stickLeftPunch2.Size = size45;
      this.Stick_Left_Punch.TabIndex = 26;
      this.Stick_Left_Punch.TabStop = false;
      this.PictureBox16.BackColor = SystemColors.ActiveCaptionText;
      PictureBox pictureBox16_1 = this.PictureBox16;
      point1 = new Point(-8, 52);
      Point point46 = point1;
      pictureBox16_1.Location = point46;
      this.PictureBox16.Name = "PictureBox16";
      PictureBox pictureBox16_2 = this.PictureBox16;
      size1 = new Size(12, 375);
      Size size46 = size1;
      pictureBox16_2.Size = size46;
      this.PictureBox16.TabIndex = 15;
      this.PictureBox16.TabStop = false;
      this.PictureBox15.BackColor = SystemColors.ActiveCaptionText;
      PictureBox pictureBox15_1 = this.PictureBox15;
      point1 = new Point(697, 22);
      Point point47 = point1;
      pictureBox15_1.Location = point47;
      this.PictureBox15.Name = "PictureBox15";
      PictureBox pictureBox15_2 = this.PictureBox15;
      size1 = new Size(12, 375);
      Size size47 = size1;
      pictureBox15_2.Size = size47;
      this.PictureBox15.TabIndex = 14;
      this.PictureBox15.TabStop = false;
      this.PictureBox14.BackColor = SystemColors.ActiveCaptionText;
      PictureBox pictureBox14_1 = this.PictureBox14;
      point1 = new Point(-8, -33);
      Point point48 = point1;
      pictureBox14_1.Location = point48;
      this.PictureBox14.Name = "PictureBox14";
      PictureBox pictureBox14_2 = this.PictureBox14;
      size1 = new Size(759, 114);
      Size size48 = size1;
      pictureBox14_2.Size = size48;
      this.PictureBox14.TabIndex = 13;
      this.PictureBox14.TabStop = false;
      this.PictureBox13.BackColor = SystemColors.ActiveCaptionText;
      PictureBox pictureBox13_1 = this.PictureBox13;
      point1 = new Point(-8, 357);
      Point point49 = point1;
      pictureBox13_1.Location = point49;
      this.PictureBox13.Name = "PictureBox13";
      PictureBox pictureBox13_2 = this.PictureBox13;
      size1 = new Size(717, 125);
      Size size49 = size1;
      pictureBox13_2.Size = size49;
      this.PictureBox13.TabIndex = 12;
      this.PictureBox13.TabStop = false;
      this.Stick_left_Superkick.BackColor = Color.Transparent;
      this.Stick_left_Superkick.Image = (Image) componentResourceManager.GetObject("Stick_left_Superkick.Image");
      PictureBox stickLeftSuperkick1 = this.Stick_left_Superkick;
      point1 = new Point(588, 208);
      Point point50 = point1;
      stickLeftSuperkick1.Location = point50;
      this.Stick_left_Superkick.Name = "Stick_left_Superkick";
      PictureBox stickLeftSuperkick2 = this.Stick_left_Superkick;
      size1 = new Size(100, 150);
      Size size50 = size1;
      stickLeftSuperkick2.Size = size50;
      this.Stick_left_Superkick.TabIndex = 11;
      this.Stick_left_Superkick.TabStop = false;
      this.Stick_Right_FireBall.BackColor = Color.Transparent;
      this.Stick_Right_FireBall.Image = (Image) componentResourceManager.GetObject("Stick_Right_FireBall.Image");
      PictureBox stickRightFireBall1 = this.Stick_Right_FireBall;
      point1 = new Point(12, 208);
      Point point51 = point1;
      stickRightFireBall1.Location = point51;
      this.Stick_Right_FireBall.Name = "Stick_Right_FireBall";
      PictureBox stickRightFireBall2 = this.Stick_Right_FireBall;
      size1 = new Size(100, 150);
      Size size51 = size1;
      stickRightFireBall2.Size = size51;
      this.Stick_Right_FireBall.TabIndex = 10;
      this.Stick_Right_FireBall.TabStop = false;
      this.Stick_Right_SuperKick.BackColor = Color.Transparent;
      this.Stick_Right_SuperKick.Image = (Image) componentResourceManager.GetObject("Stick_Right_SuperKick.Image");
      PictureBox stickRightSuperKick1 = this.Stick_Right_SuperKick;
      point1 = new Point(12, 208);
      Point point52 = point1;
      stickRightSuperKick1.Location = point52;
      this.Stick_Right_SuperKick.Name = "Stick_Right_SuperKick";
      PictureBox stickRightSuperKick2 = this.Stick_Right_SuperKick;
      size1 = new Size(100, 150);
      Size size52 = size1;
      stickRightSuperKick2.Size = size52;
      this.Stick_Right_SuperKick.TabIndex = 9;
      this.Stick_Right_SuperKick.TabStop = false;
      this.Stick_Right_Stance.BackColor = Color.Transparent;
      this.Stick_Right_Stance.Image = (Image) componentResourceManager.GetObject("Stick_Right_Stance.Image");
      PictureBox stickRightStance1 = this.Stick_Right_Stance;
      point1 = new Point(12, 208);
      Point point53 = point1;
      stickRightStance1.Location = point53;
      this.Stick_Right_Stance.Name = "Stick_Right_Stance";
      PictureBox stickRightStance2 = this.Stick_Right_Stance;
      size1 = new Size(100, 150);
      Size size53 = size1;
      stickRightStance2.Size = size53;
      this.Stick_Right_Stance.TabIndex = 8;
      this.Stick_Right_Stance.TabStop = false;
      this.Stick_right_SuperPunch.BackColor = Color.Transparent;
      this.Stick_right_SuperPunch.Image = (Image) componentResourceManager.GetObject("Stick_right_SuperPunch.Image");
      PictureBox stickRightSuperPunch1 = this.Stick_right_SuperPunch;
      point1 = new Point(12, 208);
      Point point54 = point1;
      stickRightSuperPunch1.Location = point54;
      this.Stick_right_SuperPunch.Name = "Stick_right_SuperPunch";
      PictureBox stickRightSuperPunch2 = this.Stick_right_SuperPunch;
      size1 = new Size(100, 150);
      Size size54 = size1;
      stickRightSuperPunch2.Size = size54;
      this.Stick_right_SuperPunch.TabIndex = 7;
      this.Stick_right_SuperPunch.TabStop = false;
      this.Stick_Right_Kick.BackColor = Color.Transparent;
      this.Stick_Right_Kick.BackgroundImage = (Image) componentResourceManager.GetObject("Stick_Right_Kick.BackgroundImage");
      PictureBox stickRightKick1 = this.Stick_Right_Kick;
      point1 = new Point(12, 208);
      Point point55 = point1;
      stickRightKick1.Location = point55;
      this.Stick_Right_Kick.Name = "Stick_Right_Kick";
      PictureBox stickRightKick2 = this.Stick_Right_Kick;
      size1 = new Size(100, 150);
      Size size55 = size1;
      stickRightKick2.Size = size55;
      this.Stick_Right_Kick.TabIndex = 6;
      this.Stick_Right_Kick.TabStop = false;
      this.Stick_left_Fireball.BackColor = Color.Transparent;
      this.Stick_left_Fireball.Image = (Image) componentResourceManager.GetObject("Stick_left_Fireball.Image");
      PictureBox stickLeftFireball1 = this.Stick_left_Fireball;
      point1 = new Point(588, 208);
      Point point56 = point1;
      stickLeftFireball1.Location = point56;
      this.Stick_left_Fireball.Name = "Stick_left_Fireball";
      PictureBox stickLeftFireball2 = this.Stick_left_Fireball;
      size1 = new Size(100, 150);
      Size size56 = size1;
      stickLeftFireball2.Size = size56;
      this.Stick_left_Fireball.TabIndex = 5;
      this.Stick_left_Fireball.TabStop = false;
      this.Stick_Nuke.BackColor = Color.Transparent;
      this.Stick_Nuke.Image = (Image) componentResourceManager.GetObject("Stick_Nuke.Image");
      PictureBox stickNuke1 = this.Stick_Nuke;
      point1 = new Point(1, 66);
      Point point57 = point1;
      stickNuke1.Location = point57;
      this.Stick_Nuke.Name = "Stick_Nuke";
      PictureBox stickNuke2 = this.Stick_Nuke;
      size1 = new Size(699, 292);
      Size size57 = size1;
      stickNuke2.Size = size57;
      this.Stick_Nuke.SizeMode = PictureBoxSizeMode.StretchImage;
      this.Stick_Nuke.TabIndex = 4;
      this.Stick_Nuke.TabStop = false;
      this.Stick_left_Stance.BackColor = Color.Transparent;
      this.Stick_left_Stance.Image = (Image) componentResourceManager.GetObject("Stick_left_Stance.Image");
      PictureBox stickLeftStance1 = this.Stick_left_Stance;
      point1 = new Point(588, 208);
      Point point58 = point1;
      stickLeftStance1.Location = point58;
      this.Stick_left_Stance.Name = "Stick_left_Stance";
      PictureBox stickLeftStance2 = this.Stick_left_Stance;
      size1 = new Size(100, 150);
      Size size58 = size1;
      stickLeftStance2.Size = size58;
      this.Stick_left_Stance.TabIndex = 3;
      this.Stick_left_Stance.TabStop = false;
      this.Stick_left_Superpunch.BackColor = Color.Transparent;
      this.Stick_left_Superpunch.Image = (Image) componentResourceManager.GetObject("Stick_left_Superpunch.Image");
      PictureBox stickLeftSuperpunch1 = this.Stick_left_Superpunch;
      point1 = new Point(588, 208);
      Point point59 = point1;
      stickLeftSuperpunch1.Location = point59;
      this.Stick_left_Superpunch.Name = "Stick_left_Superpunch";
      PictureBox stickLeftSuperpunch2 = this.Stick_left_Superpunch;
      size1 = new Size(100, 150);
      Size size59 = size1;
      stickLeftSuperpunch2.Size = size59;
      this.Stick_left_Superpunch.TabIndex = 2;
      this.Stick_left_Superpunch.TabStop = false;
      this.Stick_Left_Kick.BackColor = Color.Transparent;
      this.Stick_Left_Kick.Image = (Image) componentResourceManager.GetObject("Stick_Left_Kick.Image");
      PictureBox stickLeftKick1 = this.Stick_Left_Kick;
      point1 = new Point(588, 208);
      Point point60 = point1;
      stickLeftKick1.Location = point60;
      this.Stick_Left_Kick.Name = "Stick_Left_Kick";
      PictureBox stickLeftKick2 = this.Stick_Left_Kick;
      size1 = new Size(100, 150);
      Size size60 = size1;
      stickLeftKick2.Size = size60;
      this.Stick_Left_Kick.TabIndex = 1;
      this.Stick_Left_Kick.TabStop = false;
      this.Op_Attack.Enabled = true;
      this.Op_Attack.Interval = 1750;
      this.HP_checker.Enabled = true;
      this.HP_checker.Interval = 10;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonHighlight;
      size1 = new Size(700, 475);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Poke);
      this.Controls.Add((Control) this.Label16);
      this.Controls.Add((Control) this.NukeAmount);
      this.Controls.Add((Control) this.Label14);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Button10);
      this.Controls.Add((Control) this.Button6);
      this.Controls.Add((Control) this.Button7);
      this.Controls.Add((Control) this.Button8);
      this.Controls.Add((Control) this.Button5);
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Energy10);
      this.Controls.Add((Control) this.Energy50);
      this.Controls.Add((Control) this.Energy100);
      this.Controls.Add((Control) this.Health10);
      this.Controls.Add((Control) this.Health50);
      this.Controls.Add((Control) this.Health100);
      this.Controls.Add((Control) this.Label7);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Health1);
      this.Controls.Add((Control) this.Energy2);
      this.Controls.Add((Control) this.Health2);
      this.Controls.Add((Control) this.Energy1);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Stick_Right_Punch);
      this.Controls.Add((Control) this.Stick_Left_Punch);
      this.Controls.Add((Control) this.SuperPunch);
      this.Controls.Add((Control) this.Nuke);
      this.Controls.Add((Control) this.Punch);
      this.Controls.Add((Control) this.SuperKick);
      this.Controls.Add((Control) this.Kick);
      this.Controls.Add((Control) this.FireBall);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.PictureBox16);
      this.Controls.Add((Control) this.PictureBox15);
      this.Controls.Add((Control) this.PictureBox14);
      this.Controls.Add((Control) this.PictureBox13);
      this.Controls.Add((Control) this.Stick_left_Superkick);
      this.Controls.Add((Control) this.Stick_Right_FireBall);
      this.Controls.Add((Control) this.Stick_Right_SuperKick);
      this.Controls.Add((Control) this.Stick_Right_Stance);
      this.Controls.Add((Control) this.Stick_right_SuperPunch);
      this.Controls.Add((Control) this.Stick_Right_Kick);
      this.Controls.Add((Control) this.Stick_left_Fireball);
      this.Controls.Add((Control) this.Stick_Nuke);
      this.Controls.Add((Control) this.Stick_left_Stance);
      this.Controls.Add((Control) this.Stick_left_Superpunch);
      this.Controls.Add((Control) this.Stick_Left_Kick);
      this.ForeColor = SystemColors.ButtonFace;
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Arena);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Arena Fighters!";
      ((ISupportInitialize) this.PictureBox1).EndInit();
      ((ISupportInitialize) this.Stick_Right_Punch).EndInit();
      ((ISupportInitialize) this.Stick_Left_Punch).EndInit();
      ((ISupportInitialize) this.PictureBox16).EndInit();
      ((ISupportInitialize) this.PictureBox15).EndInit();
      ((ISupportInitialize) this.PictureBox14).EndInit();
      ((ISupportInitialize) this.PictureBox13).EndInit();
      ((ISupportInitialize) this.Stick_left_Superkick).EndInit();
      ((ISupportInitialize) this.Stick_Right_FireBall).EndInit();
      ((ISupportInitialize) this.Stick_Right_SuperKick).EndInit();
      ((ISupportInitialize) this.Stick_Right_Stance).EndInit();
      ((ISupportInitialize) this.Stick_right_SuperPunch).EndInit();
      ((ISupportInitialize) this.Stick_Right_Kick).EndInit();
      ((ISupportInitialize) this.Stick_left_Fireball).EndInit();
      ((ISupportInitialize) this.Stick_Nuke).EndInit();
      ((ISupportInitialize) this.Stick_left_Stance).EndInit();
      ((ISupportInitialize) this.Stick_left_Superpunch).EndInit();
      ((ISupportInitialize) this.Stick_Left_Kick).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual PictureBox Stick_Left_Kick
    {
      [DebuggerNonUserCode] get => this._Stick_Left_Kick;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Left_Kick = value;
    }

    internal virtual PictureBox Stick_left_Superpunch
    {
      [DebuggerNonUserCode] get => this._Stick_left_Superpunch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_left_Superpunch = value;
    }

    internal virtual PictureBox Stick_left_Stance
    {
      [DebuggerNonUserCode] get => this._Stick_left_Stance;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_left_Stance = value;
    }

    internal virtual PictureBox Stick_Nuke
    {
      [DebuggerNonUserCode] get => this._Stick_Nuke;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Nuke = value;
    }

    internal virtual PictureBox Stick_left_Fireball
    {
      [DebuggerNonUserCode] get => this._Stick_left_Fireball;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_left_Fireball = value;
    }

    internal virtual PictureBox Stick_Right_Kick
    {
      [DebuggerNonUserCode] get => this._Stick_Right_Kick;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Right_Kick = value;
    }

    internal virtual PictureBox Stick_right_SuperPunch
    {
      [DebuggerNonUserCode] get => this._Stick_right_SuperPunch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_right_SuperPunch = value;
    }

    internal virtual PictureBox Stick_Right_Stance
    {
      [DebuggerNonUserCode] get => this._Stick_Right_Stance;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Right_Stance = value;
    }

    internal virtual PictureBox Stick_Right_SuperKick
    {
      [DebuggerNonUserCode] get => this._Stick_Right_SuperKick;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Right_SuperKick = value;
    }

    internal virtual PictureBox Stick_Right_FireBall
    {
      [DebuggerNonUserCode] get => this._Stick_Right_FireBall;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Right_FireBall = value;
    }

    internal virtual PictureBox Stick_left_Superkick
    {
      [DebuggerNonUserCode] get => this._Stick_left_Superkick;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_left_Superkick = value;
    }

    internal virtual PictureBox PictureBox13
    {
      [DebuggerNonUserCode] get => this._PictureBox13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox13 = value;
    }

    internal virtual PictureBox PictureBox14
    {
      [DebuggerNonUserCode] get => this._PictureBox14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox14 = value;
    }

    internal virtual PictureBox PictureBox15
    {
      [DebuggerNonUserCode] get => this._PictureBox15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox15 = value;
    }

    internal virtual PictureBox PictureBox16
    {
      [DebuggerNonUserCode] get => this._PictureBox16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox16 = value;
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

    internal virtual Button FireBall
    {
      [DebuggerNonUserCode] get => this._FireBall;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FireBall_Click);
        if (this._FireBall != null)
          this._FireBall.Click -= eventHandler;
        this._FireBall = value;
        if (this._FireBall == null)
          return;
        this._FireBall.Click += eventHandler;
      }
    }

    internal virtual Button Kick
    {
      [DebuggerNonUserCode] get => this._Kick;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Kick_Click);
        if (this._Kick != null)
          this._Kick.Click -= eventHandler;
        this._Kick = value;
        if (this._Kick == null)
          return;
        this._Kick.Click += eventHandler;
      }
    }

    internal virtual Button SuperKick
    {
      [DebuggerNonUserCode] get => this._SuperKick;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SuperKick_Click);
        if (this._SuperKick != null)
          this._SuperKick.Click -= eventHandler;
        this._SuperKick = value;
        if (this._SuperKick == null)
          return;
        this._SuperKick.Click += eventHandler;
      }
    }

    internal virtual Button Punch
    {
      [DebuggerNonUserCode] get => this._Punch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Punch_Click);
        if (this._Punch != null)
          this._Punch.Click -= eventHandler;
        this._Punch = value;
        if (this._Punch == null)
          return;
        this._Punch.Click += eventHandler;
      }
    }

    internal virtual Button Nuke
    {
      [DebuggerNonUserCode] get => this._Nuke;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Nuke_Click);
        if (this._Nuke != null)
          this._Nuke.Click -= eventHandler;
        this._Nuke = value;
        if (this._Nuke == null)
          return;
        this._Nuke.Click += eventHandler;
      }
    }

    internal virtual Button SuperPunch
    {
      [DebuggerNonUserCode] get => this._SuperPunch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SuperPunch_Click);
        if (this._SuperPunch != null)
          this._SuperPunch.Click -= eventHandler;
        this._SuperPunch = value;
        if (this._SuperPunch == null)
          return;
        this._SuperPunch.Click += eventHandler;
      }
    }

    internal virtual PictureBox Stick_Left_Punch
    {
      [DebuggerNonUserCode] get => this._Stick_Left_Punch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Left_Punch = value;
    }

    internal virtual PictureBox Stick_Right_Punch
    {
      [DebuggerNonUserCode] get => this._Stick_Right_Punch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stick_Right_Punch = value;
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

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

    internal virtual ProgressBar Energy1
    {
      [DebuggerNonUserCode] get => this._Energy1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Energy1 = value;
    }

    internal virtual ProgressBar Health2
    {
      [DebuggerNonUserCode] get => this._Health2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Health2 = value;
    }

    internal virtual ProgressBar Energy2
    {
      [DebuggerNonUserCode] get => this._Energy2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Energy2 = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

    internal virtual Label Health10
    {
      [DebuggerNonUserCode] get => this._Health10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Health10 = value;
    }

    internal virtual Label Health50
    {
      [DebuggerNonUserCode] get => this._Health50;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Health50 = value;
    }

    internal virtual Label Health100
    {
      [DebuggerNonUserCode] get => this._Health100;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Health100 = value;
    }

    internal virtual Label Energy10
    {
      [DebuggerNonUserCode] get => this._Energy10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Energy10 = value;
    }

    internal virtual Label Energy50
    {
      [DebuggerNonUserCode] get => this._Energy50;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Energy50 = value;
    }

    internal virtual Label Energy100
    {
      [DebuggerNonUserCode] get => this._Energy100;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Energy100 = value;
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

    internal virtual Button Button4
    {
      [DebuggerNonUserCode] get => this._Button4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    internal virtual Button Button5
    {
      [DebuggerNonUserCode] get => this._Button5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        if (this._Button5 != null)
          this._Button5.Click -= eventHandler;
        this._Button5 = value;
        if (this._Button5 == null)
          return;
        this._Button5.Click += eventHandler;
      }
    }

    internal virtual Button Button6
    {
      [DebuggerNonUserCode] get => this._Button6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button6_Click);
        if (this._Button6 != null)
          this._Button6.Click -= eventHandler;
        this._Button6 = value;
        if (this._Button6 == null)
          return;
        this._Button6.Click += eventHandler;
      }
    }

    internal virtual Button Button7
    {
      [DebuggerNonUserCode] get => this._Button7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button7_Click);
        if (this._Button7 != null)
          this._Button7.Click -= eventHandler;
        this._Button7 = value;
        if (this._Button7 == null)
          return;
        this._Button7.Click += eventHandler;
      }
    }

    internal virtual Button Button8
    {
      [DebuggerNonUserCode] get => this._Button8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button8_Click);
        if (this._Button8 != null)
          this._Button8.Click -= eventHandler;
        this._Button8 = value;
        if (this._Button8 == null)
          return;
        this._Button8.Click += eventHandler;
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

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual Label NukeAmount
    {
      [DebuggerNonUserCode] get => this._NukeAmount;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._NukeAmount = value;
    }

    internal virtual Label Label14
    {
      [DebuggerNonUserCode] get => this._Label14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
    }

    internal virtual Label Poke
    {
      [DebuggerNonUserCode] get => this._Poke;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Poke = value;
    }

    internal virtual Label Label16
    {
      [DebuggerNonUserCode] get => this._Label16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
    }

    internal virtual Timer Op_Attack
    {
      [DebuggerNonUserCode] get => this._Op_Attack;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Op_Attack != null)
          this._Op_Attack.Tick -= eventHandler;
        this._Op_Attack = value;
        if (this._Op_Attack == null)
          return;
        this._Op_Attack.Tick += eventHandler;
      }
    }

    protected internal virtual ProgressBar Health1
    {
      [DebuggerNonUserCode] get => this._Health1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Health1 = value;
    }

    internal virtual Timer HP_checker
    {
      [DebuggerNonUserCode] get => this._HP_checker;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.HP_checker_Tick);
        if (this._HP_checker != null)
          this._HP_checker.Tick -= eventHandler;
        this._HP_checker = value;
        if (this._HP_checker == null)
          return;
        this._HP_checker.Tick += eventHandler;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      int num = (int) new Exit_Menu().ShowDialog((IWin32Window) this);
    }

    private void Arena_Load(object sender, EventArgs e)
    {
      this.Stick_left_Superkick.Visible = false;
      this.Stick_Left_Kick.Visible = false;
      this.Stick_left_Superpunch.Visible = false;
      this.Stick_left_Stance.Visible = true;
      this.Stick_Nuke.Visible = false;
      this.Stick_left_Fireball.Visible = false;
      this.Stick_Right_Kick.Visible = false;
      this.Stick_right_SuperPunch.Visible = false;
      this.Stick_Right_Stance.Visible = true;
      this.Stick_Right_SuperKick.Visible = false;
      this.Stick_Right_FireBall.Visible = false;
      this.Stick_Left_Punch.Visible = false;
      this.Stick_Right_Punch.Visible = false;
      this.PictureBox1.Visible = false;
      this.HP_checker.Enabled = false;
      if (MyProject.Forms.Difficulty.CheckBox1.Checked)
      {
        this.Op_Attack.Enabled = true;
        this.Op_Attack.Interval = 1250;
      }
      else if (MyProject.Forms.Difficulty.CheckBox2.Checked)
      {
        this.Op_Attack.Enabled = true;
        this.Op_Attack.Interval = 750;
      }
      else if (MyProject.Forms.Difficulty.CheckBox3.Checked)
      {
        this.Op_Attack.Enabled = true;
        this.Op_Attack.Interval = 250;
      }
      this.Health1.Value = 100;
      this.Energy1.Value = 100;
      this.Health2.Value = 100;
      this.Energy2.Value = 100;
      this.Health10.Text = "x" + MyProject.Forms.Data.HP10Data.ToolTipText;
      this.Health50.Text = "x" + MyProject.Forms.Data.EP50data.ToolTipText;
      this.Health100.Text = "x" + MyProject.Forms.Data.EP100Data.ToolTipText;
      this.Energy10.Text = "x" + MyProject.Forms.Data.EP10Data.ToolTipText;
      this.Energy50.Text = "x" + MyProject.Forms.Data.EP50data.ToolTipText;
      this.Energy100.Text = "x" + MyProject.Forms.Data.EP100Data.ToolTipText;
      this.Poke.Text = "x" + MyProject.Forms.Data.PokeData.ToolTipText;
      this.NukeAmount.Text = "x" + MyProject.Forms.Data.NukeData.ToolTipText;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Close();
      MyProject.Forms.Difficulty.Close();
      MyProject.Forms.Forfeit.Show();
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.HP10Data.ToolTipText) >= 1.0)
      {
        if (this.Health1.Value == 100)
        {
          int num = (int) Interaction.MsgBox((object) "You have full Health already!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
        }
        if (checked (this.Health1.Value + 10) >= 101)
        {
          checked { this.Health1.Value += this.Health1.Value - this.Health1.Maximum; }
          MyProject.Forms.Data.HP10Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP10Data.ToolTipText) - 1.0);
          this.Health10.Text = "x" + MyProject.Forms.Data.HP10Data.ToolTipText;
        }
        else
        {
          if (checked (this.Health1.Value + 10) > 100)
            return;
          checked { this.Health1.Value += 10; }
          MyProject.Forms.Data.HP10Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP10Data.ToolTipText) - 1.0);
          this.Health10.Text = "x" + MyProject.Forms.Data.HP10Data.ToolTipText;
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.HP10Data.ToolTipText) > 0.0)
          return;
        int num = (int) Interaction.MsgBox((object) "You do not have enough of those to do that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.HP50Data.ToolTipText) >= 1.0)
      {
        if (this.Health1.Value == 100)
        {
          int num = (int) Interaction.MsgBox((object) "You have full Health already!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
        }
        if (checked (this.Health1.Value + 50) >= 101)
        {
          checked { this.Health1.Value += this.Health1.Value - this.Health1.Maximum; }
          MyProject.Forms.Data.HP50Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP50Data.ToolTipText) - 1.0);
          this.Health50.Text = "x" + MyProject.Forms.Data.HP50Data.ToolTipText;
        }
        else
        {
          if (checked (this.Health1.Value + 50) > 100)
            return;
          checked { this.Health1.Value += 50; }
          MyProject.Forms.Data.HP50Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP50Data.ToolTipText) - 1.0);
          this.Health50.Text = "x" + MyProject.Forms.Data.HP10Data.ToolTipText;
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.HP50Data.ToolTipText) > 0.0)
          return;
        int num = (int) Interaction.MsgBox((object) "You do not have enough of those to do that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.HP100Data.ToolTipText) >= 1.0)
      {
        if (this.Health1.Value == 100)
        {
          int num = (int) Interaction.MsgBox((object) "You have full Health already!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
        }
        if (checked (this.Health1.Value + 100) >= 101)
        {
          checked { this.Health1.Value += this.Health1.Value - this.Health1.Maximum; }
          MyProject.Forms.Data.HP100Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP100Data.ToolTipText) - 1.0);
          this.Health100.Text = "x" + MyProject.Forms.Data.HP100Data.ToolTipText;
        }
        else
        {
          if (checked (this.Health1.Value + 100) > 100)
            return;
          checked { this.Health1.Value += 100; }
          MyProject.Forms.Data.HP100Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.HP100Data.ToolTipText) - 1.0);
          this.Health100.Text = "x" + MyProject.Forms.Data.HP100Data.ToolTipText;
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.HP100Data.ToolTipText) > 0.0)
          return;
        int num = (int) Interaction.MsgBox((object) "You do not have enough of those to do that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Button7_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.EP10Data.ToolTipText) >= 1.0)
      {
        if (this.Energy1.Value == 100)
        {
          int num = (int) Interaction.MsgBox((object) "You have full Energy already!", MsgBoxStyle.OkCancel, (object) "Oops!");
        }
        if (checked (this.Energy1.Value + 25) >= 101)
        {
          checked { this.Energy1.Value += this.Energy1.Value - this.Energy1.Maximum; }
          MyProject.Forms.Data.EP10Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP10Data.ToolTipText) - 1.0);
          this.Energy10.Text = "x" + MyProject.Forms.Data.EP10Data.ToolTipText;
        }
        else
        {
          if (checked (this.Energy1.Value + 25) > 100)
            return;
          checked { this.Energy1.Value += 25; }
          MyProject.Forms.Data.EP10Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP10Data.ToolTipText) - 1.0);
          this.Energy10.Text = "x" + MyProject.Forms.Data.EP10Data.ToolTipText;
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.EP10Data.ToolTipText) > 0.0)
          return;
        int num = (int) Interaction.MsgBox((object) "You do not have enough of those to do that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Button8_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.EP50data.ToolTipText) >= 1.0)
      {
        if (this.Energy1.Value == 100)
        {
          int num = (int) Interaction.MsgBox((object) "You have full Energy already!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
        }
        if (checked (this.Energy1.Value + 50) >= 101)
        {
          checked { this.Energy1.Value += this.Energy1.Value - this.Energy1.Maximum; }
          MyProject.Forms.Data.EP50data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP50data.ToolTipText) - 1.0);
          this.Energy50.Text = "x" + MyProject.Forms.Data.EP50data.ToolTipText;
        }
        else
        {
          if (checked (this.Energy1.Value + 50) > 100)
            return;
          checked { this.Energy1.Value += 50; }
          MyProject.Forms.Data.EP50data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP50data.ToolTipText) - 1.0);
          this.Energy50.Text = "x" + MyProject.Forms.Data.EP50data.ToolTipText;
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.EP50data.ToolTipText) > 0.0)
          return;
        int num = (int) Interaction.MsgBox((object) "You do not have enough of those to do that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Button6_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.EP100Data.ToolTipText) >= 1.0)
      {
        if (this.Energy1.Value == 100)
        {
          int num = (int) Interaction.MsgBox((object) "You have full Energy already!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
        }
        if (checked (this.Energy1.Value + 75) >= 101)
        {
          checked { this.Energy1.Value += this.Energy1.Value - this.Energy1.Maximum; }
          MyProject.Forms.Data.EP100Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP100Data.ToolTipText) - 1.0);
          this.Energy100.Text = "x" + MyProject.Forms.Data.EP100Data.ToolTipText;
        }
        else
        {
          if (checked (this.Energy1.Value + 75) > 100)
            return;
          checked { this.Energy1.Value += 75; }
          MyProject.Forms.Data.EP100Data.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.EP100Data.ToolTipText) - 1.0);
          this.Energy100.Text = "x" + MyProject.Forms.Data.EP100Data.ToolTipText;
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.EP100Data.ToolTipText) > 0.0)
          return;
        int num = (int) Interaction.MsgBox((object) "You do not have enough of those to do that!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Punch_Click(object sender, EventArgs e)
    {
      if (checked (this.Energy1.Value - 2) <= 0)
      {
        this.Stick_Right_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You do not have enough energy!", MsgBoxStyle.OkCancel, (object) "Oops!");
      }
      else if (checked (this.Energy1.Value - 2) >= 1)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(1, 8);
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else if (checked (this.Health2.Value - this.number) >= 1)
          checked { this.Health2.Value -= this.number; }
        checked { this.Energy1.Value -= 2; }
        this.Stick_Nuke.Visible = false;
        this.Stick_Right_Kick.Visible = false;
        this.Stick_right_SuperPunch.Visible = false;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = false;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Right_Punch.Visible = true;
        this.PictureBox1.Visible = false;
      }
      if (this.Health1.Value > 0)
        return;
      this.HP_checker.Interval = 10;
      this.HP_checker.Enabled = true;
      MyProject.Forms.Lose.Show();
    }

    private void Kick_Click(object sender, EventArgs e)
    {
      if (checked (this.Energy1.Value - 2) <= 0)
      {
        this.Stick_Right_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You do not have enough energy!", MsgBoxStyle.OkCancel, (object) "Oops!");
      }
      else if (checked (this.Energy1.Value - 2) >= 1)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(1, 8);
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else if (checked (this.Health2.Value - this.number) >= 1)
          checked { this.Health2.Value -= this.number; }
        checked { this.Energy1.Value -= 2; }
        this.Stick_Nuke.Visible = false;
        this.Stick_Right_Kick.Visible = true;
        this.Stick_right_SuperPunch.Visible = false;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = false;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Right_Punch.Visible = false;
        this.PictureBox1.Visible = false;
      }
      if (this.Health1.Value > 0)
        return;
      this.HP_checker.Interval = 10;
      this.HP_checker.Enabled = true;
      MyProject.Forms.Lose.Show();
    }

    private void SuperPunch_Click(object sender, EventArgs e)
    {
      if (checked (this.Energy1.Value - 10) <= 0)
      {
        this.Stick_Right_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You do not have enough energy!", MsgBoxStyle.OkCancel, (object) "Oops!");
      }
      else if (checked (this.Energy1.Value - 10) >= 1)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(9, 11);
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else if (checked (this.Health2.Value - this.number) >= 1)
          checked { this.Health2.Value -= this.number; }
        checked { this.Energy1.Value -= 10; }
        this.Stick_Nuke.Visible = false;
        this.Stick_Right_Kick.Visible = false;
        this.Stick_right_SuperPunch.Visible = true;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = false;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Right_Punch.Visible = false;
        this.PictureBox1.Visible = false;
      }
      if (this.Health1.Value > 0)
        return;
      this.HP_checker.Interval = 10;
      this.HP_checker.Enabled = true;
      MyProject.Forms.Lose.Show();
    }

    private void SuperKick_Click(object sender, EventArgs e)
    {
      if (checked (this.Energy1.Value - 15) <= 0)
      {
        this.Stick_Right_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You do not have enough energy!", MsgBoxStyle.OkCancel, (object) "Oops!");
      }
      else if (checked (this.Energy1.Value - 15) >= 1)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(13, 17);
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else if (checked (this.Health2.Value - this.number) >= 1)
          checked { this.Health2.Value -= this.number; }
        checked { this.Energy1.Value -= 15; }
        this.Stick_Nuke.Visible = false;
        this.Stick_Right_Kick.Visible = false;
        this.Stick_right_SuperPunch.Visible = false;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = true;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Right_Punch.Visible = false;
        this.PictureBox1.Visible = false;
      }
      if (this.Health1.Value > 0)
        return;
      this.HP_checker.Interval = 10;
      this.HP_checker.Enabled = true;
      MyProject.Forms.Lose.Show();
    }

    private void FireBall_Click(object sender, EventArgs e)
    {
      if (checked (this.Energy1.Value - 20) <= 0)
      {
        this.Stick_Right_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You do not have enough energy!", MsgBoxStyle.OkCancel, (object) "Oops!");
      }
      else if (checked (this.Energy1.Value - 20) >= 1)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(15, 17);
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else if (checked (this.Health2.Value - this.number) >= 1)
          checked { this.Health2.Value -= this.number; }
        checked { this.Energy1.Value -= 20; }
        this.Stick_Nuke.Visible = false;
        this.Stick_Right_Kick.Visible = false;
        this.Stick_right_SuperPunch.Visible = false;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = false;
        this.Stick_Right_FireBall.Visible = true;
        this.Stick_Right_Punch.Visible = false;
        this.PictureBox1.Visible = false;
      }
      if (this.Health1.Value > 0)
        return;
      this.HP_checker.Interval = 10;
      this.HP_checker.Enabled = true;
      MyProject.Forms.Lose.Show();
    }

    private void Nuke_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.NukeData.ToolTipText) >= 1.0)
      {
        MyProject.Forms.Data.NukeData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.NukeData.ToolTipText) - 1.0);
        this.NukeAmount.Text = "x" + MyProject.Forms.Data.NukeData.ToolTipText;
        this.Stick_Nuke.Visible = true;
        this.Stick_Right_Kick.Visible = false;
        this.Stick_right_SuperPunch.Visible = false;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = false;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Right_Punch.Visible = false;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Left_Kick.Visible = false;
        this.Stick_left_Superpunch.Visible = false;
        this.Stick_left_Stance.Visible = false;
        this.Stick_left_Superkick.Visible = false;
        this.Stick_left_Fireball.Visible = false;
        this.Stick_Left_Punch.Visible = false;
        this.Stick_left_Fireball.Visible = false;
        this.PictureBox1.Visible = false;
        this.Health2.Value = 0;
        this.Health1.Value = 5;
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else
        {
          if (checked (this.Health2.Value - this.number) < 1)
            return;
          checked { this.Health2.Value -= this.number; }
        }
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.NukeData.ToolTipText) > 0.0)
          return;
        this.Stick_left_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You have no nukes to launch!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Button10_Click(object sender, EventArgs e)
    {
      if (Conversions.ToDouble(MyProject.Forms.Data.PokeData.ToolTipText) >= 1.0)
      {
        this.pokeball_catch = new Random();
        this.Pokeball_caught = this.pokeball_catch.Next(1, 30);
        MyProject.Forms.Data.PokeData.ToolTipText = Conversions.ToString(Conversions.ToDouble(MyProject.Forms.Data.PokeData.ToolTipText) - 1.0);
        this.Poke.Text = "x" + MyProject.Forms.Data.PokeData.ToolTipText;
        checked { this.Energy1.Value -= 0; }
        checked { --this.Health2.Value; }
        this.Stick_Nuke.Visible = false;
        this.Stick_Right_Kick.Visible = false;
        this.Stick_right_SuperPunch.Visible = false;
        this.Stick_Right_Stance.Visible = false;
        this.Stick_Right_SuperKick.Visible = false;
        this.Stick_Right_FireBall.Visible = false;
        this.Stick_Right_Punch.Visible = false;
        this.PictureBox1.Visible = true;
        if (checked (this.Health2.Value - this.number) <= 0)
        {
          checked { this.Health2.Value -= this.Health2.Value; }
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          int num = (int) MyProject.Forms.Win_easy.ShowDialog((IWin32Window) this);
        }
        else if (checked (this.Health2.Value - this.number) >= 1)
          checked { this.Health2.Value -= this.number; }
        if (this.Pokeball_caught != 21)
          return;
        Caught caught = new Caught();
        this.Health2.Value = 50;
        int num1 = (int) MyProject.Forms.Caught.ShowDialog((IWin32Window) this);
      }
      else
      {
        if (Conversions.ToDouble(MyProject.Forms.Data.PokeData.ToolTipText) > 0.0)
          return;
        this.Stick_left_Stance.Visible = true;
        int num = (int) Interaction.MsgBox((object) "You have no more Pokeballs to throw!", MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.YesNo, (object) "Oops!");
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      this.number = new Random().Next(1, 5);
      if (this.number == 1)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(1, 8);
        if (checked (this.Energy2.Value - 2) <= -1)
        {
          this.Energy2.Value = 25;
          this.Health1.Value = this.Health1.Value;
        }
        else
        {
          if (checked (this.Energy2.Value - 2) < 1)
            return;
          checked { this.Energy2.Value -= 2; }
          if (checked (this.Health1.Value - this.number) <= 0)
          {
            this.HP_checker.Interval = 10;
            this.HP_checker.Enabled = true;
            checked { this.Health1.Value -= this.Health1.Value; }
            int num = (int) MyProject.Forms.Lose.ShowDialog((IWin32Window) this);
          }
          else if (checked (this.Health1.Value - this.number) >= 1)
            checked { this.Health1.Value -= this.number; }
          this.Stick_Left_Kick.Visible = false;
          this.Stick_left_Superpunch.Visible = false;
          this.Stick_left_Stance.Visible = false;
          this.Stick_left_Superkick.Visible = false;
          this.Stick_left_Fireball.Visible = false;
          this.Stick_Left_Punch.Visible = true;
        }
      }
      else if (this.number == 2)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(1, 8);
        if (checked (this.Energy2.Value - 2) <= -1)
        {
          this.Energy2.Value = 25;
          this.Health1.Value = this.Health1.Value;
        }
        else
        {
          if (checked (this.Energy2.Value - 2) < 1)
            return;
          checked { this.Energy2.Value -= 2; }
          if (checked (this.Health1.Value - this.number) <= 0)
          {
            this.HP_checker.Interval = 10;
            this.HP_checker.Enabled = true;
            checked { this.Health1.Value -= this.Health1.Value; }
            int num = (int) MyProject.Forms.Lose.ShowDialog((IWin32Window) this);
          }
          else if (checked (this.Health1.Value - this.number) >= 1)
            checked { this.Health1.Value -= this.number; }
          this.Stick_Left_Kick.Visible = true;
          this.Stick_left_Superpunch.Visible = false;
          this.Stick_left_Stance.Visible = false;
          this.Stick_left_Superkick.Visible = false;
          this.Stick_left_Fireball.Visible = false;
          this.Stick_Left_Punch.Visible = false;
        }
      }
      else if (this.number == 3)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(10, 11);
        if (checked (this.Energy2.Value - 10) <= -1)
        {
          this.Energy2.Value = 25;
          this.Health1.Value = this.Health1.Value;
        }
        else
        {
          if (checked (this.Energy2.Value - 10) < 1)
            return;
          checked { this.Energy2.Value -= 10; }
          if (checked (this.Health1.Value - this.number) <= 0)
          {
            this.HP_checker.Interval = 10;
            this.HP_checker.Enabled = true;
            checked { this.Health1.Value -= this.Health1.Value; }
            int num = (int) MyProject.Forms.Lose.ShowDialog((IWin32Window) this);
          }
          else if (checked (this.Health1.Value - this.number) >= 1)
            checked { this.Health1.Value -= this.number; }
          this.Stick_Left_Kick.Visible = false;
          this.Stick_left_Superpunch.Visible = true;
          this.Stick_left_Stance.Visible = false;
          this.Stick_left_Superkick.Visible = false;
          this.Stick_left_Fireball.Visible = false;
          this.Stick_Left_Punch.Visible = false;
        }
      }
      else if (this.number == 4)
      {
        this.rnd = new Random();
        this.number = this.rnd.Next(11, 12);
        if (checked (this.Energy2.Value - 15) <= -1)
        {
          this.Energy2.Value = 25;
          this.Health1.Value = this.Health1.Value;
        }
        else
        {
          if (checked (this.Energy2.Value - 15) < 1)
            return;
          checked { this.Energy2.Value -= 15; }
          if (checked (this.Health1.Value - this.number) <= 0)
          {
            this.HP_checker.Interval = 10;
            this.HP_checker.Enabled = true;
            checked { this.Health1.Value -= this.Health1.Value; }
            int num = (int) MyProject.Forms.Lose.ShowDialog((IWin32Window) this);
          }
          else if (checked (this.Health1.Value - this.number) >= 1)
            checked { this.Health1.Value -= this.number; }
          this.Stick_Left_Kick.Visible = false;
          this.Stick_left_Superpunch.Visible = false;
          this.Stick_left_Stance.Visible = false;
          this.Stick_left_Superkick.Visible = true;
          this.Stick_left_Fireball.Visible = false;
          this.Stick_Left_Punch.Visible = false;
        }
      }
      else
      {
        if (this.number != 5)
          return;
        this.rnd = new Random();
        this.number = this.rnd.Next(13, 14);
        if (checked (this.Energy2.Value - 20) <= -1)
        {
          this.Energy2.Value = 25;
          this.Health1.Value = this.Health1.Value;
        }
        else if (checked (this.Energy2.Value - 20) >= 1)
        {
          checked { this.Energy2.Value -= 20; }
          if (checked (this.Health1.Value - this.number) <= 0)
          {
            this.HP_checker.Interval = 10;
            this.HP_checker.Enabled = true;
            checked { this.Health1.Value -= this.Health1.Value; }
            int num = (int) MyProject.Forms.Lose.ShowDialog((IWin32Window) this);
          }
          else if (checked (this.Health1.Value - this.number) >= 1)
            checked { this.Health1.Value -= this.number; }
          this.Stick_Left_Kick.Visible = false;
          this.Stick_left_Superpunch.Visible = false;
          this.Stick_left_Stance.Visible = false;
          this.Stick_left_Superkick.Visible = false;
          this.Stick_left_Fireball.Visible = true;
          this.Stick_Left_Punch.Visible = false;
        }
        if (checked (this.Health1.Value - this.number) <= 0)
        {
          this.HP_checker.Interval = 10;
          this.HP_checker.Enabled = true;
          checked { this.Health1.Value -= this.Health1.Value; }
          int num = (int) MyProject.Forms.Lose.ShowDialog((IWin32Window) this);
        }
        else
        {
          if (checked (this.Health1.Value - this.number) < 1)
            return;
          checked { this.Health1.Value -= this.number; }
        }
      }
    }

    private void HP_checker_Tick(object sender, EventArgs e)
    {
      if (this.Health1.Value == 0)
        this.Op_Attack.Enabled = false;
      if (this.Health2.Value != 0)
        return;
      this.Op_Attack.Enabled = false;
    }
  }
}
