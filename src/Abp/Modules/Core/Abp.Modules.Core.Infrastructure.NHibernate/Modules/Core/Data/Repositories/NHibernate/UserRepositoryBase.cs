﻿using Abp.Domain.Repositories.NHibernate;
using Abp.Security.Users;

namespace Abp.Modules.Core.Data.Repositories.NHibernate
{
    /// <summary>
    /// Implements <see cref="IUserRepository{TUser}"/> for NHibernate.
    /// </summary>
    public abstract class UserRepositoryBase<TUser> : NhRepositoryBase<TUser>, IUserRepository<TUser> where TUser : AbpUser
    {
        public void UpdatePassword(int userId, string password)
        {
            var user = Load(userId);
            user.Password = password; //TODO: Test
        }

        public void UpdateEmail(int userId, string emailAddress)
        {
            var user = Load(userId);
            user.EmailAddress = emailAddress; //TODO: Test
        }

        public void UpdateIsEmailConfirmed(int userId, bool confirmed)
        {
            var user = Load(userId);
            user.IsEmailConfirmed = confirmed; //TODO: Test
        }
    }
}
