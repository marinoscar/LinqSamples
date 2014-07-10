using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class PartsRepository
    {

        public PartsRepository()
        {
            Parts = new List<Part>();
            PartTypes = new List<PartType>();
        }

        public List<Part> Parts { get; private set; }
        public List<PartType> PartTypes { get; private set; }

        public void InitializeDemoData()
        {
            PartTypes.Clear();
            Parts.Clear();

            PartTypes.Add(new PartType()
            {
                Id = 1,
                Code = "Interior",
                Description = "Interior"
            });
            PartTypes.Add(new PartType()
            {
                Id = 2,
                Code = "Exterior",
                Description = "Exterior"
            });
            Parts.Add(new Part()
            {
                Id = 1,
                Code = "IN-01",
                IssuedDate = DateTime.Today,
                Description = "Interior Part 01",
                PartTypeId = 1
            });
            Parts.Add(new Part()
            {
                Id = 2,
                Code = "IN-02",
                IssuedDate = DateTime.Today,
                Description = "Interior Part 02",
                PartTypeId = 1
            });
            Parts.Add(new Part()
            {
                Id = 3,
                Code = "EX-01",
                IssuedDate = DateTime.Today,
                Description = "Exterior Part 01",
                PartTypeId = 2
            });
            Parts.Add(new Part()
            {
                Id = 4,
                Code = "EX-02",
                IssuedDate = DateTime.Today,
                Description = "Exterior Part 02",
                PartTypeId = 2
            });
        }

        /// <summary>
        /// Gets a part by code
        /// </summary>
        /// <param name="partCode">The code of the part</param>
        /// <returns></returns>
        public Part GetPartByCode(string partCode)
        {
            if (string.IsNullOrWhiteSpace(partCode))
                throw new ArgumentException("Invalid part code");
            return (from p in Parts where p.Code == partCode select p).SingleOrDefault();
        }

        /// <summary>
        /// Gets a list of parts searched by code
        /// </summary>
        /// <param name="partTypeCode">The code of the part type</param>
        /// <returns></returns>
        public IEnumerable<Part> GetPartsByPartType(string partTypeCode)
        {
            if (string.IsNullOrWhiteSpace(partTypeCode))
                throw new ArgumentException("Invalid part code type");


            return (from p in Parts
                    join pt in PartTypes on p.PartTypeId equals pt.Id
                    where pt.Code == partTypeCode
                    select p);
        }

    }
}
