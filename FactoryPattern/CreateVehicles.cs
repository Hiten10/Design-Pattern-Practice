namespace FactoryPattern
{
    public static class CreateVehicles
    {
        public static IFactory CreateVehicle<T>() where T : IFactory, new()
        {
            return new T();
        }
    }
}
