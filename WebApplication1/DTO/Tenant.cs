using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp.DTO;

// 租户信息表实体类
public class Tenant
{
    /// <summary>
    ///  租户id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TenantID { get; set; }

    /// <summary>
    /// 所属商场id
    /// </summary>
    [Required]
    public int MallID { get; set; }

    /// <summary>
    /// 租户名称
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string TenantName { get; set; } = string.Empty;

    /// <summary>
    /// 租户经营类型
    /// </summary>
    [MaxLength(50)]
    public string? BusinessType { get; set; }

    /// <summary>
    /// 租户联系人
    /// </summary>
    [MaxLength(50)]
    public string? ContactPerson { get; set; }

    /// <summary>
    /// 租户联系电话
    /// </summary>
    [MaxLength(20)]
    public string? ContactPhone { get; set; }

    /// <summary>
    /// 租聘开始日期
    /// </summary>
    public DateTime? LeaseStartDate { get; set; }

    /// <summary>
    /// 租聘结束日期
    /// </summary>
    public DateTime? LeaseEndDate { get; set; }

    /// <summary>
    /// 商场
    /// </summary>
    [ForeignKey("MallID")]
    public Mall? Mall { get; set; }
}

