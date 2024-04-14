using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
namespace MyCompanyName.AbpZeroTemplate.FilmList


{
    [Table("FlFilm")]
    public class Film : FullAuditedEntity
    {
        public const int MaxNameLength = 32;
        public const int MaxDescriptionLength = 32;
        public const int MaxPictureLinkLength = 255;

        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public virtual string Description { get; set; }

        [MaxLength(MaxPictureLinkLength)]
        public virtual string PictureLink { get; set; }

        public virtual int Price { get; set; }
    }
}