namespace SPL.Models
{
    public class Line
    {
        public string id { get; set; }
        public string name { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string z { get; set; }

        public Line(string id, string name, string x, string y, string z)
        {
            this.id = id;
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Line()
        {

        }

        public List<Line> GetSeedData()
        {
            var SeedData = new List<Line>()
            {
                new Line("1", "10001", "0", "0", "0"),
                new Line("2", "10002", "0", "0", "1"),
                new Line("3", "10003", "0", "0", "2"),
                new Line("4", "10004", "0", "0", "3"),
                new Line("5", "10005", "0", "0", "4"),
                new Line("6", "10006", "0", "1", "1"),
                new Line("7", "10007", "0", "2", "1"),
                new Line("8", "10008", "0", "2", "2"),
                new Line("9", "10009", "0", "2", "3"),
                new Line("10", "10010", "0", "1", "3"),
            };
            return SeedData;
        }

        public IEnumerable<string> GetLineName(List<Line> lines)
        {
            var lineNames = new List<string>();
            foreach( var line in lines )
            {
                lineNames.Add(line.name);
            }
            return lineNames;
        }
    }
}
