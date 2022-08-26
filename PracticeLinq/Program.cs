var videoGameList = new List<string>()
{
    "Apex Legends",
    "Super Mario Cart",
    "Super Smash Bros",
    "Destiny",
    "Halo",
    "Overwatch",
    "Call Of Duty",
};

videoGameList.OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));