namespace StormyCommerce.Core.Interfaces.Domain
{
	public interface IEntityService
	{
		string ToSafeSlug(string slug,long entityId,string entityTypeId); 
		Entity Get(long entityId,string entityTypeId); 
		void Add(string name,string slug,long entityTypeId,string entityTypeId);
		void Update(string newName,string newSlug,long entityId,string entityTypeId); 
		void Delete(long entityId,string entityTypeId); 
	}
}
