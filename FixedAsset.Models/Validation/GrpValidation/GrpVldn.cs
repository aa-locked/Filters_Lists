using FixedAsset.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAsset.Models.Validation.GrpValidation
{
    public class GrpVldn : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var Group = (TFAMtrlGrp)validationContext.ObjectInstance;
            if (Group.GrpShortDesc == null)
            {
                return new ValidationResult("Group Shor Desc Required!");
            }
            if (Group.GrpDesc == null)
            {
                return new ValidationResult("Group Desc Required!");
            }
            if (Group.GrpDesc.ToString().ToLower() == Group.GrpShortDesc.ToString().ToLower())
            {
                return new ValidationResult("Both Cannot Be Same!");
            }
            return ValidationResult.Success;
            
        }
    }
}
