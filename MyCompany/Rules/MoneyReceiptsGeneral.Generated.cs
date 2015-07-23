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
	public partial class MoneyReceiptsGeneralBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("MoneyReceiptsGeneral", RowKind.New)]
        public void BuildNewMoneyReceiptsGeneral()
        {
            UpdateFieldValue("MRDate", DateTime.Now);
            UpdateFieldValue("ReceiptType", 1);
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
