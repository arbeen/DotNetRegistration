using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myApp.models;

namespace myDb.Db.DbOperations
{
    public class UsersRepository
    {
        public int AddUser(UsersModel model)
        {
            using(var context = new RegistrationEntities())
            {
                UsersDB usr = new UsersDB()
                {
                    FirstName = model.FirstName,
                    LastName=model.LastName,
                    Email=model.Email,
                    Password=model.Password,
                    Gender=model.Gender,
                    Province=model.Province
                };

                context.UsersDB.Add(usr);

                context.SaveChanges();

                return usr.id;
            }
        }
    }
}
