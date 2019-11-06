using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;

namespace FroneriATS.Module.Core
{
    public static class SqlOp
    {
        public static DateTime GetServerDateTime(Session session)
        {
            CriteriaOperator funcNow = new FunctionOperator(FunctionOperatorType.Now);
            return (DateTime)session.Evaluate(typeof(XPObjectType), funcNow, null);
        }
        public static DateTime GetServerDateTime(DevExpress.ExpressApp.IObjectSpace session)
        {
            CriteriaOperator funcNow = new FunctionOperator(FunctionOperatorType.Now);
            return (DateTime)session.Evaluate(typeof(XPObjectType), funcNow, null);
        }

    }
}
