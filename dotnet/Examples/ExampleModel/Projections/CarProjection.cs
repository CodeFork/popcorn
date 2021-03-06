using ExampleModel.Models;
using Skyward.Popcorn;

namespace ExampleModel.Projections
{
    public class CarProjection
    {
        [SubPropertyIncludeByDefault("[FullName,Birthday]")]
        public EmployeeProjection Owner { get; set; }

        public string Model { get; set; }
        public string Make { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public bool? Insured { get; set; }

        public string User { get; set; }

        public Business Manufacturer { get; set; }
    }
}
