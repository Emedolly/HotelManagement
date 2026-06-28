using HotelManagement.Core.Interfaces;

namespace HotelManagement.Core.Repositories;

public class InMemoryRepository<T> : IRepository<T> where T : class
{
    private readonly List<T> _items = new();
    private int _nextId = 1;

    public void Add(T entity)
    {
        _items.Add(entity);
    }

    public T GetById(int id)
    {
        return _items.FirstOrDefault(item => (int)item.GetType().GetProperty("Id")?.GetValue(item)! == id);
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public void Update(T entity)
    {
        var id = (int)entity.GetType().GetProperty("Id")?.GetValue(entity);
        var existing = GetById(id);
        if (existing != null)
        {
            var index = _items.IndexOf(existing);
            _items[index] = entity;
        }
    }
    public void Delete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }

    public bool Exists(int id)
    {
        return GetById(id) != null;
    }
}