using Act.Web.Http.Automation.Base.Page;
using OpenQA.Selenium;

namespace act.IntegrationTest.Pages.Contacts
{
    public class RelatedSection : ExpandoSection
    {
        public RelatedSection(ISearchContext context)
            : base(context)
        {
            // at some point the plan is to show more than just opp info in the related tab
            Sections<RelatedOppsSections>("Opps", By.CssSelector("#opportunitiesList .contact-opportunity"));
        }
    }

    public class RelatedOppsSections : ExpandoSection
    {
        public RelatedOppsSections(ISearchContext context)
            : base(context)
        {
            Element("Title", By.CssSelector(".contact-opportunity__name"));
            Element("Stage", By.CssSelector(".contact-opportunity .contact-opportunity__status:nth-of-type(1)"));
            Element("Value", By.CssSelector(".contact-opportunity .contact-opportunity__status:nth-of-type(2)"));
        }
    }
}
