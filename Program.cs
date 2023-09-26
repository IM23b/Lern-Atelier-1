namespace LA_319_6904_TrögerRobert
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string robertTroeger = "Robert Tröger"; 
           DateTime nächsteModulPrüfung = new DateTime(2023, 11, 30);
            Console.WriteLine(nächsteModulPrüfung.ToString());
            Console.WriteLine(robertTroeger.ToString());
            const string blutGruppe = "Blutgruppe 0 ";
            Console.WriteLine(blutGruppe.ToString());
            double erwarteteNote = 5;
            Console.WriteLine(erwarteteNote.ToString());
            char letzterBuchstabeKlassenbezeichnung = 'B';
            Console.WriteLine(letzterBuchstabeKlassenbezeichnung.ToString());
            Console.WriteLine("Ich habe den Schülerausweis bekommen."); bool ichHabeDenSchülerausweisDabei = true;
            Console.WriteLine(ichHabeDenSchülerausweisDabei.ToString());
            Random zufallsZahl1Und99 = new Random();
            int randomNumber = zufallsZahl1Und99.Next(1, 99);
            Console.WriteLine("Die Zufallszahl zwischen 1 und 99 lautet:"); Console.WriteLine(randomNumber.ToString());
            blutGruppe = "A";

        }
    }
}