using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.FilmList.Dto
{
    public class FilmListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureLink { get; set; }

        public int Price { get; set; }
    }
}
