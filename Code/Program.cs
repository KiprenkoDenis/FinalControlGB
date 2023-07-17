Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] resultArray = Array.FindAll(originalArray, item => item.Length <= 3);

        Console.Write($"[{string.Join(", ", originalArray)}] -> ");
        Console.WriteLine($"[{string.Join(", ", resultArray)}]");