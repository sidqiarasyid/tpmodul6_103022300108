// See https://aka.ms/new-console-template for more information


using tpmodul6_103022300108;

class Run {
    static void Main()
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract – Sidqi Athallah Ar");

        vid.IncreasePlayCount(10000);

        vid.PrintVideoDetails();

        for (int i = 0; i < 10; i++)
        {
            vid.IncreasePlayCount(1000000);
        }
    }

}