using TPMod4_103022300017;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(KodePos.getKodePos("Kujangsari"));
        Console.WriteLine(KodePos.getKodePos("batununggal"));
        Console.WriteLine(KodePos.getKodePos("jatisari"));

        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();
    }
}