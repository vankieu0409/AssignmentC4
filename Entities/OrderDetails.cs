using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class OrderDetails
{
    public Guid id_Order { get; set; }
    public Guid id_Product { get; set; }
    // số lượng
    public int quantity { get; set; }
    [Column(TypeName = "money")]
    [Range(0, int.MaxValue)]
    // giá tổng tiền của sản phẩm
    public int Price { get; set; }
   
    public bool IsDelete { get; set; }
    public virtual Order Orders { get; set; }

    public virtual Products Products { get; set; }
}