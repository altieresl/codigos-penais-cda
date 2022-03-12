using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.CodigoPenal
{
    [Table("CriminalCode")]
    public class CriminalCodeViewModel
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }


        [Column("Penalty")]
        [Display(Name = "Penalty")]
        public decimal Penalty{ get; set; }

        [Column("PrisionTime")]
        [Display(Name= "PrisionTime")]
        public int PrisionTime { get; set; }

        [Column("StatusId")]
        [Display(Name = "StatusId")]
        public int StatusId { get; set; }

        [Column("CreateDate")]
        [Display(Name = "CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("UpdateDate")]
        [Display(Name = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }

        [Column("CreateUserId")]
        [Display(Name = "CreateUserId")]
        public int CreateUserId { get; set; }

        [Column("UpdateUserId")]
        [Display(Name = "UpdateUserId")]
        public int? UpdateUserId { get; set; }
    }
}
