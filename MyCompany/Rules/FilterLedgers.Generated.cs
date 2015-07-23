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
	public partial class FilterLedgersBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("FilterLedgers", RowKind.New)]
        public void BuildNewFilterLedgers()
        {
            UpdateFieldValue("Start_date", DateTime.Now);
            UpdateFieldValue("To_Date", DateTime.Now);
        }
    }
}
