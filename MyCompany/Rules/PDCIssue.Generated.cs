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
	public partial class PDCIssueBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("PDCIssue", RowKind.New)]
        public void BuildNewPDCIssue()
        {
            UpdateFieldValue("PDCDate", DateTime.Now);
            UpdateFieldValue("ModeofReceiptID", 3);
        }
    }
}
