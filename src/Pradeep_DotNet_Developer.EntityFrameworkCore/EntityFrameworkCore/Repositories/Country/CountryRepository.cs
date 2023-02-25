//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Pradeep_DotNet_Developer.EntityFrameworkCore.Repositories.Country
//{
//    public class CountryRepository
//    {
//        private readonly Pradeep_DotNet_DeveloperDbContext _dbContext;
//        public CountryRepository(Pradeep_DotNet_DeveloperDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public bool AddCountry(Pradeep_DotNet_Developer.Country.Country model)
//        {
//            try
//            {
//                model.CreationTime = DateTime.UtcNow;
//                _dbContext.Countries.Add(model);
//                _dbContext.SaveChanges();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
            
//        }
//        public bool UpdateCountry(Guid id, Pradeep_DotNet_Developer.Country.Country model)
//        {
//            try
//            {
//                var country = _dbContext.Countries.FirstOrDefault(x => x.Id == id);
//                country.CountryName = model.CountryName;
//                country.LastModificationTime = DateTime.UtcNow;
//                if (country == null)
//                    return false;
//                _dbContext.Countries.Update(country);
//                _dbContext.SaveChanges();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//        public List<Pradeep_DotNet_Developer.Country.Country> GetCountries()
//        {
//            try
//            {
//                return _dbContext.Countries.AsQueryable().ToList();
//            }
//            catch (Exception ex)
//            {
//                return new List<Pradeep_DotNet_Developer.Country.Country>(); ;
//            }
//        }
//        public Pradeep_DotNet_Developer.Country.Country GetCountryById(Guid id)
//        {
//            try
//            {
//                return _dbContext.Countries.FirstOrDefault(x => x.Id == id);
//            }
//            catch (Exception ex)
//            {
//                return new Pradeep_DotNet_Developer.Country.Country();
//            }
//        }
//        public bool DeleteCountryById(Guid id)
//        {
//            try
//            {
//                var country = _dbContext.Countries.FirstOrDefault(x => x.Id == id);
//                country.IsDeleted = true;
//                country.DeletionTime = DateTime.UtcNow;
//                if (country == null)
//                    return false;
//                _dbContext.Countries.Update(country);
//                _dbContext.SaveChanges();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//    }
//}
