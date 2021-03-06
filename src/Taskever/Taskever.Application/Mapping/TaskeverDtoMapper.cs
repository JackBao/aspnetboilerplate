﻿using Taskever.Activities;
using Taskever.Activities.Dto;
using Taskever.Friendships;
using Taskever.Friendships.Dto;
using Taskever.Tasks;
using Taskever.Tasks.Dto;

namespace Taskever.Mapping
{
    public static class TaskeverDtoMapper
    {
        public static void Map()
        {
            //TODO: Check unnecessary ReverseMaps
            AutoMapper.Mapper.CreateMap<Task, TaskDto>().ReverseMap();
            AutoMapper.Mapper.CreateMap<Task, TaskWithAssignedUserDto>().ReverseMap();
            AutoMapper.Mapper.CreateMap<Friendship, FriendshipDto>().ReverseMap();

            AutoMapper.Mapper
                .CreateMap<Activity, ActivityDto>()
                .Include<CreateTaskActivity, CreateTaskActivityDto>()
                .Include<CompleteTaskActivity, CompleteTaskActivityDto>();
            AutoMapper.Mapper.CreateMap<CreateTaskActivity, CreateTaskActivityDto>();
            AutoMapper.Mapper.CreateMap<CompleteTaskActivity, CompleteTaskActivityDto>();

            AutoMapper.Mapper.CreateMap<UserFollowedActivity, UserFollowedActivityDto>();
        }
    }
}
