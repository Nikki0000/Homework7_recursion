// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int [] array = {1, 2, 5, 0, 10, 34};

void ShowReverseArray(int [] array, int count) {
    if (count < 0) return;

    Console.Write(array[count] + " ");
    ShowReverseArray(array, count - 1);
}

ShowReverseArray(array, array.Length - 1);




//Можно закоментировать стоку с инициализацией массива вручную и расскоментировать 
//весь код который ниже, так будет задаваться рандомный массив через консоль.
//Но тогда и вызов функции ShowReverseArray необходимо перенести после объявления массива, в конец кода.
//Хотя мне казалось что т.к. с# комплилируемый язык программировани, вызов функции можно осуществлять из любого места кода, но почему то так не работает.
// "Невозможно использовать локальную переменную "array" перед ее объявлением."






// int [] CreateArray(int min, int max, int size){

//     int [] array = new int [size];
//     for(int i = 0; i<size; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array; 
// }

// void ShowArray(int [] array){
    
//     for(int i = 0; i<array.Length;i++){
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }



// Console.WriteLine("Enter array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter array min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter array max");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateArray(min, max, size);
// ShowArray(array);
