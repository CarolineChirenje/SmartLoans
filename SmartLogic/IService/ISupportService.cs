using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface ISupportService
    {
        Task<int> Update(TechnicalSupport Support);
        Task<TechnicalSupport> FindSupport(int id);
        Task<List<TechnicalSupport>> Support();
    }
}
