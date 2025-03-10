,namespace CodeFirstRelation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }


        //Relational Property

        public List<PostEntity> Posts { get; set; }
    }
}
