using System;

class Annotated
{
    public int ID { get; set; }
    public string AnnotatedText { get; set; }   
    public int BookID { get; set; }
    public Annotated(int ID, string AnnotatedText, int BookID)
    {
        this.ID = ID;
        this.AnnotatedText = AnnotatedText;
        this.BookID = BookID;
    }
    public override string ToString()
    {
        return String.Format(ID + " " + AnnotatedText + " " + BookID);
    }
}