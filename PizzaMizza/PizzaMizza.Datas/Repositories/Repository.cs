using PizzaMizza.Core.Models.Base;
using System.Security.Cryptography.X509Certificates;

namespace PizzaMizza.Datas.Repositories
{
    public class Repository<T>where T : BaseModel
    {
        private readonly List<T> _items=new List<T>();

        public async Task Create(T model)
        {
            _items.Add(model);
        }
        public async Task Delete(T model) 
        {
            _items.Remove(model);        
        }
        public T Get(int id)
        {
        foreach (T item in _items)
            {
            if(item.Id == id)
                { 
                    return item;
                }
            }
            return null;               
    
        }
        public List<T> Get() 
        { 
            return _items;
        }



    }
}
