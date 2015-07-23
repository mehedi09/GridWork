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
	public partial class TrailBalanceParamBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("TrailBalanceParam", RowKind.New)]
        public void BuildNewTrailBalanceParam()
        {
            UpdateFieldValue("AccFundCode", 3);
        }
    }
}
