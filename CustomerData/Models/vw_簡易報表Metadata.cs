using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CustomerData.Models
{
    
    /// <summary>
    /// vw_簡易報表 class
    /// </summary>
    [MetadataType(typeof(vw_簡易報表Metadata))]
    public  partial class vw_簡易報表
    {
    
    	/// <summary>
    	/// vw_簡易報表 Metadata class
    	/// </summary>
    	public   class vw_簡易報表Metadata
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
    		/// 聯絡人數量
    		/// </summary>        
    	    [DisplayName("聯絡人數量")]
    		public Nullable<int>  聯絡人數量 { get; set; }
    
    		    
    		/// <summary>
    		/// 銀行帳戶數量
    		/// </summary>        
    	    [DisplayName("銀行帳戶數量")]
    		public Nullable<int>  銀行帳戶數量 { get; set; }
    
    		    
    	}
    }
    
}
