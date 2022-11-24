namespace Проводник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write.Disk();

            Strelka StrelkaUsing = new Strelka();
            StrelkaUsing.StrlekD();

            Console.Clear();

            Write.Fail();
        }
    }
}