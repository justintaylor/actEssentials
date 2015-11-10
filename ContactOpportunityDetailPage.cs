using act.IntegrationTest.Elements;
using act.IntegrationTest.Elements.ContactPicker;
using act.IntegrationTest.Elements.DateTimePickerElement;
using act.IntegrationTest.Pages.Opportunities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace act.IntegrationTest.Pages.Contacts
{
    public class ContactOpportunityDetailPage : OpportunityDetailPage
    {
        public ContactOpportunityDetailPage()
            : base("#/people/contacts/all", "#/people/contacts/all/[a-zA-Z0-9]{24}/opportunity/[a-zA-Z0-9]{24}$")
        {

        }
    }
}
