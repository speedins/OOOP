namespace Domain.users.uobject
{
    internal record UserId
    {
        public Guid Id { get; }
        private UserId(Guid id)
        {
            Id = id;
        }
        public static UserId Create(Guid value)
        {
            if (Guid.Empty == value)
            {
                throw new ArgumentNullException("Что-то пошло не так, попробуйте снова");
            }
            return new UserId(value);
        }
        public static UserId Create()
        {
            Guid Id = Guid.NewGuid();
            return new UserId(Id);
        }
    }
}
