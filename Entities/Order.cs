using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AssignmentC4.Entities;

public class Order
{
    public Guid id_Order { get; set; }
    public Guid id_Customer { get; set; }


    public Guid id_COrder { get; set; }
    public DateTime order_Time { get; set; }
    [Column(TypeName = "money")]
    public int discount { get; set; }
    [Column(TypeName = "money")]
    public int amount_Pay { get; set; }
    [Column(TypeName = "money")]
    public int paying_Customer { get; set; }
    [Column(TypeName = "money")]
    public int refunds { get; set; }
    [Column(TypeName = "money")]
    public int total_pay { get; set; }
    public string payments { get; set; }
    public string status { get; set; }
    public int order_status { get; set; }
    public bool IsDetete { get; set; }
    public virtual Customer Customers { get; set; }
    public virtual ICollection<OrderDetails> OrDerDetailses { get; set; }
}