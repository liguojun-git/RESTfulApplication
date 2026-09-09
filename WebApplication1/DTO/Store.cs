using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 店铺信息表实体类
public class Store
{
    /// <summary>
    /// 店铺id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int StoreID { get; set; }

    /// <summary>
    /// 所属租户id
    /// </summary>
    [Required]
    public int TenantID { get; set; }

    /// <summary>
    /// 店铺编号
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string StoreNumber { get; set; } = string.Empty;

    /// <summary>
    /// 店铺所在楼层
    /// </summary>
    [MaxLength(10)]
    public string? Floor { get; set; }

    /// <summary>
    /// 店铺面积
    /// </summary>
    public decimal Area { get; set; }

    /// <summary>
    /// 租户
    /// </summary>
    [ForeignKey("TenantID")]
    public  Tenant? Tenant { get; set; }
 
}

