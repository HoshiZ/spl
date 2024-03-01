using SPL.Models;

namespace SPL.Extensions
{
    public static class LineExtensions
    {
        public static IEnumerable<string> GetListLineNames(this List<Line> lines)
        {
            var lineNames = new List<string>();

            foreach (var line in lines)
            {
                lineNames.Add(line.name);
            }

            return lineNames;
        }
    }
}
