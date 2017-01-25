using Abp.Web.Mvc.Views;

namespace scubadivelogs.Web.Views
{
    public abstract class scubadivelogsWebViewPageBase : scubadivelogsWebViewPageBase<dynamic>
    {

    }

    public abstract class scubadivelogsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected scubadivelogsWebViewPageBase()
        {
            LocalizationSourceName = scubadivelogsConsts.LocalizationSourceName;
        }
    }
}