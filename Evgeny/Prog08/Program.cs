// 8. Показать четные числа от 1 до N

void evenNumber (int i){
    int [] arr = new int [i];
    int index = 0;
    while (index < arr.Length)
    {
         arr[index] = index + 1;
         if (arr[index] % 2 == 0)
         {
             Console.Write($"{arr[index]} ");
         }
         index++;
    }
}
evenNumber(10);