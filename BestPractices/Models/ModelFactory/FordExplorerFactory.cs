using DesignPatterns.Models.ModelBuilder;

namespace DesignPatterns.Models.ModelFactory
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Explorer")
                .setColor("black")
                .Build();
        }
    }
}