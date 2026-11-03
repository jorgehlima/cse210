
public class Resume
{
    // Will store the name of a person
    public string _name;

    // List of jobs
    public List<Job> _jobs = new List<Job>();

    // Adding Display() method
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}
