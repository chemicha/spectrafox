﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cFitSettingPanel_TipSampleConvolution
    Inherits SpectroscopyManager.cFitSettingPanel

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbFitFunctionSettings = New System.Windows.Forms.GroupBox()
        Me.cboFitDataType = New System.Windows.Forms.ComboBox()
        Me.lblFitDataType = New System.Windows.Forms.Label()
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth = New SpectroscopyManager.NumericTextbox()
        Me.lblInterpolationStep = New System.Windows.Forms.Label()
        Me.txtSettings_CalculateValuesBiasLowerRange = New SpectroscopyManager.NumericTextbox()
        Me.lblBiasRangeFrom = New System.Windows.Forms.Label()
        Me.txtSettings_ConvolutionIntegralE_NEG = New SpectroscopyManager.NumericTextbox()
        Me.txtSettings_CalculateValuesBiasUpperRange = New SpectroscopyManager.NumericTextbox()
        Me.lblConvolutionIntegralMin = New System.Windows.Forms.Label()
        Me.lblBiasRangeTo = New System.Windows.Forms.Label()
        Me.txtSettings_ConvolutionIntegralE_POS = New SpectroscopyManager.NumericTextbox()
        Me.lblConvolutionIntegralMax = New System.Windows.Forms.Label()
        Me.txtSettings_BroadeningStepWidth = New SpectroscopyManager.NumericTextbox()
        Me.lblBroadeningStepWidth = New System.Windows.Forms.Label()
        Me.txtSettings_ConvolutionIntegrationStepSize = New SpectroscopyManager.NumericTextbox()
        Me.lblEnergyIntegrationStepWidth = New System.Windows.Forms.Label()
        Me.gbFitFunctionSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFitFunctionSettings
        '
        Me.gbFitFunctionSettings.Controls.Add(Me.cboFitDataType)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblFitDataType)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_CalculateValuesBiasInterpolationStepWidth)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblInterpolationStep)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_CalculateValuesBiasLowerRange)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblBiasRangeFrom)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_ConvolutionIntegralE_NEG)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_CalculateValuesBiasUpperRange)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblConvolutionIntegralMin)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblBiasRangeTo)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_ConvolutionIntegralE_POS)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblConvolutionIntegralMax)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_BroadeningStepWidth)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblBroadeningStepWidth)
        Me.gbFitFunctionSettings.Controls.Add(Me.txtSettings_ConvolutionIntegrationStepSize)
        Me.gbFitFunctionSettings.Controls.Add(Me.lblEnergyIntegrationStepWidth)
        Me.gbFitFunctionSettings.Location = New System.Drawing.Point(259, 3)
        Me.gbFitFunctionSettings.Name = "gbFitFunctionSettings"
        Me.gbFitFunctionSettings.Size = New System.Drawing.Size(294, 229)
        Me.gbFitFunctionSettings.TabIndex = 22
        Me.gbFitFunctionSettings.TabStop = False
        Me.gbFitFunctionSettings.Text = "fit function settings"
        '
        'cboFitDataType
        '
        Me.cboFitDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFitDataType.FormattingEnabled = True
        Me.cboFitDataType.Location = New System.Drawing.Point(197, 194)
        Me.cboFitDataType.Name = "cboFitDataType"
        Me.cboFitDataType.Size = New System.Drawing.Size(90, 21)
        Me.cboFitDataType.TabIndex = 20
        '
        'lblFitDataType
        '
        Me.lblFitDataType.AutoSize = True
        Me.lblFitDataType.Location = New System.Drawing.Point(11, 198)
        Me.lblFitDataType.Name = "lblFitDataType"
        Me.lblFitDataType.Size = New System.Drawing.Size(83, 13)
        Me.lblFitDataType.TabIndex = 21
        Me.lblFitDataType.Text = "signal type to fit:"
        '
        'txtSettings_CalculateValuesBiasInterpolationStepWidth
        '
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.BackColor = System.Drawing.Color.White
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.FormatDecimalPlaces = 6
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.Location = New System.Drawing.Point(197, 165)
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.Name = "txtSettings_CalculateValuesBiasInterpolationStepWidth"
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.Positive
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.TabIndex = 7
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.Text = "0.000000"
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_CalculateValuesBiasInterpolationStepWidth.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'lblInterpolationStep
        '
        Me.lblInterpolationStep.AutoSize = True
        Me.lblInterpolationStep.Location = New System.Drawing.Point(12, 168)
        Me.lblInterpolationStep.Name = "lblInterpolationStep"
        Me.lblInterpolationStep.Size = New System.Drawing.Size(170, 13)
        Me.lblInterpolationStep.TabIndex = 0
        Me.lblInterpolationStep.Text = "interpolation steps between points:"
        '
        'txtSettings_CalculateValuesBiasLowerRange
        '
        Me.txtSettings_CalculateValuesBiasLowerRange.BackColor = System.Drawing.Color.White
        Me.txtSettings_CalculateValuesBiasLowerRange.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_CalculateValuesBiasLowerRange.FormatDecimalPlaces = 6
        Me.txtSettings_CalculateValuesBiasLowerRange.Location = New System.Drawing.Point(197, 143)
        Me.txtSettings_CalculateValuesBiasLowerRange.Name = "txtSettings_CalculateValuesBiasLowerRange"
        Me.txtSettings_CalculateValuesBiasLowerRange.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_CalculateValuesBiasLowerRange.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.PositiveAndNegative
        Me.txtSettings_CalculateValuesBiasLowerRange.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_CalculateValuesBiasLowerRange.TabIndex = 6
        Me.txtSettings_CalculateValuesBiasLowerRange.Text = "0.000000"
        Me.txtSettings_CalculateValuesBiasLowerRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_CalculateValuesBiasLowerRange.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'lblBiasRangeFrom
        '
        Me.lblBiasRangeFrom.AutoSize = True
        Me.lblBiasRangeFrom.Location = New System.Drawing.Point(12, 146)
        Me.lblBiasRangeFrom.Name = "lblBiasRangeFrom"
        Me.lblBiasRangeFrom.Size = New System.Drawing.Size(179, 13)
        Me.lblBiasRangeFrom.TabIndex = 0
        Me.lblBiasRangeFrom.Text = "calculate values in bias range (from):"
        '
        'txtSettings_ConvolutionIntegralE_NEG
        '
        Me.txtSettings_ConvolutionIntegralE_NEG.BackColor = System.Drawing.Color.White
        Me.txtSettings_ConvolutionIntegralE_NEG.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_ConvolutionIntegralE_NEG.FormatDecimalPlaces = 6
        Me.txtSettings_ConvolutionIntegralE_NEG.Location = New System.Drawing.Point(197, 91)
        Me.txtSettings_ConvolutionIntegralE_NEG.Name = "txtSettings_ConvolutionIntegralE_NEG"
        Me.txtSettings_ConvolutionIntegralE_NEG.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_ConvolutionIntegralE_NEG.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.PositiveAndNegative
        Me.txtSettings_ConvolutionIntegralE_NEG.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_ConvolutionIntegralE_NEG.TabIndex = 4
        Me.txtSettings_ConvolutionIntegralE_NEG.Text = "0.000000"
        Me.txtSettings_ConvolutionIntegralE_NEG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_ConvolutionIntegralE_NEG.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'txtSettings_CalculateValuesBiasUpperRange
        '
        Me.txtSettings_CalculateValuesBiasUpperRange.BackColor = System.Drawing.Color.White
        Me.txtSettings_CalculateValuesBiasUpperRange.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_CalculateValuesBiasUpperRange.FormatDecimalPlaces = 6
        Me.txtSettings_CalculateValuesBiasUpperRange.Location = New System.Drawing.Point(197, 121)
        Me.txtSettings_CalculateValuesBiasUpperRange.Name = "txtSettings_CalculateValuesBiasUpperRange"
        Me.txtSettings_CalculateValuesBiasUpperRange.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_CalculateValuesBiasUpperRange.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.PositiveAndNegative
        Me.txtSettings_CalculateValuesBiasUpperRange.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_CalculateValuesBiasUpperRange.TabIndex = 5
        Me.txtSettings_CalculateValuesBiasUpperRange.Text = "0.000000"
        Me.txtSettings_CalculateValuesBiasUpperRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_CalculateValuesBiasUpperRange.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'lblConvolutionIntegralMin
        '
        Me.lblConvolutionIntegralMin.AutoSize = True
        Me.lblConvolutionIntegralMin.Location = New System.Drawing.Point(12, 94)
        Me.lblConvolutionIntegralMin.Name = "lblConvolutionIntegralMin"
        Me.lblConvolutionIntegralMin.Size = New System.Drawing.Size(156, 13)
        Me.lblConvolutionIntegralMin.TabIndex = 0
        Me.lblConvolutionIntegralMin.Text = "convolution integral energy min:"
        '
        'lblBiasRangeTo
        '
        Me.lblBiasRangeTo.AutoSize = True
        Me.lblBiasRangeTo.Location = New System.Drawing.Point(12, 124)
        Me.lblBiasRangeTo.Name = "lblBiasRangeTo"
        Me.lblBiasRangeTo.Size = New System.Drawing.Size(168, 13)
        Me.lblBiasRangeTo.TabIndex = 0
        Me.lblBiasRangeTo.Text = "calculate values in bias range (to):"
        '
        'txtSettings_ConvolutionIntegralE_POS
        '
        Me.txtSettings_ConvolutionIntegralE_POS.BackColor = System.Drawing.Color.White
        Me.txtSettings_ConvolutionIntegralE_POS.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_ConvolutionIntegralE_POS.FormatDecimalPlaces = 6
        Me.txtSettings_ConvolutionIntegralE_POS.Location = New System.Drawing.Point(197, 69)
        Me.txtSettings_ConvolutionIntegralE_POS.Name = "txtSettings_ConvolutionIntegralE_POS"
        Me.txtSettings_ConvolutionIntegralE_POS.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_ConvolutionIntegralE_POS.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.PositiveAndNegative
        Me.txtSettings_ConvolutionIntegralE_POS.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_ConvolutionIntegralE_POS.TabIndex = 3
        Me.txtSettings_ConvolutionIntegralE_POS.Text = "0.000000"
        Me.txtSettings_ConvolutionIntegralE_POS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_ConvolutionIntegralE_POS.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'lblConvolutionIntegralMax
        '
        Me.lblConvolutionIntegralMax.AutoSize = True
        Me.lblConvolutionIntegralMax.Location = New System.Drawing.Point(12, 72)
        Me.lblConvolutionIntegralMax.Name = "lblConvolutionIntegralMax"
        Me.lblConvolutionIntegralMax.Size = New System.Drawing.Size(159, 13)
        Me.lblConvolutionIntegralMax.TabIndex = 0
        Me.lblConvolutionIntegralMax.Text = "convolution integral energy max:"
        '
        'txtSettings_BroadeningStepWidth
        '
        Me.txtSettings_BroadeningStepWidth.BackColor = System.Drawing.Color.White
        Me.txtSettings_BroadeningStepWidth.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_BroadeningStepWidth.FormatDecimalPlaces = 6
        Me.txtSettings_BroadeningStepWidth.Location = New System.Drawing.Point(197, 40)
        Me.txtSettings_BroadeningStepWidth.Name = "txtSettings_BroadeningStepWidth"
        Me.txtSettings_BroadeningStepWidth.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_BroadeningStepWidth.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.Positive
        Me.txtSettings_BroadeningStepWidth.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_BroadeningStepWidth.TabIndex = 2
        Me.txtSettings_BroadeningStepWidth.Text = "0.000000"
        Me.txtSettings_BroadeningStepWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_BroadeningStepWidth.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'lblBroadeningStepWidth
        '
        Me.lblBroadeningStepWidth.AutoSize = True
        Me.lblBroadeningStepWidth.Location = New System.Drawing.Point(12, 43)
        Me.lblBroadeningStepWidth.Name = "lblBroadeningStepWidth"
        Me.lblBroadeningStepWidth.Size = New System.Drawing.Size(172, 13)
        Me.lblBroadeningStepWidth.TabIndex = 0
        Me.lblBroadeningStepWidth.Text = "broadening convolution step-width:"
        '
        'txtSettings_ConvolutionIntegrationStepSize
        '
        Me.txtSettings_ConvolutionIntegrationStepSize.BackColor = System.Drawing.Color.White
        Me.txtSettings_ConvolutionIntegrationStepSize.ForeColor = System.Drawing.Color.Black
        Me.txtSettings_ConvolutionIntegrationStepSize.FormatDecimalPlaces = 6
        Me.txtSettings_ConvolutionIntegrationStepSize.Location = New System.Drawing.Point(197, 17)
        Me.txtSettings_ConvolutionIntegrationStepSize.Name = "txtSettings_ConvolutionIntegrationStepSize"
        Me.txtSettings_ConvolutionIntegrationStepSize.NumberFormat = SpectroscopyManager.NumericTextbox.NumberFormatTypes.ScientificUnits
        Me.txtSettings_ConvolutionIntegrationStepSize.NumberRange = SpectroscopyManager.NumericTextbox.NumberRanges.Positive
        Me.txtSettings_ConvolutionIntegrationStepSize.Size = New System.Drawing.Size(90, 20)
        Me.txtSettings_ConvolutionIntegrationStepSize.TabIndex = 1
        Me.txtSettings_ConvolutionIntegrationStepSize.Text = "0.000000"
        Me.txtSettings_ConvolutionIntegrationStepSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSettings_ConvolutionIntegrationStepSize.ValueType = SpectroscopyManager.NumericTextbox.ValueTypes.FloatingPointValue
        '
        'lblEnergyIntegrationStepWidth
        '
        Me.lblEnergyIntegrationStepWidth.AutoSize = True
        Me.lblEnergyIntegrationStepWidth.Location = New System.Drawing.Point(12, 20)
        Me.lblEnergyIntegrationStepWidth.Name = "lblEnergyIntegrationStepWidth"
        Me.lblEnergyIntegrationStepWidth.Size = New System.Drawing.Size(145, 13)
        Me.lblEnergyIntegrationStepWidth.TabIndex = 0
        Me.lblEnergyIntegrationStepWidth.Text = "energy integration step-width:"
        '
        'cFitSettingPanel_TipSampleConvolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbFitFunctionSettings)
        Me.Name = "cFitSettingPanel_TipSampleConvolution"
        Me.Size = New System.Drawing.Size(761, 235)
        Me.Controls.SetChildIndex(Me.gbFitFunctionSettings, 0)
        Me.gbFitFunctionSettings.ResumeLayout(False)
        Me.gbFitFunctionSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFitFunctionSettings As System.Windows.Forms.GroupBox
    Friend WithEvents lblEnergyIntegrationStepWidth As System.Windows.Forms.Label
    Friend WithEvents txtSettings_ConvolutionIntegrationStepSize As SpectroscopyManager.NumericTextbox
    Friend WithEvents txtSettings_ConvolutionIntegralE_NEG As SpectroscopyManager.NumericTextbox
    Friend WithEvents lblConvolutionIntegralMin As System.Windows.Forms.Label
    Friend WithEvents txtSettings_ConvolutionIntegralE_POS As SpectroscopyManager.NumericTextbox
    Friend WithEvents lblConvolutionIntegralMax As System.Windows.Forms.Label
    Friend WithEvents txtSettings_BroadeningStepWidth As SpectroscopyManager.NumericTextbox
    Friend WithEvents lblBroadeningStepWidth As System.Windows.Forms.Label
    Friend WithEvents txtSettings_CalculateValuesBiasLowerRange As SpectroscopyManager.NumericTextbox
    Friend WithEvents lblBiasRangeFrom As System.Windows.Forms.Label
    Friend WithEvents txtSettings_CalculateValuesBiasUpperRange As SpectroscopyManager.NumericTextbox
    Friend WithEvents lblBiasRangeTo As System.Windows.Forms.Label
    Friend WithEvents txtSettings_CalculateValuesBiasInterpolationStepWidth As SpectroscopyManager.NumericTextbox
    Friend WithEvents lblInterpolationStep As System.Windows.Forms.Label
    Friend WithEvents cboFitDataType As System.Windows.Forms.ComboBox
    Friend WithEvents lblFitDataType As System.Windows.Forms.Label

End Class
