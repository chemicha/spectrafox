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
    Friend Class rFileObjectActions
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SpectroscopyManager.rFileObjectActions", GetType(rFileObjectActions).Assembly)
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
        '''  Looks up a localized string similar to crop.
        '''</summary>
        Friend Shared ReadOnly Property CM_CropFile() As String
            Get
                Return ResourceManager.GetString("CM_CropFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to average.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataAverageSingleFile() As String
            Get
                Return ResourceManager.GetString("CM_DataAverageSingleFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to multiply / divide.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataMultiplication() As String
            Get
                Return ResourceManager.GetString("CM_DataMultiplication", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to non linear data fitting.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataNonLinearFit() As String
            Get
                Return ResourceManager.GetString("CM_DataNonLinearFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to normalize.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataNormalization() As String
            Get
                Return ResourceManager.GetString("CM_DataNormalization", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to regauge to numeric derivative.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataRegauging_ByFit() As String
            Get
                Return ResourceManager.GetString("CM_DataRegauging_ByFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to reverse.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataReversion() As String
            Get
                Return ResourceManager.GetString("CM_DataReversion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to smooth.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataSmoothing() As String
            Get
                Return ResourceManager.GetString("CM_DataSmoothing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to add / substract.
        '''</summary>
        Friend Shared ReadOnly Property CM_DataSummation() As String
            Get
                Return ResourceManager.GetString("CM_DataSummation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to numeric derivative.
        '''</summary>
        Friend Shared ReadOnly Property CM_DerivativeOfFile() As String
            Get
                Return ResourceManager.GetString("CM_DerivativeOfFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to rename data-columns.
        '''</summary>
        Friend Shared ReadOnly Property CM_RenameColumns() As String
            Get
                Return ResourceManager.GetString("CM_RenameColumns", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to clear all created comments.
        '''</summary>
        Friend Shared ReadOnly Property MM_ClearExtendedComment() As String
            Get
                Return ResourceManager.GetString("MM_ClearExtendedComment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to remove all cached preview images.
        '''</summary>
        Friend Shared ReadOnly Property MM_ClearPreviewImages() As String
            Get
                Return ResourceManager.GetString("MM_ClearPreviewImages", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to remove all channels generated by SpectraFox.
        '''</summary>
        Friend Shared ReadOnly Property MM_ClearScanChannels() As String
            Get
                Return ResourceManager.GetString("MM_ClearScanChannels", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to remove all data columns generated by SpectraFox.
        '''</summary>
        Friend Shared ReadOnly Property MM_ClearSpectroscopyColumn() As String
            Get
                Return ResourceManager.GetString("MM_ClearSpectroscopyColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to remove all crop ranges.
        '''</summary>
        Friend Shared ReadOnly Property MM_ClearSpectroscopyCropInformations() As String
            Get
                Return ResourceManager.GetString("MM_ClearSpectroscopyCropInformations", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: crop all files.
        '''</summary>
        Friend Shared ReadOnly Property MM_CropFiles() As String
            Get
                Return ResourceManager.GetString("MM_CropFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to average values across files.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataAverageMultipleFiles() As String
            Get
                Return ResourceManager.GetString("MM_DataAverageMultipleFiles", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: average columns in each file.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataAverageSingleFile() As String
            Get
                Return ResourceManager.GetString("MM_DataAverageSingleFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: multiply by factor.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataMultiplicationFactor() As String
            Get
                Return ResourceManager.GetString("MM_DataMultiplicationFactor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: multiply two data columns.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataMultiplicationOtherColumn() As String
            Get
                Return ResourceManager.GetString("MM_DataMultiplicationOtherColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to two data sets: non linear data fitting.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataNonLinearFit() As String
            Get
                Return ResourceManager.GetString("MM_DataNonLinearFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: normalize.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataNormalization() As String
            Get
                Return ResourceManager.GetString("MM_DataNormalization", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: regauge to numeric derivative.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataRegauging_ByFit() As String
            Get
                Return ResourceManager.GetString("MM_DataRegauging_ByFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: regauge by parameters.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataRegauging_ByParameters() As String
            Get
                Return ResourceManager.GetString("MM_DataRegauging_ByParameters", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: reverse.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataReversion() As String
            Get
                Return ResourceManager.GetString("MM_DataReversion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: smooth.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataSmoothing() As String
            Get
                Return ResourceManager.GetString("MM_DataSmoothing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: add / substract a value.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataSummationFactor() As String
            Get
                Return ResourceManager.GetString("MM_DataSummationFactor", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: sum two columns.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataSummationOtherColumn() As String
            Get
                Return ResourceManager.GetString("MM_DataSummationOtherColumn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: sum values of different files.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataSummationTwoSets_Last() As String
            Get
                Return ResourceManager.GetString("MM_DataSummationTwoSets_Last", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to two data sets: sum values of different files.
        '''</summary>
        Friend Shared ReadOnly Property MM_DataSummationTwoSets_Manual() As String
            Get
                Return ResourceManager.GetString("MM_DataSummationTwoSets_Manual", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: numeric derivative.
        '''</summary>
        Friend Shared ReadOnly Property MM_DerivativeOfFile() As String
            Get
                Return ResourceManager.GetString("MM_DerivativeOfFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to plot spectra as stacked contour-plot.
        '''</summary>
        Friend Shared ReadOnly Property MM_LineScanPlot() As String
            Get
                Return ResourceManager.GetString("MM_LineScanPlot", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using last settings: rename data-columns.
        '''</summary>
        Friend Shared ReadOnly Property MM_RenameColumns() As String
            Get
                Return ResourceManager.GetString("MM_RenameColumns", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to crops measured data to certain ranges.
        '''</summary>
        Friend Shared ReadOnly Property TT_CropFile() As String
            Get
                Return ResourceManager.GetString("TT_CropFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Average multiple columns in the same file to
        '''one single column with improved data quality..
        '''</summary>
        Friend Shared ReadOnly Property TT_DataAverageSingleFile() As String
            Get
                Return ResourceManager.GetString("TT_DataAverageSingleFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to multiply or divide values in a data column by a constant factor,
        '''or with another data column in the same file.
        '''</summary>
        Friend Shared ReadOnly Property TT_DataMultiplication() As String
            Get
                Return ResourceManager.GetString("TT_DataMultiplication", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Fit data using a non-linear fit model..
        '''</summary>
        Friend Shared ReadOnly Property TT_DataNonLinearFit() As String
            Get
                Return ResourceManager.GetString("TT_DataNonLinearFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Allows to select a range which should be set to one (1),
        '''and normalizes the rest to this reference..
        '''</summary>
        Friend Shared ReadOnly Property TT_DataNormalization() As String
            Get
                Return ResourceManager.GetString("TT_DataNormalization", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Calculate the numeric derivative of a source column, and
        '''fit the target column to it, using a linearly factor.
        '''The target column is then regauged by the fitted parameters
        '''to obtain correct physical dimensions of the target column. [e.g. I(V) -&gt; dI/dV(V)].
        '''</summary>
        Friend Shared ReadOnly Property TT_DataRegauging_ByFit() As String
            Get
                Return ResourceManager.GetString("TT_DataRegauging_ByFit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Smooth values of a data column using different procedures..
        '''</summary>
        Friend Shared ReadOnly Property TT_DataSmoothing() As String
            Get
                Return ResourceManager.GetString("TT_DataSmoothing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to add or substract values in data column with a constant value,
        '''or with another data column in the same file.
        '''</summary>
        Friend Shared ReadOnly Property TT_DataSummation() As String
            Get
                Return ResourceManager.GetString("TT_DataSummation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to calculates the numeric derivative of a column in the data file.
        '''</summary>
        Friend Shared ReadOnly Property TT_DerivativeOfFile() As String
            Get
                Return ResourceManager.GetString("TT_DerivativeOfFile", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
