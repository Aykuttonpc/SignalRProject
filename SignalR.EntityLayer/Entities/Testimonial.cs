namespace SignalR.EntityLayer.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImagUrl { get; set; }
        public bool Status { get; set; }
    }
}
