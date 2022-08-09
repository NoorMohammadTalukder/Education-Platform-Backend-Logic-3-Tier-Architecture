﻿using AutoMapper;
using Business_Logic_Layer.BOs;
using Data_Access_Layer;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class AdminService
    {

       /*
        public static List<AdminModel> Get1()
        {
            var data = DataAccess.GetAdminDataAccess().Get();
            var rdata = new List<AdminModel>();
            foreach (var item in data)
            {
                rdata.Add(new AdminModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                   
                });
            }
            return rdata;
        }
       */

        public static List<AdminModel> Get()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>())).Map<List<AdminModel>>(DataAccess.GetAdminDataAccess().Get());
            return data;
        }

        public static AdminModel GetId(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>()));
            var data = config.Map<AdminModel>(DataAccess.GetAdminDataAccess().GetId(id));
            return data;
        }

        public static bool Create(AdminModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(obj);
           // var data = config.Map<Admin>(obj);

            try
            {
                DataAccess.GetAdminDataAccess().Create(data);

                return true;
                
            }
            catch
            {
                return false;
            }
            
        }

        public static bool Update(AdminModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(obj);
            // var data = config.Map<Admin>(obj);

            try
            {
                DataAccess.GetAdminDataAccess().Update(data);

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(int id)
        {
            DataAccess.GetAdminDataAccess().Delete(id);
            return true;
        }


        //-----------------------------------------------------------
        //------------------Institution Work Started-----------------
        //-----------------------------------------------------------

        public static List<InstitutionModel> GetInstitution()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Institution, InstitutionModel>())).Map<List<InstitutionModel>>(DataAccess.GetInstitutionDataAccess().Get());
            return data;
        }

    }
}
