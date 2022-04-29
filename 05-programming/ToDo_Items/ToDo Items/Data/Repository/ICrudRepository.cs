namespace ToDo_Items.Data.Repository
{
    public interface ICrudRepository<T,U>
    {
        public IEnumerable<T> GetAll();

        public T Get(U id);

        public void Add(T element);

        public void Update(T element);

        public void Delete(U id);

        // Extra

        public bool Exists(U id);

        public bool Save();
    }
}
