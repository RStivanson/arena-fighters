// Decompiled with JetBrains decompiler
// Type: ArenaFighters.My.MySettings
// Assembly: Arena Fighters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DC6B005-E91F-4E91-B085-E39357C10E21
// Assembly location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.exe
// XML documentation location: C:\Users\magni\Desktop\AF\Arena Fighters\Arena Fighters.xml

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ArenaFighters.My
{
  [CompilerGenerated]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerNonUserCode]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          Monitor.Enter(handlerLockObject);
          try
          {
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            Monitor.Exit(handlerLockObject);
          }
        }
        return MySettings.defaultInstance;
      }
    }

    [SpecialSetting(SpecialSetting.ConnectionString)]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Data Source=|DataDirectory|\\Database1.sdf")]
    [ApplicationScopedSetting]
    public string Database1ConnectionString => Conversions.ToString(this[nameof (Database1ConnectionString)]);
  }
}
