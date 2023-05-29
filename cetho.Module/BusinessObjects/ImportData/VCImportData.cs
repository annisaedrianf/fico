using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
//using cetho.Ecosys.BusinessObjects;
using DevExpress.Utils;
using DevExpress.DataAccess.Native.Data;
using System.Reflection;
using cetho.Module.BusinessObjects;
//using DevExpress.ExpressApp.Blazor.Components;

namespace cetho.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class VCImportData :  ViewController
    {
        //private string sLast;
        //private oImportFiles obj;
        private ChoiceActionItem setPriorityItem;
        public VCImportData()
        {

            InitializeComponent();
            TargetViewType = ViewType.DashboardView;
            // 
            PopupWindowShowAction ImportDataAction = new PopupWindowShowAction(this, "ShowImportAction", PredefinedCategory.Edit)
            {
                Caption = "Import Data"
            };

            
            ImportDataAction.CustomizePopupWindowParams += ShowImportAction_CustomizePopupWindowParams;
            ImportDataAction.Execute += ShowImportAction_Execute;

            //PopupWindowShowAction showInitiatedAction = new PopupWindowShowAction(this, "ShowInitiatedAction", PredefinedCategory.Edit)
            //{
            //    Caption = "Initiated"
            //};
            //SingleChoiceAction SetTaskAction = new SingleChoiceAction(this, "SetTaskAction", PredefinedCategory.Edit)
            //{
            //    Caption = "Set Task",
            //    ItemType = SingleChoiceActionItemType.ItemIsOperation,
            //    SelectionDependencyType = SelectionDependencyType.RequireMultipleObjects
            //};


        }
        private void ShowImportAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(oImportFiles));
            
            /*
            //string noteListViewId = Application.FindLookupListViewId(typeof(iFileTemplate));
            string noteListViewId = Application.FindDetailViewId(typeof(oImportFiles));
            CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(oImportFiles), noteListViewId);
            //e.View = Application.CreateListView(noteListViewId, collectionSource, true);
            e.View = Application.CreateDetailView(objectSpace,noteListViewId, true);
            */
            string oid;
            string MasterOid = "";
            string MasterPropertyName = "";
            object objMaster = null;
            ListView lv = (ListView)View;
            IObjectSpace objectSpaceInternal = Application.CreateObjectSpace(typeof(oImportFiles));
            oImportFiles obj = objectSpaceInternal.CreateObject<oImportFiles>();
            //obj.DataType = View.ObjectTypeInfo.Type.Name/*/*;*/*/
            PropertyCollectionSource pcs = lv.CollectionSource as PropertyCollectionSource;

            if (pcs != null)
            {
                Type otype = pcs.MasterObject.GetType();
                objMaster = pcs.MasterObject;
                string MasterId = pcs.MasterObject.ToString();
                MasterPropertyName = pcs.MemberInfo.AssociatedMemberInfo.Name;
                int start = MasterId.IndexOf("(") + 1;
                int end = MasterId.IndexOf(")");
                MasterOid = MasterId.Substring(start, (end - start));
            }

            obj.UpdateTempate(lv.ObjectTypeInfo.Type.ToString());

            //IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Person));
            Object currentObject = objectSpace.CreateObject(typeof(oImportFiles));


            string dvoImportFiles = Application.FindDetailViewId(typeof(oImportFiles));
            // objectSpace
            //e.View = Application.CreateDetailView(objectSpace, dvoImportFiles, true);
            
            DetailView createdView = Application.CreateDetailView(objectSpace, dvoImportFiles, true);
            
            createdView.CurrentObject = currentObject;
            e.View = createdView;


            /*
            DetailView confirmationDetailView = Application.CreateDetailView(objectSpaceInternal, obj);
            confirmationDetailView.Caption = confirmationDetailView.Caption + " " + lv.Caption;
            Application.ShowViewStrategy.ShowViewInPopupWindow(confirmationDetailView, OkDelegate, CancelDelegate);
            //Import(obj.Oid.ToString(), MasterOid);
            //e.View = DetailView;
              
            oid = obj.Oid.ToString();
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(oImportFiles));
            string sqlQuery = string.Format(" Oid == '{0}' ", oid.Replace("'", "''"));
            CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            oImportFiles oImportFile = objectSpace.FindObject<oImportFiles>(filterOperator);
            
            if (oImportFile != null)
            {
                // oImportFile.Import(MasterOid);
                oImportFile.Import(View.ObjectTypeInfo.Type, MasterOid, MasterPropertyName);
            }

            lv.RefreshDataSource();
            lv.Refresh();
            */

        }
        private void ShowImportAction_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {



            /*
            DemoTask task = (DemoTask)View.CurrentObject;
            foreach (Note note in e.PopupWindowViewSelectedObjects)
            {
                if (!string.IsNullOrEmpty(task.Description))
                {
                    task.Description += Environment.NewLine;
                }
                // Add selected notes' text to a Task's description
                task.Description += note.Text;
            }
            View.ObjectSpace.CommitChanges();
            */

            //oImportFiles op = e.PopupWindowViewSelectedObjects
            string oid;
            string MasterOid = "";
            string MasterPropertyName = "";
            object objMaster = null;
            ListView lv = (ListView)View;
            IObjectSpace objectSpaceInternal = Application.CreateObjectSpace(typeof(oImportFiles));
            oImportFiles obj = objectSpaceInternal.CreateObject<oImportFiles>();
            //obj.DataType = View.ObjectTypeInfo.Type.Name/*/*;*/*/
            PropertyCollectionSource pcs = lv.CollectionSource as PropertyCollectionSource;

            if (pcs != null)
            {
                Type otype = pcs.MasterObject.GetType();
                objMaster = pcs.MasterObject;
                string MasterId = pcs.MasterObject.ToString();
                MasterPropertyName = pcs.MemberInfo.AssociatedMemberInfo.Name;
                int start = MasterId.IndexOf("(") + 1;
                int end = MasterId.IndexOf(")");
                MasterOid = MasterId.Substring(start, (end - start));
            }

            foreach (oImportFiles note in e.PopupWindowViewSelectedObjects)
            {
                note.Save();
                note.Session.CommitTransaction();
                note.Import(View.ObjectTypeInfo.Type, MasterOid, MasterPropertyName);

                //note.Template();
            }
            //lv.Refresh();
        }
        void showDetailViewAction_CustomizePopupWindowParams( object sender, CustomizePopupWindowParamsEventArgs e)
        {
            /*
            IObjectSpace newObjectSpace = Application.CreateObjectSpace(typeof(oImportFiles));
            //IObjectSpace newObjectSpace = Application.CreateObjectSpace(View.ObjectTypeInfo.Type);
            Object objectToShow = newObjectSpace.GetObject(View.CurrentObject);
            if (objectToShow != null)
            {
                DetailView createdView = Application.CreateDetailView(newObjectSpace, objectToShow);
                createdView.ViewEditMode = ViewEditMode.Edit;
                e.View = createdView;
            }
            */
        }
        private void ShowListViewAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            /*
            Type objectType = typeof(fLanguage);
            //e.View = Application.CreateListView(objectType, true);
            
            //IObjectSpace newObjectSpace = Application.CreateObjectSpace(typeof(oImportFiles));
            IObjectSpace newObjectSpace = Application.CreateObjectSpace(View.ObjectTypeInfo.Type);
            Object objectToShow = newObjectSpace.GetObject(View.CurrentObject);
            if (objectToShow != null)
            {
                DetailView createdView = Application.CreateDetailView(newObjectSpace, objectToShow);
                createdView.ViewEditMode = ViewEditMode.Edit;
                e.View = createdView;
            }
            */
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            //base.OnActivated();
            NewObjectViewController controller = Frame.GetController<NewObjectViewController>();
            if (controller != null)
            {
                controller.CollectDescendantTypes += NewObjectViewController_CollectDescendantTypes;
            }
        }
        private void NewObjectViewController_CollectDescendantTypes(
        object sender, CollectTypesEventArgs e)
        {
            //foreach (Type type in e.Types)
            //{
            //    if (type.Name == nameof(Person)) { e.Types.Remove(type); break; }
            //}
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }

        
        private void sAImportData_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

            string MasterOid = "";
            ListView lv = (ListView)View;
            IObjectSpace objectSpaceInternal = Application.CreateObjectSpace(typeof(oImportFiles));
            oImportFiles obj  = objectSpaceInternal.CreateObject<oImportFiles>();
            //obj.Type= lv.GetType();
            //obj.name  name

            obj.DataType = View.ObjectTypeInfo.Type.Name;
            //obj.ObjectType = View.ObjectTypeInfo.Type/*/*;*/*/*/*/
            PropertyCollectionSource pcs = lv.CollectionSource as PropertyCollectionSource;
            
            if (pcs != null)
            {
                //DataView b = pcs.MasterObject.GetType();
                //object masterObject = pcs != null ? objectSpaceInternal.GetObjectByKey(pcs.MasterObjectType, objectSpaceInternal.GetKeyValue(pcs.MasterObject)) : null;

                string MasterId= pcs.MasterObject.ToString();

                obj.Description = pcs.MasterObject.ToString();
                obj.MasterObject = pcs.MasterObject.GetType().Name;
                int start= MasterId.IndexOf("(")+1;
                int end = MasterId.IndexOf(")");
                MasterOid = MasterId.Substring(start, (end - start));

                //obj.Description = pcs.MasterObject.GetHashCode. .TargetViewI().
                //obj.Description= pcs.ObjectTypeInfo.Type.
            }
                //obj.da.DataType = View.ObjectTypeInfo.Type;
                //obj.Name = "Analysis: " + View.Caption + " " + SecuritySystem.CurrentUserName.ToString(); ;
                //e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpaceInternal, obj);
                //e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow;
                //e.ShowViewParameters.Context = TemplateContext.View;
                DetailView confirmationDetailView = Application.CreateDetailView(objectSpaceInternal, obj);
            Application.ShowViewStrategy.ShowViewInPopupWindow(confirmationDetailView, OkDelegate, CancelDelegate);
            Import(obj.Oid.ToString(), MasterOid);
            lv.RefreshDataSource();
            lv.Refresh();
            //obj.Import();

            //ChoiceActionItem activeItem = e.Action. .SelectedChoiceActionItem;

            // NonPersistentObjectSpace objectSpace =
            //(NonPersistentObjectSpace)Application.CreateObjectSpace(typeof(ConfirmationWindowParameters));
            // ConfirmationWindowParameters parameters = new ConfirmationWindowParameters();
            // parameters.ConfirmationMessage = "A confirmation message text.";
            // DetailView confirmationDetailView = Application.CreateDetailView(objectSpace, parameters);
            // confirmationDetailView.Caption = "Custom Confirmation Window";
            //Application.ShowViewStrategy.ShowViewInPopupWindow(confirmationDetailView, OkDelegate, CancelDelegate);
            //e.

            // ImportData(e);
        }
        private void Import(string oid,string MasterOid="")
        {
           // Application.ShowViewStrategy.ShowMessage(" data -> " + oid);
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(oImportFiles));
            string sqlQuery = string.Format(" Oid == '{0}' ", oid.Replace("'", "''"));
            CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            oImportFiles oImportFile = objectSpace.FindObject<oImportFiles>(filterOperator);
            if (oImportFile != null)
            {
                oImportFile.Import(MasterOid);
  
            }
          }
        public void OkDelegate()
        {
             //.GetType().typeof(oImportFiles));
          //  Application.ShowViewStrategy.ShowMessage("The message is accepted!" + View.ObjectTypeInfo.Type.Name);
        }
        public void CancelDelegate()
        {
            //Application.ShowViewStrategy.ShowMessage("The message is canceled!" + View.ObjectTypeInfo.Type.Name);
        }
      

 

        private void scAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {
            ChoiceActionItem activeItem = e.SelectedChoiceActionItem;

            ListView lv = (ListView)View;
            switch (activeItem.Id)
            {
                case "Import":
                    Import(lv);
                    break;

                case "Export":
                    Export(lv);
                    break;
            }
        }

       private void Export(ListView lv)
        {
            string oid;
            string MasterOid = "";

            IObjectSpace objectSpaceInternal = Application.CreateObjectSpace(typeof(iFileTemplate));
            string sqlQuery = string.Format(" DataType == '{0}' ", View.ObjectTypeInfo.Type.Name.Replace("'", "''"));
            CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            iFileTemplate obj = objectSpaceInternal.FindObject<iFileTemplate>(filterOperator);

            if (obj==null)
            {
                 obj = objectSpaceInternal.CreateObject<iFileTemplate>();
            }

            //iFileTemplate oImportFile = objectSpace.FindObject<iFileTemplate>(filterOperator);
            //obj.DataType = View.ObjectTypeInfo.Type.Name;
            obj.DataType = View.ObjectTypeInfo.Type.FullName;
            PropertyCollectionSource pcs = lv.CollectionSource as PropertyCollectionSource;
            if (pcs != null)
            {
                string MasterId = pcs.MasterObject.ToString();
                obj.Object = pcs.MasterObject.ToString();
              //  obj.Name = pcs.MasterObject.GetType().Name;
                int start = MasterId.IndexOf("(") + 1;
                int end = MasterId.IndexOf(")");
                MasterOid = MasterId.Substring(start, (end - start));
            }
            obj.UpdateTempate();
            obj.Save();
            obj.Session.CommitTransaction();

            DetailView confirmationDetailView = Application.CreateDetailView(objectSpaceInternal, obj);
            confirmationDetailView.ViewEditMode = ViewEditMode.View;
            confirmationDetailView.Model.AllowEdit = false;
            confirmationDetailView.Model.AllowDelete = false;
            confirmationDetailView.Model.AllowNew = false;
            Application.ShowViewStrategy.ShowViewInPopupWindow(confirmationDetailView, OkDelegate, CancelDelegate);
            //Import(obj.Oid.ToString(), MasterOid);
            //oid = obj.Oid.ToString();
            //IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(iFileTemplate));
            //string sqlQuery = string.Format(" Oid == '{0}' ", oid.Replace("'", "''"));
            //CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            //iFileTemplate oImportFile = objectSpace.FindObject<iFileTemplate>(filterOperator);


            lv.RefreshDataSource();
            lv.Refresh();
        }
       private void Import(ListView lv)
        {
            string oid;
            string MasterOid = "";
            string MasterPropertyName = "";
            object objMaster=null;
            IObjectSpace objectSpaceInternal = Application.CreateObjectSpace(typeof(oImportFiles));
            oImportFiles obj = objectSpaceInternal.CreateObject<oImportFiles>();
            //obj.DataType = View.ObjectTypeInfo.Type.Name/*/*;*/*/
            PropertyCollectionSource pcs = lv.CollectionSource as PropertyCollectionSource;
            
            if (pcs != null)
            {
                Type otype = pcs.MasterObject.GetType();
                objMaster = pcs.MasterObject;
                string MasterId = pcs.MasterObject.ToString();
                //obj.Description = pcs.MasterObject.ToString();
                //obj.MasterObject = pcs.MasterObject.GetType().Name;
                //obj.Description=pcs.MemberInfo.AssociatedMemberInfo.Name;
                MasterPropertyName = pcs.MemberInfo.AssociatedMemberInfo.Name;
                int start = MasterId.IndexOf("(") + 1;
                int end = MasterId.IndexOf(")");
                MasterOid = MasterId.Substring(start, (end - start));
      

            }
            DetailView confirmationDetailView = Application.CreateDetailView(objectSpaceInternal, obj);
            confirmationDetailView.Caption = confirmationDetailView.Caption + " " + lv.Caption;
            Application.ShowViewStrategy.ShowViewInPopupWindow(confirmationDetailView, OkDelegate, CancelDelegate);
            //Import(obj.Oid.ToString(), MasterOid);
            
            oid = obj.Oid.ToString();
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(oImportFiles));
            string sqlQuery = string.Format(" Oid == '{0}' ", oid.Replace("'", "''"));
            CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            oImportFiles oImportFile = objectSpace.FindObject<oImportFiles>(filterOperator);
            if (oImportFile != null)
            {
                // oImportFile.Import(MasterOid);
                oImportFile.Import(View.ObjectTypeInfo.Type, MasterOid, MasterPropertyName);
            }

            lv.RefreshDataSource();
            lv.Refresh();

            
        }

        protected virtual void ImportData(SingleChoiceActionExecuteEventArgs e)
        {

            ChoiceActionItem activeItem = e.SelectedChoiceActionItem;
            //ListView lv = (ListView)View;
            //ImportDataManager importManager = new ImportDataManager(Application);
            switch (activeItem.Data.ToString())
            {
                case "Person_ListView":
                    //importManager.ImportData<Person>(MaxImportedRecordsCount, ImportDataLogic.CreateCoolPersonImportDataFromXmlFileDelegate(), null, lv, true);
                    //Dennis: This line won't be executed unless you handle the exception thrown from the previus ImportData call.
                    //ImportDataManager.ImportData<Person>(MaxImportedRecordsCount, ImportDataLogic.CreateDummyPersonImportDataDelegate(), ImportDataLogic.CreateDummyPersonValidateDataDelegate(), lv, true);
                    break;
                case "Party_PhoneNumbers_ListView":
                    //PropertyCollectionSource pcs = lv.CollectionSource as PropertyCollectionSource;
                    //if (pcs != null)
                    //{
                    //    importManager.ImportData<PhoneNumber>(MaxImportedRecordsCount, ImportDataLogic.CreateDummyPhoneNumberImportDataDelegate(), ImportDataLogic.CreateDummyPhoneNumberValidateDataDelegate(), lv, true);
                    //}
                    break;
            }

        }
    }
}
