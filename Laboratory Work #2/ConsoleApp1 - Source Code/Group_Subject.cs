using System;

class Group_Subject
{
    public int ID { get; set; }
    public int Group_ID { get; set; }
    public int Subject_ID { get; set; }

    public Group_Subject(int iD, int group_ID, int subject_ID)
    {
        ID = iD;
        Group_ID = group_ID;
        Subject_ID = subject_ID;
    }
    public override string ToString()
    {
        return String.Format(ID + " " + Group_ID + " " + Subject_ID);
    }
}
