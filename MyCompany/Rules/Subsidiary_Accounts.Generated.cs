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
	public partial class Subsidiary_AccountsBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("Subsidiary_Accounts", RowKind.New)]
        public void BuildNewSubsidiary_Accounts()
        {
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
