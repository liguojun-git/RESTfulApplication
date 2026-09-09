using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 商品信息表实体类
public class Product
{
    /// <summary>
    ///  商品id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductID { get; set; }

    /// <summary>
    /// 所属店铺id
    /// </summary>
    [Required]
    public int StoreID { get; set; }

    /// <summary>
    /// 商品名称
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// 商品品牌
    /// </summary>
    [MaxLength(50)]
    public string? Brand { get; set; }

    /// <summary>
    /// 商品类别
    /// </summary>
    [MaxLength(50)]
    public string? Category { get; set; }

    /// <summary>
    /// 商品价格
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// 商品库存数量
    /// </summary>
    public int StockQuantity { get; set; }

    /// <summary>
    /// 店铺
    /// </summary>
    [ForeignKey("StoreID")]
    public Store? Store { get; set; }
}

