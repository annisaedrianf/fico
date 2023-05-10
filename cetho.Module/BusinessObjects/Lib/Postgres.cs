using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace cetho.Module.BusinessObjects
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class Postgres : ViewController
    {
        public Postgres()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            DialogController dialogController = Frame.GetController<DialogController>();
            if (dialogController != null)
            {
                dialogController.AcceptAction.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Unknown;
            }
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();

        }
        public class PostgreSqlConnectionProviderEx : PostgreSqlConnectionProvider
        {
            public new const string XpoProviderTypeString =  "PostgresEx"; //"Postgres";//
            public PostgreSqlConnectionProviderEx(IDbConnection connection, AutoCreateOption autoCreateOption) : base(connection, autoCreateOption)
            {
            }
            public override string FormatFunction(FunctionOperatorType operatorType, params string[] operands)
            {
                if (operatorType == FunctionOperatorType.Contains)
                {
                    return string.Format(CultureInfo.InvariantCulture, "(Strpos(Lower({0}), Lower({1})) > 0)", operands[0], operands[1]);
                }
                return base.FormatFunction(operatorType, operands);
            }
            public new static IDataStore CreateProviderFromString(string connectionString, AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
            {
                IDbConnection connection = CreateConnection(connectionString);
                objectsToDisposeOnDisconnect = new IDisposable[] { connection };
                return CreateProviderFromConnection(connection, autoCreateOption);
            }
            public new static IDataStore CreateProviderFromConnection(IDbConnection connection, AutoCreateOption autoCreateOption)
            {
                return new PostgreSqlConnectionProviderEx(connection, autoCreateOption);
            }
            public new static void Register()
            {
                try
                {
                    DataStoreBase.RegisterDataStoreProvider(XpoProviderTypeString, new DataStoreCreationFromStringDelegate(CreateProviderFromString));
                }
                catch (ArgumentException e)
                {
                    Tracing.Tracer.LogText(e.Message);
                    Tracing.Tracer.LogText("A connection provider with the same name ( {0} ) has already been registered", XpoProviderTypeString);
                }
            }
        }
    }
}
