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
	public partial class AccountsReceivableBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("AccountsReceivable", RowKind.New)]
        public void BuildNewAccountsReceivable()
        {
            UpdateFieldValue("AccSubTypeID", 3);
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
