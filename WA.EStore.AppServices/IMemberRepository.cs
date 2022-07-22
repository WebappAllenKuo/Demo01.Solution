using WA.EStore.Domains;

namespace WA.EStore.AppServices
{
	public interface IMemberRepository
	{
		bool IsExists(string account);
		void Create(Member member);
	}
}