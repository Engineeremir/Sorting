// See https://aka.ms/new-console-template for more information

//Time Complexisty => 0(n^2) ==> İki döngü içi içe
//Space Complexisty => 0(1) ==> Yeni bir bellekte alan yaratmıyoruz
//Easy to use
//Expensive


int[] numbers = { 57, 9, 6, 12, 4, 36, 14, 0, 1, 13, 5, 4 };
string[] names = { "Ahmet","Mehmet","Ayşe","Ali","Fatma","Veli"};

SelectionSort(numbers);
SelectionSort(names);

Console.WriteLine(string.Join(',',numbers));
Console.WriteLine(string.Join(',',names));

void SelectionSort<T>(T[] array) where T:IComparable
{
    for (int i = 0; i < array.Length; i++)
    {
        int minIndex = i;
        for (int j = i+1; j < array.Length; j++)
        {
            
            if (array[j].CompareTo(array[minIndex])<0)
            {
                minIndex = j;
            }
        }

        var temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
    }
}
