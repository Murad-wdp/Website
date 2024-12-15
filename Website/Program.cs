//Primary Constructor
//public class Website
//{
//    public Website(string name, string Url, string description, string IPadress)
//    {

//        WebSiteName = name;
//        WebUrl = Url;
//        WebDescription = description;
//        WebSiteIP = IPadress;

//    }

//    public string? WebUrl { get; set; }
//    public string? WebDescription { get; set; }
//    public string? WebSiteIP { get; set; }
//    public string? WebSiteName { get; set; }

//    public void Setdata(string name, string Url, string description, string IPadress)
//    {
//        WebSiteName = name;
//        WebUrl = Url;
//        WebDescription = description;
//        WebSiteIP = IPadress;
//    }

//    public void Print()
//    {
//        Console.WriteLine($"Web saytin adi:{WebSiteName}");
//        Console.WriteLine($"Web saytin Urlsi:{WebUrl}");
//        Console.WriteLine($"Web saytin tesviri:{WebDescription}");
//        Console.WriteLine($"Web saytin IPsi:{WebSiteIP}");
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {

//        Website website = new Website("Google", "www.google.com", "Axtaris", " IPv4: 8.8.8.8 and/or 8.8.4.4");
//        website.Print();
//    }
//}

// Primary Constructor - suz

public class Website
{
    private string _siteName;
    private string _siteUrl;
    private string _description;
    private string _ip;

    public void setData(string _siteName, string _siteUrl, string _description, string _ip)
    {
        this._siteName = _siteName;
        this._siteUrl = _siteUrl;
        this._description = _description;
        this._ip = _ip;
    }

    public void Print()
    {
        Console.WriteLine($"Web saytin adi:{_siteName}");
        Console.WriteLine($"Web saytin Urlsi:{_siteUrl}");
        Console.WriteLine($"Web saytin tesviri:{_description}");
        Console.WriteLine($"Web saytin IPsi:{_ip}");
    }

    public string getName() => _siteName;
    public string getUrl() => _siteUrl;
    public string getDescription() => _description;
    public string getIp() => _ip;
}

public class Program
{
    static void Main()
    {
        Website website = new Website();
        website.setData("Google", "www.google.com", "Axtaris", "IPv4: 8.8.8.8 and/or 8.8.4.4");
        website.Print();
        Console.WriteLine(website.getName());
        Console.WriteLine(website.getUrl());
        Console.WriteLine(website.getDescription());
        Console.WriteLine(website.getIp());
    }
}
