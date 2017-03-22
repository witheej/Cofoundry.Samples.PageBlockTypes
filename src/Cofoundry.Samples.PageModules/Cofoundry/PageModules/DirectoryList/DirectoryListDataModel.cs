﻿using Cofoundry.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cofoundry.Samples.PageModules
{
    /// <summary>
    /// Each module should have a data model that implements IPageModuleDataModel that 
    /// describes the data to store in the database. Data is stored in an unstructured 
    /// format (json) so simple serializable data types are best.
    /// 
    /// Attributes can be used to describe validations as well as hints to the 
    /// content editor UI on how to render the data input controls.
    /// 
    /// See https://github.com/cofoundry-cms/cofoundry/wiki/Page-Module-Types
    /// for more information
    /// </summary>
    public class DirectoryListDataModel : IPageModuleDataModel
    {
        [Display(Name = "Directory", Description = "A directory to list pages for.")]
        [WebDirectory]
        public int WebDirectoryId { get; set; }

        [Display(Name = "Page Size", Description = "The number of page links to show in the list.")]
        public int PageSize { get; set; }
    }
}