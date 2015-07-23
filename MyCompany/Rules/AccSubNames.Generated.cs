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
	public partial class AccSubNamesBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("AccSubNames", RowKind.New)]
        public void BuildNewAccSubNames()
        {
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
