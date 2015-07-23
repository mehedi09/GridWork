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
	public partial class AccBillRegisterDBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("AccBillRegisterD", RowKind.New)]
        public void BuildNewAccBillRegisterD()
        {
            UpdateFieldValue("Amount", 0);
        }
    }
}
