using System.ComponentModel;

namespace LeaveManagement.Enum
{
    public static class NotificationType
    {
        public enum EventType
        {
            [Description("Appraisal Cycle Start")]
            AppraisalStart = 1,
            [Description("Goal Setting Start")]
            GoalSettingStart = 2,
            [Description("Goal Setting End")]
            GoalSettingEndHR = 3,
            [Description("Goal Setting End")]
            GoalSettingEndEmployee = 4,
            [Description("Self Assesment Start")]
            SelfAssesmentStart = 5,
            [Description("Self Assesment End")]
            SelfAssesmentEnd = 6,
            [Description("Lead Assesment Start")]
            LeadAssesmentStart = 7,
            [Description("Lead Assesment End/Manager Assesment Start")]
            ManagerAssesmentStart = 8,
            [Description("Project Manager Assesment End")]
            ManagerAssesmentEnd = 9,
            [Description("Intimation Email")]
            IntimationEmail = 10,
            [Description("Email Sent At 11 AM")]
            EmailSent11Am = 11,
            [Description("Email Sent At 04 PM")]
            EmailSent04PM = 12,
            [Description("Management Feedback")]
            ManagementFeedback = 13,
            [Description("Form Rejection HR")]
            FormRejectionHR = 14,
            [Description("Form Rejection Manager")]
            FormRejectionManager = 15,
            [Description("Form Rejection Lead")]
            FormRejectionLead = 16,
            [Description("Form Rejection Employee")]
            FormRejectionEmployee = 17,
            [Description("Form Rejection Goal")]
            FormRejectionGoal = 18
        }
    }
}
