using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOne;

namespace BusinessClassLibrary
{
    public class CreateAccount
    {
        public bool wasAccountCreated;

       public void CreateAcct(string userName, string password, string emailAddress)
        {
            try
            {
                StreamWriter outPutFile = new StreamWriter("UserDatabase.txt", append: true);
                var abo = DevOne.Security.Cryptography.BCrypt.BCryptHelper.GenerateSalt(12);
                var hashed_password = DevOne.Security.Cryptography.BCrypt.BCryptHelper.HashPassword(password, abo);
                if (hashed_password != string.Empty)
                {
                    outPutFile.WriteLine(userName + '\n' + hashed_password + '\n' + emailAddress);
                    outPutFile.Close();
                    wasAccountCreated = true;
                }
                else
                {
                    wasAccountCreated = false;
                }
            }
            catch(ArgumentException argExcept)
            {
                throw argExcept;
            }

            catch(Exception genExcept)
            {
                throw genExcept;
            }
        }

      

       public CreateAccount()
        {

        }
    }
   
}
