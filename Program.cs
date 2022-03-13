MainMenu();

string input = Console.ReadLine();

while (true)
{
    if (input == "1")
    {
        StanardKnitting();
        break;
    }
    else if (input == "2")
    {
        NonStandardKnitting();
        break;
    }
    else
    {
        Console.Clear();
        MainMenu();
        input = Console.ReadLine();
        continue;
    }
}




static void Print(double countOfStitches, double height, double puloverWidth, double puloverHeight)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"{puloverWidth} броя бримки за ред");
    Console.WriteLine($"{puloverHeight} реда");
    Console.WriteLine($"{countOfStitches} бримка/и на сантиметър");
    Console.WriteLine($"{height} височина на реда");
}

static void StanardKnitting()
{

    Console.WriteLine($"Въведете брой бримки");
    double stitchesPerTenCm = double.Parse(Console.ReadLine());


    Console.WriteLine($"Въведете брой редове");
    double rowsPerTenCm = double.Parse(Console.ReadLine());


    Console.WriteLine("Въведете широчина на плетивото(cm)");
    double puloverWidth = double.Parse(Console.ReadLine());


    Console.WriteLine($"Въведете височина на плетивото(cm)");
    double puloverHeight = double.Parse(Console.ReadLine());



    double stitchesPerCm = stitchesPerTenCm / 10;
    double sizeOfRow = rowsPerTenCm / 10;
    double countOfstitchesForWidth = puloverWidth * stitchesPerCm;
    double countOfTotalRows = puloverHeight * sizeOfRow;

    double totalStitches = countOfTotalRows * countOfstitchesForWidth;
    double totalSpentYarn = totalStitches * stitchesPerCm;

    Print(stitchesPerCm, sizeOfRow, countOfstitchesForWidth, countOfTotalRows);
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"{totalSpentYarn / 100}м. прежда е необходима за плетивото");
}

static void NonStandardKnitting()
{
    Console.WriteLine($"Въведете брой бримки");
    double stitchesPerTenCm = double.Parse(Console.ReadLine());

    Console.WriteLine($"Въведете брой редове");
    double rowsPerTenCm = double.Parse(Console.ReadLine());

    Console.WriteLine("Въведете широчината във връхната(cm) точка на плетивото");
    double widthInTheTop = double.Parse(Console.ReadLine());

    Console.WriteLine("Въведете широчината в началната(cm) точка на плетивото");
    double widthInTheBottom = double.Parse(Console.ReadLine());

    Console.WriteLine("Въведете височина на плетивото(cm)");
    double height = double.Parse(Console.ReadLine());

    double stitchesPerCm = stitchesPerTenCm / 10;
    double sizeOfRow = rowsPerTenCm / 10;
    double countOfstitchesForWidth = widthInTheBottom * stitchesPerCm;
    double countOfTotalRows = height * sizeOfRow;

    double totalStitches = countOfTotalRows * countOfstitchesForWidth;
    double totalSpentYarn = totalStitches * stitchesPerCm;

    double nRow = countOfTotalRows / ((widthInTheTop * stitchesPerCm - countOfstitchesForWidth) / 2);
    Console.WriteLine($"На всеки {Math.Floor(nRow)} ред прибавка");
    Console.WriteLine($"{totalSpentYarn / 100}м. прежда е необходима за плетивото");

}
static void MainMenu()
{

    string pattern = @"
██╗  ██╗███╗   ██╗██╗████████╗████████╗██╗███╗   ██╗ ██████╗ 
██║ ██╔╝████╗  ██║██║╚══██╔══╝╚══██╔══╝██║████╗  ██║██╔════╝ 
█████╔╝ ██╔██╗ ██║██║   ██║      ██║   ██║██╔██╗ ██║██║  ███╗
██╔═██╗ ██║╚██╗██║██║   ██║      ██║   ██║██║╚██╗██║██║   ██║
██║  ██╗██║ ╚████║██║   ██║      ██║   ██║██║ ╚████║╚██████╔╝
╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝   ╚═╝      ╚═╝   ╚═╝╚═╝  ╚═══╝ ╚═════╝                                                             
";


    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(pattern);
    Console.WriteLine();
    Console.WriteLine();
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine("Избирете опция от следното меню");
    Console.WriteLine("[За стандартно плетиво въведете: 1]");
    Console.WriteLine("[За не стандартно плетиво въведете: 2]");


    Console.ResetColor();
}
