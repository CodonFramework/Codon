using System.Collections.Generic;
using System.Linq;

namespace Calcium.UserOptionsModel
{
	public interface IUserOptionGroupings 
		: IEnumerable<IGrouping<IOptionCategory, IUserOptionReaderWriter>>
	{
		void Refresh();
	}
}
