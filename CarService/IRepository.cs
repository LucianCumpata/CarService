﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarService
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public abstract class EntityBase
    {
        //public int Id { get; protected set; }
    }

    public partial class Auto : EntityBase
    {

    }

    public partial class Sasiu : EntityBase
    {

    }

    public partial class Mecanic : EntityBase
    {

    }

    public partial class Client : EntityBase
    {

    }

    public partial class Comanda : EntityBase
    {

    }

    public partial class Material : EntityBase
    {

    }

    public partial class DetaliuComanda : EntityBase
    {

    }

    public partial class Imagine : EntityBase
    {

    }

    public partial class Operatie : EntityBase
    {

    }

}
