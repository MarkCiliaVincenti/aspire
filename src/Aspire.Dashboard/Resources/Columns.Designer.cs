﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aspire.Dashboard.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Columns {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Columns() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aspire.Dashboard.Resources.Columns", typeof(Columns).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None.
        /// </summary>
        public static string EndpointsColumnDisplayNone {
            get {
                return ResourceManager.GetString("EndpointsColumnDisplayNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting....
        /// </summary>
        public static string EndpointsColumnDisplayPlaceholder {
            get {
                return ResourceManager.GetString("EndpointsColumnDisplayPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container ID: {0}.
        /// </summary>
        public static string ResourceNameDisplayContainerIdText {
            get {
                return ResourceManager.GetString("ResourceNameDisplayContainerIdText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy container ID to clipboard.
        /// </summary>
        public static string ResourceNameDisplayCopyContainerIdText {
            get {
                return ResourceManager.GetString("ResourceNameDisplayCopyContainerIdText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process ID: {0}.
        /// </summary>
        public static string ResourceNameDisplayProcessIdText {
            get {
                return ResourceManager.GetString("ResourceNameDisplayProcessIdText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container args.
        /// </summary>
        public static string SourceColumnDisplayContainerArgsTitle {
            get {
                return ResourceManager.GetString("SourceColumnDisplayContainerArgsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command: {0}.
        /// </summary>
        public static string SourceColumnDisplayContainerCommand {
            get {
                return ResourceManager.GetString("SourceColumnDisplayContainerCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container command.
        /// </summary>
        public static string SourceColumnDisplayContainerCommandTitle {
            get {
                return ResourceManager.GetString("SourceColumnDisplayContainerCommandTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port: {0}.
        /// </summary>
        public static string SourceColumnDisplayPort {
            get {
                return ResourceManager.GetString("SourceColumnDisplayPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ports: {0}.
        /// </summary>
        public static string SourceColumnDisplayPorts {
            get {
                return ResourceManager.GetString("SourceColumnDisplayPorts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Working directory: {0}.
        /// </summary>
        public static string SourceColumnDisplayWorkingDirectory {
            get {
                return ResourceManager.GetString("SourceColumnDisplayWorkingDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy image name and tag to clipboard.
        /// </summary>
        public static string SourceColumnSourceCopyContainerToClipboard {
            get {
                return ResourceManager.GetString("SourceColumnSourceCopyContainerToClipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy file path to clipboard.
        /// </summary>
        public static string SourceColumnSourceCopyFullPathToClipboard {
            get {
                return ResourceManager.GetString("SourceColumnSourceCopyFullPathToClipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is no longer running.
        /// </summary>
        public static string StateColumnResourceExited {
            get {
                return ResourceManager.GetString("StateColumnResourceExited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} exited unexpectedly with exit code {1}.
        /// </summary>
        public static string StateColumnResourceExitedUnexpectedly {
            get {
                return ResourceManager.GetString("StateColumnResourceExitedUnexpectedly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} error log.
        /// </summary>
        public static string UnreadLogErrorsBadgeErrorLog {
            get {
                return ResourceManager.GetString("UnreadLogErrorsBadgeErrorLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} error logs.
        /// </summary>
        public static string UnreadLogErrorsBadgeErrorLogs {
            get {
                return ResourceManager.GetString("UnreadLogErrorsBadgeErrorLogs", resourceCulture);
            }
        }
    }
}
