using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentC4.Entities;

public class Categories
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid IdCategory { get; set; }
    public Guid ICCategory { get; set; }
    public string NameCategory { get; set; }
    public bool IsDeleted { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts{ get; set; }
}