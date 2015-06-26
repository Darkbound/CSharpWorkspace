using System;
using System.Linq;
using System.Text;

public class MyList<T>
{
    private const int DEFAULT_CAPACITY = 4;

    private T[] items;

    public MyList()
    {
        this.Count = 0;
        this.Capacity = DEFAULT_CAPACITY;
        this.items = new T[this.Capacity];
    }

    public int Count { get; private set; }

    public int Capacity { get; private set; }

    public T this[int index]
    {
        get
        {
            if ((index >= 0) && (index < this.items.Length))
            {
                return this.items[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

        }

        set
        {
            if ((index >= 0) && (index < this.items.Length))
            {
                this.items[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }
        }
    }

    public void Add(T item)
    {
        this.Count++;
        this.Resize(this.Count);
        this.items[this.Count - 1] = item;
    }

    public void Insert(int index, T item)
    {
        if (!((index >= 0) && (index < this.items.Length)))
        {
            throw new IndexOutOfRangeException("Invalid index.");
        }

        this.Count++;
        this.Resize(this.Count);

        Array.Copy(this.items, index, this.items, index + 1, this.Count - index - 1);

        this.items[index] = item;
    }

    public void RemoveAt(int index)
    {
        if (!((index >= 0) && (index < this.items.Length)))
        {
            throw new IndexOutOfRangeException("Invalid index.");
        }

        this.Count--;
        this.Resize(this.Count);
        Array.Copy(this.items, index + 1, this.items, index, this.Count - index);
        this.items[index] = default(T);
    }

    public int IndexOf(T item)
    {
        return Array.IndexOf(this.items, item);
    }

    public bool Contains(T item)
    {
        return this.items.Contains(item);
    }

    public void Clear()
    {
        this.Count = 0;
        this.Capacity = DEFAULT_CAPACITY;
        this.items = new T[this.Capacity];
    }

    public override string ToString()
    {
        if (this.Count == 0)
        {
            return "The list does not contain any elements!";
        }

        StringBuilder sb = new StringBuilder();
        sb.Append("myList: ");

        for (int i = 0; i < this.Count; i++)
        {
            sb.AppendFormat("{0}", this.items[i]);
            if (i + 1 < this.Count)
            {
                sb.Append(", ");
            }
        }

        return sb.ToString();
    }
    
    private void Resize(int capacity)
    {
        this.Capacity = capacity * 2;
        Array.Resize(ref this.items, this.Capacity);
    }
}