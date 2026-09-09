using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 会员消费记录信息表实体类
public class MemberConsumptionRecord
{
    /// <summary>
    ///  消费记录id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ConsumptionRecordID { get; set; }

    /// <summary>
    /// 会员id
    /// </summary>
    [Required]
    public int MemberID { get; set; }

    /// <summary>
    /// 销售记录id
    /// </summary>
    [Required]
    public int SalesRecordID { get; set; }

    /// <summary>
    ///  会员表
    /// </summary>
    [ForeignKey("MemberID")]
    public virtual Member? Member { get; set; }

    /// <summary>
    ///  销售记录表
    /// </summary>
    [ForeignKey("SalesRecordID")]
    public virtual SalesRecord? SalesRecord { get; set; }
}


