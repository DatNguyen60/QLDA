using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using MyCompanyName.AbpZeroTemplate.FilmList.Dto;
using System.Threading.Tasks;
using Abp.ObjectMapping;

namespace MyCompanyName.AbpZeroTemplate.FilmList
{
    public interface IFilmAppService : IApplicationService
    {
        ListResultDto<FilmListDto> GetFilms(GetPeopleInput input);
        Task CreateFilm(CreateFilmInput input);
        Task DeleteFilm(EntityDto input);
    }
    public class GetPeopleInput
    {
        public string Filter { get; set; }
    }

}