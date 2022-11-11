internal class Program
{
    private static void Main(string[] args)
    {
        var debugging = true;

        Console.WriteLine("Starting no bueno...");

        if (debugging)
        {

            /// Run test email controller.
            var myEmailController = new no_bueno.testEmailController();
        }
    }

}