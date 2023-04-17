namespace modul9_1302213103
{
    public class Movies1
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movies1() { Stars = new List<string>(); }
    }
}