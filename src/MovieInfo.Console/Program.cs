using MovieInfo.Data.Interfaces;
using MovieInfo.Data.Repositories;
using MovieInto.Domain.Configurations;
using MovieInto.Domain.Entities;

IActorRepository actorRepository = new ActorRepository();
Actor actor = await actorRepository.ReadAsync(2);
Console.WriteLine(actor.FirstName + " " + actor.LastName);