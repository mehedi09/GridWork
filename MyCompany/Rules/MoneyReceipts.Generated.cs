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
	public partial class MoneyReceiptsBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("MoneyReceipts", RowKind.New)]
        public void BuildNewMoneyReceipts()
        {
            UpdateFieldValue("MRDate", DateTime.Now);
            UpdateFieldValue("ReceiptType", 0);
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
