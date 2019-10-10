using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    public static class EnumTranslator
    {
        public static IDictionary<Semester, string> semesterToString = new Dictionary<Semester, string>
        {
            {Semester.WS1920, "WS19/20"}, {Semester.SS19, "SS19" },
            {Semester.WS1819, "WS18/19"}, {Semester.SS18, "SS18" },
            {Semester.WS1718, "WS17/18"}, {Semester.SS17, "SS17" },
            {Semester.WS1617, "WS16/17"}, {Semester.SS16, "SS16" },
            {Semester.WS1516, "WS15/16"}, {Semester.SS15, "SS15" },
            {Semester.WS1415, "WS14/15"}, {Semester.SS14, "SS14" },
            {Semester.WS1314, "WS13/14"}, {Semester.SS13, "SS13" },
            {Semester.WS1213, "WS12/13"}, {Semester.SS12, "SS12" },
            {Semester.WS1112, "WS11/12"}, {Semester.SS11, "SS11" },
            {Semester.WS1011, "WS10/11"}, {Semester.SS10, "SS10" }
        };

        public static IDictionary<string, Semester> stringToSemester = new Dictionary<string, Semester>
        {
            {"WS19/20", Semester.WS1920}, {"SS19", Semester.SS19},
            {"WS18/19", Semester.WS1819}, {"SS18", Semester.SS18},
            {"WS17/18", Semester.WS1718}, {"SS17", Semester.SS17},
            {"WS16/17", Semester.WS1617}, {"SS16", Semester.SS16},
            {"WS15/16", Semester.WS1516}, {"SS15", Semester.SS15},
            {"WS14/15", Semester.WS1415}, {"SS14", Semester.SS14},
            {"WS13/14", Semester.WS1314}, {"SS13", Semester.SS13},
            {"WS12/13", Semester.WS1213}, {"SS12", Semester.SS12},
            {"WS11/12", Semester.WS1112}, {"SS11", Semester.SS11},
            {"WS10/11", Semester.WS1011}, {"SS10", Semester.SS10}
        };

        public static List<string> allSemester = new List<string>()
        {
            "WS19/20", "SS19", "WS18/19", "SS18", "WS17/18", "SS17", "WS16/17", "SS16",
            "WS15/16", "SS15", "WS14/15", "SS14", "WS13/14", "SS13", "WS12/13", "SS12",
            "WS11/12", "SS11", "WS10/11", "SS10"
        };
    }
}
