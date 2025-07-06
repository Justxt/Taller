using DesignPatterns.Models.ModelBuilder;

namespace DesignPatterns.Models.ModelFactory
{
    public class FordMustangFactory : CarFactory
    {

        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Mustang")
                .setColor("white")
                .Build();
        }
    }
}