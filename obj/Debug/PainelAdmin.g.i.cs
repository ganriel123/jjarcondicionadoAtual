﻿#pragma checksum "..\..\PainelAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B47ABCEB22191B926EB2740DCE1465F4B7B37ACBB36A582A8A5E0C91D877DBC"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace JJ_ArCondicionado_Jailton {
    
    
    /// <summary>
    /// PainelAdmin
    /// </summary>
    public partial class PainelAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal JJ_ArCondicionado_Jailton.PainelAdmin PainelAdmin;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCampoPesquisa;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListContatos;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListInfo;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CadastrarAgendamentos;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem PesquisarManutencoes;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RealizarOrcamentos;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\PainelAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RegistrarHospedagem;
        
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
            System.Uri resourceLocater = new System.Uri("/JJ ArCondicionado Jailton;component/paineladmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PainelAdmin.xaml"
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
            this.PainelAdmin = ((JJ_ArCondicionado_Jailton.PainelAdmin)(target));
            return;
            case 2:
            this.TxtCampoPesquisa = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\PainelAdmin.xaml"
            this.TxtCampoPesquisa.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtCampoPesquisa_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListContatos = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.ListInfo = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.CadastrarAgendamentos = ((System.Windows.Controls.MenuItem)(target));
            
            #line 173 "..\..\PainelAdmin.xaml"
            this.CadastrarAgendamentos.Click += new System.Windows.RoutedEventHandler(this.CadastrarAgendamentos_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PesquisarManutencoes = ((System.Windows.Controls.MenuItem)(target));
            
            #line 183 "..\..\PainelAdmin.xaml"
            this.PesquisarManutencoes.Click += new System.Windows.RoutedEventHandler(this.PesquisarManutencoes_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RealizarOrcamentos = ((System.Windows.Controls.MenuItem)(target));
            
            #line 184 "..\..\PainelAdmin.xaml"
            this.RealizarOrcamentos.Click += new System.Windows.RoutedEventHandler(this.RealizarOrcamentos_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RegistrarHospedagem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 185 "..\..\PainelAdmin.xaml"
            this.RegistrarHospedagem.Click += new System.Windows.RoutedEventHandler(this.RegistrarHospedagem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

