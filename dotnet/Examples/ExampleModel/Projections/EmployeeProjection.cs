﻿using ExampleModel.Models;
using Skyward.Popcorn;
using System.Collections.Generic;

namespace ExampleModel.Projections
{
    public class EmployeeProjection
    {
        [IncludeByDefault]
        public string FirstName { get; set; }
        [IncludeByDefault]
        public string LastName { get; set; }
        public string FullName { get; set; }

        public long? SocialSecurityNumber { get; set; }

        public string Birthday { get; set; }
        public int? VacationDays { get; set; }
        public EmploymentType? Employment { get; set; }

        [SubPropertyIncludeByDefault("[Make,Model,Color]")]
        public List<CarProjection> Vehicles { get; set; }

        public List<CarProjection> InsuredVehicles { get; set; }
    }
}
