using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.FilmList.Dto
{
    public class CreateFilmInput
    {
        [Required]
        [MaxLength(FilmConsts.MaxNameLength)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(FilmConsts.MaxDescriptionLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(FilmConsts.MaxPictureLinkLength)]
        public string PictureLink { get; set; }

        public int price { get; set; }
    }
}
