using MovieInfo.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfo.Service.Interfaces
{
    public interface IActorService
    {
        Task<bool> CreateAsync(ActorForCreationDto actorDto);
        Task<bool> UpdateAsync(Int64 id, ActorForCreationDto actorDto);
    
    }
}
