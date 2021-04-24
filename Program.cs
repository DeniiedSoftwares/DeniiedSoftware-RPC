using DiscordRPC;
using System;

namespace DeniiedSoftware_RPC
{
    class Program
    {
		public static DiscordRpcClient app;
		private static void Main(string[] args)
        {
			app = new DiscordRpcClient("825924421700943882");
			app.Initialize();

			var VisitButton = new Button();
			VisitButton.Label = "Visit";
			VisitButton.Url = "https://deniiedsoftwares.github.io";

			app.SetPresence(new RichPresence()
			{

				State = "For 69 years",
				Assets = new Assets() { LargeImageKey = "obama" },
				Buttons=new Button[] { VisitButton }

			});
			

			Console.ReadLine();
		}
    }
}
