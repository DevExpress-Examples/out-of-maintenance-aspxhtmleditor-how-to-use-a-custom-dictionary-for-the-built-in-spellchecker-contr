Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraSpellChecker
Imports System.Globalization

Public Class MyCustomDictionary
	Inherits SpellCheckerCustomDictionary
	Public Overrides ReadOnly Property Loaded() As Boolean
		Get
			Return True
		End Get
	End Property
End Class