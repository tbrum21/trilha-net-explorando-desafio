namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            
            }
            else
            {

                Exception ex = new Exception("Capacidade menor que o número de hóspedes");
                Console.WriteLine(ex.Message);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = 0;


            if (DiasReservados>=10)
            {
                valor = DiasReservados * Suite.ValorDiaria * 0.9m;
                return valor;
            }
            else
            {
                return DiasReservados * Suite.ValorDiaria;
            }
        }
    }
}