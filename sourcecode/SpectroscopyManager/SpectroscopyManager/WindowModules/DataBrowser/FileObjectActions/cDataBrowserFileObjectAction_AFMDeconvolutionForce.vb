﻿Public Class cDataBrowserFileObjectAction_AFMDeconvolutionForce
    Implements iDataBrowser_FileObjectAction

#Region "Class abilities"
    ''' <summary>
    ''' This class can handle single file-objects.
    ''' </summary>
    Public ReadOnly Property CanHandleMultipleFileObjects As Boolean Implements iDataBrowser_FileObjectAction.CanHandleMultipleFileObjects
        Get
            Return True
        End Get
    End Property

    ''' <summary>
    ''' This class can handle single file-objects.
    ''' </summary>
    Public ReadOnly Property CanHandleSingleFileObjects As Boolean Implements iDataBrowser_FileObjectAction.CanHandleSingleFileObjects
        Get
            Return True
        End Get
    End Property

    ''' <summary>
    ''' Handle spectroscopy files only.
    ''' </summary>
    Public ReadOnly Property CanHandleFileObjectType As cFileObject.FileTypes Implements iDataBrowser_FileObjectAction.CanHandleFileObjectType
        Get
            Return cFileObject.FileTypes.SpectroscopyTable
        End Get
    End Property
#End Region

#Region "Style and Settings"

    ''' <summary>
    ''' Return a quick-button with icon.
    ''' </summary>
    Public Function QuickButtonInListEntry() As Button Implements iDataBrowser_FileObjectAction.QuickButtonInListEntry
        Return Nothing
    End Function

    ''' <summary>
    ''' Tooltip description of the quick-button
    ''' </summary>
    Public ReadOnly Property QuickButtonToolTip As String Implements iDataBrowser_FileObjectAction.QuickButtonToolTip
        Get
            Return String.Empty
        End Get
    End Property

    ''' <summary>
    ''' Set the category, where the menu item for single files will be set.
    ''' </summary>
    Public ReadOnly Property CategoryOfSingleFileActionMenu As mDataBrowserList.APISingleFileToolsMenuCategories Implements iDataBrowser_FileObjectAction.CategoryOfSingleFileActionMenu
        Get
            Return mDataBrowserList.APISingleFileToolsMenuCategories.SpectroscopyFiles_AtomicForceMicroscopyTools
        End Get
    End Property

    ''' <summary>
    ''' Menu button for the single file action context menu.
    ''' </summary>
    Public Function SingleFileActionMenuItem() As ToolStripMenuItem Implements iDataBrowser_FileObjectAction.SingleFileActionMenuItem
        Dim M As New ToolStripMenuItem
        M.Text = My.Resources.rFileObjectActions.CM_AFMDeconvolutionForce
        M.Image = My.Resources.normalize_16
        Return M
    End Function

    ''' <summary>
    ''' Set the category, where the menu item for multiple files will be set.
    ''' </summary>
    Public ReadOnly Property CategoryOfMultipleFileActionMenu As mDataBrowserList.APIMultipleFilesToolsMenuCategories Implements iDataBrowser_FileObjectAction.CategoryOfMultipleFileActionMenu
        Get
            Return mDataBrowserList.APIMultipleFilesToolsMenuCategories.SpectroscopyFiles_AtomicForceMicroscopyTools
        End Get
    End Property

    ''' <summary>
    ''' Menu button for the multiple file action menu.
    ''' </summary>
    Public Function MultipleFileActionMenuItem() As ToolStripMenuItem Implements iDataBrowser_FileObjectAction.MultipleFileActionMenuItem
        Dim M As New ToolStripMenuItem
        M.Text = My.Resources.rFileObjectActions.MM_AFMDeconvolutionForce
        M.Image = My.Resources.normalize_16
        Return M
    End Function

#End Region

#Region "Multiple file objects"

    ''' <summary>
    ''' Check the settings.
    ''' </summary>
    Public Function MultipleFileActionCheckSettings() As Boolean Implements iDataBrowser_FileObjectAction.MultipleFileActionCheckSettings
        ' Check, if settings had been saved.
        With My.Settings
            If .AFMDeconvolution_LastSmoothMethod = String.Empty OrElse
               .AFMDeconvolution_LastSmoothSettings = String.Empty OrElse
               .AFMDeconvolution_OutputName_Current = String.Empty OrElse
               .AFMDeconvolution_OutputName_Force = String.Empty OrElse
               .AFMDeconvolution_LastColumn_ZRel = String.Empty OrElse
               .AFMDeconvolution_LastColumn_ForceGradient = String.Empty OrElse
               .AFMDeconvolution_LastColumn_CurrentSignal = String.Empty OrElse
               .AFMDeconvolution_SpringConstant = 0 OrElse
               .AFMDeconvolution_ResonanceFrequency = 0 OrElse
               .AFMDeconvolution_OscillationAmplitude = 0 Then
                Return False
            End If
        End With
        Return True
    End Function

    ''' <summary>
    ''' Maximum number of file-objects to select.
    ''' </summary>
    Public ReadOnly Property MultipleFiles_Count_Max As Integer Implements iDataBrowser_FileObjectAction.MultipleFiles_Count_Max
        Get
            Return Integer.MaxValue
        End Get
    End Property

    ''' <summary>
    ''' Minimum number of file-objects to select.
    ''' </summary>
    Public ReadOnly Property MultipleFiles_Count_Min As Integer Implements iDataBrowser_FileObjectAction.MultipleFiles_Count_Min
        Get
            Return 1
        End Get
    End Property

    ''' <summary>
    ''' Action for multiple file objects.
    ''' Is called async in a thread pool.
    ''' </summary>
    Public Function MultipleFileAction_IndividualAction(ByRef FileObject As cFileObject) As Boolean Implements iDataBrowser_FileObjectAction.MultipleFileAction_IndividualAction

        ' Only consider spectroscopy files.
        If FileObject.FileType <> cFileObject.FileTypes.SpectroscopyTable Then Return True

        ' Create tool.
        Dim Tool As New cSpectroscopyTableAFMForceCurrentDeconvolution(FileObject)

        ' Create the smoothing method.
        Dim SmoothingMethod As iNumericSmoothingFunction = cNumericalMethods.GetSmoothingMethodByType(cNumericalMethods.GetSmoothingMethodFromString(My.Settings.AFMDeconvolution_LastSmoothMethod))
        SmoothingMethod.CurrentSmoothingSettings = My.Settings.AFMDeconvolution_LastSmoothSettings

        ' Setup the tool.
        With Tool
            .DataSmoother = SmoothingMethod
            .SpringConstant = My.Settings.AFMDeconvolution_SpringConstant
            .ResonanceFrequency = My.Settings.AFMDeconvolution_ResonanceFrequency
            .OscillationAmplitude = My.Settings.AFMDeconvolution_OscillationAmplitude
            .RemoveFrequencyShiftOffsetToZero = My.Settings.AFMDeconvolution_RemoveFrequencyShiftOffset
        End With

        ' Perform the deconvolution directly.
        Tool.DeconvoluteWITHFetch_Direct(My.Settings.AFMDeconvolution_LastColumn_ZRel,
                                         My.Settings.AFMDeconvolution_LastColumn_ForceGradient,
                                         My.Settings.AFMDeconvolution_LastColumn_CurrentSignal,
                                         My.Settings.AFMDeconvolution_OutputName_Force,
                                         My.Settings.AFMDeconvolution_OutputName_Current)
        Tool.SaveColumnsToFileObject(My.Settings.AFMDeconvolution_OutputName_Force, My.Settings.AFMDeconvolution_OutputName_Current)
        Tool = Nothing

        Return True
    End Function

    ''' <summary>
    ''' All at once action for all file-objects.
    ''' </summary>
    Public Function MultipleFileAction_AllAtOnce(ByRef FileObjectList As List(Of cFileObject)) As Boolean Implements iDataBrowser_FileObjectAction.MultipleFileAction_AllAtOnce
        Return True
    End Function

    ''' <summary>
    ''' This function needs to process all the files individually.
    ''' </summary>
    Public ReadOnly Property MultipleFilesProcessedIndividually As Boolean Implements iDataBrowser_FileObjectAction.MultipleFilesProcessedIndividually
        Get
            Return True
        End Get
    End Property

    ''' <summary>
    ''' Process multiple files in the thread-pool
    ''' </summary>
    Public ReadOnly Property MultipleFilesProcessASYNC As Boolean Implements iDataBrowser_FileObjectAction.MultipleFilesProcessASYNC
        Get
            Return True
        End Get
    End Property

#End Region

#Region "Single file object"
    ''' <summary>
    ''' Action for a single file object.
    ''' </summary>
    Public Function SingleFileAction(ByRef FileObject As cFileObject) As Boolean Implements iDataBrowser_FileObjectAction.SingleFileAction
        Dim Tool As New wAFMForceCurrentDeconvolution
        Tool.Show(FileObject)
        Return True
    End Function
#End Region
End Class
