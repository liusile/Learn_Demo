using Abp.Web.Mvc.Views;

namespace Learn_ABP.Web.Views
{
    public abstract class Learn_ABPWebViewPageBase : Learn_ABPWebViewPageBase<dynamic>
    {

    }

    public abstract class Learn_ABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected Learn_ABPWebViewPageBase()
        {
            LocalizationSourceName = Learn_ABPConsts.LocalizationSourceName;
        }
    }
}