namespace Domain.Base
{
    public abstract class BaseEntity
    {
        public Guid Id = Guid.NewGuid();
    }
}
