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
    Friend Class rDataBrowser
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SpectroscopyManager.rDataBrowser", GetType(rDataBrowser).Assembly)
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
        '''  Looks up a localized string similar to Loading file ...
        '''.
        '''</summary>
        Friend Shared ReadOnly Property File_Loading_Tag() As String
            Get
                Return ResourceManager.GetString("File_Loading_Tag", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A list refresh is running. The window can&apos;t be closed until this finished.
        '''You may abort it manually, if you want to quit..
        '''</summary>
        Friend Shared ReadOnly Property FormClose_FileFetcherRunning() As String
            Get
                Return ResourceManager.GetString("FormClose_FileFetcherRunning", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to list refresh running.
        '''</summary>
        Friend Shared ReadOnly Property FormClose_FileFetcherRunning_Title() As String
            Get
                Return ResourceManager.GetString("FormClose_FileFetcherRunning_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to processing requested actions ... please wait.
        '''</summary>
        Friend Shared ReadOnly Property MultipleFileActions_Processing() As String
            Get
                Return ResourceManager.GetString("MultipleFileActions_Processing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The requested function is applied to the selected files ... please wait!.
        '''</summary>
        Friend Shared ReadOnly Property ProgressBox_FileProcessHeading() As String
            Get
                Return ResourceManager.GetString("ProgressBox_FileProcessHeading", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The data folder is being scanned for compatible files ... please wait!.
        '''</summary>
        Friend Shared ReadOnly Property ProgressBox_FolderScanHeading() As String
            Get
                Return ResourceManager.GetString("ProgressBox_FolderScanHeading", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to time to next list-refresh: %t s.
        '''</summary>
        Friend Shared ReadOnly Property RefreshTimer_CountDown() As String
            Get
                Return ResourceManager.GetString("RefreshTimer_CountDown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to automatic list refresh disabled.
        '''</summary>
        Friend Shared ReadOnly Property RefreshTimer_Disabled() As String
            Get
                Return ResourceManager.GetString("RefreshTimer_Disabled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You are about to load a large amount of individual windows.
        '''This may take some time. Do you want to continue anyway?.
        '''</summary>
        Friend Shared ReadOnly Property ShowFileDetails_MultipleWindow_LargeCount_Question() As String
            Get
                Return ResourceManager.GetString("ShowFileDetails_MultipleWindow_LargeCount_Question", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Open large amount of files?.
        '''</summary>
        Friend Shared ReadOnly Property ShowFileDetails_MultipleWindow_LargeCount_Question_Title() As String
            Get
                Return ResourceManager.GetString("ShowFileDetails_MultipleWindow_LargeCount_Question_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ready.
        '''</summary>
        Friend Shared ReadOnly Property StatusText_Ready() As String
            Get
                Return ResourceManager.GetString("StatusText_Ready", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to File comments as saved by your data acquisition software..
        '''</summary>
        Friend Shared ReadOnly Property TT_Comment() As String
            Get
                Return ResourceManager.GetString("TT_Comment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Data (channels / columns) stored in the file..
        '''</summary>
        Friend Shared ReadOnly Property TT_DataColumns() As String
            Get
                Return ResourceManager.GetString("TT_DataColumns", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to the dimension of the stored data object.
        '''</summary>
        Friend Shared ReadOnly Property TT_DataPoints() As String
            Get
                Return ResourceManager.GetString("TT_DataPoints", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This is the time of the last change of the data file, when it was written
        '''to the hard disk of your computer. It may differ from the record time..
        '''</summary>
        Friend Shared ReadOnly Property TT_FileChangeTime() As String
            Get
                Return ResourceManager.GetString("TT_FileChangeTime", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Filename of the data file. The current folder can be found in the window title.
        '''
        '''Double click on the entry, to open a separate data explorer window for this file..
        '''</summary>
        Friend Shared ReadOnly Property TT_FileName() As String
            Get
                Return ResourceManager.GetString("TT_FileName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This is the time saved by your data acquisition software
        '''in the header of the data file. It may differ from the file time..
        '''</summary>
        Friend Shared ReadOnly Property TT_FileRecordTime() As String
            Get
                Return ResourceManager.GetString("TT_FileRecordTime", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to This is a small preview of the data. Use the &quot;settings&quot; panel in the
        '''menu above to select the channels / data columns to be displayed.
        '''
        '''Double click on the entry, to open a separate data explorer window for this file..
        '''</summary>
        Friend Shared ReadOnly Property TT_PreviewImage() As String
            Get
                Return ResourceManager.GetString("TT_PreviewImage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click here to select a list entry.
        '''</summary>
        Friend Shared ReadOnly Property TT_SelectListEntry() As String
            Get
                Return ResourceManager.GetString("TT_SelectListEntry", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to click here to sort by filename.
        '''</summary>
        Friend Shared ReadOnly Property TT_SortByFileName() As String
            Get
                Return ResourceManager.GetString("TT_SortByFileName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  points.
        '''</summary>
        Friend Shared ReadOnly Property Word_DataPoints() As String
            Get
                Return ResourceManager.GetString("Word_DataPoints", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
