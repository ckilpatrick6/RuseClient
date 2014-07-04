﻿#pragma checksum "..\..\..\Views\Player.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "61D41C314E1CFEAEBD30A4E3C53C5166"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Elysium;
using Elysium.Controls;
using Elysium.Converters;
using Framework.UI;
using Framework.UI.Commands;
using Framework.UI.Controls;
using Framework.UI.Converters;
using NodeGrooverClient.Helpers.Converters;
using NodeGrooverClient.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NodeGrooverClient.Views {
    
    
    /// <summary>
    /// Player
    /// </summary>
    public partial class Player : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrevButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar SongScrubber;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock songTimeBlock;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock songMaxBlock;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nowPlayingBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock artistBlock;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VolumeSlider;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VolumeLabel;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image albumArt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NodeGrooverClient;component/views/player.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Player.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PrevButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.SongScrubber = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.songTimeBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.songMaxBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.nowPlayingBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.artistBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.VolumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 48 "..\..\..\Views\Player.xaml"
            this.VolumeSlider.LostMouseCapture += new System.Windows.Input.MouseEventHandler(this.VolumeSlider_LostMouseCapture);
            
            #line default
            #line hidden
            return;
            case 10:
            this.VolumeLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.albumArt = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

