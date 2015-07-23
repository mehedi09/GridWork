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
	public partial class CoaDetailBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("CoaDetail", RowKind.New)]
        public void BuildNewCoaDetail()
        {
            UpdateFieldValue("AccCurrency", 1);
        }
    }
}
