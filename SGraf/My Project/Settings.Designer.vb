﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funzionalità di salvataggio automatico My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("prima riga intestazione")>  _
        Public Property intestazione1() As String
            Get
                Return CType(Me("intestazione1"),String)
            End Get
            Set
                Me("intestazione1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("seconda riga intestazione")>  _
        Public Property intestazione2() As String
            Get
                Return CType(Me("intestazione2"),String)
            End Get
            Set
                Me("intestazione2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("terza riga intestazione")>  _
        Public Property intestazione3() As String
            Get
                Return CType(Me("intestazione3"),String)
            End Get
            Set
                Me("intestazione3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Indagini relative a....")>  _
        Public Property oggetto() As String
            Get
                Return CType(Me("oggetto"),String)
            End Get
            Set
                Me("oggetto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Contiene fotografie di....")>  _
        Public Property contenutoDettaglio() As String
            Get
                Return CType(Me("contenutoDettaglio"),String)
            End Get
            Set
                Me("contenutoDettaglio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("cognome e nome autore")>  _
        Public Property autore() As String
            Get
                Return CType(Me("autore"),String)
            End Get
            Set
                Me("autore") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("comune")>  _
        Public Property luogo() As String
            Get
                Return CType(Me("luogo"),String)
            End Get
            Set
                Me("luogo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property gradoCognomeNome() As String
            Get
                Return CType(Me("gradoCognomeNome"),String)
            End Get
            Set
                Me("gradoCognomeNome") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("11")>  _
        Public Property carattereDimensioneBase() As String
            Get
                Return CType(Me("carattereDimensioneBase"),String)
            End Get
            Set
                Me("carattereDimensioneBase") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("IL COMANDANTE")>  _
        Public Property gruppoFirmaIRiga() As String
            Get
                Return CType(Me("gruppoFirmaIRiga"),String)
            End Get
            Set
                Me("gruppoFirmaIRiga") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property carattereDimensioneTitoloFoto() As String
            Get
                Return CType(Me("carattereDimensioneTitoloFoto"),String)
            End Get
            Set
                Me("carattereDimensioneTitoloFoto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Immagine nr.")>  _
        Public Property titoloFoto() As String
            Get
                Return CType(Me("titoloFoto"),String)
            End Get
            Set
                Me("titoloFoto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bIncorporaImmagini() As Boolean
            Get
                Return CType(Me("bIncorporaImmagini"),Boolean)
            End Get
            Set
                Me("bIncorporaImmagini") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property disposizioneColonne() As String
            Get
                Return CType(Me("disposizioneColonne"),String)
            End Get
            Set
                Me("disposizioneColonne") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property disposizioneRighe() As String
            Get
                Return CType(Me("disposizioneRighe"),String)
            End Get
            Set
                Me("disposizioneRighe") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("9")>  _
        Public Property carattereDimensioneDidascalia() As String
            Get
                Return CType(Me("carattereDimensioneDidascalia"),String)
            End Get
            Set
                Me("carattereDimensioneDidascalia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15")>  _
        Public Property fotoLarghezzaCM() As String
            Get
                Return CType(Me("fotoLarghezzaCM"),String)
            End Get
            Set
                Me("fotoLarghezzaCM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property fotoAltezzaCM() As String
            Get
                Return CType(Me("fotoAltezzaCM"),String)
            End Get
            Set
                Me("fotoAltezzaCM") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Identificazione")>  _
        Public Property tipoFascicolo() As String
            Get
                Return CType(Me("tipoFascicolo"),String)
            End Get
            Set
                Me("tipoFascicolo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property newVersion() As Boolean
            Get
                Return CType(Me("newVersion"),Boolean)
            End Get
            Set
                Me("newVersion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bMemorizzaDidascalia() As Boolean
            Get
                Return CType(Me("bMemorizzaDidascalia"),Boolean)
            End Get
            Set
                Me("bMemorizzaDidascalia") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property fotoAltezzaThumb() As String
            Get
                Return CType(Me("fotoAltezzaThumb"),String)
            End Get
            Set
                Me("fotoAltezzaThumb") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("315")>  _
        Public Property fotoLarghezzaThumb() As String
            Get
                Return CType(Me("fotoLarghezzaThumb"),String)
            End Get
            Set
                Me("fotoLarghezzaThumb") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFMarca() As Boolean
            Get
                Return CType(Me("bEXIFMarca"),Boolean)
            End Get
            Set
                Me("bEXIFMarca") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFModello() As Boolean
            Get
                Return CType(Me("bEXIFModello"),Boolean)
            End Get
            Set
                Me("bEXIFModello") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFEsposizione() As Boolean
            Get
                Return CType(Me("bEXIFEsposizione"),Boolean)
            End Get
            Set
                Me("bEXIFEsposizione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFDiaframma() As Boolean
            Get
                Return CType(Me("bEXIFDiaframma"),Boolean)
            End Get
            Set
                Me("bEXIFDiaframma") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFDataOra() As Boolean
            Get
                Return CType(Me("bEXIFDataOra"),Boolean)
            End Get
            Set
                Me("bEXIFDataOra") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFFlash() As Boolean
            Get
                Return CType(Me("bEXIFFlash"),Boolean)
            End Get
            Set
                Me("bEXIFFlash") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bEXIFISO() As Boolean
            Get
                Return CType(Me("bEXIFISO"),Boolean)
            End Get
            Set
                Me("bEXIFISO") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192, 255, 255")>  _
        Public Property coloreSelezione() As Global.System.Drawing.Color
            Get
                Return CType(Me("coloreSelezione"),Global.System.Drawing.Color)
            End Get
            Set
                Me("coloreSelezione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-40")>  _
        Public Property trasparenzaImmagine() As String
            Get
                Return CType(Me("trasparenzaImmagine"),String)
            End Get
            Set
                Me("trasparenzaImmagine") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property bNomeFile() As Boolean
            Get
                Return CType(Me("bNomeFile"),Boolean)
            End Get
            Set
                Me("bNomeFile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30")>  _
        Public Property zoomMiniaturaDefaultMenu() As String
            Get
                Return CType(Me("zoomMiniaturaDefaultMenu"),String)
            End Get
            Set
                Me("zoomMiniaturaDefaultMenu") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property zoomMiniaturaDefaultMouse() As String
            Get
                Return CType(Me("zoomMiniaturaDefaultMouse"),String)
            End Get
            Set
                Me("zoomMiniaturaDefaultMouse") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SGraf.My.MySettings
            Get
                Return Global.SGraf.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
