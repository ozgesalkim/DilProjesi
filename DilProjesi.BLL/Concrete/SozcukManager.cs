using AutoMapper;
using DilProjesi.BLL.Abstact;
using DilProjesi.BLL.Models.ProjeDto;
using DilProjesi.BLL.Models.SozcukDto;
using DilProjesi.COMMON;
using DilProjesi.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace DilProjesi.BLL.Concrete
{
    public class SozcukManager : ISozcukService
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;

        public SozcukManager(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Add(CreateSozcukDto model)
        {
            var entity = _mapper.Map<Sozcuk>(model);

            _context.Sozcuk.Add(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public bool Delete(int id)
        {
            var entity = _context.Sozcuk.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return false;
            }

            _context.Sozcuk.Remove(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }

        public List<GetSozcukDto> GetAll()
        {
            var entities = _context.Sozcuk;

            var models = _mapper.Map<List<GetSozcukDto>>(entities);

            return models;
        }

        public GetSozcukDto GetById(int id)
        {
            var entity = _context.Sozcuk.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<GetSozcukDto>(entity);

            return model;
        }

        public UpdateSozcukDto GetByIdForUpdate(int id)
        {
            var entity = _context.Sozcuk.FirstOrDefault(x => x.Id == id);

            var model = _mapper.Map<UpdateSozcukDto>(entity);

            return model;
        }

        public DataTableResponse<GetSozcukDto> LoadTable(DataTableRequest request)
        {
            var draw = request.draw;

            // Skip number of Rows count  
            var start = request.start;

            // Paging Length 10,20  
            var length = request.length;

            // Sort Column Name  
            var sortColumn = request.columns[request.order[0].column].data;

            // Sort Column Direction (asc, desc)  
            var sortColumnDirection = request.order[0].dir;

            // Search Value from (Search box)  
            var searchValue = request.search.value;

            //Paging Size (10, 20, 50,100)  
            int pageSize = length;

            int skip = start;

            int recordsTotal = 0;

            // getting all Customer data  
            var sozcukData = _context.Sozcuk.AsQueryable();

            //Sorting  
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                sozcukData = sozcukData.OrderBy(sortColumn + " " + sortColumnDirection);
            }

            //Search  
            if (!string.IsNullOrEmpty(searchValue))
            {
                sozcukData = sozcukData.Where(m => m.Ad.Contains(searchValue));
            }

            //total number of rows counts   
            recordsTotal = sozcukData.Count();

            //Paging   
            var data = sozcukData.Skip(skip).Take(pageSize).ToList();

            return new DataTableResponse<GetSozcukDto>()
            {
                Data = _mapper.Map<List<GetSozcukDto>>(data),
                draw = draw,
                recordsFiltered = recordsTotal,
                recordsTotal = recordsTotal
            };
        }

        public bool Update(UpdateSozcukDto model)
        {

            var entity = _mapper.Map<Sozcuk>(model);

            _context.Sozcuk.Update(entity);

            var result = _context.SaveChanges();

            return result > 0 ? true : false;
        }
    }
}
