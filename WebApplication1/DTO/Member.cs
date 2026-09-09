using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DTO;

// 会员信息表实体类
public class Member
{
    /// <summary>
    /// 会员id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MemberID { get; set; }

    /// <summary>
    /// 会员姓名
    /// </summary>
    [Required]
    [MaxLength(50)]
    public string MemberName { get; set; } = string.Empty;

    /// <summary>
    /// 会员联系电话
    /// </summary>
    [MaxLength(20)]
    public string? Phone { get; set; }

    /// <summary>
    ///  会员加入时间
    /// </summary>
    public DateTime? JoinDate { get; set; }

    /// <summary>
    ///  会员积分
    /// </summary>
    public int Points { get; set; }
}

