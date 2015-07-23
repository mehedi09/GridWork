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
	public partial class VoucherTypesBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("VoucherTypes", RowKind.New)]
        public void BuildNewVoucherTypes()
        {
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
