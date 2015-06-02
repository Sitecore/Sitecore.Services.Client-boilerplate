using Sitecore.EntityServiceBoilerplate.Attributes;
using Sitecore.Services.Core.MetaData;

namespace Sitecore.EntityServiceBoilerplate.MetaData
{
    public class RandomResultMetaData : ValidationMetaDataBase<RandomResultAttribute>
    {
        public RandomResultMetaData()
            : base("randomResult")
        {
        }
    }
}