using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CustomerData.Models
{
    
    /// <summary>
    /// 客戶資料 class
    /// </summary>
    [MetadataType(typeof(客戶資料Metadata))]
    public  partial class 客戶資料
    {
    
    	/// <summary>
    	/// 客戶資料 Metadata class
    	/// </summary>
    	public   class 客戶資料Metadata
    	{
    		    
    		/// <summary>
    		/// Id
    		/// </summary>        
    	    [DisplayName("Id")]
            [Required(ErrorMessage = "Id is required")]
    		public int  Id { get; set; }
    
    		    
    		/// <summary>
    		/// 客戶名稱
    		/// </summary>        
    	    [DisplayName("客戶名稱")]
            [Required(ErrorMessage = "客戶名稱 is required")]
            [MaxLength(50, ErrorMessage = "客戶名稱 cannot be longer than 50 characters")]
    		public string  客戶名稱 { get; set; }
    
    		    
    		/// <summary>
    		/// 統一編號
    		/// </summary>        
    	    [DisplayName("統一編號")]
            [Required(ErrorMessage = "統一編號 is required")]
            [MaxLength(8, ErrorMessage = "統一編號 cannot be longer than 8 characters")]
    		public string  統一編號 { get; set; }
    
    		    
    		/// <summary>
    		/// 電話
    		/// </summary>        
    	    [DisplayName("電話")]
            [Required(ErrorMessage = "電話 is required")]
            [MaxLength(50, ErrorMessage = "電話 cannot be longer than 50 characters")]
    		public string  電話 { get; set; }
    
    		    
    		/// <summary>
    		/// 傳真
    		/// </summary>        
    	    [DisplayName("傳真")]
            [MaxLength(50, ErrorMessage = "傳真 cannot be longer than 50 characters")]
    		public string  傳真 { get; set; }
    
    		    
    		/// <summary>
    		/// 地址
    		/// </summary>        
    	    [DisplayName("地址")]
            [MaxLength(100, ErrorMessage = "地址 cannot be longer than 100 characters")]
    		public string  地址 { get; set; }
    
    		    
    		/// <summary>
    		/// Email
    		/// </summary>        
    	    [DisplayName("Email")]
            [MaxLength(250, ErrorMessage = "Email cannot be longer than 250 characters")]
    		public string  Email { get; set; }
    
    		    
    		/// <summary>
    		/// 是否已刪除
    		/// </summary>        
    	    [DisplayName("是否已刪除")]
            [Required(ErrorMessage = "是否已刪除 is required")]
    		public bool  是否已刪除 { get; set; }
    
    		    
    	}
    }
    
}
