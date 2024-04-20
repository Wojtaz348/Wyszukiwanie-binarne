internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int left = 0;
        int right = arr.Length - 1;
        int mid = left + (right - left) / 2;
        Console.WriteLine("Podaj poszukiwana liczbe.");
        int cel = Int32.Parse(Console.ReadLine());
        while (left <= right)
        {
            if (arr[mid] == cel)
            {
                int idx = cel - 1;
                Console.WriteLine(cel + "\no indeksie: " + idx); break;

            }
            if (arr[mid] > cel)
            {
                right = mid - 1;
            }
            if (arr[mid] < cel)
            {
                left = mid + 1;
            }
            if (left > right)
            {
                Console.WriteLine("-1"); break;
            }
            mid = left + (right - left) / 2;

        }
    }
}