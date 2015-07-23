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
	public partial class ImpresstFundBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("ImpresstFund", RowKind.New)]
        public void BuildNewImpresstFund()
        {
            UpdateFieldValue("AccSubTypeID", 2);
            UpdateFieldValue("OpenDate", DateTime.Now);
        }
    }
}
