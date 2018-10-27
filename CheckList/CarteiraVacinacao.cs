using System;
using CheckList.Enum;

namespace CheckList
{
    public class CarteiraVacinacao
    {
        public int Id { get; set; }
        public DateTime Vencimento { get; set; }
        public StatusVacinacaoEnum Status { get; set; }
        public string Responsavel { get; set; }
        public string Pet { get; set; }

        public bool IsVencido()
        {
            var dataAtual = DateTime.Now;
            return DateTime.Compare(this.Vencimento, new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day, 0, 0, 0)) < 0;
        }

        public bool IsVencer()
        {
            var dataAtual = DateTime.Now;
            return DateTime.Compare(this.Vencimento, new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day, 0, 0, 0)) == 0;
        }
    }
}
