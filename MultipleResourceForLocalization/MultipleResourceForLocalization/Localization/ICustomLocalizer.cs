using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleResourceForLocalization.Localization
{
    public interface ICustomLocalizer
    {
        string GetLocalizedString(MessageType type, string key);
    }
}
