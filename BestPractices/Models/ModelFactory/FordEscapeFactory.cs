using DesignPatterns.Models.ModelBuilder;

namespace DesignPatterns.Models.ModelFactory
{
    public class FordEscapeFactory : CarFactory
    {

        public override Vehicle Create()
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .setColor("red")
                .Build();
        }

    }
}