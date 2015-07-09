using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CustomerData.Models
{

    /// <summary>
    /// 客戶聯絡人 class
    /// </summary>
    [MetadataType(typeof(客戶聯絡人Metadata))]
    public partial class 客戶聯絡人
    {

        /// <summary>
        /// 客戶聯絡人 Metadata class
        /// </summary>
        public class 客戶聯絡人Metadata
        {

            /// <summary>
            /// Id
            /// </summary>        
            [DisplayName("Id")]
            [Required(ErrorMessage = "Id is required")]
            public int Id { get; set; }


            /// <summary>
            /// 客戶 Id
            /// </summary>        
            [DisplayName("客戶 Id")]
            [Required(ErrorMessage = "客戶 Id is required")]
            public int 客戶Id { get; set; }


            /// <summary>
            /// 職稱
            /// </summary>        
            [DisplayName("職稱")]
            [Required(ErrorMessage = "職稱 is required")]
            [MaxLength(50, ErrorMessage = "職稱 cannot be longer than 50 characters")]
            public string 職稱 { get; set; }


            /// <summary>
            /// 姓名
            /// </summary>        
            [DisplayName("姓名")]
            [Required(ErrorMessage = "姓名 is required")]
            [MaxLength(50, ErrorMessage = "姓名 cannot be longer than 50 characters")]
            public string 姓名 { get; set; }


            /// <summary>
            /// Email
            /// </summary>        
            [DisplayName("Email")]
            [Required(ErrorMessage = "Email is required")]
            [MaxLength(250, ErrorMessage = "Email cannot be longer than 250 characters")]
            [EmailAddress]
            public string Email { get; set; }


            /// <summary>
            /// 手機
            /// </summary>        
            [DisplayName("手機")]
            [MaxLength(50, ErrorMessage = "手機 cannot be longer than 50 characters")]
            [RegularExpression(@"\d{4}-\d{6}", ErrorMessage = "must be 09XX-XXXXXX")]
            public string 手機 { get; set; }


            /// <summary>
            /// 電話
            /// </summary>        
            [DisplayName("電話")]
            [MaxLength(50, ErrorMessage = "電話 cannot be longer than 50 characters")]
            public string 電話 { get; set; }


            /// <summary>
            /// 是否已刪除
            /// </summary>        
            [DisplayName("是否已刪除")]
            [Required(ErrorMessage = "是否已刪除 is required")]
            public bool 是否已刪除 { get; set; }


        }
    }

}
