using EnumsNET;
using System.ComponentModel;

namespace BlazorAppCRUD.Utilities.Enums
{
    public enum PositionType
    {
        [Description("Software Developer")]
        SoftwareDeveloper,

        [Description("Senior Software Developer")]
        SeniorSoftwareDeveloper
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
