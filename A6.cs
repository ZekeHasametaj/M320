namespace A6
{
    internal class Rectangle
    {
    static void Main(string[] args) {

            int height = 5;
            int width = 5;

            static int Area(int width, int height)
            {
                int area = width * height;  // berechnung Fläche
                return area;
            }

            static int Diagonal(int width, int height) {
                int diagonal = width ^ 2 * height ^ 2;
                diagonal = (int)Math.Sqrt(diagonal); // Funktion zur Berechnung
                return diagonal;
            }

            static int Volume(int width, int height) {
                int volume = width * height * width;
                return volume;
            }
        }
    }
}
