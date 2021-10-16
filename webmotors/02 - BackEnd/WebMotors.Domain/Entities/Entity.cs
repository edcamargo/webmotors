﻿namespace WebMotors.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DateIntegration = null;
        }

        public Guid Id { get; private set; }

        public DateTime? DateIntegration { get; private set; }

        public bool Equals(Entity? other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
    }
}