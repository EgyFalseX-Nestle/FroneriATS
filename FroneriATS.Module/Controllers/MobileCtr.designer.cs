using System;
using DevExpress.ExpressApp.Actions;

namespace FroneriATS.Module.Controllers
{
    partial class MobileCtr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileCtr));
            this.ChangeMobileInventorypopupWin = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ChangeMobileStatuspopupWin = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.TargetObjectType = typeof(Module.BusinessObjects.FroneriATS.mobile);
            this.Actions.Add(this.ChangeMobileInventorypopupWin);
            this.Actions.Add(this.ChangeMobileStatuspopupWin);
            // 
            // ChangeInventorypopupWin
            // 
            this.ChangeMobileInventorypopupWin.AcceptButtonCaption = "Save";
            this.ChangeMobileInventorypopupWin.CancelButtonCaption = "Cancel";
            this.ChangeMobileInventorypopupWin.Caption = "Change Inventory";
            this.ChangeMobileInventorypopupWin.Category = "Edit";
            this.ChangeMobileInventorypopupWin.ConfirmationMessage = null;
            this.ChangeMobileInventorypopupWin.Id = "ChangeMobileInventorypopupWin";
            this.ChangeMobileInventorypopupWin.ImageName = "RenameDataSource_32x32";
            this.ChangeMobileInventorypopupWin.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireMultipleObjects;
            this.ChangeMobileInventorypopupWin.TargetObjectType = typeof(Module.BusinessObjects.FroneriATS.mobile);
            this.ChangeMobileInventorypopupWin.ToolTip = null;
            this.ChangeMobileInventorypopupWin.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.ChangeMobileInventorypopupWin.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ChangeInventorypopupWin_CustomizePopupWindowParams);
            this.ChangeMobileInventorypopupWin.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ChangeInventorypopupWin_Execute);

            // 
            // ChangeStatuspopupWin
            // 
            this.ChangeMobileStatuspopupWin.AcceptButtonCaption = "Save";
            this.ChangeMobileStatuspopupWin.CancelButtonCaption = "Cancel";
            this.ChangeMobileStatuspopupWin.Caption = "Change Status";
            this.ChangeMobileStatuspopupWin.Category = "Edit";
            this.ChangeMobileStatuspopupWin.ConfirmationMessage = null;
            this.ChangeMobileStatuspopupWin.Id = "ChangeMobileStatuspopupWin";
            this.ChangeMobileStatuspopupWin.ImageName = "RenameDataSource_32x32";
            this.ChangeMobileStatuspopupWin.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireMultipleObjects;
            this.ChangeMobileStatuspopupWin.TargetObjectType = typeof(Module.BusinessObjects.FroneriATS.mobile);
            this.ChangeMobileStatuspopupWin.ToolTip = null;
            this.ChangeMobileStatuspopupWin.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.ChangeMobileStatuspopupWin.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ChangeStatuspopupWin_CustomizePopupWindowParams);
            this.ChangeMobileStatuspopupWin.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ChangeStautspopupWin_Execute);

        }

        


        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ChangeMobileInventorypopupWin;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ChangeMobileStatuspopupWin;
    }
}
