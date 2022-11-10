using System;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Group_ID { get; set; }

    public Student(int iD, string name, string surname, int group_ID)
    {
        ID = iD;
        Name = name;
        Surname = surname;
        Group_ID = group_ID;
    }
    public override string ToString()
    {
        return String.Format(ID + " " + Name + " " + Surname + " " + Group_ID);
    }
}
