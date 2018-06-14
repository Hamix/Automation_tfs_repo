namespace Automation.Core.Infrastructure
{
    public abstract class LinkBase
    {
        public string URL { get; set; }
        public int Position { get; set; }
        public LinkBase(string url, int position)
        {
            URL = url;
            Position = position;
        }
        public LinkBase()
        {

        }
    }
}
