    // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

    string[] stringInput = new string[] {"Hello", ":)", "три", "четыре"};
    string[] stringOutput = new string[stringInput.Length];
    int count = 0;

    for (int j = 0; j < stringInput.Length; j++)
    {
        string currentWord = stringInput[j];
        
        for (int i = 0; i < currentWord.Length; i++)
        {
            count++;
        }
    
        if (count <= 3)
        {
            stringOutput[j] = stringInput[j];
        }
        count = 0;
    }

    Console.Write($"[{String.Join(", ", stringInput)}] ---> ");
    Console.Write($"[{String.Join(" ", stringOutput)}]");