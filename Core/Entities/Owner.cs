namespace Core.Entities
{
	public class Owner : BaseEntity
	{
		public string FullName { get; set; }
		public string Profil { get; set; }
		public string PictureUrl { get; set; }
		public Address Address { get; set; }
	}
}
