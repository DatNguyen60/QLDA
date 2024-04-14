using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.ObjectMapping;
using AutoMapper;
using MyCompanyName.AbpZeroTemplate.FilmList.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.FilmList
{
    public class FilmAppService : AbpZeroTemplateAppServiceBase, IFilmAppService
    {
        private readonly IRepository<Film> _filmRepository;

        public FilmAppService(IRepository<Film> filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public ListResultDto<FilmListDto> GetFilms(GetPeopleInput input)
        {
            var film = _filmRepository
                .GetAll()
                .WhereIf(
                    !input.Filter.IsNullOrEmpty(),
                    p => p.Name.Contains(input.Filter) ||
                         p.Description.Contains(input.Filter) ||
                         p.PictureLink.Contains(input.Filter)
                )
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Description)
            .ToList();

            return new ListResultDto<FilmListDto>(ObjectMapper.Map<List<FilmListDto>>(film));
        }
    }
}