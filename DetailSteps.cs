using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Act.Web.Http.Automation.Base;
using Act.Web.Http.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace act.IntegrationTest.Steps.Contact
{
    [Binding]
    public class ContactDetailSteps:AutomationTestBase
    {
        [When(@"I open the (info|related) tab")]
        public void GivenIOpenTheInfoTab(string tab)
        {
            var page = Page.ContactDetail;
            Assert.IsTrue(page.Displayed);

            switch(tab)
            {
                case "info":
                    page.InfoTab.Click();
                    break;

                case "related":
                    page.RelatedTab.Click();
                    break;

                default:
                    Assert.Fail(string.Format("unrecognised tab name: {0}", tab) );
                    break;
            }
        }
        
        [Then(@"I should see (\d+) opportunities in the related list")]
        public void ThenIShouldSeeOpportunitiesInTheRelatedList(int count)
        {
            var page = Page.ContactDetail.Related;

            Assert.AreEqual(count, page.Opps.Count);
        }

        [When(@"I click the second opportunity")]
        public void WhenIClickTheSecondOpportunity()
        {
            var page = Page.ContactDetail.Related;

            page.Opps[1].Title.Click();
        }
    }
}