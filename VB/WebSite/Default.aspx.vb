Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxHtmlEditor
Imports System.IO
Imports DevExpress.Web.ASPxSpellChecker
Imports System.Globalization
Imports DevExpress.XtraSpellChecker

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private ReadOnly Property UserDictionaryPath() As String
		Get
			Return GetUserDictionaryPath()
		End Get
	End Property
	Private ReadOnly Property UserName() As String
		Get
			Return GetUserName()
		End Get
	End Property
	Private Function GetUserName() As String
		Return If((Request.ServerVariables("remote_user") <> String.Empty), Request.ServerVariables("remote_user").Replace("\", "_"), "anonymous")
	End Function
	Private Function GetUserDictionaryPath() As String
		Dim userDictName As String = String.Format("~/CustomDictionaries/{0}.dic", UserName)
		Return Server.MapPath(userDictName)
	End Function

	Protected Sub myHtmlEditor_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim htmlEditor As ASPxHtmlEditor = CType(sender, ASPxHtmlEditor)

		Dim userDictionary As ASPxSpellCheckerCustomDictionary = CType(htmlEditor.SettingsSpellChecker.Dictionaries(1), ASPxSpellCheckerCustomDictionary)
		userDictionary.CacheKey = String.Format("dic_{0}", UserName)
		userDictionary.DictionaryPath = String.Format("~/CustomDictionaries/{0}.dic", UserName)
	End Sub

	Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim dic As SpellCheckerCachedCustomDictionary = CType(Session(myHtmlEditor.SettingsSpellChecker.Dictionaries(1).CacheKey), SpellCheckerCachedCustomDictionary)

		Dim dictionary As New MyCustomDictionary()
		For i As Integer = 0 To dic.WordCount - 1
			dictionary.AddWord(dic(i))
		Next i
		dictionary.SaveAs(dic.DictionaryPath)
	End Sub

End Class

