﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoBoundaries.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NoBoundaries.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap bkg {
            get {
                object obj = ResourceManager.GetObject("bkg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap bkg_btnStart {
            get {
                object obj = ResourceManager.GetObject("bkg_btnStart", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap bkg_State {
            get {
                object obj = ResourceManager.GetObject("bkg_State", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap close_down {
            get {
                object obj = ResourceManager.GetObject("close_down", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap close_enter {
            get {
                object obj = ResourceManager.GetObject("close_enter", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap close_normal {
            get {
                object obj = ResourceManager.GetObject("close_normal", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 cd /d %~dp0
        ///rundll32.exe cmroute.dll,SetRoutes /STATIC_FILE_NAME routetmp.txt /DONT_REQUIRE_URL /IPHLPAPI_ACCESS_DENIED_OK 的本地化字符串。
        /// </summary>
        internal static string CMD {
            get {
                return ResourceManager.GetString("CMD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] cmroute {
            get {
                object obj = ResourceManager.GetObject("cmroute", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap delete {
            get {
                object obj = ResourceManager.GetObject("delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 @echo off
        ///&gt;nul 2&gt;&amp;1 &quot;%SYSTEMROOT%\system32\cacls.exe&quot; &quot;%SYSTEMROOT%\system32\config\system&quot;
        ///if &apos;%errorlevel%&apos; EQU &apos;5&apos; (
        ///goto UACPrompt
        ///) else ( goto gotAdmin )
        ///:UACPrompt
        ///echo Set UAC = CreateObject^(&quot;Shell.Application&quot;^) &gt; &quot;%temp%\getadmin.vbs&quot;
        ///echo UAC.ShellExecute &quot;%~s0&quot;, &quot;&quot;, &quot;&quot;, &quot;runas&quot;, 1 &gt;&gt; &quot;%temp%\getadmin.vbs&quot;
        ///&quot;%temp%\getadmin.vbs&quot;
        ///exit /B
        ///:gotAdmin
        ///if exist &quot;%temp%\getadmin.vbs&quot; ( del &quot;%temp%\getadmin.vbs&quot; )
        ///pushd &quot;%CD%&quot;
        ///CD /D &quot;%~dp0&quot;
        ///rem Execute.bat
        /// 的本地化字符串。
        /// </summary>
        internal static string Elevation {
            get {
                return ResourceManager.GetString("Elevation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 @echo off
        ///if exist &quot;%SystemRoot%\SysWOW64&quot; path %path%;%windir%\SysNative;%SystemRoot%\SysWOW64;%~dp0
        ///bcdedit &gt;nul
        ///if &apos;%errorlevel%&apos; NEQ &apos;0&apos; (goto UACPrompt) else (goto UACAdmin)
        ///:UACPrompt
        ///%1 start &quot;&quot; mshta vbscript:createobject(&quot;shell.application&quot;).shellexecute(&quot;&quot;&quot;%~0&quot;&quot;&quot;,&quot;::&quot;,,&quot;runas&quot;,1)(window.close)&amp;exit
        ///exit /B
        ///:UACAdmin
        ///cd /d &quot;%~dp0&quot;
        ///cd /d %~dp0
        ///rundll32.exe cmroute.dll,SetRoutes /STATIC_FILE_NAME routetmp.txt /DONT_REQUIRE_URL /IPHLPAPI_ACCESS_DENIED_OK 的本地化字符串。
        /// </summary>
        internal static string Execute {
            get {
                return ResourceManager.GetString("Execute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap hide_down {
            get {
                object obj = ResourceManager.GetObject("hide_down", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap hide_enter {
            get {
                object obj = ResourceManager.GetObject("hide_enter", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap hide_normal {
            get {
                object obj = ResourceManager.GetObject("hide_normal", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Logo1 {
            get {
                object obj = ResourceManager.GetObject("Logo1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap menu_down {
            get {
                object obj = ResourceManager.GetObject("menu_down", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap menu_enter {
            get {
                object obj = ResourceManager.GetObject("menu_enter", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap menu_normal {
            get {
                object obj = ResourceManager.GetObject("menu_normal", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap net_Green {
            get {
                object obj = ResourceManager.GetObject("net_Green", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap panel_menu_about {
            get {
                object obj = ResourceManager.GetObject("panel_menu_about", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap panel_menu_loginout {
            get {
                object obj = ResourceManager.GetObject("panel_menu_loginout", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap panel_menu_repair {
            get {
                object obj = ResourceManager.GetObject("panel_menu_repair", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap panel_menu_set {
            get {
                object obj = ResourceManager.GetObject("panel_menu_set", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap panel_menu_update {
            get {
                object obj = ResourceManager.GetObject("panel_menu_update", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon 游戏 {
            get {
                object obj = ResourceManager.GetObject("游戏", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
