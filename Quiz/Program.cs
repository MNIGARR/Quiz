using System;
using System.Threading;


var totalScore = 0;

string[] questions =
{
                "1. Bakinin paytaxti haradir?",
                "2. Suyun kimyevi formulu necedir?",
                "3. Eminem hansi mahnisini qizlarina yazib?",
                "4. Yazin xebercisi hansi qusdur?",
                "5. Urek neche kameralidir?",
                "6. 333-un 3 qati, 333-un 3de birinden ne qeder coxdur?",
                "7. Goy qurshaginin ortasinda hansi reng vardir?",
                "8. Disney sehzadelerinden hansi su altinda yasayirdi?",
                "9. Bitki alemini basqa cur nece adlanirirlar?",
                "10. 'Web hosting' ne demekdir?"
};

Console.WriteLine("Suallara \"A\", \"B\" ve ya \"C\" yazaraq cavab vermelisiniz.");

string[][] variants = new string[10][];

variants[0] = new string[3] { " A) Baki", " B) Sumqayit", " C) Gence" };
variants[1] = new string[3] { " A) HCl", " B) CaSO4", " C) H2O" };
variants[2] = new string[3] { " A) Mockingbird", " B) Not Afraid", " C) Lose Yourself" };
variants[3] = new string[3] { " A) Qaranqus", " B) Serce", " C) Qartal" };
variants[4] = new string[3] { " A) 4", " B) 3", " C) 6" };
variants[5] = new string[3] { " A) Beraberdir", " B) 222", " C) 888" };
variants[6] = new string[3] { " A) Mavi", " B) Yasil", " C) Sari " };
variants[7] = new string[3] { " A) Cindrella", " B) Ariel", " C) Tiana" };
variants[8] = new string[3] { " A) Fauna", " B) Noosfer", " C) Flora" };
variants[9] = new string[3] { " A) Vebsayt fayllarinin saxlandigi yer", " B) Vebsaytlarin adi", " C) Vebsaytlarin idare paneli" };
string[] correctAnswers =
{
                "A",
                "C",
                "A",
                "A",
                "A",
                "C",
                "B",
                "B",
                "C",
                "A"
            };


void CorrectAnswer(ref int totalScore)
{
    Console.Clear();
    totalScore += 10;
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Sizin cavabiniz DOGRUDUR !!!");
    Thread.Sleep(1200);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("\nSizin xaliniz: " + totalScore);
}

void IncorrectAnswer(ref int totalScore)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Sizin cavabiniz YALNISDIR !!!");
    Thread.Sleep(1200);
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.White;
    if (totalScore <= 0) { 
        totalScore = 0;
        Console.WriteLine("\nSizin xaliniz: " + totalScore); 
    }
    else
    {
        totalScore -= 10;
        Console.WriteLine("\nSizin xaliniz: " + totalScore);

    }
}

void Final(ref int totalScore)
{
    Console.WriteLine("Quiz bitdi!!!");
    Console.WriteLine();
    Console.WriteLine("Sizin umumi topladiginiz xal: " + totalScore);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(questions[i]);

    Random rand = new Random();

    int j = rand.Next(0, 3);
    for (j = 0; j < 3; j++)
    {
        Console.WriteLine(variants[i][j]);
    }

    Console.WriteLine("Sizin cavabiniz: ");
    var guessEntry = Console.ReadLine();
    string upperGuess = guessEntry.ToUpper();
    if (upperGuess == correctAnswers[i])
    {
        CorrectAnswer(ref totalScore);
    }
    else
    {
        IncorrectAnswer(ref totalScore);
    }
}
Final(ref totalScore);
