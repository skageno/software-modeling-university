using System;
class Adress
{
    public int ID { get; set; }
    public string Student_Adress { get; set; }
    public int Student_ID { get; set; }

    public Adress(int iD, string student_Adress, int student_ID)
    {
        ID = iD;
        Student_Adress = student_Adress;
        Student_ID = student_ID;
    }
    public override string ToString()
    {
        return String.Format(ID + " " + Student_Adress + " " + Student_ID);
    }
}
