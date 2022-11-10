using System;

class DB_Item<T>
{
    public List<T> Items { get; set; }

    public DB_Item()
    {
        Items = new List<T>();
    }
    public void AddItem(T item)
    {
        Items.Add(item);
    }
}
