namespace Colaborativny_projekt_na_hodine;

class Program
{
    static void Main(string[] args)
    {
        string cesta = "cisla.txt";

        // Krok 1 (Teammate 1): Vygeneruje súbor a načíta z neho čísla
        SuborHelper.VytvorSubor(cesta);
        List<int> nacitaneCisla = SuborHelper.NaciatajCisla(cesta);

        // Krok 2 (Teammate 2): Vypočíta priemer/max a vypíše výsledok
        VypoctyHelper.SpracujAVypisStatistiky(nacitaneCisla);
    }
}
