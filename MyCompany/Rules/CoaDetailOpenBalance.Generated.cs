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
	public partial class CoaDetailOpenBalanceBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("CoaDetailOpenBalance", RowKind.New)]
        public void BuildNewCoaDetailOpenBalance()
        {
            UpdateFieldValue("AccCurrency", 1);
        }
    }
}
