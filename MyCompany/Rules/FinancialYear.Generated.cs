﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using MyCompany.Data;

namespace MyCompany.Rules
{
	public partial class FinancialYearBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("FinancialYear", RowKind.New)]
        public void BuildNewFinancialYear()
        {
            UpdateFieldValue("AccFundCode", 3);
        }
    }
}