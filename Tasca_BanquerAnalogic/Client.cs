namespace Tasca_BanquerAnalogic
{
    public class Client
    {
        public Client(string nomClient)
        {
            Nom = nomClient;
            Saldo = 0;
        }

        public string Nom { get; }

        //private saldo; (JAVA)
        //public getSaldo() {return Saldo;}
        //public setSaldo(int x) { saldo=x;}
        
        public int Saldo{get;set;}
        
    }
}