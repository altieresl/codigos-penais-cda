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
        public string Penalty{ get; set; }

        [Column("PrisionTime")]
        [Display(Name= "PrisionTime")]
        public string PrisionNTime { get; set; }

        [Column("StatusId")]
        [Display(Name = "StatusId")]
        public string StatusId { get; set; }

        [Column("CreateDate")]
        [Display(Name = "CreateDate")]
        public string CreateDate { get; set; }

        [Column("UpdateDate")]
        [Display(Name = "UpdateDate")]
        public string UpdateDate { get; set; }

        [Column("CreateUserId")]
        [Display(Name = "CreateUserId")]
        public string CreateUserId { get; set; }

        [Column("UpdateUserId")]
        [Display(Name = "UpdateUserId")]
        public string UpdateUserId { get; set; }
    }
}
