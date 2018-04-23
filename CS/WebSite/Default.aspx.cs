using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxHtmlEditor;
using System.IO;
using DevExpress.Web.ASPxSpellChecker;
using System.Globalization;
using DevExpress.XtraSpellChecker;

public partial class _Default : System.Web.UI.Page {
    string UserDictionaryPath {
        get { return GetUserDictionaryPath(); }
    }
    string UserName {
        get { return GetUserName(); }
    }
    private string GetUserName() {
        return (Request.ServerVariables["remote_user"] != string.Empty) ?
                Request.ServerVariables["remote_user"].Replace("\\", "_") : "anonymous";
    }
    private string GetUserDictionaryPath() {
        string userDictName = string.Format("~/CustomDictionaries/{0}.dic", UserName);
        return Server.MapPath(userDictName);
    }

    protected void myHtmlEditor_Load(object sender, EventArgs e) {
        ASPxHtmlEditor htmlEditor = (ASPxHtmlEditor)sender;

        ASPxSpellCheckerCustomDictionary userDictionary = (ASPxSpellCheckerCustomDictionary)htmlEditor.SettingsSpellChecker.Dictionaries[1];
        userDictionary.CacheKey = string.Format("dic_{0}", UserName);
        userDictionary.DictionaryPath = string.Format("~/CustomDictionaries/{0}.dic", UserName);
    }

    protected void ASPxButton1_Click(object sender, EventArgs e) {
        SpellCheckerCachedCustomDictionary dic = (SpellCheckerCachedCustomDictionary)Session[myHtmlEditor.SettingsSpellChecker.Dictionaries[1].CacheKey];
        MyCustomDictionary dictionary = new MyCustomDictionary();
        for (int i = 0; i < dic.WordCount; i++)
            dictionary.AddWord(dic[i]);
        dictionary.SaveAs(dic.DictionaryPath);
    }
}