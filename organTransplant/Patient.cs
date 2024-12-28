namespace organTransplant;

public class Patient
{
    private string name;
    private int _kidneyCount;

    public Patient(string name, int kidneyCount)
    {
        this.name = name;
        _kidneyCount = kidneyCount;
    }
    
    public void TransplantKidney(Patient patient)
    {
        if (patient._kidneyCount < 2)
        {
            patient._kidneyCount++;
            _kidneyCount--;
            Console.WriteLine($"{name} kidney count {_kidneyCount}\n" +
                              $"{patient.name} kidney count {patient._kidneyCount}");
        }
    }
}