using System;
using System.Security.Cryptography.X509Certificates;

class Book
{
    public int ID { get; set; }
    public string _BookName { get; set; }
    
    public Book(int ID, string _BookName)
    {
        this.ID = ID;
        this._BookName = _BookName;
    }
    public override string ToString()
    {
        return String.Format(ID + " " + _BookName);

    }
}
