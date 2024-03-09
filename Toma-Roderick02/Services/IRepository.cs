namespace Toma_Roderick02.Services
{
    internal interface IRepository
    {
        public void FindAll();
        public void FindById();
        public void Create();
        public void Update();
        public void Delete();
    }
}
