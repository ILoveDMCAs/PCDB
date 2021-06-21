﻿using PCDB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCDB.Models.Components
{
    public class Memory : IComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ComponentType ComponentType { get; set; } = ComponentType.Memory;
        public string GetComponentTypeLink => new UrlHelper(HttpContext.Current.Request.RequestContext).Action("Memory", "Products");
    }
}