using AutoMapper;
using BEL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuthService
    {
      

        public static Access_tokenDto Authenticate(UserDto user)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDto, User>();
                c.CreateMap<User, UserDto>();
                c.CreateMap<Access_token, Access_tokenDto>();
            });

            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAcees();
            var u = mapper.Map<User>(user);
            var data = mapper.Map<Access_tokenDto>(da.Authenticate(u));
            return data;
        }

    }
}
