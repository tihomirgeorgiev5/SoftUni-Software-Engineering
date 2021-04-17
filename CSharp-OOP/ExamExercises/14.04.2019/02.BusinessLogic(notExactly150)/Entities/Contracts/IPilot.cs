namespace MortalEngines.Entities.Contracts
{
    public interface IPilot
    {
        string Name { get; }

        void AddMashine(IMachine machine);

        string Report();
    }
}