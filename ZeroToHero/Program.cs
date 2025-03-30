namespace ZeroToHero;

internal class EntryPointClass
{
    static void Main(string[] args)
    {
        WriteGreenConsoleText("----Task1----");
        Task1();
        WriteGreenConsoleText("----Task2----");
        Task2();
        WriteGreenConsoleText("----Task3----");
        Task3();
        WriteGreenConsoleText("----Task4----");
        Task4();
        WriteGreenConsoleText("----Task5----");
        Task5();
        WriteGreenConsoleText("----Task6----");
        Task6();
        WriteGreenConsoleText("----Task7----");
        Task7();
        WriteGreenConsoleText("----Task8----");
        Task8();
        WriteGreenConsoleText("----Task9----");
        Task9();
        WriteGreenConsoleText("----Task10----");
        Task10();
        WriteGreenConsoleText("----Task11----");
        Task11();
        WriteGreenConsoleText("----Task12----");
        Task12();
        WriteGreenConsoleText("----Task13----");
        Task13();
        WriteGreenConsoleText("----Task14----");
        Task14();
        WriteGreenConsoleText("----Task15----");
        Task15();
        WriteGreenConsoleText("----Task16----");
        Task16();
        WriteGreenConsoleText("----Task17----");
        Task17();
        WriteGreenConsoleText("----Task18----");
        Task18();
        WriteGreenConsoleText("----Task19----");
        Task19();
        WriteGreenConsoleText("----Task20----");
        Task20();
        WriteGreenConsoleText("----Task21----");
        Task21();
        WriteGreenConsoleText("----Task22----");
        Task22();
        WriteGreenConsoleText("----Task23----");
        Task23();
        WriteGreenConsoleText("----Task24----");
        Task24();
        WriteGreenConsoleText("----Task25----");
        Task25();
        WriteGreenConsoleText("----Task26----");
        Task26();
        WriteGreenConsoleText("----Task27----");
        Task27();
        WriteGreenConsoleText("----Task28----");
        Task28();
        WriteGreenConsoleText("----Task29----");
        Task29();
        WriteGreenConsoleText("----Task30----");
        Task30();
        WriteGreenConsoleText("----Task31----");
        Task31();
        WriteGreenConsoleText("----Task32----");
        Task32();
    }

    static void Task1()
    {
        int x = 5;
        int y = 12;

        Console.WriteLine(x + y);
    }

    static void Task2()
    {
        int x = 5;

        Console.WriteLine(x * x);
    }

    static void Task3()
    {
        string name = "Erol";
        byte age = 20;

        Console.WriteLine($"Salam, mənim adım {name}-dur və mənim {age} yaşım var.");
    }

    static void Task4()
    {
        int a = 12;
        int b = 83;

        Console.WriteLine($"a dəyişəninin əvvəlki dəyəri {a}, b dəyişəninin əvvəlki dəyəri {b}");
        (a, b) = (b, a);
        Console.WriteLine($"a dəyişəninin sonraki dəyəri {a}, b dəyişəninin sonraki dəyəri {b}");
    }

    static void Task5()
    {
        int a = 123;
        int b = 872;
        int c = 42;

        int total = a + b + c;
        int avg = total / 3;
        Console.WriteLine($"Total: {total}, avg: {avg}");
    }

    static void Task6()
    {
        int x = AskIntFromInput("x", 1000, 9999);

        int total = 0;
        while (x > 0)
        {
            total += x % 10;
            x /= 10;
        }

        Console.WriteLine($"Result: {total}");
    }

    static void Task7()
    {
        int x = AskIntFromInput("x");

        Console.WriteLine($"Is even: {((x % 2) == 0)}");
    }

    static void Task8()
    {
        int x = AskIntFromInput("x");
        int y = AskIntFromInput("y");

        if (x == y)
        {
            Console.WriteLine("x = y");
        }
        else
        {
            Console.WriteLine((x > y) ? "x > y" : "x < y");
        }
    }

    static void Task9()
    {
        int x = AskIntFromInput("x");

        if (x == 0)
        {
            Console.WriteLine("x = 0");
        }
        else
        {
            Console.WriteLine((x < 0) ? "x < 0 (negative)" : "x > 0 (positive)");
        }
    }

    static void Task10()
    {
        int x = AskIntFromInput("x");

        Console.WriteLine((((x % 3) == 0) && ((x % 5) == 0)) ? "x is dividable to 3 and 5" : "x is not dividable to 3 and 5");
    }

    static void Task11()
    {
        int x = AskIntFromInput("x");

        Console.WriteLine(((x % 2) == 0) ? "x is dividable to 2" : "x is not dividable to 2");
        Console.WriteLine(((x % 3) == 0) ? "x is dividable to 3" : "x is not dividable to 3");
    }

    static void Task12()
    {
        int x = AskIntFromInput("Month num", 1, 12);

        string name = "";
        switch (x)
        {
            case 1: name = "January"; break;
            case 2: name = "February"; break;
            case 3: name = "March"; break;
            case 4: name = "April"; break;
            case 5: name = "May"; break;
            case 6: name = "June"; break;
            case 7: name = "July"; break;
            case 8: name = "August"; break;
            case 9: name = "September"; break;
            case 10: name = "October"; break;
            case 11: name = "November"; break;
            case 12: name = "December"; break;
        }
        Console.WriteLine(name);
    }

    static void Task13()
    {
        int x = AskIntFromInput("Bal", 0, 100);

        char mark = '\0';
        switch (x)
        {
            case <= 50: mark = 'F'; break;
            case <= 60: mark = 'E'; break;
            case <= 70: mark = 'D'; break;
            case <= 80: mark = 'C'; break;
            case <= 90: mark = 'B'; break;
            case <= 100: mark = 'A'; break;
        }
        Console.WriteLine(mark);
    }

    static void Task14()
    {
        int x = AskIntFromInput("x");
        int y = AskIntFromInput("y");
        string op = AskStringFromInput("Operation", allowedStrings: new string[] { "+", "-", "*", "/" });

        switch (op)
        {
            case "+": Console.WriteLine(x + y); break;
            case "-": Console.WriteLine(x - y); break;
            case "*": Console.WriteLine(x * y); break;
            case "/": Console.WriteLine(x / y); break;
        }
    }

    static void Task15()
    {
        int amount = AskIntFromInput("Amount (AZN)", minValue: 1);

        int discount = 0;
        switch (amount)
        {
            case < 50: break;
            case < 100: discount = 5; break;
            default: discount = 10; break;
        }

        float amountToPay = (float)amount * (1.0f - (float)discount / 100.0f);

        Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {amount} AZN. Ödəyəcəyiniz məbləğ {amountToPay} AZN ({discount}% endirim tətbiq edildi)");
    }

    static void Task16()
    {
        string username = "admin";
        string password = "2222";

        string inUn = AskStringFromInput("Username");
        string inPw = AskStringFromInput("Password");

        Console.WriteLine((inUn == username && inPw == password) ? "Welcome!" : "HTTP ERROR 403 ACCESS DENIED");
    }

    static void Task17()
    {
        double aznPrice = 1.695;

        int amountAznToUsd = AskIntFromInput("Amount (AZN) (AZN-USD)", minValue: 1);
        Console.WriteLine((double)amountAznToUsd / aznPrice);

        int amountUsdToAzn = AskIntFromInput("Amount (USD) (USD-AZN)", minValue: 1);
        Console.WriteLine((double)amountUsdToAzn * aznPrice);
    }

    static void Task18()
    {
        float kg = AskFloatFromInput("Cekinizi qeyd edin", 1.0f, 200.0f);
        float height = AskFloatFromInput("Boyunuzu qeyd edin (metr)", 0.30f, 3.5f);

        Console.WriteLine($"Sizin BMI: {(kg / (height * height))}");
    }

    static void Task19()
    {
        int currentBalance = 816;

        while (true)
        {
            bool exitLoop = false;

            int selected = AskIntFromInput("1. Balans yoxlamaq\n2. Nagdlasdirma\n3. Balans artimi\n0. Cixis\n\nSecim", 0, 3);
            switch (selected)
            {
                case 0: exitLoop = true; break;
                case 1: Console.WriteLine("Sizin balans: " + currentBalance); break;
                case 2:
                    {
                        int amount = AskIntFromInput("Mebleg", minValue: 1);
                        if (amount > currentBalance)
                        {
                            Console.WriteLine("Balansda qeyd edilen vesait movcud deyil");
                        }
                        else
                        {
                            currentBalance -= amount;
                            Console.WriteLine($"Qeyd evilen vesaiti ({amount} AZN) goture bilersiniz.");
                        }
                    }
                    break;
                case 3:
                    {
                        int amount = AskIntFromInput("Mebleg", minValue: 1);
                        currentBalance += amount;
                        Console.WriteLine($"Qeyd edilen mebleg ({amount} AZN) elave olundu.");
                    }
                    break;
            }

            if (exitLoop)
            {
                break;
            }
        }
    }

    static void Task20()
    {
        int[] arr = { 1, 2, 3, 4 };

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static void Task21()
    {
        int[] arr = { 1, 2, 3, 4 };

        int total = 0;
        foreach (var item in arr)
        {
            total += item;
        }

        Console.WriteLine(total);
    }

    static void Task22()
    {
        int[] arr = { 1, 2, 3, 4 };

        int total = 0;
        foreach (var item in arr)
        {
            total += item;
        }

        Console.WriteLine((float)total / (float)arr.Length);
    }

    static void Task23()
    {
        int greatestDigit = int.MinValue;
        int smallestDigit = int.MaxValue;
        int greatestDigitIdx = -1;
        int smallestDigitIdx = -1;

        int[] arr = { 1, 2, 3, 81, 72, 23, 61, 99, 11, 265, 71 };
        for (var i = 0; i < arr.Length; ++i)
        {
            var item = arr[i];
            if (item > greatestDigit)
            {
                greatestDigit = item;
                greatestDigitIdx = i;
            }
            if (item < smallestDigit)
            {
                smallestDigit = item;
                smallestDigitIdx = i;
            }
        }

        Console.WriteLine("En balaca: " + smallestDigit + " index: " + smallestDigitIdx);
        Console.WriteLine("En boyuk: " + greatestDigit + " index: " + greatestDigitIdx);
    }

    static void Task24()
    {
        int[] arr = { 1, 2, 3, 4 };

        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine(item);
            }
        }
    }

    static void Task25()
    {
        int[] arr = { 1, 2, 3, 4 };

        int[] arr2 = new int[arr.Length];
        for (var i = 0; i < arr.Length; ++i)
        {
            arr2[i] = arr[arr.Length - 1 - i];
        }

        foreach (var item in arr2)
        {
            Console.WriteLine(item);
        }
    }

    static void Task26()
    {
        int lookupDigit = 23;

        int[] arr = { 1, 2, 3, 81, 72, 23, 61, 99 };
        for (var i = 0; i < arr.Length; ++i)
        {
            if (arr[i] == lookupDigit)
            {
                Console.WriteLine(lookupDigit);
            }
        }
    }

    static void Task27()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 3, 6 };

        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (var item in arr)
        {
            if (!seen.Add(item))
            {
                duplicates.Add(item);
            }
        }

        Console.WriteLine("Tekrarlanan ededler:");
        foreach (var item in duplicates)
        {
            Console.WriteLine(item);
        }
    }

    static void Task28()
    {
        int prevGreatestDigit = int.MinValue;
        int lastGreatestDigit = int.MinValue;

        int[] arr = { 1, 2, 3, 81, 72, 23, 61, 99, 11, 265, 71 };
        foreach (var item in arr)
        {
            if (item > lastGreatestDigit)
            {
                prevGreatestDigit = lastGreatestDigit;
                lastGreatestDigit = item;
            }
        }

        Console.WriteLine(prevGreatestDigit);
    }

    static void Task29()
    {
        int x = 816254;

        int total = 0;
        while (x > 0)
        {
            total += x % 10;
            x /= 10;
        }

        Console.WriteLine(total);
    }

    static void Task30()
    {
        int x = 816254;

        int total = 0;
        while (x > 0)
        {
            x /= 10;
            ++total;
        }

        Console.WriteLine(total);
    }

    static void Task31()
    {
        int digit = 1270;
        int digit2 = 2;

        Console.WriteLine($"Eded: {digit}, sadedir mi: {(IsDigitSimple(digit))}");
        Console.WriteLine($"Eded: {digit2}, sadedir mi: {(IsDigitSimple(digit2))}");
    }

    static void Task32()
    {
        int x = 8162;
        int y = 2112;

        Console.WriteLine(IsStringPalindrome(x.ToString()));
        Console.WriteLine(IsStringPalindrome(y.ToString()));
    }


    // Helpers

    static void WriteGreenConsoleText(string text)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ForegroundColor = previousColor;
    }

    static bool IsStringPalindrome(string str)
    {
        if (str.Length == 0)
        {
            return false;
        }
        for (var i = 0; i < (str.Length / 2); ++i)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static bool IsDigitSimple(int digit)
    {
        if (digit <= 1)
        {
            return false;
        }
        for (var i = digit - 1; i > 1; --i)
        {
            if (digit % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int AskIntFromInput(string str, int minValue = int.MinValue, int maxValue = int.MaxValue)
    {
        while (true)
        {
            Console.Write(str + ": ");
            try
            {
                var response = Console.ReadLine();
                if (response != null && response.Length > 0)
                {
                    var responseInt = int.Parse(response);
                    if (responseInt >= minValue && responseInt <= maxValue)
                    {
                        return responseInt;
                    }
                    else
                    {
                        Console.WriteLine($"Minimal value: {minValue}, max value: {maxValue}");
                    }
                }
            }
            catch
            {
            }
        }
    }

    static float AskFloatFromInput(string str, float minValue = float.MinValue, float maxValue = float.MaxValue)
    {
        while (true)
        {
            Console.Write(str + ": ");
            try
            {
                var response = Console.ReadLine();
                if (response != null && response.Length > 0)
                {
                    var responseInt = float.Parse(response);
                    if (responseInt >= minValue && responseInt <= maxValue)
                    {
                        return responseInt;
                    }
                    else
                    {
                        Console.WriteLine($"Minimal value: {minValue}, max value: {maxValue}");
                    }
                }
            }
            catch
            {
            }
        }
    }

    static string AskStringFromInput(string str, uint minLength = 0, uint maxLength = 0, string[]? allowedStrings = null)
    {
        while (true)
        {
            Console.Write(str + ": ");
            var response = Console.ReadLine();
            if (response != null && response.Length > 0)
            {
                if ((minLength > 0 && response.Length < minLength) || (maxLength > 0 && response.Length > maxLength))
                {
                    Console.WriteLine($"Minimal length: {(minLength == 0 ? "unlimited" : minLength)}, max length: {(maxLength == 0 ? "unlimited" : maxLength)}");
                }
                else
                {
                    if (allowedStrings != null && !allowedStrings.Contains(response))
                    {
                        Console.WriteLine("Allowed values:");
                        foreach (var entry in allowedStrings)
                        {
                            Console.WriteLine("- " + entry);
                        }
                    }
                    else
                    {
                        return response;
                    }
                }
            }
        }
    }
}
