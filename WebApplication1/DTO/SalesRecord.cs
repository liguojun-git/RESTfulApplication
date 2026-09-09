using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 销售记录信息表实体类
public class SalesRecord
{
    /// <summary>
    /// 销售记录id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SalesRecordID { get; set; }

    /// <summary>
    /// 销售商品id
    /// </summary>
    [Required]
    public int ProductID { get; set; }

    /// <summary>
    /// 销售人员id
    /// </summary>
    [Required]
    public int EmployeeID { get; set; }

    /// <summary>
    /// 销售日期
    /// </summary>
    [Required]
    public DateTime SalesDate { get; set; }

    /// <summary>
    /// 销售数量
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// 销售总金额
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// 商品表
    /// </summary>
    [ForeignKey("ProductID")]
    public Product? Product { get; set; }

    /// <summary>
    /// 员工表
    /// </summary>
    [ForeignKey("EmployeeID")]
    public Employee? Employee { get; set; }
}
    
