using AutoMapper;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<Testimonial, GetSocialMediaDto>().ReverseMap();
            CreateMap<Testimonial, CreateSocialMediaDto>().ReverseMap();
        }
    }
}
