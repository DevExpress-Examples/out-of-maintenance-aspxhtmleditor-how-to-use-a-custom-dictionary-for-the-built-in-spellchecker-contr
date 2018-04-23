<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxHtmlEditor ID="myHtmlEditor" runat="server" OnLoad="myHtmlEditor_Load">
            <SettingsSpellChecker Culture="English (United States)">
                <Dictionaries>
                    <dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/Dictionaries/EnglishAlphabet.txt"
                        GrammarPath="~/Dictionaries/english.aff" DictionaryPath="~/Dictionaries/american.xlg"
                        CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)" />
                    <dx:ASPxSpellCheckerCustomDictionary AlphabetPath="~/Dictionaries/EnglishAlphabet.txt"
                        Culture="English (United States)" EncodingName="Western European (Windows)" />
                </Dictionaries>
            </SettingsSpellChecker>
            <Toolbars>
                <dx:HtmlEditorToolbar Caption="StandardToolbar1" Name="StandardToolbar1">
                    <Items>
                        <dx:ToolbarCheckSpellingButton BeginGroup="True">
                        </dx:ToolbarCheckSpellingButton>
                    </Items>
                </dx:HtmlEditorToolbar>
            </Toolbars>
        </dx:ASPxHtmlEditor>
        <dx:ASPxButton ID="saveButton" runat="server" Text="Save dictionary"
            OnClick="ASPxButton1_Click">
        </dx:ASPxButton>
    </form>
</body>
</html>
