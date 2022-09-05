using MovieInfo.Data.Interfaces;
using MovieInfo.Data.Repositories;
using MovieInfo.Service.DTOs;
using MovieInfo.Service.Interfaces;
using MovieInto.Domain.Configurations;
using MovieInto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfo.Service.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        public ActorService()
        {
            _actorRepository = new ActorRepository();
        }

        public async Task<bool> CreateAsync(ActorForCreationDto actorDto)
        {
            var actors = await _actorRepository.ReadAllAsync(new PaginationParams { PageIndex=1, PageSize=20});
            bool res = actors.Any(x => x.FirstName == actorDto.FirstName && x.LastName == actorDto.LastName
            && x.BirthDate == actorDto.BirthDate && x.Hobby == actorDto.Hobby);

            if (res) 
            {
                throw new Exception("Actor already exist");
            }
            return await _actorRepository.CreateAsync(
                new Actor
                {
                    FirstName = actorDto.FirstName,
                    LastName = actorDto.LastName,
                    BirthDate = actorDto.BirthDate,
                    Hobby = actorDto.Hobby,
                    Gender = actorDto.Gender
                }
                );

        }
    }
}
