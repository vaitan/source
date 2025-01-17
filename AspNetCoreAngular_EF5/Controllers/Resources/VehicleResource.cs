﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AspNetCoreAngular_EF5.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public ModelResource Model { get; set; }
        public bool IsRegistered { get; set; }
        public ContactResource Contact { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<FeatureResource> Features { get; set; }
        public MakeResource Make { get; internal set; }

        public VehicleResource()
        {
            Features = new Collection<FeatureResource>();
        }
    }
}