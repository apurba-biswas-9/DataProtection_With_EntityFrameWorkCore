using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataProtection
{
    public class SqlXmlRepository : IXmlRepository
    {
        private readonly MyKeysContext DataProtectionDbContext;

        public SqlXmlRepository(MyKeysContext context)
        {
            DataProtectionDbContext = context;
        }

        public IReadOnlyCollection<XElement> GetAllElements()
        {
            return new ReadOnlyCollection<XElement>(DataProtectionDbContext.DataProtectionKeys.Select(x => XElement.Parse(x.Xml)).ToList());
        }

        public void StoreElement(XElement element, string friendlyName)
        {
            DataProtectionDbContext.DataProtectionKeys.Add(
                new DataProtectionKey
                {
                    FriendlyName = friendlyName,
                    Xml = element.ToString(SaveOptions.DisableFormatting)
                }
            );

            DataProtectionDbContext.SaveChanges();
        }
    }
}
