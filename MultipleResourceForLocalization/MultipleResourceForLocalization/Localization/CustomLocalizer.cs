using Microsoft.Extensions.Localization;
using MultipleResourceForLocalization.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleResourceForLocalization.Localization
{
    public class CustomLocalizer : ICustomLocalizer
    {
        private readonly IStringLocalizerFactory Factory;
        public CustomLocalizer(IStringLocalizerFactory factory)
        {
            Factory = factory;
        }
        public string GetLocalizedString(MessageType type, string key)
        {
            var localizer = GetStringLocalizer(type);
            return localizer[key];
        }

        private IStringLocalizer GetStringLocalizer(MessageType type)
        {
            switch (type)
            {
                case MessageType.Info:
                    return Factory.Create(typeof(Info));
                case MessageType.Warn:
                    return Factory.Create(typeof(Warn));
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
