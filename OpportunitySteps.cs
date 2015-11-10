using System;
﻿using System.Collections.Generic;
﻿using System.Globalization;
﻿using System.Linq;
﻿using System.Text.RegularExpressions;
﻿using act.Models;
﻿using act.Repository;
﻿using Act.Web.Http.Automation.Base;
using Act.Web.Http.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
﻿using MongoDB.Driver;
﻿using MongoDB.Driver.Builders;
using TechTalk.SpecFlow;
﻿using TechTalk.SpecFlow.Assist;
using OpportunityData = act.IntegrationTest.Pages.Opportunities.OpportunityListPage.OpportunityData;
using OpportunitySortEnum = act.IntegrationTest.Pages.Opportunities.OpportunityListPage.OpportunitySortEnum;
using FilterStatistics = act.IntegrationTest.Pages.Opportunities.OpportunityListPage.FilterStatistics;

namespace act.IntegrationTest.Steps
{
    [Binding]
    public class OpportunitySteps : AutomationTestBase
    {
        [StepArgumentTransformation(@"(.+):\s*(.+)")]
        public OpportunitySortEnum OpportunitySortTransform(string prefix, string suffix)
        {
            suffix = Regex.Replace(suffix, @"\s?-\s?", "to");
            return (OpportunitySortEnum)Enum.Parse(typeof(OpportunitySortEnum), prefix + suffix, true);
        }

        [StepArgumentTransformation]
        public IEnumerable<OpportunityData> OpportunityDataTransform(Table table)
        {
            return table.CreateSet<OpportunityData>();
        }

        [Then(@"I should see the contact opportunity details for (.*)$")]
        public void ThenIShouldSeeTheContactOppportunityDetailsForOpportunity(String enityName)
        {
            var entity = Global.Tags[enityName] as Opportunity;
            Assert.IsNotNull(entity);
            
            var page = Page.ContactOpportunityDetail;
            Assert.IsTrue(page.Displayed, "page is not displayed");
            Assert.IsTrue(page.DisplayName.Text.Contains(entity.Title), "title is incorrect");
        }
    }
}
