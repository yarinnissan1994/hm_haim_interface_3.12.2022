using System.Web;

namespace ShapesForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static IShape CompareVertices(IShape o1, IShape o2)
        {
            if (o1.NumOfVertices() > o2.NumOfVertices()) { return o1; }
            else { return o2; }
        }
    }
}