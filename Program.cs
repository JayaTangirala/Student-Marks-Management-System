namespace StudentMarksManagementSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] m = { 78, 56, 89, 90, 45, 68, 92, 74, 81, 66 };

            // instantiate marks object with size as m's length.
            IntegerArray marks = new IntegerArray(m.Length);
            
            //insert all elements of m into marks.
            for (int i = 0;i < m.Length; i++)
            {
                marks.insert(i, m[i]);
            }
            
            marks.traverse();

            Console.WriteLine("Highest mark is: " + marks.getMax());
            Console.WriteLine("Least mark is: " + marks.getMin());
            Console.WriteLine("Average mark is: " + marks.computeAverage());
            Console.WriteLine("Number of students secured above average mark is: " + marks.countAboveAverage());
                       
        }
    }
}