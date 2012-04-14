﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vim.UI.Wpf.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vim.UI.Wpf.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to External edit detected (hit &lt;ESC&gt;to return to Insert mode).
        /// </summary>
        internal static string ExternalEditBanner {
            get {
                return ResourceManager.GetString("ExternalEditBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- INSERT --.
        /// </summary>
        internal static string InsertBanner {
            get {
                return ResourceManager.GetString("InsertBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- ({0}) --.
        /// </summary>
        internal static string NormalOneTimeCommandBanner {
            get {
                return ResourceManager.GetString("NormalOneTimeCommandBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- REPLACE --.
        /// </summary>
        internal static string ReplaceBanner {
            get {
                return ResourceManager.GetString("ReplaceBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- SELECT --.
        /// </summary>
        internal static string SelectBanner {
            get {
                return ResourceManager.GetString("SelectBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to replace with {0} (y/n/a/q/l/^E/^Y)?.
        /// </summary>
        internal static string SubstituteConfirmBannerFormat {
            get {
                return ResourceManager.GetString("SubstituteConfirmBannerFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- VISUAL BLOCK --.
        /// </summary>
        internal static string VisualBlockBanner {
            get {
                return ResourceManager.GetString("VisualBlockBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- ({0}) VISUAL BLOCK --.
        /// </summary>
        internal static string VisualBlockOneTimeCommandBanner {
            get {
                return ResourceManager.GetString("VisualBlockOneTimeCommandBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- VISUAL --.
        /// </summary>
        internal static string VisualCharacterBanner {
            get {
                return ResourceManager.GetString("VisualCharacterBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- ({0}) VISUAL --.
        /// </summary>
        internal static string VisualCharacterOneTimeCommandBanner {
            get {
                return ResourceManager.GetString("VisualCharacterOneTimeCommandBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- VISUAL LINE--.
        /// </summary>
        internal static string VisualLineBanner {
            get {
                return ResourceManager.GetString("VisualLineBanner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- ({0}) VISUAL LINE --.
        /// </summary>
        internal static string VisualLineOneTimeCommandBanner {
            get {
                return ResourceManager.GetString("VisualLineOneTimeCommandBanner", resourceCulture);
            }
        }
    }
}
