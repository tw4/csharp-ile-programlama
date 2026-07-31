// Kod 6.2 — switch deyimi ve durum birleştirme
// switch Deyimi

DayOfWeek gun = DateTime.Today.DayOfWeek;

switch (gun)
{
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("Hafta sonu");
        break;

    case DayOfWeek.Friday:
        Console.WriteLine("Haftanın son iş günü");
        break;

    default:
        Console.WriteLine("İş günü");
        break;
}
