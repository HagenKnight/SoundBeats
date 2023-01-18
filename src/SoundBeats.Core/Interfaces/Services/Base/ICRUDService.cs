﻿using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Management;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Services.Base
{
    public interface ICRUDService<TGetDto, TAddDto, TUpdDto, TDelDto, TKey, TEntity, TRepoAll, TContext>
     where TEntity : class, IEntityBase<TKey>
     where TRepoAll : IBaseRepository<TEntity, TContext>
     where TContext : DbContext, new()
    {
        Task<IEnumerable<TGetDto>> GetAll(CancellationToken cancellationToken = default);
        Task<TGetDto> FindAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<TGetDto>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
        Task<TUpdDto> UpdateAsync(TUpdDto objDTO, CancellationToken cancellationToken = default);
        Task<TAddDto> InsertAsync(TAddDto objDTO, CancellationToken cancellationToken = default);
        Task<TDelDto> DeleteAsync(TDelDto objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
    }
}