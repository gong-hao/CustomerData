using System;
using System.Linq;
using System.Collections.Generic;
	
namespace CustomerData.Models
{   
	public  class vw_簡易報表Repository : EFRepository<vw_簡易報表>, Ivw_簡易報表Repository
	{

	}

	public  interface Ivw_簡易報表Repository : IRepository<vw_簡易報表>
	{

	}
}