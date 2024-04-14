using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using MyCompanyName.AbpZeroTemplate.PhoneBook.Dto;

namespace MyCompanyName.AbpZeroTemplate.PhoneBook
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
    }
    public class GetPeopleInput
    {
        public string Filter { get; set; }
    }
}
