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
    public partial class MobileCtr : ViewController
    {
        public MobileCtr()
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
                mobile mob = null;
                if (item.GetType() == typeof(XafInstantFeedbackRecord))
                    mob = ObjectSpace.GetObjectByKey<mobile>(((XafInstantFeedbackRecord)item).ObjectKeyValue);
                else if (item.GetType() == typeof(mobile))
                    mob = ObjectSpace.GetObjectByKey<mobile>(((mobile)item).id);

                mob.inventory_id = ObjectSpace.GetObject(currentObject.inventoryId);
                mob.Save();
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
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(ChangeMobileStatus));
            string win = Application.FindDetailViewId(typeof(ChangeMobileStatus));

            //CollectionSourceBase collectionSource = Application.CreateCollectionSource(objectSpace, typeof(BusinessObjects.NonPersistent.StudentPayments), win);
            //e.View = Application.CreateListView(win, collectionSource, true);
            e.View = Application.CreateDetailView(objectSpace, objectSpace.CreateObject(typeof(ChangeMobileStatus)), true);
            //Optionally customize the window display settings. 
            e.Size = new System.Drawing.Size(200, 120);
            //e.Maximized = true; 
            //e.IsSizeable = false;
        }
        private void ChangeStautspopupWin_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            ChangeMobileStatus currentObject = (ChangeMobileStatus)e.PopupWindowView.CurrentObject;

            foreach (object item in e.SelectedObjects)
            {
                mobile mob = null;
                if (item.GetType() == typeof(XafInstantFeedbackRecord))
                    mob = ObjectSpace.GetObjectByKey<mobile>(((XafInstantFeedbackRecord)item).ObjectKeyValue);
                else if (item.GetType() == typeof(mobile))
                    mob = ObjectSpace.GetObjectByKey<mobile>(((mobile)item).id);

                mob.status_id = ObjectSpace.GetObject(currentObject.status_id);
                mob.Save();
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
