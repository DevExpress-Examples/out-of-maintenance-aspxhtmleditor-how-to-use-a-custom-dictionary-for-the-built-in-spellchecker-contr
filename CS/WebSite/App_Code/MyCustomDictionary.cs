using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraSpellChecker;
using System.Globalization;

public class MyCustomDictionary : SpellCheckerCustomDictionary {
    public override bool Loaded { get { return true; } }
}