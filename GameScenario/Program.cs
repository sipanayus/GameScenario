// See https://aka.ms/new-console-template for more information
using GameScenario;

//Console.WriteLine("Hello, World!");
//dc de yardım iste


GamerManager gamerManager = new GamerManager(new GamerCheckManager());

gamerManager.Save(new Gamer
{
    Id = 1,
    Name = "sipan",
    Surname = "ay",
    BirthYear = new DateTime(2003, 1, 2),
    NationalityIdentity = "123456789"
});




GameManager gameManager = new GameManager( );

gameManager.GameAdd(new Game { GameId = 1, GameName = "GTA V", GamePrice = 150 });



CampaignManager campaignManager = new CampaignManager();
campaignManager.CampaignAdd(new Campaign { CampaignName ="sezon sonu" });

Console.ReadLine();