﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kEditor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastFilePath {
            get {
                return ((string)(this["LastFilePath"]));
            }
            set {
                this["LastFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RecentFiles {
            get {
                return ((string)(this["RecentFiles"]));
            }
            set {
                this["RecentFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahmoa")]
        public string DefaultFontName {
            get {
                return ((string)(this["DefaultFontName"]));
            }
            set {
                this["DefaultFontName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public float DefaultFontSize {
            get {
                return ((float)(this["DefaultFontSize"]));
            }
            set {
                this["DefaultFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("32")]
        public int GlyphRangeFirst {
            get {
                return ((int)(this["GlyphRangeFirst"]));
            }
            set {
                this["GlyphRangeFirst"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("62")]
        public int GlyphRangeLength {
            get {
                return ((int)(this["GlyphRangeLength"]));
            }
            set {
                this["GlyphRangeLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool forceDefaultEditor {
            get {
                return ((bool)(this["forceDefaultEditor"]));
            }
            set {
                this["forceDefaultEditor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<Styles>
  <Style index=""1"" fontName=""Segoe UI"" fontSize=""8""
  foreColor=""FF2D2DFF"" backColor=""FFFFFFFF"" bold=""False""
  italic=""False"" />
  <Style index=""4"" fontName=""Segoe UI"" fontSize=""8""
  foreColor=""FF2D2DFF"" backColor=""FFFFFFFF"" bold=""False""
  italic=""False"" />
  <Style index=""5"" fontName=""Verdana"" fontSize=""8""
  foreColor=""FF1E90FF"" backColor=""FFFFFFFF"" bold=""False""
  italic=""False"" />
  <Style index=""6"" fontName=""Verdana"" fontSize=""8""
  foreColor=""FFFF7F50"" backColor=""FFFFFFFF"" bold=""False""
  italic=""False"" />
  <Style index=""7"" fontName=""Arial"" fontSize=""8"" foreColor=""C4""
  backColor=""FFFFFFFF"" bold=""False"" italic=""False"" />
  <Style index=""8"" fontName=""Arial"" fontSize=""8"" foreColor=""C4""
  backColor=""FFFFFFFF"" bold=""False"" italic=""True"" />
  <Style index=""11"" fontName=""Verdana"" fontSize=""8""
  foreColor=""80C0"" backColor=""FFFFFFFF"" bold=""False""
  italic=""False"" />
  <Style index=""12"" fontName=""Verdana"" fontSize=""8""
  foreColor=""FF008000"" backColor=""FFFFFFFF"" bold=""False""
  italic=""True"" />
  <Style index=""13"" fontName=""Verdana"" fontSize=""8""
  foreColor=""FF008000"" backColor=""FFFFFFFF"" bold=""False""
  italic=""True"" />
  <Style index=""15"" fontName=""Verdana"" fontSize=""8""
  foreColor=""FF8000"" backColor=""FFFFFFFF"" bold=""False""
  italic=""False"" />
</Styles>")]
        public string StyleConfig {
            get {
                return ((string)(this["StyleConfig"]));
            }
            set {
                this["StyleConfig"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LineNumber {
            get {
                return ((bool)(this["LineNumber"]));
            }
            set {
                this["LineNumber"] = value;
            }
        }
    }
}