﻿#pragma checksum "C:\Users\huong\Documents\Visual Studio 2017\Projects\BindData\WeatherSplitview\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "26EFF167DA35DA0DC1A01B3C62F57B2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherSplitview
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 50
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.ListBox element3 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)element3).SelectionChanged += this.ListBox_SelectionChanged;
                }
                break;
            case 4: // MainPage.xaml line 58
                {
                    this.WeatherOne = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 68
                {
                    this.WeatherFive = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 81
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 7: // MainPage.xaml line 17
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                }
                break;
            case 8: // MainPage.xaml line 26
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                }
                break;
            case 9: // MainPage.xaml line 34
                {
                    this.TitleTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // MainPage.xaml line 41
                {
                    this.SearchAutoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.SearchAutoSuggestBox).TextChanged += this.SearchAutoSuggestBox_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.SearchAutoSuggestBox).QuerySubmitted += this.SearchAutoSuggestBox_QuerySubmitted;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

