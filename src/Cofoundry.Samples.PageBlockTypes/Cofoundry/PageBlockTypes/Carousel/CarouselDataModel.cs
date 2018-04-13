﻿using Cofoundry.Core;
using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cofoundry.Samples.PageBlockTypes
{
    public class CarouselDataModel : IPageBlockTypeDataModel
    {
        [Required]
        [NestedDataModelCollection(IsOrderable = true, MinItems = 2, MaxItems = 6)]
        public ICollection<CarouselSlideDataModel> Slides { get; set; }
    }
}
