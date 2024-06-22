
namespace ToDoApp.GraphQLApi.HotChocolate.Profiles;

public class ProjectProfile:Profile
{
    public ProjectProfile()
    {
        CreateMap<ToDo,ToDoResponse>();
    }
}
