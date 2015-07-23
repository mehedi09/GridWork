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
	public partial class PDCReceiveBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("PDCReceive", RowKind.New)]
        public void BuildNewPDCReceive()
        {
            UpdateFieldValue("PDCDate", DateTime.Now);
            UpdateFieldValue("ModeofReceiptID", 3);
            UpdateFieldValue("Amount", 0);
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
