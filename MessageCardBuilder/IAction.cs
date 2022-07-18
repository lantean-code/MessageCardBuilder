namespace MessageCard.Builder
{
    public interface IAction
    {
        string Type { get; set; }
        string Name { get; set; }
    }
}