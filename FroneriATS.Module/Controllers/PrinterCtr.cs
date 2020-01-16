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
using FroneriATS.Module.BusinessObjects.FroneriATS;
using FroneriEG.Module.BusinessObjects.NonPersistent;

namespace FroneriATS.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PrinterCtr : ViewController
    {
        public PrinterCtr()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
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

        private void ChangeInventorypopupWin_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(ChangeInventory));
            string win = Application.FindDetailViewId(typeof(ChangeInventory));

            //CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(BusinessObjects.NonPersistent.StudentPayments), win);
            //e.View = Application.CreateListView(win, collectionSource, true);
            e.View = Application.CreateDetailView(objectSpace, objectSpace.CreateObject(typeof(ChangeInventory)), true);
            //Optionally customize the window display settings. 
            e.Size = new System.Drawing.Size(200, 120);
            //e.Maximized = true; 
            //e.IsSizeable = false;
        }
        private void ChangeInventorypopupWin_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            ChangeInventory currentObject = (ChangeInventory)e.PopupWindowView.CurrentObject;

            foreach (object item in e.SelectedObjects)
            {
                printer prnt = null;
                if (item.GetType() == typeof(XafInstantFeedbackRecord))
                    prnt = ObjectSpace.GetObjectByKey<printer>(((XafInstantFeedbackRecord)item).ObjectKeyValue);
                else if (item.GetType() == typeof(printer))
                    prnt = ObjectSpace.GetObjectByKey<printer>(((printer)item).id);

                prnt.inventory_id = ObjectSpace.GetObject(currentObject.inventoryId);
                prnt.Save();
            }
            try
            {
                ObjectSpace.CommitChanges();
            }
            catch (Exception ex)
            {
                ObjectSpace.Rollback(false);
            }
        }

        private void ChangeStatuspopupWin_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(ChangePrinterStatus));
            string win = Application.FindDetailViewId(typeof(ChangePrinterStatus));

            //CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(BusinessObjects.NonPersistent.StudentPayments), win);
            //e.View = Application.CreateListView(win, collectionSource, true);
            e.View = Application.CreateDetailView(objectSpace, objectSpace.CreateObject(typeof(ChangePrinterStatus)), true);
            //Optionally customize the window display settings. 
            e.Size = new System.Drawing.Size(200, 120);
            //e.Maximized = true; 
            //e.IsSizeable = false;
        }
        private void ChangeStautspopupWin_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            ChangePrinterStatus currentObject = (ChangePrinterStatus)e.PopupWindowView.CurrentObject;

            foreach (object item in e.SelectedObjects)
            {
                printer prnt = null;
                if (item.GetType() == typeof(XafInstantFeedbackRecord))
                    prnt = ObjectSpace.GetObjectByKey<printer>(((XafInstantFeedbackRecord)item).ObjectKeyValue);
                else if (item.GetType() == typeof(printer))
                    prnt = ObjectSpace.GetObjectByKey<printer>(((printer)item).id);

                prnt.status_id = ObjectSpace.GetObject(currentObject.status_id);
                prnt.Save();
            }
            try
            {
                ObjectSpace.CommitChanges();
            }
            catch (Exception ex)
            {
                ObjectSpace.Rollback(false);
            }
        }

    }
}

