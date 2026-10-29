public class LabelGenerator
{
    public string CreateLabel(string rawText) //kan kalle utenfor class
    {
        // TODO: Bruk den private helperen og returner f.eks. "LABEL: LUNAR SAMPLE".
        return "LABEL: " + Normalize(rawText);
    }

    private string Normalize(string rawText) // private kall i samme class
    {
        // TODO: Trim og gjør teksten uppercase.
        return rawText.ToUpper().Trim();

    }


}

