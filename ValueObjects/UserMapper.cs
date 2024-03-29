﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    public class UserMapper
    {
        private IMapper mMapper;
        public UserMapper()
        {
            mMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<UserEntity, UserDto>()
                .ForMember(x=>x.IsAboveEighteen, y=>y.MapFrom(z=>z.Age>18))
                .ReverseMap();
                config.CreateMap<UserDto, UserViewModel>()
                .ForMember(x => x.IsAboveEighteen, y => y.MapFrom(z => z.Age > 18))
                .ReverseMap();
            })
            .CreateMapper();
        }
        public UserDto Map(UserEntity entity)
            =>mMapper.Map<UserDto>(entity);
        public UserEntity ReverseMap(UserDto dto)
            => mMapper.Map<UserEntity>(dto);
        public UserViewModel Map(UserDto dto)
             => mMapper.Map<UserViewModel>(dto);
        public UserDto ReverseMap(UserViewModel viewModel)
             => mMapper.Map<UserDto>(viewModel);

    }
}
