using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CustomerData.Models
{
    
    /// <summary>
    /// 客戶銀行資訊 class
    /// </summary>
    [MetadataType(typeof(客戶銀行資訊Metadata))]
    public  partial class 客戶銀行資訊
    {
    
    	/// <summary>
    	/// 客戶銀行資訊 Metadata class
    	/// </summary>
    	public   class 客戶銀行資訊Metadata
    	{
    		    
    		/// <summary>
    		/// Id
    		/// </summary>        
    	    [DisplayName("Id")]
            [Required(ErrorMessage = "Id is required")]
    		public int  Id { get; set; }
    
    		    
    		/// <summary>
    		/// 客戶 Id
    		/// </summary>        
    	    [DisplayName("客戶 Id")]
            [Required(ErrorMessage = "客戶 Id is required")]
    		public int  客戶Id { get; set; }
    
    		    
    		/// <summary>
    		/// 銀行名稱
    		/// </summary>        
    	    [DisplayName("銀行名稱")]
            [Required(ErrorMessage = "銀行名稱 is required")]
            [MaxLength(50, ErrorMessage = "銀行名稱 cannot be longer than 50 characters")]
    		public string  銀行名稱 { get; set; }
    
    		    
    		/// <summary>
    		/// 銀行代碼
    		/// </summary>        
    	    [DisplayName("銀行代碼")]
            [Required(ErrorMessage = "銀行代碼 is required")]
            [MaxLength(3, ErrorMessage = "銀行代碼 cannot be longer than 3 characters")]
    		public string  銀行代碼 { get; set; }
    
    		    
    		/// <summary>
    		/// 分行代碼
    		/// </summary>        
    	    [DisplayName("分行代碼")]
            [MaxLength(4, ErrorMessage = "分行代碼 cannot be longer than 4 characters")]
    		public string  分行代碼 { get; set; }
    
    		    
    		/// <summary>
    		/// 帳戶名稱
    		/// </summary>        
    	    [DisplayName("帳戶名稱")]
            [Required(ErrorMessage = "帳戶名稱 is required")]
            [MaxLength(50, ErrorMessage = "帳戶名稱 cannot be longer than 50 characters")]
    		public string  帳戶名稱 { get; set; }
    
    		    
    		/// <summary>
    		/// 帳戶號碼
    		/// </summary>        
    	    [DisplayName("帳戶號碼")]
            [Required(ErrorMessage = "帳戶號碼 is required")]
            [MaxLength(20, ErrorMessage = "帳戶號碼 cannot be longer than 20 characters")]
    		public string  帳戶號碼 { get; set; }
    
    		    
    		/// <summary>
    		/// 是否已刪除
    		/// </summary>        
    	    [DisplayName("是否已刪除")]
            [Required(ErrorMessage = "是否已刪除 is required")]
    		public bool  是否已刪除 { get; set; }
    
    		    
    	}
    }
    
}
