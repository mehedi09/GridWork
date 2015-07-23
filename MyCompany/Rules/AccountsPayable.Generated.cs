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
	public partial class AccountsPayableBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("AccountsPayable", RowKind.New)]
        public void BuildNewAccountsPayable()
        {
            UpdateFieldValue("AccSubTypeID", 4);
        }
    }
}
