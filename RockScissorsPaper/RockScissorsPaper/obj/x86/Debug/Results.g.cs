﻿#pragma checksum "C:\Users\Bigre\OneDrive\Workspace\GMIT\Y2\RockScissorsPaper\RockScissorsPaper\Results.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7012FA5D8C2D7B6E174C79AED6036418"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RockScissorsPaper
{
    partial class Results : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ResultLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.ResultsTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.Return = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\Results.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Return).Click += this.Return_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

