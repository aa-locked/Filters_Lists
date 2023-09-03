using FixedAsset.Models.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAsset.Models.ViewModels
{
    public class VM_FAMTRLSUBGRP
    {
        public TFAMtrlSubGrp TFAMtrlSubGrp { get; set; }
        public IEnumerable<SelectListItem> FAGrpList { get; set; }
    }
}
