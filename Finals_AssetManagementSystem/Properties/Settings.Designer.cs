﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finals_AssetManagementSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=CAHRLOS-ASUS1\\MSSQLSERVER01;Initial Catalog=\"Asset Management System\"" +
            ";Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True")]
        public string Asset_Management_SystemConnectionString {
            get {
                return ((string)(this["Asset_Management_SystemConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-J6LAVJTP\\SQLEXPRESS;Initial Catalog=MAS;Integrated Security=Tr" +
            "ue;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True")]
        public string MASConnectionString {
            get {
                return ((string)(this["MASConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-J6LAVJTP\\SQLEXPRESS;Initial Catalog=MAS;Integrated Security=Tr" +
            "ue;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True")]
        public string MASConnectionString1 {
            get {
                return ((string)(this["MASConnectionString1"]));
            }
        }
    }
}
