public class Job
{
  public string _jobTitle;
  public string _company;
  public int _startYear;
  public int _endYear;

  public void Display()
  {
     Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }

  /*
  string _display;

  public string Display()
  {
     _display = $"{_jobTitle} ({_company}) {_years}";
     return _display;
  }
  */
}