using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Concat.Concats;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.Concat
{
    public class ConcatDataSeederContributor:IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Concats.Concat, Guid> _concatRepository;

        public ConcatDataSeederContributor(IRepository<Concats.Concat, Guid> concatRepository)
        {
            _concatRepository = concatRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _concatRepository.GetCountAsync() <= 0)
            {
                await _concatRepository.InsertAsync(
                    new Concats.Concat
                    {
                        Name = "Serhat",
                        LastName = "Taraman",
                        Type = ConcatType.ComputerProgrammer,
                        PublishDate = new DateTime(2022, 7, 4),
                        phone = "05384714674"
                    },
                    autoSave: true
                );

                await _concatRepository.InsertAsync(
                    new Concats.Concat
                    {
                        Name = "Harun",
                        LastName = "Çelik",
                        Type = ConcatType.ComputerProgrammer,
                        PublishDate = new DateTime(2022, 5, 3),
                        phone = "05366088507"
                    },
                    autoSave: true
                );
            }
        }
    }
}
