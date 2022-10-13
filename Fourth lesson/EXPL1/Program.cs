// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("Задаем случайным образом 8 цифр в пределах 0 - 1");
int[] myArray = new int[8];
         Random rand = new Random();
            
         for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(0,2);
                Console.WriteLine($"Число {x+1} = {myArray[x]}");
            }
