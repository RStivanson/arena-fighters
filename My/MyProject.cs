// Decompiled with JetBrains decompiler
// Type: ArenaFighters.My.MyProject
// Assembly: Arena Fighters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC6B005-E91F-4E91-B085-E39357C10E21
// Assembly location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.exe
// XML documentation location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ArenaFighters.My
{
  [StandardModule]
  [HideModuleName]
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [DebuggerNonUserCode]
    static MyProject()
    {
    }

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
      public About m_About;
      public Arena m_Arena;
      public Caught m_Caught;
      public Data m_Data;
      public Difficulty m_Difficulty;
      public Exit_Menu m_Exit_Menu;
      public Forfeit m_Forfeit;
      public Form1 m_Form1;
      public Inventory m_Inventory;
      public Lose m_Lose;
      public Market m_Market;
      public Outside m_Outside;
      public Win_easy m_Win_easy;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public About About
      {
        [DebuggerNonUserCode] get
        {
          this.m_About = MyProject.MyForms.Create__Instance__<About>(this.m_About);
          return this.m_About;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_About)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<About>(ref this.m_About);
        }
      }

      public Arena Arena
      {
        [DebuggerNonUserCode] get
        {
          this.m_Arena = MyProject.MyForms.Create__Instance__<Arena>(this.m_Arena);
          return this.m_Arena;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Arena)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Arena>(ref this.m_Arena);
        }
      }

      public Caught Caught
      {
        [DebuggerNonUserCode] get
        {
          this.m_Caught = MyProject.MyForms.Create__Instance__<Caught>(this.m_Caught);
          return this.m_Caught;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Caught)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Caught>(ref this.m_Caught);
        }
      }

      public Data Data
      {
        [DebuggerNonUserCode] get
        {
          this.m_Data = MyProject.MyForms.Create__Instance__<Data>(this.m_Data);
          return this.m_Data;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Data)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Data>(ref this.m_Data);
        }
      }

      public Difficulty Difficulty
      {
        [DebuggerNonUserCode] get
        {
          this.m_Difficulty = MyProject.MyForms.Create__Instance__<Difficulty>(this.m_Difficulty);
          return this.m_Difficulty;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Difficulty)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Difficulty>(ref this.m_Difficulty);
        }
      }

      public Exit_Menu Exit_Menu
      {
        [DebuggerNonUserCode] get
        {
          this.m_Exit_Menu = MyProject.MyForms.Create__Instance__<Exit_Menu>(this.m_Exit_Menu);
          return this.m_Exit_Menu;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Exit_Menu)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Exit_Menu>(ref this.m_Exit_Menu);
        }
      }

      public Forfeit Forfeit
      {
        [DebuggerNonUserCode] get
        {
          this.m_Forfeit = MyProject.MyForms.Create__Instance__<Forfeit>(this.m_Forfeit);
          return this.m_Forfeit;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Forfeit)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Forfeit>(ref this.m_Forfeit);
        }
      }

      public Form1 Form1
      {
        [DebuggerNonUserCode] get
        {
          this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
          return this.m_Form1;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Form1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form1>(ref this.m_Form1);
        }
      }

      public Inventory Inventory
      {
        [DebuggerNonUserCode] get
        {
          this.m_Inventory = MyProject.MyForms.Create__Instance__<Inventory>(this.m_Inventory);
          return this.m_Inventory;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Inventory)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Inventory>(ref this.m_Inventory);
        }
      }

      public Lose Lose
      {
        [DebuggerNonUserCode] get
        {
          this.m_Lose = MyProject.MyForms.Create__Instance__<Lose>(this.m_Lose);
          return this.m_Lose;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Lose)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Lose>(ref this.m_Lose);
        }
      }

      public Market Market
      {
        [DebuggerNonUserCode] get
        {
          this.m_Market = MyProject.MyForms.Create__Instance__<Market>(this.m_Market);
          return this.m_Market;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Market)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Market>(ref this.m_Market);
        }
      }

      public Outside Outside
      {
        [DebuggerNonUserCode] get
        {
          this.m_Outside = MyProject.MyForms.Create__Instance__<Outside>(this.m_Outside);
          return this.m_Outside;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Outside)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Outside>(ref this.m_Outside);
        }
      }

      public Win_easy Win_easy
      {
        [DebuggerNonUserCode] get
        {
          this.m_Win_easy = MyProject.MyForms.Create__Instance__<Win_easy>(this.m_Win_easy);
          return this.m_Win_easy;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Win_easy)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Win_easy>(ref this.m_Win_easy);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new System.Type GetType() => typeof (MyProject.MyWebServices);

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
