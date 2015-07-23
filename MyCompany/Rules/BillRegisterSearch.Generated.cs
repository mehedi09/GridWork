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
	public partial class BillRegisterSearchBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("BillRegisterSearch", RowKind.New)]
        public void BuildNewBillRegisterSearch()
        {
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
