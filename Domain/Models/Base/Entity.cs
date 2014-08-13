using System;

namespace Domain.Models.Base {
    public interface IEntity<T> {
        T Id { get; set; }
    }

    public abstract class Entity : IEntity<Guid> {
        public Guid Id { get; set; }
    }
}