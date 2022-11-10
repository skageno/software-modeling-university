class Program
{
    static void Main(string[] args)
    {
        DB_Item<Group> db_Group = new DB_Item<Group>();
        Group group1 = new Group(1, "PD-33");
        db_Group.AddItem(group1);
        Group group2 = new Group(2, "PD-34");
        db_Group.AddItem(group2);

        DB_Item<Student> db_Student = new DB_Item<Student>();
        Student student1 = new Student(1, "Maxim", "Gorilko", 2);
        db_Student.AddItem(student1);
        Student student2 = new Student(2, "Oleksi", "Kotchetkov", 2);
        db_Student.AddItem(student2);
        Student student3 = new Student(3, "Illya", "Pastuh", 1);
        db_Student.AddItem(student3);

        DB_Item<Adress> db_Adress = new DB_Item<Adress>();
        Adress adress1 = new Adress(1, "Kyiv", 2);
        db_Adress.AddItem(adress1);
        Adress adress2 = new Adress(2, "Brovary", 3);
        db_Adress.AddItem(adress2);
        Adress adress3 = new Adress(3, "Boryspil", 1);
        db_Adress.AddItem(adress3);

        DB_Item<Subject> db_Subject = new DB_Item<Subject>();
        Subject subject1 = new Subject(1, "Modelyvana-PS");
        db_Subject.AddItem(subject1);
        Subject subject2 = new Subject(2, "Architectura-PS");
        db_Subject.AddItem(subject2);
        Subject subject3 = new Subject(3, "Vimogy-PS");
        db_Subject.AddItem(subject3);

        DB_Item<Group_Subject> db_Group_Subject = new DB_Item<Group_Subject>();
        Group_Subject group_subject1 = new Group_Subject(1, 2, 2);
        db_Group_Subject.AddItem(group_subject1);
        Group_Subject group_subject2 = new Group_Subject(2, 2, 1);
        db_Group_Subject.AddItem(group_subject2);
        Group_Subject group_subject3 = new Group_Subject(3, 1, 3);
        db_Group_Subject.AddItem(group_subject3);
        Group_Subject group_subject4 = new Group_Subject(4, 1, 2);
        db_Group_Subject.AddItem(group_subject4);

        foreach (Student s in db_Student.Items)
        {
            Console.WriteLine(s);
            foreach (Adress a in db_Adress.Items)
            {
                if (s.ID == a.Student_ID)
                {
                    Console.WriteLine(a);
                }
            }
            foreach (Group g in db_Group.Items)
            {
                if (g.ID == s.Group_ID)
                {
                    Console.WriteLine(g);
                }
            }
        }
    }
}