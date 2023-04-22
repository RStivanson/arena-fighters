// Decompiled with JetBrains decompiler
// Type: ArenaFighters.Data
// Assembly: Arena Fighters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC6B005-E91F-4E91-B085-E39357C10E21
// Assembly location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.exe
// XML documentation location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.xml

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ArenaFighters
{
  [DesignerGenerated]
  public class Data : Form
  {
    private IContainer components;
    [AccessedThroughProperty("MenuStrip1")]
    private MenuStrip _MenuStrip1;
    [AccessedThroughProperty("GoldToolStripMenuItem")]
    private ToolStripMenuItem _GoldToolStripMenuItem;
    [AccessedThroughProperty("GoldData")]
    private ToolStripMenuItem _GoldData;
    [AccessedThroughProperty("ExpDataa")]
    private ToolStripMenuItem _ExpDataa;
    [AccessedThroughProperty("ExpData")]
    private ToolStripMenuItem _ExpData;
    [AccessedThroughProperty("HP10ToolStripMenuItem")]
    private ToolStripMenuItem _HP10ToolStripMenuItem;
    [AccessedThroughProperty("HP10Data")]
    private ToolStripMenuItem _HP10Data;
    [AccessedThroughProperty("HP50ToolStripMenuItem")]
    private ToolStripMenuItem _HP50ToolStripMenuItem;
    [AccessedThroughProperty("HP50Data")]
    private ToolStripMenuItem _HP50Data;
    [AccessedThroughProperty("HP100ToolStripMenuItem")]
    private ToolStripMenuItem _HP100ToolStripMenuItem;
    [AccessedThroughProperty("HP100Data")]
    private ToolStripMenuItem _HP100Data;
    [AccessedThroughProperty("EP10Dataa")]
    private ToolStripMenuItem _EP10Dataa;
    [AccessedThroughProperty("EP10Data")]
    private ToolStripMenuItem _EP10Data;
    [AccessedThroughProperty("EP50Dataa")]
    private ToolStripMenuItem _EP50Dataa;
    [AccessedThroughProperty("EP50data")]
    private ToolStripMenuItem _EP50data;
    [AccessedThroughProperty("EP100Dataa")]
    private ToolStripMenuItem _EP100Dataa;
    [AccessedThroughProperty("EP100Data")]
    private ToolStripMenuItem _EP100Data;
    [AccessedThroughProperty("NukesData")]
    private ToolStripMenuItem _NukesData;
    [AccessedThroughProperty("NukeData")]
    private ToolStripMenuItem _NukeData;
    [AccessedThroughProperty("PokeballsToolStripMenuItem")]
    private ToolStripMenuItem _PokeballsToolStripMenuItem;
    [AccessedThroughProperty("PokeData")]
    private ToolStripMenuItem _PokeData;
    [AccessedThroughProperty("LevelDataa")]
    private ToolStripMenuItem _LevelDataa;
    [AccessedThroughProperty("LevelData")]
    private ToolStripMenuItem _LevelData;

    [DebuggerNonUserCode]
    public Data() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Data));
      this.MenuStrip1 = new MenuStrip();
      this.GoldToolStripMenuItem = new ToolStripMenuItem();
      this.GoldData = new ToolStripMenuItem();
      this.ExpDataa = new ToolStripMenuItem();
      this.ExpData = new ToolStripMenuItem();
      this.HP10ToolStripMenuItem = new ToolStripMenuItem();
      this.HP10Data = new ToolStripMenuItem();
      this.HP50ToolStripMenuItem = new ToolStripMenuItem();
      this.HP50Data = new ToolStripMenuItem();
      this.HP100ToolStripMenuItem = new ToolStripMenuItem();
      this.HP100Data = new ToolStripMenuItem();
      this.EP10Dataa = new ToolStripMenuItem();
      this.EP10Data = new ToolStripMenuItem();
      this.EP50Dataa = new ToolStripMenuItem();
      this.EP50data = new ToolStripMenuItem();
      this.EP100Dataa = new ToolStripMenuItem();
      this.EP100Data = new ToolStripMenuItem();
      this.NukesData = new ToolStripMenuItem();
      this.NukeData = new ToolStripMenuItem();
      this.PokeballsToolStripMenuItem = new ToolStripMenuItem();
      this.PokeData = new ToolStripMenuItem();
      this.LevelDataa = new ToolStripMenuItem();
      this.LevelData = new ToolStripMenuItem();
      this.MenuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.MenuStrip1.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.GoldToolStripMenuItem,
        (ToolStripItem) this.ExpDataa,
        (ToolStripItem) this.HP10ToolStripMenuItem,
        (ToolStripItem) this.HP50ToolStripMenuItem,
        (ToolStripItem) this.HP100ToolStripMenuItem,
        (ToolStripItem) this.EP10Dataa,
        (ToolStripItem) this.EP50Dataa,
        (ToolStripItem) this.EP100Dataa,
        (ToolStripItem) this.NukesData,
        (ToolStripItem) this.PokeballsToolStripMenuItem,
        (ToolStripItem) this.LevelDataa
      });
      this.MenuStrip1.Location = new Point(0, 0);
      this.MenuStrip1.Name = "MenuStrip1";
      MenuStrip menuStrip1 = this.MenuStrip1;
      Size size1 = new Size(662, 24);
      Size size2 = size1;
      menuStrip1.Size = size2;
      this.MenuStrip1.TabIndex = 0;
      this.MenuStrip1.Text = "MenuStrip1";
      this.GoldToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.GoldData
      });
      this.GoldToolStripMenuItem.Name = "GoldToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.GoldToolStripMenuItem;
      size1 = new Size(44, 20);
      Size size3 = size1;
      toolStripMenuItem1.Size = size3;
      this.GoldToolStripMenuItem.Text = "Gold";
      this.GoldData.Name = "GoldData";
      ToolStripMenuItem goldData = this.GoldData;
      size1 = new Size(99, 22);
      Size size4 = size1;
      goldData.Size = size4;
      this.GoldData.Text = "Gold";
      this.GoldData.ToolTipText = "20";
      this.ExpDataa.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ExpData
      });
      this.ExpDataa.Name = "ExpDataa";
      ToolStripMenuItem expDataa = this.ExpDataa;
      size1 = new Size(75, 20);
      Size size5 = size1;
      expDataa.Size = size5;
      this.ExpDataa.Text = "Experience";
      this.ExpData.Name = "ExpData";
      ToolStripMenuItem expData = this.ExpData;
      size1 = new Size(92, 22);
      Size size6 = size1;
      expData.Size = size6;
      this.ExpData.Text = "Exp";
      this.ExpData.ToolTipText = "1";
      this.HP10ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.HP10Data
      });
      this.HP10ToolStripMenuItem.Name = "HP10ToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem2 = this.HP10ToolStripMenuItem;
      size1 = new Size(47, 20);
      Size size7 = size1;
      toolStripMenuItem2.Size = size7;
      this.HP10ToolStripMenuItem.Text = "HP10";
      this.HP10Data.Name = "HP10Data";
      ToolStripMenuItem hp10Data = this.HP10Data;
      size1 = new Size(102, 22);
      Size size8 = size1;
      hp10Data.Size = size8;
      this.HP10Data.Text = "HP10";
      this.HP10Data.ToolTipText = "1";
      this.HP50ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.HP50Data
      });
      this.HP50ToolStripMenuItem.Name = "HP50ToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem3 = this.HP50ToolStripMenuItem;
      size1 = new Size(47, 20);
      Size size9 = size1;
      toolStripMenuItem3.Size = size9;
      this.HP50ToolStripMenuItem.Text = "HP50";
      this.HP50Data.Name = "HP50Data";
      ToolStripMenuItem hp50Data = this.HP50Data;
      size1 = new Size(102, 22);
      Size size10 = size1;
      hp50Data.Size = size10;
      this.HP50Data.Text = "HP50";
      this.HP50Data.ToolTipText = "0";
      this.HP100ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.HP100Data
      });
      this.HP100ToolStripMenuItem.Name = "HP100ToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem4 = this.HP100ToolStripMenuItem;
      size1 = new Size(53, 20);
      Size size11 = size1;
      toolStripMenuItem4.Size = size11;
      this.HP100ToolStripMenuItem.Text = "HP100";
      this.HP100Data.Name = "HP100Data";
      ToolStripMenuItem hp100Data = this.HP100Data;
      size1 = new Size(108, 22);
      Size size12 = size1;
      hp100Data.Size = size12;
      this.HP100Data.Text = "HP100";
      this.HP100Data.ToolTipText = "0";
      this.EP10Dataa.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.EP10Data
      });
      this.EP10Dataa.Name = "EP10Dataa";
      ToolStripMenuItem ep10Dataa = this.EP10Dataa;
      size1 = new Size(44, 20);
      Size size13 = size1;
      ep10Dataa.Size = size13;
      this.EP10Dataa.Text = "EP10";
      this.EP10Dataa.ToolTipText = "1";
      this.EP10Data.Name = "EP10Data";
      ToolStripMenuItem ep10Data = this.EP10Data;
      size1 = new Size(99, 22);
      Size size14 = size1;
      ep10Data.Size = size14;
      this.EP10Data.Text = "EP10";
      this.EP10Data.ToolTipText = "1";
      this.EP50Dataa.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.EP50data
      });
      this.EP50Dataa.Name = "EP50Dataa";
      ToolStripMenuItem ep50Dataa = this.EP50Dataa;
      size1 = new Size(44, 20);
      Size size15 = size1;
      ep50Dataa.Size = size15;
      this.EP50Dataa.Text = "EP50";
      this.EP50Dataa.ToolTipText = "0";
      this.EP50data.Name = "EP50data";
      ToolStripMenuItem ep50data = this.EP50data;
      size1 = new Size(99, 22);
      Size size16 = size1;
      ep50data.Size = size16;
      this.EP50data.Text = "EP50";
      this.EP50data.ToolTipText = "0";
      this.EP100Dataa.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.EP100Data
      });
      this.EP100Dataa.Name = "EP100Dataa";
      ToolStripMenuItem ep100Dataa = this.EP100Dataa;
      size1 = new Size(50, 20);
      Size size17 = size1;
      ep100Dataa.Size = size17;
      this.EP100Dataa.Text = "EP100";
      this.EP100Dataa.ToolTipText = "0";
      this.EP100Data.Name = "EP100Data";
      ToolStripMenuItem ep100Data = this.EP100Data;
      size1 = new Size(105, 22);
      Size size18 = size1;
      ep100Data.Size = size18;
      this.EP100Data.Text = "EP100";
      this.EP100Data.ToolTipText = "0";
      this.NukesData.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.NukeData
      });
      this.NukesData.Name = "NukesData";
      ToolStripMenuItem nukesData = this.NukesData;
      size1 = new Size(52, 20);
      Size size19 = size1;
      nukesData.Size = size19;
      this.NukesData.Text = "Nukes";
      this.NukeData.Name = "NukeData";
      ToolStripMenuItem nukeData = this.NukeData;
      size1 = new Size(102, 22);
      Size size20 = size1;
      nukeData.Size = size20;
      this.NukeData.Text = "Nuke";
      this.NukeData.ToolTipText = "0";
      this.PokeballsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.PokeData
      });
      this.PokeballsToolStripMenuItem.Name = "PokeballsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem5 = this.PokeballsToolStripMenuItem;
      size1 = new Size(69, 20);
      Size size21 = size1;
      toolStripMenuItem5.Size = size21;
      this.PokeballsToolStripMenuItem.Text = "Pokeballs";
      this.PokeData.Name = "PokeData";
      ToolStripMenuItem pokeData = this.PokeData;
      size1 = new Size(100, 22);
      Size size22 = size1;
      pokeData.Size = size22;
      this.PokeData.Text = "Poke";
      this.PokeData.ToolTipText = "0";
      this.LevelDataa.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.LevelData
      });
      this.LevelDataa.Name = "LevelDataa";
      ToolStripMenuItem levelDataa = this.LevelDataa;
      size1 = new Size(46, 20);
      Size size23 = size1;
      levelDataa.Size = size23;
      this.LevelDataa.Text = "Level";
      this.LevelData.Name = "LevelData";
      ToolStripMenuItem levelData = this.LevelData;
      size1 = new Size(98, 22);
      Size size24 = size1;
      levelData.Size = size24;
      this.LevelData.Text = "level";
      this.LevelData.ToolTipText = "0";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(662, 23);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.MenuStrip1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.MenuStrip1;
      this.Name = nameof (Data);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Data);
      this.MenuStrip1.ResumeLayout(false);
      this.MenuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual MenuStrip MenuStrip1
    {
      [DebuggerNonUserCode] get => this._MenuStrip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MenuStrip1 = value;
    }

    internal virtual ToolStripMenuItem GoldToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._GoldToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GoldToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem GoldData
    {
      [DebuggerNonUserCode] get => this._GoldData;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GoldData = value;
    }

    internal virtual ToolStripMenuItem ExpDataa
    {
      [DebuggerNonUserCode] get => this._ExpDataa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExpDataa = value;
    }

    internal virtual ToolStripMenuItem ExpData
    {
      [DebuggerNonUserCode] get => this._ExpData;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExpData = value;
    }

    internal virtual ToolStripMenuItem HP10ToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._HP10ToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP10ToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem HP10Data
    {
      [DebuggerNonUserCode] get => this._HP10Data;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP10Data = value;
    }

    internal virtual ToolStripMenuItem HP50ToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._HP50ToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP50ToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem HP50Data
    {
      [DebuggerNonUserCode] get => this._HP50Data;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP50Data = value;
    }

    internal virtual ToolStripMenuItem HP100ToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._HP100ToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP100ToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem HP100Data
    {
      [DebuggerNonUserCode] get => this._HP100Data;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HP100Data = value;
    }

    internal virtual ToolStripMenuItem EP10Dataa
    {
      [DebuggerNonUserCode] get => this._EP10Dataa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP10Dataa = value;
    }

    internal virtual ToolStripMenuItem EP10Data
    {
      [DebuggerNonUserCode] get => this._EP10Data;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP10Data = value;
    }

    internal virtual ToolStripMenuItem EP50Dataa
    {
      [DebuggerNonUserCode] get => this._EP50Dataa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP50Dataa = value;
    }

    internal virtual ToolStripMenuItem EP50data
    {
      [DebuggerNonUserCode] get => this._EP50data;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP50data = value;
    }

    internal virtual ToolStripMenuItem EP100Dataa
    {
      [DebuggerNonUserCode] get => this._EP100Dataa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP100Dataa = value;
    }

    internal virtual ToolStripMenuItem EP100Data
    {
      [DebuggerNonUserCode] get => this._EP100Data;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EP100Data = value;
    }

    internal virtual ToolStripMenuItem NukesData
    {
      [DebuggerNonUserCode] get => this._NukesData;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._NukesData = value;
    }

    internal virtual ToolStripMenuItem NukeData
    {
      [DebuggerNonUserCode] get => this._NukeData;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._NukeData = value;
    }

    internal virtual ToolStripMenuItem PokeballsToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._PokeballsToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PokeballsToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem PokeData
    {
      [DebuggerNonUserCode] get => this._PokeData;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PokeData = value;
    }

    internal virtual ToolStripMenuItem LevelDataa
    {
      [DebuggerNonUserCode] get => this._LevelDataa;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LevelDataa = value;
    }

    internal virtual ToolStripMenuItem LevelData
    {
      [DebuggerNonUserCode] get => this._LevelData;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LevelData = value;
    }
  }
}
