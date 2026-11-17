// in tamrin mrbvt bh bharad mhar ast
try
{
    Console.Clear();
    Console.WriteLine("tadad saat kar kargr ra vard kn");
    var mizankar = Convert.ToInt32(Console.ReadLine());
    var sod = mizankar * 3.5;
    Console.WriteLine($"mizan sod kargr ghbl az km krdn malyat: {sod}");
    var malyat = sod * 5 / 100;
    Console.WriteLine($"malyaty kh ghrar ast km shvd: {malyat}");
    Console.WriteLine($"sody kh ghrar ast bh kargr dadh shvd{sod - malyat}");
}
catch (FormatException)
{
    Console.WriteLine("add vard nkrdy");
}
catch (OverflowException)
{
    Console.WriteLine("addy kh vard krdy bzrg ast dobarh emtehan kn");
}
finally
{
    Console.WriteLine("✅");
}