namespace ConsultaMovimentoPDV.Models
{
    public class MovimentoModel
    {
        public Guid Id { get; set; }
        public int Loja { get; set; }
        public int Terminal { get; set; }
        public string CPF_CNPJ { get; set; }
        public decimal ValorTotal_Compra { get; set; }
        public decimal ValorTotal_Item { get; set; }
        public decimal Desconto { get; set; }
        public int NR_Seq { get; set; }
        public string Promocao { get; set; }
        public string Barra { get; set; }
        public string Produto { get; set; }
    }
}
