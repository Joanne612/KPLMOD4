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
    }


}