namespace CQRSPatternSandbox
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}