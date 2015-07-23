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
	public partial class ImpresstFundCoinsBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("ImpresstFundCoins", RowKind.New)]
        public void BuildNewImpresstFundCoins()
        {
            UpdateFieldValue("TranDate", DateTime.Now);
            UpdateFieldValue("CoinName", 1000);
        }
    }
}
