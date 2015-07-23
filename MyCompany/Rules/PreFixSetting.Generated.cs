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
	public partial class PreFixSettingBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("PreFixSetting", RowKind.New)]
        public void BuildNewPreFixSetting()
        {
            UpdateFieldValue("AccFundID", 3);
        }
    }
}
