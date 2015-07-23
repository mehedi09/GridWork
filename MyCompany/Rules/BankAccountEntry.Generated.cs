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
	public partial class BankAccountEntryBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("BankAccountEntry", RowKind.New)]
        public void BuildNewBankAccountEntry()
        {
            UpdateFieldValue("AccFundID", 3);
            UpdateFieldValue("AccTypeID", 1);
            UpdateFieldValue("AccDestID", 3);
            UpdateFieldValue("AccBalTypeID", 1);
            UpdateFieldValue("AccCurrency", 1);
            UpdateFieldValue("CoaControlID", 9);
            UpdateFieldValue("CoaSubID", 16);
            UpdateFieldValue("CoaMainID", 42);
            UpdateFieldValue("AccSubTypeID", 1);
            UpdateFieldValue("MonthlyExp", 0);
            UpdateFieldValue("Dlt", "N");
        }
    }
}
