using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PedidosApiWebApplication.Modelos
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPedido { get; set; }
        public int idCliente { get; set; } 
        public DateTime dataPedido { get; set; } 
        public string statusPedido { get; set; }
        public decimal valorTotalPedido { get; set; }
        public string observacoesPedido { get; set; }
        public ICollection<ItemPedido> itemPedidos { get; set;} 
    }
}
