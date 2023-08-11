public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        string complement = "";
        for (int i = 0; i < dna.Length; i++)
        {
            if (dna[i] == 'T')
            {
                complement = complement + 'A';
            }
            else if (dna[i] == 'A')
            {
                complement = complement + 'T';
            }
            else if (dna[i] == 'C')
            {
                complement = complement + 'G';
            }
            else if (dna[i] == 'G')
            {
                complement = complement + 'C';
            }
        }
        return complement;
    }
}