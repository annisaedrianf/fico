using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace cetho.Module.BusinessObjects
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)] // AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Field | 
    public class NullTextAttribute : Attribute
    {
        public static NullTextAttribute Default = new NullTextAttribute(null);

        public NullTextAttribute(string nullText)
        {
            NullText = nullText;
        }

        public string NullText { get; set; }
    }
}
