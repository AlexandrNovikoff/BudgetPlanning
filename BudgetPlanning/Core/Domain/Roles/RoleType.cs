namespace Novikov.Core.Domain.Roles
{
    public enum RoleType
    {
        /// <summary>
        /// Неавторизированный пользователь
        /// </summary>
        Guest = 0,

        /// <summary>
        /// Авторизированный пользователь
        /// </summary>
        User = 1,

        /// <summary>
        /// Администратор
        /// </summary>
        Admin = 2
    }
}
