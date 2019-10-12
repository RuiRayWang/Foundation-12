using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Cms.Pages
{
    [ContentType(DisplayName = "Search Result Page",
        GUID = "6e0c84de-bd17-43ee-9019-04f08c7fcf8d",
        Description = "Page to allow customer to search the site",
        GroupName = CmsTabNames.Content)]
    [ImageUrl("~/assets/icons/cms/pages/CMS-icon-page-03.png")]
    public class SearchResultPage : FoundationPageData
    {
        [CultureSpecific]
        [Display(Name = "Top content area", Order = 10)]
        public virtual ContentArea TopContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Show recommendations", Description = "This will determine whether or not to show recommendations", Order = 20)]
        public virtual bool ShowRecommendations { get; set; }

        public override void SetDefaultValues(ContentType contentType) => ShowRecommendations = true;
    }
}