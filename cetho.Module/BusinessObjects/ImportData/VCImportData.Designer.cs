namespace cetho.Module.Controllers
{
    partial class VCImportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem1 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem2 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            this.scAction = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            // 
            // scAction
            // 
            this.scAction.Caption = "Import";
            this.scAction.ConfirmationMessage = null;
            this.scAction.DefaultItemMode = DevExpress.ExpressApp.Actions.DefaultItemMode.LastExecutedItem;
            this.scAction.Id = "scImport";
            this.scAction.ImageName = "Import";
            choiceActionItem1.Caption = "Import";
            choiceActionItem1.Id = "Import";
            choiceActionItem1.ImageName = "Import";
            choiceActionItem1.Shortcut = null;
            choiceActionItem1.ToolTip = null;
            
            choiceActionItem2.Caption = "Template for Import";
            choiceActionItem2.Id = "Export";
            choiceActionItem2.ImageName = "Export";
            choiceActionItem2.Shortcut = null;
            choiceActionItem2.ToolTip = null;
            this.scAction.Items.Add(choiceActionItem1);
            this.scAction.Items.Add(choiceActionItem2);
            this.scAction.ItemType = DevExpress.ExpressApp.Actions.SingleChoiceActionItemType.ItemIsOperation;
            this.scAction.QuickAccess = true;
            this.scAction.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.scAction.ToolTip = null;
            this.scAction.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.scAction.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.scAction_Execute);
            // 
            // VCImportData
            // 
            //this.Actions.Add(this.scAction);

        }

        #endregion
        private DevExpress.ExpressApp.Actions.SingleChoiceAction scAction;
    }
}
