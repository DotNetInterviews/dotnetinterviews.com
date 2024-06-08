public class Report
{
    public string ReportType { get; set; }

    public void GenerateReport()
    {
        /*Code to generate report*/
    }

    public void SaveReport()
    {
        /*Code to save report*/
    }
}

//To follow SRP
public class ReportGenerator
{
    public void GenerateReport()
    {
        /*Code to generate report*/
    }
}

public class ReportSaver
{
    public void SaveReport()
    {
        /*Code to save report*/
    }
}