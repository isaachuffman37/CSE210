class Resume{
    public string name;
    // instances
    public List<Job>_jobs = new List<Job>();
    // constructor
    public Resume(){

    }

    // methods
    public void DisplayResume(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Jobs:");
        foreach(Job job in _jobs){
            job.DisplayJobInfo();
        }
    }
}