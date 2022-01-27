using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartInterfaces


{

    public class KhonapoReport
    {

        public string KonapoFundID { get; set; }
        public string ClientID { get; set; }
        public string FundName { get; set; }
        public string FundReference { get; set; }
        public string CFEmergencyfund { get; set; }
        public string CFPeriod { get; set; }
        public string CFAnnualFund { get; set; }
        public string CFLifeTimeRetirement { get; set; }
        public string CFRetirementPeriod { get; set; }
        public string CFFund { get; set; }
        public bool CFDisplayOnReport { get; set; }
        public string OTIInvestmentAmount { get; set; }
        public string OTIInterestRate { get; set; }
        public string OTITenure { get; set; }
        public string OTITotalValue { get; set; }
        public string OTIMultiplier { get; set; }
        public bool OTIDisplayOnReport { get; set; }
        public string TTRIncomeAverage { get; set; }
        public string TTRCommittment { get; set; }
        public string TTRFundTargetMonths { get; set; }
        public string TTRFundTargetYears { get; set; }
        public bool TTRDisplayOnReport { get; set; }
        public string TAFPProgress { get; set; }
        public string TAFPBalance { get; set; }
        public string TAFPCommittment { get; set; }
        public string TAFPTargetMonths { get; set; }
        public string TAFPTargetYears { get; set; }
        public bool TAFPDisplayOnReport { get; set; }
        public string TATProgress { get; set; }
        public string TATBalance { get; set; }
        public string TATCommittment { get; set; }
        public string TATTargetMonths { get; set; }
        public string TATTargetYears { get; set; }
        public bool TATDisplayOnReport { get; set; }
        public string RDInvestmentAmount { get; set; }
        public string RDInterestRate { get; set; }
        public string RDTenure { get; set; }
        public string RDPaymentsYear { get; set; }
        public string RDContributions { get; set; }
        public string RDTotalValue { get; set; }
        public string RDMultiplier { get; set; }
        public bool RDDisplayOnReport { get; set; }
        public bool MBDisplayOnReport { get; set; }
        public string CurrentURL { get; set; }
        public string KonapoFundReportID { get; set; }

        public bool SavePrintedReport { get; set; }
        
        public ClientForm Client { get; set; }

        public DataTable Transactions { get; set; }

    }

}
