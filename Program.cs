using GamePaintBall;

internal class Program
{
    private static void Main(string[] args)
    {
       PaintballGun Gun = new PaintballGun();
        while (true)
        {
            Console.WriteLine($"Kulki: {Gun.GetBalls()}, zaladowano: {Gun.GetBallsLoaded}");
            if (Gun.IsEmpty) Console.WriteLine("Ostrzezenie brak amunicji");
            Console.WriteLine("Spacja - strzal, p - przeladowanie," +
                " + - dodaj amunicje, k - koniec");
            char key = Console.ReadKey(false).KeyChar;
            if (key == ' ') Console.WriteLine($"Proba strzalu: {Gun.Shoot()}");
            else if (key == 'p') Gun.Reload();
            else if (key == '+') Gun.SetBalls(Gun.GetBalls() + PaintballGun.MAGAZINE_SIZE);
            else if (key == 'k') return;
        }
    }
}