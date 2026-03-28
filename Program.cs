public class KodePaket
{
    public void getKodePaket(string namaPaket)
    {
        string[] NamaPaket = {"Basic", "Standard", "Premium", "Unlimited", "Gaming", "Streaming", "Family", "Business", "Student", "Traveler"};
        string[] kodePaket = {"P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210"};

        for(int i= 0;i< NamaPaket.Length; i++)
        {
            if(namaPaket == NamaPaket[i])
            {
                Console.WriteLine("Kode Paket: " + kodePaket[i]);
                return;
            }
        }
    }

    public static void Main(string[] args)
    {
        KodePaket paket = new KodePaket();
        Console.WriteLine("Masukkan nama paket:");
        string namaPaket = Console.ReadLine();
        paket.getKodePaket(namaPaket);

        MesinKopi.Main2(args);

    }
}
public class MesinKopi
{
    enum State { OFF, STANDBY, BREWING, MAINTENANCE };

    State state = State.OFF;
    string[] screenName = { "OFF", "STANDBY", "BREWING", "MAINTENANCE" };

    public void standby()
    {
        State currentState = state;
        state = State.STANDBY;
        Console.WriteLine("Mesin " + currentState + " berubah menjadi " + screenName[(int)state]);
    }

    public void brewing()
    {
        State currentState = state;
        state = State.BREWING;
        Console.WriteLine("Mesin " + currentState + " berubah menjadi " + screenName[(int)state]);
    }
    public void maintenance()
    {
        State currentState = state;
        state = State.MAINTENANCE;
        Console.WriteLine("Mesin " + currentState + " berubah menjadi " + screenName[(int)state]);
    }

    public static void Main2(string[] args)
    {
        MesinKopi mesin = new MesinKopi();
        State state = State.OFF;
        Console.WriteLine("Masukkan status mesin yang ingin dipilih:");
        string statusMesin = Console.ReadLine();
        if (statusMesin == "POWER_ON" || statusMesin == "POWER_OFF")
        {
            mesin.standby();
        }
        else if(statusMesin == "START_BREW" || statusMesin == "FINISH_BREW")
        {
            mesin.brewing();
        }
        else if (statusMesin == "START_MAINTENANCE" || statusMesin == "FINISH_MAINTENANCE")
        {
            mesin.maintenance();
        }
    }
}