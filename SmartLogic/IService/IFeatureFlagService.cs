using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
  public  interface IFeatureFlagService
    {
        Task<int> Delete(int id);
        Task<int> Save(FeatureFlag FeatureFlag);
        Task<int> Update(FeatureFlag FeatureFlag);
        Task<int> ActionFeatureFlag(int id, DatabaseAction action);
        Task<FeatureFlag> FindFeatureFlag(int id);
        Task<List<FeatureFlag>> FeatureFlag();
    }
}
