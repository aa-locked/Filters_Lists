using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedAsset.Models.Domain
{
    public class TFAItemGrp
    {
        [Key]
        public int FAItemGrpId { get; set; }
        [Required]
        [StringLength(100)]
        public string ItemGrpDesc { get; set; }
        [Required]
        public bool ActStatus { get; set; }
        [Required]
        [StringLength(10)]
        public string AddedBy { get; set; } = "12558";
        [Required]
        public DateTime AddedOn { get; set; } = DateTime.Now;

    }
}
