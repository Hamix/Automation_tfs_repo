namespace Automation.Core.Infrastructure
{
    public class MenuItem : LinkBase
    {
        public string Name { get; set; }
        public MenuItem(string url, int position,string name) : base(url, position)
        {
            Name = name;
        }
        public MenuItem():base()
        {

        }
    }
}
