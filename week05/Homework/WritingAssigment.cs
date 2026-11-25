public class WritingAssigment: Assigment
{   
    private string _title;
    public WritingAssigment(string studentName, string topic, string title): base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
      // To get the data you need for the method you can either make 
      // the variable protected in the base class, or you can create
      // a public GetStudentName method to return it.
        return $"{_title} by {_studentName}" ;
    }
}