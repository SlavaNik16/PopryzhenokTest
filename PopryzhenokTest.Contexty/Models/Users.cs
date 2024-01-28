namespace PopryzhenokTest
{
    public class User
	{

		///<summary>
		/// Идентификатор
		///</summary>
		public int Id { get; set; }

		///<summary>
		/// Фамилия
		///</summary>
		public string Surname { get; set; }

		///<summary>
		/// Имя
		///</summary>
		public string Name { get; set; }

		///<summary>
		/// Отчество
		///</summary>
		public string Patronymic { get; set; } = null;

		///<summary>
		/// Логин
		///</summary>
		public string Login { get; set; }

		///<summary>
		/// Пароль
		///</summary>
		public string Password { get; set; }

		///<summary>
		/// Роль
		///</summary>
		public RoleTypes RoleType { get; set; }
	}

	public enum RoleTypes
	{

		///<summary>
		/// Клиент
		///</summary>
		Client,

		///<summary>
		/// Менеджер
		///</summary>
		Manager,

		///<summary>
		/// Админ
		///</summary>
		Admin,
	}



}
