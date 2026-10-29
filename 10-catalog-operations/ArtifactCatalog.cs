public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {

        if (artifacts.Contains(artifact))
        {


            Console.WriteLine("Atrefact finnes fra før ");
        }
        else
        {

            if (!artifacts.Contains(artifact))
            {

                artifacts.Add(artifact);


            }
        }

    }

    public void PrintAll()
    {

        foreach (Artifact art in artifacts)


        {

            Console.WriteLine("Artifacts er :" + art.Name + " " + art.Origin);

        }


    }



    public Artifact? FindByName(string name)
    {

        if (string.IsNullOrWhiteSpace(name))
        {

            return null;
        }
        else
        {
            for (int i = 0; i <= artifacts.Count; i++)
            {
                var Artifact = artifacts[i]; // elemnet som skal returnes


                if (artifacts[i] != null)
                {
                    return Artifact;

                }


            }
            return null;

        }





    }



    // TODO: Finn manuelt med løkke.

}

