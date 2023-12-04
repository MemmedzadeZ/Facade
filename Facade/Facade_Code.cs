namespace Facade;

public class SaglamliqQorumaq 
{
    public void SaglamQida()
    {
        Console.WriteLine("SaglamQida");
    }

    public void  Hərəkət()
    {
        Console.WriteLine("Hərəkət");
    }

}

public class TehsilAlmaq
{
    public void Budce()
    {
        Console.WriteLine("Budce");
    }

    public void Qeydiyyat()
    {
        Console.WriteLine("Qeydiyyat");
    }
}

public class KariyeraQurmaq
{ 
    public void Istek()
    {
        Console.WriteLine("Istek");
    }

    public void Əminonmaq()
    {
        Console.WriteLine("Əminonmaq");
    }
}


class HeyatFactory
{

    private SaglamliqQorumaq? saglam;
    private TehsilAlmaq? tehsilAlmaq;
    private KariyeraQurmaq? kariyeraQurmaq;

    public HeyatFactory()
    {
        saglam = new SaglamliqQorumaq();
        tehsilAlmaq = new TehsilAlmaq();
        kariyeraQurmaq = new KariyeraQurmaq();
    }

    public void SaglamliqQorumaq()
    {
        saglam.SaglamQida();
        saglam.Hərəkət();
    }


    public void TehsilAlmaq()
    {
        tehsilAlmaq.Budce();
        tehsilAlmaq.Qeydiyyat();


    }

    public void KariyeraQurmaq()
    {
        kariyeraQurmaq.Əminonmaq();
        kariyeraQurmaq.Istek();
    }

}
