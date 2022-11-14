internal class Program
{
    private static void Main(string[] args)
    {
        var debugging = false;

        Console.WriteLine("Starting no bueno...");
        Console.WriteLine("Debugging is " + debugging);

        if (debugging)
        {
            /// Run test email controller.
            var myEmailController = new no_bueno.testEmailController();
        } else
        {
            var myEmailController = new no_bueno.emailManager.controller();
        }

        Console.WriteLine("\nExting Program");
        System.Environment.Exit(1);
    }

}