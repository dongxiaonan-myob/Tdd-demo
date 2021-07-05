namespace DemoProject.Repository
{
    public interface IVoteRepository
    {
        public int Save(Vote.Vote item);
    }
}