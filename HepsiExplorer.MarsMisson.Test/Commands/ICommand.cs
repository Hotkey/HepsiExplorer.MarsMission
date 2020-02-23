namespace HepsiExplorer.MarsMisson.Console
{
    public interface ICommand
    {
        public string Name { get; }
        public string Description { get; }
        public int Order { get; set; }
        void Apply();
    }
}
