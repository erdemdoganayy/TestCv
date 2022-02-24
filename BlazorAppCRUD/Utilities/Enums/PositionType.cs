using EnumsNET;
using System.ComponentModel;

namespace BlazorAppCRUD.Utilities.Enums
{
    public enum PositionType
    {
        [Description("Other")]
        Other,

        [Description("Software Developer")]
        SoftwareDeveloper,

        [Description("Senior Software Developer")]
        SeniorSoftwareDeveloper,

        [Description("QA Engineer")]
        QAEngineer,

        [Description("Senior QA Engineer")]
        SeniorQAEngineer,

        [Description("Senior / Product Manager")]
        SeniorProductManager,

        [Description("Senior / Project Manager")]
        SeniorProjectManager,

        [Description("Cyber Security Specialist")]
        CyberSecuritySpecialist,

        [Description("Cyber Security Engineer")]
        CyberSecurityEngineer,

        [Description("Design Engineering")]
        DesignEngineering,

        [Description("Senior Engineering")]
        SeniorEngineering,

        [Description("Network Engineer")]
        NetworkEngineer,

        [Description("Data Engineer")]
        DataEngineer,

         [Description("DevOps Engineer ")]
        DevOpsEngineer,

        [Description("Security Engineer")]
        SecurityEngineer,

        [Description("Computer Engineer")]
        ComputerEngineer,

        [Description("Computer Hardware Engineer")]
        ComputerHardwareEngineer,
    }

    public static class PositionTypeExtentions
    {
        public static List<string> GetPositionTypeDescriptions()
        {
            var list = Enum.GetValues(typeof(PositionType)).Cast<PositionType>().ToList();

            List<string> descriptions = new List<string>();
            foreach (var item in list)
            {
                descriptions.Add(item.AsString(EnumFormat.Description));
            }

            return descriptions;
        }
    }

}
