using System;
using WA.EStore.Domains;

namespace WA.EStore.AppServices.Members
{
	public class CreateMemberRequest
	{
		public string Account { get; set; }
		public string Password { get; set; }

		public Member ToModel()
			=> new Member(Account, Password);
	}

	public class CreateMemberResponse
	{
		// 略過細節
	}

	public class CreateMemberCommand
	{
		private readonly IMemberRepository _repository;

		public CreateMemberCommand(IMemberRepository repository)
		{
			_repository = repository;
		}

		public CreateMemberResponse Execute(CreateMemberRequest request)
		{
			// todo 驗證 request

			// 將 request 轉型為 WA.EStore.Domains.Member, 在此, 會在 Member 建構函數裡再進行欄位驗證
			var member = request.ToModel();

			// 檢查 account 是否唯一
			if (_repository.IsExists(request.Account))
			{
				throw new Exception("帳號已存在");
			}

			// 建立記錄
			_repository.Create(member);

			// return response
			return new CreateMemberResponse();
		}
	}
}