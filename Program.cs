Console.WriteLine("Введите длину массива");
int len_arr_init = int.Parse(Console.ReadLine()!);
string[] arr_init = new string[len_arr_init];
int len_of_element_to_check = 3;
string elements = "";
for (int i = 0; i < len_arr_init; i++){
    Console.Write($"Введите строку для {i}-го элемента массива: ");
    arr_init[i] = Console.ReadLine()!;
    if (arr_init[i].Length <= len_of_element_to_check){
        elements += (arr_init[i]+" ");
    }
}

string[] arr_final = elements.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"[{String.Join(", ", arr_init)}] ->  [{String.Join(", ", arr_final)}]");