using System;

class Subject
{
    public int ID { get; set; }
    public string Subject_Name { get; set; }

    public Subject(int iD, string subject_Name)
    {
        ID = iD;
        Subject_Name = subject_Name;
    }
    public override string ToString()
    {
        return String.Format(ID + " " + Subject_Name);
    }
}