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
            // Feito: Verifica se a suíte foi cadastrada e se a quantidade de hóspedes não ultrapassa a capacidade da suíte
            if (Suite !=null && hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Feito
                throw new Exception("Capacidade da suíte ultrapassada. Não é possível cadastrar hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Feito: Retorna a quantidade de hóspedes cadastrados
            if (Hospedes != null)
            {
                return Hospedes.Count;
            } else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // Feito: Retorna o valor da diária
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Feito: Aplica desconto de 10% se a reserva for para 10 dias ou mais
            if (DiasReservados >= 10)
            {
                valor -= (valor * 10) / 100;
            }

            return valor;
        }
    }
}