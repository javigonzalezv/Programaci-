using System.Collections.Generic;

namespace Tasca_BanquerAnalogic
{
    public class Banker
    {
        private Dictionary <string,Client> clients;

        public Banker()
        {
            clients = new Dictionary<string, Client>(0);
        }

        public void CreaClient(string nomNouClient)
        {
            clients.Add(nomNouClient, new Client(nomNouClient));
        }
        
        public string PosarDiners(string nomClient, int quantitat)
        {
            if (clients.ContainsKey(nomClient))
            { 
                var client= clients[nomClient];
                client.Saldo += quantitat;
                return $"{nomClient}: {quantitat} € ingressats correctament";
            }
            return $"Tu no ets client, {nomClient}";
        }

        public string TreureDiners(string nomCLient, int quantitat)
        {
            if (clients.ContainsKey(nomCLient))
            {
                var client = clients[nomCLient];
                var comissio = (int)quantitat / 100;
                if (quantitat + comissio > client.Saldo)
                {
                    return $"{nomCLient} no tens {quantitat + comissio} € diners per treure";
                }

                client.Saldo -= quantitat + comissio;
                return $"{nomCLient}{quantitat}Diners retirats correctament";
            }
            return $"Tu no ets client, {nomCLient}";
        }

    }
}