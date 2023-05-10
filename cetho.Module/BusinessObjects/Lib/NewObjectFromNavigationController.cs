using DevExpress.Data.Filtering;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace cetho.Module.BusinessObjects
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public partial class NewObjectFromNavigationController : WindowController
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public NewObjectFromNavigationController()
        {
            InitializeComponent();
            // Target required Windows (via the TargetXXX properties) and create their Actions.
            TargetWindowType = WindowType.Main;
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target Window.
            //ShowNavigationItemController showNavigationItemController = Frame.GetController<ShowNavigationItemController>();
            //showNavigationItemController.CustomShowNavigationItem += showNavigationItemController_CustomShowNavigationItem;

            Frame.GetController<ShowNavigationItemController>().CustomShowNavigationItem += new EventHandler<CustomShowNavigationItemEventArgs>(ViewController1_CustomShowNavigationItem);
        }

        void ViewController1_CustomShowNavigationItem(object sender, CustomShowNavigationItemEventArgs e)
        {
            IModelDetailView model = ((IModelNavigationItem)e.ActionArguments.SelectedChoiceActionItem.Model).View as IModelDetailView;
            //if (model != null && model.Id == "RpMMRFFBProduction_DetailView_Copy")
            
           
            if (model != null )
            {
                //&&  model.ModelClass.Name== "cetho.Module.BusinessObjects.ReportMMR"
                Type oType = Type.GetType(model.ModelClass.Name);
                if (oType.Name.Contains("ReportUI"))
                {
                    //model.ModelClass.Name
                    IObjectSpace objectSpace = Application.CreateObjectSpace(oType);
                    //ReportUI objectToShow = objectSpace.FirstOrDefault<ReportUI>(u => u.ReportId == e.ActionArguments.SelectedChoiceActionItem.Id);
                    // IObjectSpace objectSpace = Application.CreateObjectSpace();
                    //RpMMRFFBProduction objectToShow = objectSpace.CreateObject<RpMMRFFBProduction>();
                    object objectToShow = objectSpace.CreateObject(oType);
                    e.ActionArguments.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpace, model, true, objectToShow);
                    e.ActionArguments.ShowViewParameters.TargetWindow = TargetWindow.Current;
                    e.Handled = true;
                }
            }
        }

        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            Frame.GetController<ShowNavigationItemController>().CustomShowNavigationItem -= new EventHandler<CustomShowNavigationItemEventArgs>(ViewController1_CustomShowNavigationItem);
        }

        //void showNavigationItemController_CustomShowNavigationItem(object sender, CustomShowNavigationItemEventArgs e)
        //{
                
        //        IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(RpMMRFFBProduction));
        //        RpMMRFFBProduction newIssue = objectSpace.FirstOrDefault<RpMMRFFBProduction>(u => u.ReportId == e.ActionArguments.SelectedChoiceActionItem.Id);
        //        //RpMMRFFBProduction newIssue = objectSpace.CreateObject<RpMMRFFBProduction>();
        //        if (newIssue != null)
        //        {
        //            DetailView detailView = Application.CreateDetailView(objectSpace, newIssue.ViewId, false, newIssue);
        //            detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
        //            e.ActionArguments.ShowViewParameters.CreatedView = detailView;
        //            e.Handled = true;
        //        }
            
        //}
    }
}
