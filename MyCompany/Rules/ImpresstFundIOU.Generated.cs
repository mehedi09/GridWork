using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class ImpresstFundIOUBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("ImpresstFundIOU", RowKind.New)]
        public void BuildNewImpresstFundIOU()
        {
            UpdateFieldValue("AccSubTypeID", 2);
            UpdateFieldValue("IUODate", DateTime.Now);
            UpdateFieldValue("TransactionType", 0);
            UpdateFieldValue("PaymentMode", 0);
        }
    }
}
