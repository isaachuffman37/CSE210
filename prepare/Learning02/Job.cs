public class Job{
    // instances
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // constructor
    public Job(){

    }

    //methods
    public void DisplayJobInfo(){
        Console.WriteLine($" {_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }


}