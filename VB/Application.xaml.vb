﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports System.Data.Entity
Imports Scaffolding.CustomFilter.Model

Namespace Scaffolding.CustomFilter
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application
		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			Database.SetInitializer(Of IssueContext)(New IssueContextInitializer())
			MyBase.OnStartup(e)
		End Sub
		Private Sub OnAppStartup_UpdateThemeName(ByVal sender As Object, ByVal e As StartupEventArgs)
			DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
		End Sub
	End Class
End Namespace