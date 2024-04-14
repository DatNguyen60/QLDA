using MyCompanyName.AbpZeroTemplate.EntityFrameworkCore;
using MyCompanyName.AbpZeroTemplate.FilmList;
using MyCompanyName.AbpZeroTemplate.PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Migrations.Seed.Host
{
    public class InitialPeopleCreator
    {
        private readonly AbpZeroTemplateDbContext _context;

        public InitialPeopleCreator(AbpZeroTemplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Douglas",
                        Surname = "Adams",
                        EmailAddress = "douglas.adams@fortytwo.com"
                    });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            if (asimov == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Isaac",
                        Surname = "Asimov",
                        EmailAddress = "isaac.asimov@foundation.org"
                    });
            }
            var filmSample1 = _context.Films.FirstOrDefault(p => p.PictureLink == "m.media-amazon.com/images/M/MV5BMzk2ZmYxNTUtODlhMi00NzE2LTkwMTctYjg0ODQ1ZjkyNzJmXkEyXkFqcGdeQXVyMTA3MDk2NDg2._V1_.jpg");
            if (filmSample1 == null)
            {
                _context.Films.Add(
                    new Film
                    {
                        Name = "Kong vs Godzilla",
                        Description = "Monsterverse",
                        PictureLink = "m.media-amazon.com/images/M/MV5BMzk2ZmYxNTUtODlhMi00NzE2LTkwMTctYjg0ODQ1ZjkyNzJmXkEyXkFqcGdeQXVyMTA3MDk2NDg2._V1_.jpg",
                        Price = 45,
                    });
            }

            var filmSample2 = _context.Films.FirstOrDefault(p => p.PictureLink == "upload.wikimedia.org/wikipedia/pt/5/5e/Godzilla_x_Kong_-_The_New_Empire.jpg");
            if (filmSample2 == null)
            {
                _context.Films.Add(
                    new Film
                    {
                        Name = "New empire",
                        Description = "Kong and Godzilla",
                        PictureLink = "upload.wikimedia.org/wikipedia/pt/5/5e/Godzilla_x_Kong_-_The_New_Empire.jpg",
                        Price = 45,
                    });
            }
        }
    }
}
