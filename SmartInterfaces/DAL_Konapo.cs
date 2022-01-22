using System;
using System.Collections.Generic;
using System.Text;

namespace SmartInterfaces


{

    public class KhonapoReport
    {
        public string ClientID { get; set; }
        public string KonapoFundID { get; set; }
        public string FundName { get; set; }
        public string FundReference { get; set; }
        public string CFEmergencyfund { get; set; }
        public string CFPeriod { get; set; }
        public string CFAnnualFund { get; set; }
        public string CFLifeTimeRetirement { get; set; }
        public string CFRetirementPeriod { get; set; }
        
        public string CFFund { get; set; }
        public string OTIInvestmentAmount { get; set; }
        public string OTIInterestRate { get; set; }
        public string OTITenure { get; set; }
        public string OTITotalValue { get; set; }
        public string OTIMultiplier { get; set; }
        public string TTRIncomeAverage { get; set; }
        public string TTRCommittment { get; set; }
        public string TTRFundTargetMonths { get; set; }
        public string TTRFundTargetYears { get; set; }
        public string TAFPProgress { get; set; }
        public string TAFPBalance { get; set; }
        public string TAFPCommittment { get; set; }
        public string TAFPTargetMonths { get; set; }
        public string TAFPTargetYears { get; set; }
        public string TATProgress { get; set; }
        public string TATBalance { get; set; }
        public string TATCommittment { get; set; }
        public string TATTargetMonths { get; set; }
        public string TATTargetYears { get; set; }
        public ClientForm Client { get; set; }
       
    }

}
