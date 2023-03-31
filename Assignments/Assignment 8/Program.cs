// See https://aka.ms/new-console-template for more information
Console.WriteLine("Assignemnt 8!");

/*
1. Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
1. int Count()
2. T Pop()
3. Void Push()
*/

public int Count()
{
    return items.Count;
}

public T Pop()
{
    T item = items.LastOrDefault();
    items.RemoveAt(items.Count - 1);
    return item;
}

public void Push(T item)
{
    items.Add(item);
}

/*
2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index)
*/
public void Add(T element)
{
    items.Add(element);
}

public T Remove(int index)
{
    T item = items[index];
    items.RemoveAt(index);
    return item;
}

public bool Contains(T element)
{
    return items.Contains(element);
}

public void Clear()
{
    items.Clear();
}

public void InsertAt(T element, int index)
{
    items.Insert(index, element);
}

public void DeleteAt(int index)
{
    items.RemoveAt(index);
}

public T Find(int index)
{
    return items[index];
}


/*
3. Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)
*/
public void Add(T item)
{
    items.Add(item);
}

public void Remove(T item)
{
    items.Remove(item);
}

public void Save()
{
    // implementation for saving to database or other data source
}

public IEnumerable<T> GetAll()
{
    return items;
}

public T GetById(int id)
{
    return items.FirstOrDefault(item => item.Id == id);
}
