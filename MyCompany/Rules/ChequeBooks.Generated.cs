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
	public partial class ChequeBooksBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("ChequeBooks", RowKind.New)]
        public void BuildNewChequeBooks()
        {
            UpdateFieldValue("CreatedDate", DateTime.Now);
        }
    }
}
