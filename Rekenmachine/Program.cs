Console.WriteLine();
Console.WriteLine("**************************************************************************");
Console.WriteLine("*  W E L CO M E    T O    T H E    C O N S O L E    C A L C U L A T O R  *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* -Om een berekening te maken, geef een bewerking in als 1+2;            *"); 
Console.WriteLine("* -Om te rekenen met variabelen, geef een bewerking in als 1+m2;         *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* -Om de lokale variabelen met hun waarde te tonen, tyoe 'locals'.       *");
Console.WriteLine("* -Om een variabele in te stellen, geef een opdracht als m1+1            *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* -Voor een lijst van alle ondersteunende bewerkingen, typ 'listcalc'.   *");
Console.WriteLine("* -Voor informatie van de schrijver weer te geven, typ 'author'.         *");
Console.WriteLine("* -Om de console leeg te maken, schrijf 'clear'.                         *");
Console.WriteLine("* -Om de rekenmachine af te sluiten, typ 'exit'.                         *");
Console.WriteLine("*                                                                        *"); 
Console.WriteLine("**************************************************************************");
Console.WriteLine();
Console.WriteLine();


while (true)

{
    Console.WriteLine();
    Console.Write("> ");
    Console.SetCursorPosition(2, Console.CursorTop);
    // input is wat de gebruiker ingeeft
    // verwijder spaties
    string input = Console.ReadLine().Replace(" ", "");


    //De console applicatie stopzetten.
    if (input.ToLower().Trim() == "exit")
    {
        // Close the console.
        Environment.Exit(0);
    }
    // Het commando om alles te bekijken want je kan doen.
    if (input.ToLower().Trim() == "listcalc")
    {
        Console.WriteLine();
        Console.WriteLine(">   COMMAND      VOORBEELD       UITLEG");
        Console.WriteLine(">    +             1+2            //Geef de som van de getallen weer ");
        Console.WriteLine(">    -             1-2            //Geef het verschil van de getallen weer");
        Console.WriteLine(">    *             1*2            //Geef het product van de getallen zeer");
        Console.WriteLine(">    /             1/2            //Geef het quotient van de getallen weer");
        Console.WriteLine(">    %             1%2            //Geef de delingsrest van de getallen weer");

    } // Het commando om alles te bekijken want je kan doen.
    if (input.ToLower().Trim() == "locals")
    {

    }

    //De ascii art en author command
    if (input.ToLower().Trim() == "author")
    {
        Console.WriteLine("");
        Console.WriteLine(@"  ` : | | | |:  ||  :     `  :  |  |+|: | : : :|   .        `              .
      ` : | :|  ||  |:  :    `  |  | :| : | : |:   |  .                    :
         .' ':  ||  |:  |  '       ` || | : | |: : |   .  `           .   :.
                `'  ||  |  ' |   *    ` : | | :| |*|  :   :               :|
        *    *       `  |  : :  |  .      ` ' :| | :| . : :         *   :.||
             .`            | |  |  : .:|       ` | || | : |: |          | ||
      '          .         + `  |  :  .: .         '| | : :| :    .   |:| ||
         .                 .    ` *|  || :       `    | | :| | :      |:| |
 .                .          .        || |.: *          | || : :     :|||
        .            .   . *    .   .  ` |||.  +        + '| |||  .  ||`
     .             *              .     +:`|!             . ||||  :.||`
 +                      .                ..!|*          . | :`||+ |||`
     .                         +      : |||`        .| :| | | |.| ||`     .
       *     +   '               +  :|| |`     :.+. || || | |:`|| `
                            .      .||` .    ..|| | |: '` `| | |`  +
  .       +++                      ||        !|!: `       :| |
              +         .      .    | .      `|||.:      .||    .      .    `
          '                           `|.   .  `:|||   + ||'     `
  __    +      *                         `'       `'|.    `:
""'  `---""""----....____,..^---`^``----.,.___          `.    `.  .    ____,.,-
    ___,--'""""`---""'   ^  ^ ^        ^       """"'---,..___ __,..---""'
--""'      ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Dit rekenmachine is gemaakt door James Derant van 6InfoA in 2023");

    }
    //De console leeg maken
    if (input.ToLower().Trim() == "clear")
    {
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*  W E L CO M E    T O    T H E    C O N S O L E    C A L C U L A T O R  *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("* -Om een berekening te maken, geef een bewerking in als 1+2;            *");
        Console.WriteLine("* -Om te rekenen met variabelen, geef een bewerking in als 1+m2;         *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("* -Om de lokale variabelen met hun waarde te tonen, tyoe 'locals'.       *");
        Console.WriteLine("* -Om een variabele in te stellen, geef een opdracht als m1+1            *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("* -Voor een lijst van alle ondersteunende bewerkingen, typ 'listcalc'.   *");
        Console.WriteLine("* -Voor informatie van de schrijver weer te geven, typ 'author'.         *");
        Console.WriteLine("* -Om de console leeg te maken, schrijf 'clear'.                         *");
        Console.WriteLine("* -Om de rekenmachine af te sluiten, typ 'exit'.                         *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine();


    }

    // De berekening
    // temp wordt gebruikt om de huidige waarde van het getal bij te houden,
    // De char.IsDigit methode wordt gebruikt om te controleren of een bepaald karakter een cijfer is of niet. 

    double result = 0;
    double temp = 0;
    char operation = '+';

    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];

        if (Char.IsDigit(c))
        {
            // als het een getal is
            temp = temp * 10 + Convert.ToDouble(c.ToString());
        }
        else if (c == '%')
        {
            // als het een percent teken is
            temp /= 100.0;
        }
        else
        {
            // anders, verwerk de vorige berekening en update de nieuwe bewerking
            switch (operation)
            {
                case '+':
                    result += temp;
                    break;
                case '-':
                    result -= temp;
                    break;
                case '*':
                    result *= temp;
                    break;
                case '/':
                    result /= temp;
                    break;
            }

            temp = 0;
            operation = c;
        }
    }

    // Verwerk de laatste berekening
    switch (operation)
    {
        case '+':
            result += temp;
            break;
        case '-':
            result -= temp;
            break;
        case '*':
            result *= temp;
            break;
        case '/':
            result /= temp;
            break;
    }

    Console.WriteLine(result);

}
