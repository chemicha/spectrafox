﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class rSpectroscopyTableViewer
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SpectroscopyManager.rSpectroscopyTableViewer", GetType(rSpectroscopyTableViewer).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to plot of %n files.
        '''</summary>
        Friend Shared ReadOnly Property InfobarTemplate_MultipleFiles() As String
            Get
                Return ResourceManager.GetString("InfobarTemplate_MultipleFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to %f.
        '''</summary>
        Friend Shared ReadOnly Property InfobarTemplate_SingleFile() As String
            Get
                Return ResourceManager.GetString("InfobarTemplate_SingleFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click to select a datapoint, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_DataPoint() As String
            Get
                Return ResourceManager.GetString("SelectionMode_DataPoint", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to point selection mode active, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_Else() As String
            Get
                Return ResourceManager.GetString("SelectionMode_Else", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click &amp; hold to select X-range, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_XRange() As String
            Get
                Return ResourceManager.GetString("SelectionMode_XRange", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click to select X-value, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_XValue() As String
            Get
                Return ResourceManager.GetString("SelectionMode_XValue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click &amp; hold to select XY-range, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_XYRange() As String
            Get
                Return ResourceManager.GetString("SelectionMode_XYRange", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click to select X-Y-point - ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_XYValue() As String
            Get
                Return ResourceManager.GetString("SelectionMode_XYValue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click &amp; hold to select Y-range, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_YRange() As String
            Get
                Return ResourceManager.GetString("SelectionMode_YRange", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click to select Y-value, ESC to cancel.
        '''</summary>
        Friend Shared ReadOnly Property SelectionMode_YValue() As String
            Get
                Return ResourceManager.GetString("SelectionMode_YValue", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to stack offset: %v.
        '''</summary>
        Friend Shared ReadOnly Property StackOffsetGraphInformation() As String
            Get
                Return ResourceManager.GetString("StackOffsetGraphInformation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to dx = %v.
        '''</summary>
        Friend Shared ReadOnly Property Tool_MeasureDistance_Result_DeltaX() As String
            Get
                Return ResourceManager.GetString("Tool_MeasureDistance_Result_DeltaX", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to dy = %v.
        '''</summary>
        Friend Shared ReadOnly Property Tool_MeasureDistance_Result_DeltaY() As String
            Get
                Return ResourceManager.GetString("Tool_MeasureDistance_Result_DeltaY", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
