﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOutdated.Core.Resources {
    using System;
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidationErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOutdated.Core.Resources.ValidationErrorMessages", typeof(ValidationErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Specify which project file to use because the directory &apos;{0}&apos; contains more than one..
        /// </summary>
        internal static string DirectoryContainsMultipleProjects {
            get {
                return ResourceManager.GetString("DirectoryContainsMultipleProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify which solution file to use because the directory &apos;{0}&apos; contains more than one..
        /// </summary>
        internal static string DirectoryContainsMultipleSolutions {
            get {
                return ResourceManager.GetString("DirectoryContainsMultipleSolutions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory &apos;{0}&apos; does not contain any solutions or projects..
        /// </summary>
        internal static string DirectoryDoesNotContainSolutionsOrProjects {
            get {
                return ResourceManager.GetString("DirectoryDoesNotContainSolutionsOrProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory or file &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string DirectoryOrFileDoesNotExist {
            get {
                return ResourceManager.GetString("DirectoryOrFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; is not a valid solution or project..
        /// </summary>
        internal static string FileNotAValidSolutionOrProject {
            get {
                return ResourceManager.GetString("FileNotAValidSolutionOrProject", resourceCulture);
            }
        }
    }
}
