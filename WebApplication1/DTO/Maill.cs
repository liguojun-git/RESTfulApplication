using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 商场信息表实体类
public class Mall
{
    /// <summary>
    /// 商场id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MallID { get; set; }

    /// <summary>
    ///  商场名称
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string MallName { get; set; } = string.Empty;

    /// <summary>
    ///  商场地址
    /// </summary>
    [Required]
    [MaxLength(200)]
    public string? Address { get; set; }

    /// <summary>
    ///  联系电话
    /// </summary>
    [MaxLength(20)]
    public string? Phone { get; set; }

    /// <summary>
    ///  开业时间
    /// </summary>
    public DateTime? OpenDate { get; set; }
}

