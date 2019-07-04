using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class LoginMgrFields
    {
       public const string UserName = "UserName";

       public const string Password = "Password";
    }
   public class LoginMgr
   {
       public string UserName
       {
           get;
           set;
       }
       public string Password
       {
           get;
           set;
       }
       public LoginMgr()
       {
       
       }
       public LoginMgr(IDataReader dr)
       {
           popolateObj(this,dr);
       }
       internal static void popolateObj(LoginMgr obj,IDataReader dr)
       {
           if (!dr.IsDBNull(dr.GetOrdinal(LoginMgrFields.UserName)))
           {
               obj.UserName = dr.GetString(dr.GetOrdinal(LoginMgrFields.UserName));
           }
           if(!dr.IsDBNull(dr.GetOrdinal(LoginMgrFields.Password)))
           {
               obj.Password=dr.GetString(dr.GetOrdinal(LoginMgrFields.Password));
           }
       }
       //public int LoginUserDetails()
       //{
       //  int RetVal = 0;

       //     LoginData objData = null;

       //     try
       //     {
       //         objData = new LoginData();

       //         RetVal = objData.LoginUserDetails(UserName, Password);

       //         return RetVal;
       //     }       
       //    finally
       //    {

       //    }

           
       //}

       public int LoginUserDetails()
       {
           int RetVal = 0;

           LoginData objData = null;

           try
           {
               objData = new LoginData();

               RetVal = objData.LoginUserDetails(UserName, Password);

               return RetVal;
           }
           finally
           {
               objData = null;
           }
       }
  
   }

}
