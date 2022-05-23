namespace FreeCourse.Services.Catalog.Dtos
{
    public class CourceCreateDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public string UserId { get; set; }

        public FeaturedDto Feature { get; set; }

        public string CategoryId { get; set; }
    }
}
