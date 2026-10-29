public class Beacon
{
    public int Frequency { get; set; } // ikke static, fordi hver Beacon har sin egen frekvens
    public static int CreatedCount { get; private set; } //static, fordi det er en felles teller for alle Beacon-objekter

    public Beacon(int frequency)
    {
        Frequency = frequency;
        CreatedCount++;         //øker CreatedCount hver gang en ny Beacon blir opprettet

        // TODO: Oppdater CreatedCount.
    }
}
