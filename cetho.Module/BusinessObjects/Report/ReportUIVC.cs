using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor.SystemModule;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
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
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ReportUIVC : ViewController<DetailView>
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public ReportUIVC()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            //Activate the Controller only in the Detail View
            TargetViewType = ViewType.DetailView;
            //Specify the type of objects that can use the Controller
            //SimpleAction myAction = new SimpleAction(this, "MyAction",save);
            //myAction.ImageName = "Action_SimpleAction";

            TargetObjectType = typeof(ReportUI);
            //SimpleAction printTasksAction = new SimpleAction(this, "PrintTaskAction", PredefinedCategory.View)
            //{
            //    //Specify the Action's button caption.
            //    Caption = "Print",
            //    //Specify the confirmation message that pops up when a user executes an Action.
            //    ConfirmationMessage = "Are you sure you want to Print?",
            //    //Specify the icon of the Action's button in the interface.
            //    ImageName = "Action_Printing_Print"
            //};
            //////This event fires when a user clicks the Simple Action control.
            //printTasksAction.Execute += printTasksAction_Execute;

        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.

            var blazorModificationsController = Frame.GetController<BlazorModificationsController>();

            if (blazorModificationsController != null)
            {
                //blazorModificationsController.SaveAndNewAction.
            }

            if (View is ListView && !View.IsRoot && View.ObjectTypeInfo.Type == typeof(ReportUI))
            {

                DevExpress.ExpressApp.SystemModule.NewItemRowListViewController NewItemRowController = Frame.GetController<DevExpress.ExpressApp.SystemModule.NewItemRowListViewController>();
                if (NewItemRowController != null)
                {
                    //NewItemRowController.  .Actions("").Active.SetItemValue("myReason", false);
                    // The line below disables the Action button
                    // linkUnlinkController.LinkAction.Enabled.SetItemValue("myReason", false);
                }

                DevExpress.ExpressApp.SystemModule.LinkUnlinkController linkUnlinkController = Frame.GetController<DevExpress.ExpressApp.SystemModule.LinkUnlinkController>();
                if (linkUnlinkController != null)
                {
                    linkUnlinkController.LinkAction.Active.SetItemValue("myReason", false);
                    // The line below disables the Action button
                    // linkUnlinkController.LinkAction.Enabled.SetItemValue("myReason", false);
                }
            }
            //if (blazorModificationsController != null &&
            //    blazorModificationsController.SaveAndNewAction.Active &&
            //    blazorModificationsController.SaveAndNewAction.Enabled)
            //{
            //    blazorModificationsController.SaveAndNewAction.DoExecute(blazorModificationsController.SaveAndNewAction.Items[0]);
            //}

            //SaveAndCloseAction.Active.RemoveItem("BlazorApplication");
            //SaveAndNewAction.Active.RemoveItem("BlazorApplication");

            //var SaveDetailViewController = Frame.GetController<ModificationsController>();
            //if (SaveDetailViewController != null)
            //{
            //      SaveDetailViewController.Actions["Save"].ImageName = "Action_Printing_Print";
            //    SaveDetailViewController.Actions["Save"].Caption = "Print";

            //}
            //if (ObjectSpace is NonPersistentObjectSpace)
            //{

            var confirmationDetailViewController = Frame.GetController<ConfirmationDetailViewController>();
            if (confirmationDetailViewController != null)
            {
                confirmationDetailViewController.Active["DeactivateInCode"] = false;
            }
        }
        //IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(RpMMRFFBProduction));
        //RpMMRFFBProduction newIssue = objectSpace.FirstOrDefault<RpMMRFFBProduction>(u => u.ReportId == TargetViewId);

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

        //public virtual void printTasksAction_Execute(Object sender, SimpleActionExecuteEventArgs e)
        //{
        //    //while (((ReportMMR)View.CurrentObject).Tasks.Count > 0)
        //    //{
        //    //    ((ReportMMR)View.CurrentObject).Tasks.Remove(((Contact)View.CurrentObject).Tasks[0]);
        //    //    ObjectSpace.SetModified(View.CurrentObject);
        //    //}

        //    var controller = Frame.GetController<ModificationsController>();
        //    if (controller != null)
        //    {
        //        controller.SaveAndNewAction.Active.RemoveItem("BlazorApplication");
        //        //controller.SaveAction.DoExecute();// .DoExecute(controller.SaveAndNewAction.Items.FirstActiveItem);
        //        //controller.fi .SaveAndNewAction.DoExecute(controller.SaveAndNewAction.Items.FirstActiveItem);
        //    }
        //}
    }
}

