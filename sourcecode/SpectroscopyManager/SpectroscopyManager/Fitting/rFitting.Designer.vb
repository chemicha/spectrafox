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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class rFitting
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SpectroscopyManager.rFitting", GetType(rFitting).Assembly)
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
        '''  Looks up a localized string similar to combined fit-data.
        '''</summary>
        Friend Shared ReadOnly Property CombinedFitColumnName() As String
            Get
                Return ResourceManager.GetString("CombinedFitColumnName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ....
        '''</summary>
        Friend Shared ReadOnly Property dummy() As String
            Get
                Return ResourceManager.GetString("dummy", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to export complete.
        '''</summary>
        Friend Shared ReadOnly Property ExportComplete() As String
            Get
                Return ResourceManager.GetString("ExportComplete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An export is currently running. Please wait until it is complete..
        '''</summary>
        Friend Shared ReadOnly Property ExportRunning_PleaseWaitWithWindowClose() As String
            Get
                Return ResourceManager.GetString("ExportRunning_PleaseWaitWithWindowClose", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to #t - calculated Chi2 &gt;&gt; #d &lt;&lt;.
        '''</summary>
        Friend Shared ReadOnly Property FitEcho_CalculatedChi2() As String
            Get
                Return ResourceManager.GetString("FitEcho_CalculatedChi2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Should the output of the previous fit be cleared in advance?.
        '''</summary>
        Friend Shared ReadOnly Property FitEcho_ReallyClearFitEcho() As String
            Get
                Return ResourceManager.GetString("FitEcho_ReallyClearFitEcho", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Clear Fit-Log?.
        '''</summary>
        Friend Shared ReadOnly Property FitEcho_ReallyClearFitEcho_Title() As String
            Get
                Return ResourceManager.GetString("FitEcho_ReallyClearFitEcho_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The export failed:
        '''.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_Error_Export() As String
            Get
                Return ResourceManager.GetString("FitModelExport_Error_Export", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The import failed:
        '''.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_Error_Import() As String
            Get
                Return ResourceManager.GetString("FitModelExport_Error_Import", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_Error_Title() As String
            Get
                Return ResourceManager.GetString("FitModelExport_Error_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Export finished!.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_Export_Success() As String
            Get
                Return ResourceManager.GetString("FitModelExport_Export_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save fit-models as ....
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_ExportWindowTitle() As String
            Get
                Return ResourceManager.GetString("FitModelExport_ExportWindowTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .fmxm.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_FileExtension_MultipleData() As String
            Get
                Return ResourceManager.GetString("FitModelExport_FileExtension_MultipleData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .fmx.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_FileExtension_SingleData() As String
            Get
                Return ResourceManager.GetString("FitModelExport_FileExtension_SingleData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to fit model export file (multiple data sets).
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_FileExtensionDescription_MultipleData() As String
            Get
                Return ResourceManager.GetString("FitModelExport_FileExtensionDescription_MultipleData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to fit model export file (single data set).
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_FileExtensionDescription_SingleData() As String
            Get
                Return ResourceManager.GetString("FitModelExport_FileExtensionDescription_SingleData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Import finished!.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_Import_Success() As String
            Get
                Return ResourceManager.GetString("FitModelExport_Import_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Load fit-models from ....
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_ImportWindowTitle() As String
            Get
                Return ResourceManager.GetString("FitModelExport_ImportWindowTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Success.
        '''</summary>
        Friend Shared ReadOnly Property FitModelExport_Success_Title() As String
            Get
                Return ResourceManager.GetString("FitModelExport_Success_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A fit is currently running. Please cancel it, or wait until it is complete..
        '''</summary>
        Friend Shared ReadOnly Property FitRunning_PleaseWaitWithWindowClose() As String
            Get
                Return ResourceManager.GetString("FitRunning_PleaseWaitWithWindowClose", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Window cannot be closed!.
        '''</summary>
        Friend Shared ReadOnly Property FitRunning_PleaseWaitWithWindowClose_Title() As String
            Get
                Return ResourceManager.GetString("FitRunning_PleaseWaitWithWindowClose_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to greating combined fit-model-data ....
        '''</summary>
        Friend Shared ReadOnly Property FitSaving_GeneratingCombinedData() As String
            Get
                Return ResourceManager.GetString("FitSaving_GeneratingCombinedData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to greating individual fit-model-data ....
        '''</summary>
        Friend Shared ReadOnly Property FitSaving_GeneratingIndividualData() As String
            Get
                Return ResourceManager.GetString("FitSaving_GeneratingIndividualData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cancel Fit.
        '''</summary>
        Friend Shared ReadOnly Property Fitting_CancelFit() As String
            Get
                Return ResourceManager.GetString("Fitting_CancelFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cancellation pending ....
        '''</summary>
        Friend Shared ReadOnly Property Fitting_CancellationPending() As String
            Get
                Return ResourceManager.GetString("Fitting_CancellationPending", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A fit is currently running!.
        '''</summary>
        Friend Shared ReadOnly Property Fitting_FitRunning() As String
            Get
                Return ResourceManager.GetString("Fitting_FitRunning", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A fit is currently running!
        '''Please wait until the fit has finished before closing the window..
        '''</summary>
        Friend Shared ReadOnly Property Fitting_FitRunningCloseWindowNotPossible() As String
            Get
                Return ResourceManager.GetString("Fitting_FitRunningCloseWindowNotPossible", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Start Fitting.
        '''</summary>
        Friend Shared ReadOnly Property Fitting_StartFit() As String
            Get
                Return ResourceManager.GetString("Fitting_StartFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to initializing ....
        '''</summary>
        Friend Shared ReadOnly Property initializing() As String
            Get
                Return ResourceManager.GetString("initializing", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
