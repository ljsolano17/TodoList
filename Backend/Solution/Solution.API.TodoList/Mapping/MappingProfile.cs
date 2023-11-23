using AutoMapper;
using data = Solution.DO.Objects;

namespace Solution.API.TodoList.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<data.Tareas, datamodels.Tareas>().ReverseMap();
        }
    }
}
