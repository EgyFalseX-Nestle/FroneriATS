using System;
using DevExpress.ExpressApp.Actions;

namespace FroneriATS.Module.Controllers
{
    partial class PrinterCtr
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
            this.ChangePrinterInventorypopupWin = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.ChangePrinterStatuspopupWin = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.TargetObjectType = typeof(Module.BusinessObjects.FroneriATS.printer);
            this.Actions.Add(this.ChangePrinterInventorypopupWin);
            this.Actions.Add(this.ChangePrinterStatuspopupWin);
            // 
            // ChangeInventorypopupWin
            // 
            this.ChangePrinterInventorypopupWin.AcceptButtonCaption = "Save";
            this.ChangePrinterInventorypopupWin.CancelButtonCaption = "Cancel";
            this.ChangePrinterInventorypopupWin.Caption = "Change Inventory";
            this.ChangePrinterInventorypopupWin.Category = "Edit";
            this.ChangePrinterInventorypopupWin.ConfirmationMessage = null;
            this.ChangePrinterInventorypopupWin.Id = "ChangePrinterInventorypopupWin";
            this.ChangePrinterInventorypopupWin.ImageName = "RenameDataSource_32x32";
            this.ChangePrinterInventorypopupWin.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireMultipleObjects;
            this.ChangePrinterInventorypopupWin.TargetObjectType = typeof(Module.BusinessObjects.FroneriATS.printer);
            this.ChangePrinterInventorypopupWin.ToolTip = null;
            this.ChangePrinterInventorypopupWin.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.ChangePrinterInventorypopupWin.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ChangeInventorypopupWin_CustomizePopupWindowParams);
            this.ChangePrinterInventorypopupWin.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ChangeInventorypopupWin_Execute);
            // 
            // ChangeStatuspopupWin
            // 
            this.ChangePrinterStatuspopupWin.AcceptButtonCaption = "Save";
            this.ChangePrinterStatuspopupWin.CancelButtonCaption = "Cancel";
            this.ChangePrinterStatuspopupWin.Caption = "Change Status";
            this.ChangePrinterStatuspopupWin.Category = "Edit";
            this.ChangePrinterStatuspopupWin.ConfirmationMessage = null;
            this.ChangePrinterStatuspopupWin.Id = "ChangePrinterStatuspopupWin";
            this.ChangePrinterStatuspopupWin.ImageName = "RenameDataSource_32x32";
            this.ChangePrinterStatuspopupWin.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireMultipleObjects;
            this.ChangePrinterStatuspopupWin.TargetObjectType = typeof(Module.BusinessObjects.FroneriATS.printer);
            this.ChangePrinterStatuspopupWin.ToolTip = null;
            this.ChangePrinterStatuspopupWin.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.ChangePrinterStatuspopupWin.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.ChangeStatuspopupWin_CustomizePopupWindowParams);
            this.ChangePrinterStatuspopupWin.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ChangeStautspopupWin_Execute);

        }

        


        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ChangePrinterInventorypopupWin;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ChangePrinterStatuspopupWin;
    }
}
