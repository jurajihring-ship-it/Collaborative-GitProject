namespace Colaborativny_projekt_na_hodine;

class Program
{
    static void Main(string[] args)
    {
        void Function()
        {
            File.OpenWrite("Program.cs,");
            if (cisla == null || cisla.Count == 0)
            {
                Console.WriteLine("Zoznam čísel je prázdny.");
                return;
            }

            // 1. Výpočet Priemeru (Mean/Average)
            double suma = 0;
            for (int i = 0; i < cisla.Count; i++)
            {
                suma += cisla[i];
            }
            double priemer = suma / cisla.Count;

            // 2. Výpočet Maxima
            int max = cisla[0];
            for (int i = 0; i < cisla.Count; i++)
            {
                if (cisla[i] > max)
                {
                    max = cisla[i];
                }
            }

            // 3. Dekoratívny výstup do konzoly
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("       📊 ŠTATISTICKÝ PREHĽAD 📊        ");
            Console.WriteLine("========================================");
            Console.WriteLine("  ► Počet načítaných čísel : " + cisla.Count);
            Console.WriteLine("  ► Priemer (Mean/Average)  : " + priemer);
            Console.WriteLine("  ► Maximum (Max)           : " + max);
            Console.WriteLine("========================================");
            Console.WriteLine();

        }
    }
}