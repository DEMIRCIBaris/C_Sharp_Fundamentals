using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public interface IRepository<Type> where Type:class, IEntity,new() //struct yazarsak sadece değer tipleri verebilirdik
    {
        List<Type> GetAll();
        Type Get(int id);
        void Add(Type entity);
        void Delete(Type entity);
        void Update(Type entity);
    }
}
