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
	public partial class ImpresstFundTransBusinessRules : MyCompany.Rules.SharedBusinessRules
    {
        
        [RowBuilder("ImpresstFundTrans", RowKind.New)]
        public void BuildNewImpresstFundTrans()
        {
            UpdateFieldValue("TranDate", DateTime.Now);
            UpdateFieldValue("IsCashCheque", 0);
            UpdateFieldValue("IsPayReceived", 0);
        }
        
        [ControllerAction("ImpresstFundTrans", "Insert", ActionPhase.Before)]
        [ControllerAction("ImpresstFundTrans", "Update", ActionPhase.Before)]
        public void AssignFieldValuesToImpresstFundTrans(
                    int? impFundTranID, 
                    int? impresstFundID, 
                    string impresstFundReference, 
                    string impresstFundAccSubAccSubName, 
                    string impresstFundAccSubAccSubTypeAccSubType, 
                    string impresstFundAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccName, 
                    string impresstFundCoaDetailAccBalTypeAccBalType, 
                    string impresstFundCoaDetailAccCurrencyAccCurrencyName, 
                    string impresstFundCoaDetailAccDestAccDest, 
                    string impresstFundCoaDetailAccFundAccFundName, 
                    string impresstFundCoaDetailAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccTypeAccType, 
                    string impresstFundCoaDetailCoaControlAccName, 
                    string impresstFundCoaDetailCoaMainAccName, 
                    string impresstFundCoaDetailCoaSubAccName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    DateTime? tranDate, 
                    int? slipNo, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundName, 
                    string coaDetailAccSubTypeAccSubType, 
                    string coaDetailAccTypeAccType, 
                    string coaDetailCoaControlAccName, 
                    string coaDetailCoaControlAccBalTypeAccBalType, 
                    string coaDetailCoaControlAccDestAccDest, 
                    string coaDetailCoaControlAccTypeAccType, 
                    string coaDetailCoaControlCompTypeDescription, 
                    string coaDetailCoaMainAccName, 
                    string coaDetailCoaMainAccBalTypeAccBalType, 
                    string coaDetailCoaMainAccDestAccDest, 
                    string coaDetailCoaMainAccFundAccFundName, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundName, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    decimal? amount, 
                    int? isCashCheque, 
                    int? isPayReceived)
        {
            FieldValue IsPayReceivedFieldValue = SelectFieldValueObject("IsPayReceived");
            object IsPayReceivedCodeValue = 1;
            if (IsPayReceivedFieldValue == null)
            	AddFieldValue("IsPayReceived", IsPayReceivedCodeValue);
            else
            {
                IsPayReceivedFieldValue.NewValue = IsPayReceivedCodeValue;
                IsPayReceivedFieldValue.Modified = true;
                IsPayReceivedFieldValue.ReadOnly = false;
            }
        }
    }
}
