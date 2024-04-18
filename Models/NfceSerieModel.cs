using System.ComponentModel.DataAnnotations;

namespace ConsultaMovimentoPDV.Models
{
    public class NfceSerieModel
    {
        [Key]
        public Guid Cod_NFE_Serie { get; set; }
        public int NR_Auxiliar { get; set; }
        public int garrafa { get; set; }
    }
}
