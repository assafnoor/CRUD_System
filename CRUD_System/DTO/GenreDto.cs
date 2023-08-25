namespace CRUD_System.DTO
{
    public class GenreDto
    {
        [StringLength(100)]
        public string Name { get; set; }
    }
}
