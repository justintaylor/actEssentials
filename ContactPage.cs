using act.IntegrationTest.Elements;
using act.IntegrationTest.Elements.DateTimePickerElement;
using Act.Web.Http.Automation.Base;
using OpenQA.Selenium;

namespace act.IntegrationTest.Pages.Contacts
{
    public class ContactDetailPage : LoggedInPage
    {
        public ContactDetailPage()
            : this("#/people/contacts/all/", @"#/people(/search/contact|/contacts/all)/\w{24}$")
        {
        }

        public ContactDetailPage(string url, string matcher) : base(url, matcher)
        {        
            /************ Begin Contact Card **************/
            #region contact Card
            Element("DisplayName", By.CssSelector("[data-role='contact-detail'] [data-field='name']")); 
            Element("DisplayEmail", By.CssSelector("[data-field='email'] a"));
            Element("Phone", By.CssSelector("[data-field='phone'] a"));
            Element("Address", By.CssSelector("[data-field='map'] a"));
            Element("Portrait", By.ClassName("contact-portrait"));
            Element("ProfilePic", By.CssSelector("img[src^='http']"));
            Element("CustomProfilePic", By.CssSelector(".contact-portrait[style*='https://s3.amazon']"));
            Element("ContactCardDisplayName", By.CssSelector("[data-field='name']"));
            Element("ContactCardEmail", By.CssSelector("[data-field='email'] a"));
            Element("ContactCardPhone", By.CssSelector("[data-field='phone'] a"));
            Element("ContactCardAddress", By.CssSelector("[data-field='map'] a"));
            Element("Edit", By.CssSelector("[data-action='edit']"));
            Element("Delete", ByHelper.DataAttribute("action", "delete"));
            Element("ScrollPanel", By.CssSelector(".flex-detail.detail-pane"));
            #endregion

            #region group picker
            Element("GroupsTab", By.Id("groups-tab"));
            Element<GroupSelectorElement>("GroupSelect", By.CssSelector(".contact-groups__select-container"));
            Sections<GroupSection>("Groups", By.CssSelector("[data-role='contact-group-option']"));
            #endregion

            #region contact edit
            Element("Save", ByHelper.DataAttribute("action", "save"));
            Element("Cancel", ByHelper.DataAttribute("action", "cancel"));
            #endregion

            #region contact delete

            Element("DeleteConfirm", ByHelper.DataAttribute("action", "confirm-delete"));
            Element("DeleteCancel", ByHelper.DataAttribute("action", "cancel-delete"));
            #endregion

            #region edit view
            Element<SelectElement>("ProfileImageSelect", By.CssSelector("[data-role='profile-image-select']"));
            Element("File", By.CssSelector("[accept='image/*']"));
            Element("SelectNewImage", By.CssSelector("[href='#']"));
            // Popup error message element inherited from LoggedInPage //Element("Errors", By.CssSelector(".popover.fade.top.in.show .popover-content")); // any visible alert message
            Element<EditElement>("FirstName", By.Id("firstName"));
            Element<EditElement>("LastName", By.Id("lastName"));
            Element<EditElement>("Company", By.Id("company"));
            Element<EditElement>("JobTitle", By.Id("jobTitle"));
            Element<EditElement>("Email", By.Id("emailAddress"));
            Element<EditElement>("AltEmail", By.Id("altEmailAddress"));
            Element<EditElement>("BusinessPhone", By.Id("businessPhone"));
            Element<EditElement>("MobilePhone", By.Id("mobilePhone"));
            Element<EditElement>("HomePhone", By.Id("homePhone"));
            Element<EditElement>("PriAddressLine1", By.Id("businessAddressLine1"));
            Element<EditElement>("PriAddressCity", By.Id("businessAddressCity"));
            Element<SelectElement>("PriCountry", By.Id("businessAddressCountry"));
            Element<SelectElement>("PriAddressState", By.Id("businessAddressState"));
            Element<EditElement>("PriAddressZip", By.Id("businessAddressPostalCode"));
            Element<EditElement>("Website", By.Id("website"));
            Element<DatePickerElement>("Birthday", By.Id("birthday"));
            Element<EditElement>("CustomField1", By.Id("customField1"));
            Element("CustomField1Label", By.CssSelector("[for=customField1]"));
            Element<EditElement>("CustomField2", By.Id("customField2"));
            Element("CustomField2Label", By.CssSelector("[for=customField2]"));
            Element<EditElement>("CustomField3", By.Id("customField3"));
            Element("CustomField3Label", By.CssSelector("[for=customField3]"));
            Element<EditElement>("CustomField4", By.Id("customField4"));
            Element("CustomField4Label", By.CssSelector("[for=customField4]"));
            Element<EditElement>("CustomField5", By.Id("customField5"));
            Element("CustomField5Label", By.CssSelector("[for=customField5]"));
            Element("SaveAtBottom", By.CssSelector(".panel-footer [data-action='save']"));
            Element("CancelAtBottom", By.CssSelector(".panel-footer [data-action='cancel']"));
            #endregion

            #region Activity List View
            Element("ActivitiesTab", By.Id("interactions-tab"));
            Section<DetailActivitySection>("ActivitySection", By.Id("interactions-tab-pane"));
            #endregion

            #region tabs
            Element("InfoTab", By.Id("info-tab"));
            Section<InfoSection>("Info", By.ClassName("contact-detail-info"));

            Element("RelatedTab", By.Id("related-tab"));
            Section<RelatedSection>("Related", By.Id("related-tab-pane"));
            #endregion

            #region social linker (modal)
            Section<SocialLinkerSection>("SocialLinker", By.ClassName("modal-dialog"));
            Element("ModalBackdropFade", By.CssSelector(".modal-backdrop.fade"));
            #endregion

            Section<UnsavedChangesSection>("UnsavedChanges",By.ClassName("modial-dialog"));
        }
    }
}
