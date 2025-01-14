﻿Imports System.Numerics.Complex

Public Class cFitFunction_FrotaDerivative
    Inherits cFitFunction

#Region "Initialize Fit-Parameters"

    Public Property DerivativeDistance As Double = 0.01

    ''' <summary>
    ''' Identification Indizes of the Parameters.
    ''' </summary>
    Public Enum FitParameterIdentifier
        a
        b
        c
        XCenter
        Phi
        Gamma
    End Enum

    ''' <summary>
    ''' Method that sets all Initial FitParameters
    ''' </summary>
    Protected Overrides Sub InitializeFitParameters()
        Me.FitParameters.Add(New cFitParameter(FitParameterIdentifier.a.ToString, 1, False, My.Resources.rFitFunction_Frota.Parameter_A))
        Me.FitParameters.Add(New cFitParameter(FitParameterIdentifier.b.ToString, 0, False, My.Resources.rFitFunction_Frota.Parameter_B))
        Me.FitParameters.Add(New cFitParameter(FitParameterIdentifier.c.ToString, 0, False, My.Resources.rFitFunction_Frota.Parameter_C))
        Me.FitParameters.Add(New cFitParameter(FitParameterIdentifier.XCenter.ToString, 0, False, My.Resources.rFitFunction_Frota.Parameter_XCenter))
        Me.FitParameters.Add(New cFitParameter(FitParameterIdentifier.Phi.ToString, 1, False, My.Resources.rFitFunction_Frota.Parameter_PhiInPi))
        Me.FitParameters.Add(New cFitParameter(FitParameterIdentifier.Gamma.ToString, 1, False, My.Resources.rFitFunction_Frota.Parameter_Gamma))
    End Sub
#End Region

#Region "FitFunction"
    ''' <summary>
    ''' Returns the actual FitFunction-Value at a given X
    ''' </summary>
    ''' <param name="x">x-value at which the fit function should be evaluated.</param>
    Public Overrides Function GetY(ByRef x As Double, ByRef InputParameters As cFitParameterGroupGroup) As Double

        ' Calculate the function value.
        Return FitFunction(x,
                           InputParameters.Group(Me.UseFitParameterGroupID).Parameter(FitParameterIdentifier.a.ToString).Value,
                           InputParameters.Group(Me.UseFitParameterGroupID).Parameter(FitParameterIdentifier.b.ToString).Value,
                           InputParameters.Group(Me.UseFitParameterGroupID).Parameter(FitParameterIdentifier.c.ToString).Value,
                           InputParameters.Group(Me.UseFitParameterGroupID).Parameter(FitParameterIdentifier.XCenter.ToString).Value,
                           InputParameters.Group(Me.UseFitParameterGroupID).Parameter(FitParameterIdentifier.Phi.ToString).Value,
                           InputParameters.Group(Me.UseFitParameterGroupID).Parameter(FitParameterIdentifier.Gamma.ToString).Value,
                           Me.DerivativeDistance)

    End Function

    ''' <summary>
    ''' Fit-Function
    ''' </summary>
    Public Shared Function FitFunction(ByVal x As Double,
                                       ByVal a As Double,
                                       ByVal b As Double,
                                       ByVal c As Double,
                                       ByVal XCenter As Double,
                                       ByVal Phi As Double,
                                       ByVal Gamma As Double,
                                       ByVal dx As Double) As Double

        Dim Value1 As System.Numerics.Complex = cFitFunction_Frota.FitFunction(x, a, b, c, XCenter, Phi, Gamma)
        Dim Value2 As System.Numerics.Complex = cFitFunction_Frota.FitFunction(x + dx, a, b, c, XCenter, Phi, Gamma)

        Dim dResult As Double = (Value2.Real - Value1.Real) / dx
        Return dResult
    End Function
#End Region

#Region "Fit-Description and Formula"
    ''' <summary>
    ''' Formula used the fit-function.
    ''' </summary>
    Public Overrides Function FitFunctionFormula() As String
        Return My.Resources.rFitFunction_Frota.Formula
    End Function

    ''' <summary>
    ''' Name of the fit-function.
    ''' </summary>
    Public Overrides Function FitFunctionName() As String
        Return My.Resources.rFitFunction_Frota.Derivative_Name
    End Function

    ''' <summary>
    ''' Description of the fit that is performed.
    ''' </summary>
    Public Overrides Function FitDescription() As String
        Return My.Resources.rFitFunction_Frota.Derivative_Description
    End Function

    ''' <summary>
    ''' Authors of the fit function.
    ''' </summary>
    Public Overrides Function FitFunctionAuthors() As String
        Return My.Resources.rFitFunction_Frota.Authors
    End Function
#End Region

#Region "Fit-Settings-Panel"
    ''' <summary>
    ''' Returns the Settings-Panel
    ''' </summary>
    Overrides ReadOnly Property FunctionSettingPanel As cFitSettingPanel
        Get
            Return New cFitSettingPanel_FrotaDerivative
        End Get
    End Property
#End Region

End Class
