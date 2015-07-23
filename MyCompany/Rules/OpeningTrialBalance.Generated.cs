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
	public partial class OpeningTrialBalanceBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("OpeningTrialBalance", RowKind.New)]
        public void BuildNewOpeningTrialBalance()
        {
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
