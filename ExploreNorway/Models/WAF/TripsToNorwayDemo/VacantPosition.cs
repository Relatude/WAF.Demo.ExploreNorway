// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************


using System;
using WAF.Common;
using WAF.Definition;
using WAF.Engine;
using WAF.Engine.Content;
using WAF.Engine.Content.Native;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;
using WAF.Engine.Property;
using WAF.Data;
using WAF.Data.Query;
using WAF.Data.Query.TripsToNorwayDemo;
using WAF.Data.Content;
using WAF.Data.DataValue;
using WAF.Presentation.Web;

namespace WAF.Engine.Content.TripsToNorwayDemo {
    [Serializable]
    public partial class VacantPosition: WAF.Engine.Content.Native.HierarchicalContent {
        IntegerPropertyValue _salary;
        public virtual int Salary {
        get { return IntegerPropertyValue.GetValue(WAFID.GetDataValueId("eec506a1-911d-4025-a1a5-6ea48e6d3937"), ref _salary, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); IntegerPropertyValue.SetValue(WAFID.GetDataValueId("eec506a1-911d-4025-a1a5-6ea48e6d3937"), ref _salary, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _salaryCurrency;
        public virtual string SalaryCurrency {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("1806be87-3bd8-4cc7-916c-a748e7af39d1"), ref _salaryCurrency, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("1806be87-3bd8-4cc7-916c-a748e7af39d1"), ref _salaryCurrency, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LongStringPropertyValue _responsibilities;
        public virtual string Responsibilities {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("27fab971-586d-4c61-ae94-45f126617361"), ref _responsibilities, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("27fab971-586d-4c61-ae94-45f126617361"), ref _responsibilities, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _employmentType;
        public virtual string EmploymentType {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("00d4b547-8438-4665-a07f-99167898992e"), ref _employmentType, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("00d4b547-8438-4665-a07f-99167898992e"), ref _employmentType, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _workHours;
        public virtual string WorkHours {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("23db5e2e-7b8e-4a95-bb24-109c0db91036"), ref _workHours, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("23db5e2e-7b8e-4a95-bb24-109c0db91036"), ref _workHours, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _industry;
        public virtual string Industry {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("3afab358-044e-4c44-a81d-1a7dd64dee1f"), ref _industry, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("3afab358-044e-4c44-a81d-1a7dd64dee1f"), ref _industry, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        LongStringPropertyValue _description;
        public virtual string Description {
        get { return LongStringPropertyValue.GetValue(WAFID.GetDataValueId("3bc7fa16-e227-419d-af8f-1c251f77c27e"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); LongStringPropertyValue.SetValue(WAFID.GetDataValueId("3bc7fa16-e227-419d-af8f-1c251f77c27e"), ref _description, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _skills;
        public virtual string Skills {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("ffa07e89-50c3-4933-ad4a-a1d1ea2286bb"), ref _skills, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("ffa07e89-50c3-4933-ad4a-a1d1ea2286bb"), ref _skills, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        HTMLPropertyValue _qualifications;
        public virtual string Qualifications {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("6eeb1488-6ba2-4c04-be91-3f7958c69faf"), ref _qualifications, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("6eeb1488-6ba2-4c04-be91-3f7958c69faf"), ref _qualifications, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        ShortStringPropertyValue _benefits;
        public virtual string Benefits {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("bea3ebe1-c264-4981-a0f7-73a2ceb7f405"), ref _benefits, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("bea3ebe1-c264-4981-a0f7-73a2ceb7f405"), ref _benefits, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        DateTimePropertyValue _datePosted;
        public virtual DateTime DatePosted {
        get { return DateTimePropertyValue.GetValue(WAFID.GetDataValueId("8a55dd8d-4fcf-4dfd-a14d-b040e8259776"), ref _datePosted, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); DateTimePropertyValue.SetValue(WAFID.GetDataValueId("8a55dd8d-4fcf-4dfd-a14d-b040e8259776"), ref _datePosted, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _hiringOrganization;
        public virtual string HiringOrganization {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("55829837-cb42-4c29-a0d1-ca6850ddd604"), ref _hiringOrganization, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("55829837-cb42-4c29-a0d1-ca6850ddd604"), ref _hiringOrganization, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _jobLocation;
        public virtual string JobLocation {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("24aac8f9-fc45-4fea-aacd-76278c6fe8de"), ref _jobLocation, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("24aac8f9-fc45-4fea-aacd-76278c6fe8de"), ref _jobLocation, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _occupationalCategory;
        public virtual string OccupationalCategory {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("0d04814f-937c-4722-aa52-d6a1c9bf82ea"), ref _occupationalCategory, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("0d04814f-937c-4722-aa52-d6a1c9bf82ea"), ref _occupationalCategory, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _additionalInfo;
        public virtual string AdditionalInfo {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("c56d9f03-3b3b-4fa3-b06f-53e7c9568a53"), ref _additionalInfo, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("c56d9f03-3b3b-4fa3-b06f-53e7c9568a53"), ref _additionalInfo, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        ShortStringPropertyValue _educationRequirements;
        public virtual string EducationRequirements {
        get { return ShortStringPropertyValue.GetValue(WAFID.GetDataValueId("550c9a30-e6d7-4a78-9cc2-bac2e80521ce"), ref _educationRequirements, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); ShortStringPropertyValue.SetValue(WAFID.GetDataValueId("550c9a30-e6d7-4a78-9cc2-bac2e80521ce"), ref _educationRequirements, this.Session, this.ContentId, this.ContentData.DataValueById, value); }
        }
      
        HTMLPropertyValue _experienceRequirements;
        public virtual string ExperienceRequirements {
        get { return HTMLPropertyValue.GetValue(WAFID.GetDataValueId("d84d8f6d-8ebd-4901-80ae-5c50613e0024"), ref _experienceRequirements, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath); }
        set { EnsureContentDataIndependence(); HTMLPropertyValue.SetValue(WAFID.GetDataValueId("d84d8f6d-8ebd-4901-80ae-5c50613e0024"), ref _experienceRequirements, this.Session, this.ContentId, this.ContentData.DataValueById, this.ContentParentPath, value); }
        }
      
        public override IContent AddCulture(int lcid) {
            return _WAFSession.AddCulture<VacantPosition>(NodeId, lcid);
        }
        public override IContent AddRevision(int revision) {
            return _WAFSession.AddRevision<VacantPosition>(NodeId, revision);
        }
        public override IContent AddContent(int lcid, int revision) {
            return _WAFSession.AddContent<VacantPosition>(NodeId, lcid, revision);
        }
        ///<summary>
        ///The internal Id of the Ontology content class
        ///</summary>
        public static new int ContentClassId {
            get {
                return WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e");
            }
        }

        public static int PropertyIdSalary {
            get {
                return WAFID.GetPropertyId("859db19e-aac0-4115-804d-03315ae3fb08");
            }
        }

        public static int DataValueIdSalarySalary {
            get {
                return WAFID.GetDataValueId("eec506a1-911d-4025-a1a5-6ea48e6d3937");
            }
        }

        public static int PropertyIdSalaryCurrency {
            get {
                return WAFID.GetPropertyId("01c2f068-7da5-4c22-a8bc-ea5114570691");
            }
        }

        public static int DataValueIdSalaryCurrencySalarycurrency {
            get {
                return WAFID.GetDataValueId("1806be87-3bd8-4cc7-916c-a748e7af39d1");
            }
        }

        public static int PropertyIdResponsibilities {
            get {
                return WAFID.GetPropertyId("0904ede9-5fa2-4cf9-b18f-1a9df65ca41a");
            }
        }

        public static int DataValueIdResponsibilitiesResponsibilities {
            get {
                return WAFID.GetDataValueId("27fab971-586d-4c61-ae94-45f126617361");
            }
        }

        public static int PropertyIdEmploymentType {
            get {
                return WAFID.GetPropertyId("7a27533e-895a-4eef-88b6-2309d0685625");
            }
        }

        public static int DataValueIdEmploymentTypeEmploymenttype {
            get {
                return WAFID.GetDataValueId("00d4b547-8438-4665-a07f-99167898992e");
            }
        }

        public static int PropertyIdWorkHours {
            get {
                return WAFID.GetPropertyId("4c294867-fb94-4f32-9c4d-36d716d9ffd9");
            }
        }

        public static int DataValueIdWorkHoursWorkhours {
            get {
                return WAFID.GetDataValueId("23db5e2e-7b8e-4a95-bb24-109c0db91036");
            }
        }

        public static int PropertyIdIndustry {
            get {
                return WAFID.GetPropertyId("e6242ba5-8f56-467f-98d2-05223d96d99e");
            }
        }

        public static int DataValueIdIndustryIndustry {
            get {
                return WAFID.GetDataValueId("3afab358-044e-4c44-a81d-1a7dd64dee1f");
            }
        }

        public static int PropertyIdDescription {
            get {
                return WAFID.GetPropertyId("ce07abde-e367-49cd-b9a7-1aede976adb9");
            }
        }

        public static int DataValueIdDescriptionDescription {
            get {
                return WAFID.GetDataValueId("3bc7fa16-e227-419d-af8f-1c251f77c27e");
            }
        }

        public static int PropertyIdSkills {
            get {
                return WAFID.GetPropertyId("302f8ec1-7228-4091-b8d1-23e386486456");
            }
        }

        public static int DataValueIdSkillsSkills {
            get {
                return WAFID.GetDataValueId("ffa07e89-50c3-4933-ad4a-a1d1ea2286bb");
            }
        }

        public static int PropertyIdQualifications {
            get {
                return WAFID.GetPropertyId("6a4cd1a0-2fb5-4c98-8b47-c641a389cb0e");
            }
        }

        public static int DataValueIdQualificationsQualifications {
            get {
                return WAFID.GetDataValueId("6eeb1488-6ba2-4c04-be91-3f7958c69faf");
            }
        }

        public static int PropertyIdBenefits {
            get {
                return WAFID.GetPropertyId("9a19f30c-c055-45c4-b913-31158a176bfa");
            }
        }

        public static int DataValueIdBenefitsBenefits {
            get {
                return WAFID.GetDataValueId("bea3ebe1-c264-4981-a0f7-73a2ceb7f405");
            }
        }

        public static int PropertyIdDatePosted {
            get {
                return WAFID.GetPropertyId("162d585f-dadf-4825-9c43-3d26c9e27138");
            }
        }

        public static int DataValueIdDatePostedDateposted {
            get {
                return WAFID.GetDataValueId("8a55dd8d-4fcf-4dfd-a14d-b040e8259776");
            }
        }

        public static int PropertyIdHiringOrganization {
            get {
                return WAFID.GetPropertyId("92744ad4-7e77-46a0-bca4-bfa931d83019");
            }
        }

        public static int DataValueIdHiringOrganizationHiringorganization {
            get {
                return WAFID.GetDataValueId("55829837-cb42-4c29-a0d1-ca6850ddd604");
            }
        }

        public static int PropertyIdJobLocation {
            get {
                return WAFID.GetPropertyId("1e8c1223-2d8c-4bda-99ec-0d6f205b87a5");
            }
        }

        public static int DataValueIdJobLocationJoblocation {
            get {
                return WAFID.GetDataValueId("24aac8f9-fc45-4fea-aacd-76278c6fe8de");
            }
        }

        public static int PropertyIdOccupationalCategory {
            get {
                return WAFID.GetPropertyId("e1b1c5a9-3ef2-4de4-aa31-f732279dee4e");
            }
        }

        public static int DataValueIdOccupationalCategoryOccupationalcategory {
            get {
                return WAFID.GetDataValueId("0d04814f-937c-4722-aa52-d6a1c9bf82ea");
            }
        }

        public static int PropertyIdAdditionalInfo {
            get {
                return WAFID.GetPropertyId("63455570-9d11-4083-abac-2708704872c6");
            }
        }

        public static int DataValueIdAdditionalInfoAdditionalinfo {
            get {
                return WAFID.GetDataValueId("c56d9f03-3b3b-4fa3-b06f-53e7c9568a53");
            }
        }

        public static int PropertyIdEducationRequirements {
            get {
                return WAFID.GetPropertyId("76f32b1a-29c8-409b-839e-3fa6b40c94cd");
            }
        }

        public static int DataValueIdEducationRequirementsEducationrequirements {
            get {
                return WAFID.GetDataValueId("550c9a30-e6d7-4a78-9cc2-bac2e80521ce");
            }
        }

        public static int PropertyIdExperienceRequirements {
            get {
                return WAFID.GetPropertyId("ffa5564b-d1ea-48fe-9155-8ef2a7b2899f");
            }
        }

        public static int DataValueIdExperienceRequirementsExperiencerequirements {
            get {
                return WAFID.GetDataValueId("d84d8f6d-8ebd-4901-80ae-5c50613e0024");
            }
        }

        public override object GetProperty(int propertyId) {
            EnsureContentDataIndependence();
            if (propertyId == WAFID.GetPropertyId("859db19e-aac0-4115-804d-03315ae3fb08")) {
                object init = Salary;
                return _salary;
            }
            else if (propertyId == WAFID.GetPropertyId("01c2f068-7da5-4c22-a8bc-ea5114570691")) {
                object init = SalaryCurrency;
                return _salaryCurrency;
            }
            else if (propertyId == WAFID.GetPropertyId("0904ede9-5fa2-4cf9-b18f-1a9df65ca41a")) {
                object init = Responsibilities;
                return _responsibilities;
            }
            else if (propertyId == WAFID.GetPropertyId("7a27533e-895a-4eef-88b6-2309d0685625")) {
                object init = EmploymentType;
                return _employmentType;
            }
            else if (propertyId == WAFID.GetPropertyId("4c294867-fb94-4f32-9c4d-36d716d9ffd9")) {
                object init = WorkHours;
                return _workHours;
            }
            else if (propertyId == WAFID.GetPropertyId("e6242ba5-8f56-467f-98d2-05223d96d99e")) {
                object init = Industry;
                return _industry;
            }
            else if (propertyId == WAFID.GetPropertyId("ce07abde-e367-49cd-b9a7-1aede976adb9")) {
                object init = Description;
                return _description;
            }
            else if (propertyId == WAFID.GetPropertyId("302f8ec1-7228-4091-b8d1-23e386486456")) {
                object init = Skills;
                return _skills;
            }
            else if (propertyId == WAFID.GetPropertyId("6a4cd1a0-2fb5-4c98-8b47-c641a389cb0e")) {
                object init = Qualifications;
                return _qualifications;
            }
            else if (propertyId == WAFID.GetPropertyId("9a19f30c-c055-45c4-b913-31158a176bfa")) {
                object init = Benefits;
                return _benefits;
            }
            else if (propertyId == WAFID.GetPropertyId("162d585f-dadf-4825-9c43-3d26c9e27138")) {
                object init = DatePosted;
                return _datePosted;
            }
            else if (propertyId == WAFID.GetPropertyId("92744ad4-7e77-46a0-bca4-bfa931d83019")) {
                object init = HiringOrganization;
                return _hiringOrganization;
            }
            else if (propertyId == WAFID.GetPropertyId("1e8c1223-2d8c-4bda-99ec-0d6f205b87a5")) {
                object init = JobLocation;
                return _jobLocation;
            }
            else if (propertyId == WAFID.GetPropertyId("e1b1c5a9-3ef2-4de4-aa31-f732279dee4e")) {
                object init = OccupationalCategory;
                return _occupationalCategory;
            }
            else if (propertyId == WAFID.GetPropertyId("63455570-9d11-4083-abac-2708704872c6")) {
                object init = AdditionalInfo;
                return _additionalInfo;
            }
            else if (propertyId == WAFID.GetPropertyId("76f32b1a-29c8-409b-839e-3fa6b40c94cd")) {
                object init = EducationRequirements;
                return _educationRequirements;
            }
            else if (propertyId == WAFID.GetPropertyId("ffa5564b-d1ea-48fe-9155-8ef2a7b2899f")) {
                object init = ExperienceRequirements;
                return _experienceRequirements;
            }
            return base.GetProperty(propertyId);
        }
        protected override void ResetPropertyValues() {
            _salary = null;
            _salaryCurrency = null;
            _responsibilities = null;
            _employmentType = null;
            _workHours = null;
            _industry = null;
            _description = null;
            _skills = null;
            _qualifications = null;
            _benefits = null;
            _datePosted = null;
            _hiringOrganization = null;
            _jobLocation = null;
            _occupationalCategory = null;
            _additionalInfo = null;
            _educationRequirements = null;
            _experienceRequirements = null;
            base.ResetPropertyValues();
        }
    }
}
namespace WAF.Data.Query.TripsToNorwayDemo {
    public abstract class SqlVacantPosition {
        public static SqlTable Table {
            get {
                return new SqlTable("tripstonorwaydemo_vacantposition", WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public abstract partial class Field {
            public static SqlFieldInteger ContentId {
                get {
                    return new SqlFieldPrimaryInteger("content_id", Table);
                }
            }

            public static SqlFieldInteger Salary {
                get {
                    return new SqlFieldInteger("salary", Table, WAFID.GetDataValueId("eec506a1-911d-4025-a1a5-6ea48e6d3937"));
                }
            }

            public static SqlFieldShortString SalaryCurrency {
                get {
                    return new SqlFieldShortString("salarycurrency", Table, WAFID.GetDataValueId("1806be87-3bd8-4cc7-916c-a748e7af39d1"));
                }
            }

            public static SqlFieldLongString Responsibilities {
                get {
                    return new SqlFieldLongString("responsibilities", Table, WAFID.GetDataValueId("27fab971-586d-4c61-ae94-45f126617361"));
                }
            }

            public static SqlFieldShortString EmploymentType {
                get {
                    return new SqlFieldShortString("employmenttype", Table, WAFID.GetDataValueId("00d4b547-8438-4665-a07f-99167898992e"));
                }
            }

            public static SqlFieldShortString WorkHours {
                get {
                    return new SqlFieldShortString("workhours", Table, WAFID.GetDataValueId("23db5e2e-7b8e-4a95-bb24-109c0db91036"));
                }
            }

            public static SqlFieldShortString Industry {
                get {
                    return new SqlFieldShortString("industry", Table, WAFID.GetDataValueId("3afab358-044e-4c44-a81d-1a7dd64dee1f"));
                }
            }

            public static SqlFieldLongString Description {
                get {
                    return new SqlFieldLongString("description", Table, WAFID.GetDataValueId("3bc7fa16-e227-419d-af8f-1c251f77c27e"));
                }
            }

            public static SqlFieldLongString Skills {
                get {
                    return new SqlFieldLongString("skills", Table, WAFID.GetDataValueId("ffa07e89-50c3-4933-ad4a-a1d1ea2286bb"));
                }
            }

            public static SqlFieldLongString Qualifications {
                get {
                    return new SqlFieldLongString("qualifications", Table, WAFID.GetDataValueId("6eeb1488-6ba2-4c04-be91-3f7958c69faf"));
                }
            }

            public static SqlFieldShortString Benefits {
                get {
                    return new SqlFieldShortString("benefits", Table, WAFID.GetDataValueId("bea3ebe1-c264-4981-a0f7-73a2ceb7f405"));
                }
            }

            public static SqlFieldDateTime DatePosted {
                get {
                    return new SqlFieldDateTime("dateposted", Table, WAFID.GetDataValueId("8a55dd8d-4fcf-4dfd-a14d-b040e8259776"));
                }
            }

            public static SqlFieldShortString HiringOrganization {
                get {
                    return new SqlFieldShortString("hiringorganization", Table, WAFID.GetDataValueId("55829837-cb42-4c29-a0d1-ca6850ddd604"));
                }
            }

            public static SqlFieldShortString JobLocation {
                get {
                    return new SqlFieldShortString("joblocation", Table, WAFID.GetDataValueId("24aac8f9-fc45-4fea-aacd-76278c6fe8de"));
                }
            }

            public static SqlFieldShortString OccupationalCategory {
                get {
                    return new SqlFieldShortString("occupationalcategory", Table, WAFID.GetDataValueId("0d04814f-937c-4722-aa52-d6a1c9bf82ea"));
                }
            }

            public static SqlFieldShortString AdditionalInfo {
                get {
                    return new SqlFieldShortString("additionalinfo", Table, WAFID.GetDataValueId("c56d9f03-3b3b-4fa3-b06f-53e7c9568a53"));
                }
            }

            public static SqlFieldShortString EducationRequirements {
                get {
                    return new SqlFieldShortString("educationrequirements", Table, WAFID.GetDataValueId("550c9a30-e6d7-4a78-9cc2-bac2e80521ce"));
                }
            }

            public static SqlFieldLongString ExperienceRequirements {
                get {
                    return new SqlFieldLongString("experiencerequirements", Table, WAFID.GetDataValueId("d84d8f6d-8ebd-4901-80ae-5c50613e0024"));
                }
            }

        }
    }
    public class SqlAliasVacantPosition : SqlAlias {
        public SqlAliasVacantPosition()
            : base(SqlVacantPosition.Table) {
        }
        public SqlExpressionFieldInteger ContentId {
            get {
                return new SqlExpressionFieldInteger(SqlVacantPosition.Field.ContentId, this);
            }
        }

        public SqlExpressionFieldInteger Salary {
            get {
                return new SqlExpressionFieldInteger(SqlVacantPosition.Field.Salary, this);
            }
        }

        public SqlExpressionFieldShortString SalaryCurrency {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.SalaryCurrency, this);
            }
        }

        public SqlExpressionFieldLongString Responsibilities {
            get {
                return new SqlExpressionFieldLongString(SqlVacantPosition.Field.Responsibilities, this);
            }
        }

        public SqlExpressionFieldShortString EmploymentType {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.EmploymentType, this);
            }
        }

        public SqlExpressionFieldShortString WorkHours {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.WorkHours, this);
            }
        }

        public SqlExpressionFieldShortString Industry {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.Industry, this);
            }
        }

        public SqlExpressionFieldLongString Description {
            get {
                return new SqlExpressionFieldLongString(SqlVacantPosition.Field.Description, this);
            }
        }

        public SqlExpressionFieldLongString Skills {
            get {
                return new SqlExpressionFieldLongString(SqlVacantPosition.Field.Skills, this);
            }
        }

        public SqlExpressionFieldLongString Qualifications {
            get {
                return new SqlExpressionFieldLongString(SqlVacantPosition.Field.Qualifications, this);
            }
        }

        public SqlExpressionFieldShortString Benefits {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.Benefits, this);
            }
        }

        public SqlExpressionFieldDateTime DatePosted {
            get {
                return new SqlExpressionFieldDateTime(SqlVacantPosition.Field.DatePosted, this);
            }
        }

        public SqlExpressionFieldShortString HiringOrganization {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.HiringOrganization, this);
            }
        }

        public SqlExpressionFieldShortString JobLocation {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.JobLocation, this);
            }
        }

        public SqlExpressionFieldShortString OccupationalCategory {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.OccupationalCategory, this);
            }
        }

        public SqlExpressionFieldShortString AdditionalInfo {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.AdditionalInfo, this);
            }
        }

        public SqlExpressionFieldShortString EducationRequirements {
            get {
                return new SqlExpressionFieldShortString(SqlVacantPosition.Field.EducationRequirements, this);
            }
        }

        public SqlExpressionFieldLongString ExperienceRequirements {
            get {
                return new SqlExpressionFieldLongString(SqlVacantPosition.Field.ExperienceRequirements, this);
            }
        }

    }
}
namespace WAF.Engine.Query.TripsToNorwayDemo {
    [System.Serializable]
    public partial class AqlVacantPosition{
        public static AqlPropertyInteger NodeId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.Id, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyShortString Guid  {
            get {
                return new AqlPropertyShortString(Sql.Field.Node.Guid, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger SiteId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.SiteId, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger ContentId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ContentId, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger Revision  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.Revision, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger AuthorId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.AuthorId, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger TemplateId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.TemplateId, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger ModuleId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Content.ModuleId, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger LCID  {
            get {
                return new AqlPropertyInteger(Sql.Field.NodeCsd.LCID, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyBoolean IsDerived  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDerived, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyBoolean IsPublished  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsPublished, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyBoolean Hidden  {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.Hidden, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyBoolean IsRevisionDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Content.IsDeleted, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyBoolean IsNodeDeleted {
            get {
                return new AqlPropertyBoolean(Sql.Field.Node.IsDeleted, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger ContentClassId  {
            get {
                return new AqlPropertyInteger(Sql.Field.Node.ContentClassId, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyDateTime CreateDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.CreateDate, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyDateTime ChangeDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ChangeDate, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyDateTime PublishDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.PublishDate, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyDateTime ReleaseDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.ReleaseDate, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyDateTime RetainDate  {
            get {
                return new AqlPropertyDateTime(Sql.Field.Content.RetainDate, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyShortString Name  {
            get {
                return new AqlPropertyShortString(Sql.Field.Content.Name, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")); 
            }
        }

        public static AqlPropertyInteger Salary {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Salary, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString SalaryCurrency {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.SalaryCurrency, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString Responsibilities {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Responsibilities, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString EmploymentType {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.EmploymentType, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString WorkHours {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.WorkHours, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString Industry {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Industry, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString Description {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Description, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString Skills {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Skills, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString Qualifications {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Qualifications, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString Benefits {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.Benefits, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyDateTime DatePosted {
            get {
                return new AqlPropertyDateTime(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.DatePosted, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString HiringOrganization {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.HiringOrganization, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString JobLocation {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.JobLocation, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString OccupationalCategory {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.OccupationalCategory, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString AdditionalInfo {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.AdditionalInfo, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString EducationRequirements {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.EducationRequirements, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString ExperienceRequirements {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.TripsToNorwayDemo.SqlVacantPosition.Field.ExperienceRequirements, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString TemplatePath {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.TemplatePath, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyShortString MetaTitle {
            get {
                return new AqlPropertyShortString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaTitle, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaTitle {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaTitle, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString MetaDescription {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaDescription, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaDescription {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaDescription, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyLongString MetaKeywords {
            get {
                return new AqlPropertyLongString(WAF.Data.Query.Native.SqlHierarchicalContent.Field.MetaKeywords, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean AutoMetaKeywords {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AutoMetaKeywords, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyRelation ContentTags {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a4e4d56c-8ff9-4ede-9232-094e72398668"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasContentTag(), WAF.Engine.Query.Native.AqlRelTaxonomyHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Children {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("cc90eccd-1d77-40c8-aab7-5262842a66e2"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyRelation Parent {
            get {
                return new AqlPropertyRelation( WAFID.GetPropertyId("a1eca898-8f93-4522-a46c-669c56af9b55"), new AqlAliasRelation(new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), new WAF.Engine.Query.Native.AqlAliasHierarchicalContent(), WAF.Engine.Query.Native.AqlRelHierarchical.Relation));
            }
        }

        public static AqlPropertyBoolean ShowInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInTree, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean ShowInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ShowInMenu, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyInteger DefaultReadAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultReadAccessOnChildren, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyInteger DefaultEditAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultEditAccessOnChildren, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyInteger DefaultPublishAccessOnChildren {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultPublishAccessOnChildren, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyInteger AddChildAccess {
            get {
                return new AqlPropertyInteger(WAF.Data.Query.Native.SqlHierarchicalContent.Field.AddChildAccess, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean DefaultInTree {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInTree, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean DefaultInMenu {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.DefaultInMenu, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

        public static AqlPropertyBoolean ExcludeFromIndex {
            get {
                return new AqlPropertyBoolean(WAF.Data.Query.Native.SqlHierarchicalContent.Field.ExcludeFromIndex, WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e"));
            }
        }

    }
    [System.Serializable]
    public class AqlAliasVacantPosition
        : WAF.Engine.Query.Native.AqlAliasHierarchicalContent{

        public AqlAliasVacantPosition()
            : base(WAFID.GetContentClassId("ce6ee110-eac5-49e9-a637-50ea86e01e8e")) {

        }

        public AqlAliasVacantPosition(int contentClassId)
            : base(contentClassId) {

        }

        public AqlExpressionPropertyInteger Salary {
            get {
                return new AqlExpressionPropertyInteger(AqlVacantPosition.Salary, this);
            }
        }

        public AqlExpressionPropertyShortString SalaryCurrency {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.SalaryCurrency, this);
            }
        }

        public AqlExpressionPropertyLongString Responsibilities {
            get {
                return new AqlExpressionPropertyLongString(AqlVacantPosition.Responsibilities, this);
            }
        }

        public AqlExpressionPropertyShortString EmploymentType {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.EmploymentType, this);
            }
        }

        public AqlExpressionPropertyShortString WorkHours {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.WorkHours, this);
            }
        }

        public AqlExpressionPropertyShortString Industry {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.Industry, this);
            }
        }

        public AqlExpressionPropertyLongString Description {
            get {
                return new AqlExpressionPropertyLongString(AqlVacantPosition.Description, this);
            }
        }

        public AqlExpressionPropertyLongString Skills {
            get {
                return new AqlExpressionPropertyLongString(AqlVacantPosition.Skills, this);
            }
        }

        public AqlExpressionPropertyLongString Qualifications {
            get {
                return new AqlExpressionPropertyLongString(AqlVacantPosition.Qualifications, this);
            }
        }

        public AqlExpressionPropertyShortString Benefits {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.Benefits, this);
            }
        }

        public AqlExpressionPropertyDateTime DatePosted {
            get {
                return new AqlExpressionPropertyDateTime(AqlVacantPosition.DatePosted, this);
            }
        }

        public AqlExpressionPropertyShortString HiringOrganization {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.HiringOrganization, this);
            }
        }

        public AqlExpressionPropertyShortString JobLocation {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.JobLocation, this);
            }
        }

        public AqlExpressionPropertyShortString OccupationalCategory {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.OccupationalCategory, this);
            }
        }

        public AqlExpressionPropertyShortString AdditionalInfo {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.AdditionalInfo, this);
            }
        }

        public AqlExpressionPropertyShortString EducationRequirements {
            get {
                return new AqlExpressionPropertyShortString(AqlVacantPosition.EducationRequirements, this);
            }
        }

        public AqlExpressionPropertyLongString ExperienceRequirements {
            get {
                return new AqlExpressionPropertyLongString(AqlVacantPosition.ExperienceRequirements, this);
            }
        }

    }
}
