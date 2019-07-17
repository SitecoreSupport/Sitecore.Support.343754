namespace Sitecore.Support.XA.Feature.Search.Repositories
{
    using Sitecore.XA.Feature.Search;
    using System.Web.Script.Serialization;

    public class ResultsCountRepository : Sitecore.XA.Feature.Search.Repositories.ResultsCountRepository
    {
        protected override string GetJsonDataProperties()
        {
            #region Added code
            var signature = Rendering.Parameters[Constants.SearchSignature];
            #endregion
            var data = new
            {
                #region Added code
                targetSignature = signature
                #endregion
            }; 
            
            return new JavaScriptSerializer().Serialize(data);
        }
    }
}