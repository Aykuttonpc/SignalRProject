using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpGet]
        public IActionResult NotificationList()
        {
            return Ok(_notificationService.TGetListAll());
        }
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }
        [HttpGet("GetAllNotificationByFalse")]
        public IActionResult GetAllNotificationByFalse() {

            return Ok(_notificationService.TGetAllNotificationByFalse());
        }
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification notification = new Notification()
            {
                Description = createNotificationDto.Description,
                Icon = createNotificationDto.Icon,
                Type = createNotificationDto.Type,
                Status = false,
                Date = Convert.ToDateTime(createNotificationDto.Date),
            };
            _notificationService.TAdd(notification);
            return Ok("Ekleme Başarılı");

        }
        [HttpDelete]
        public IActionResult DeleteNotification(int id) {
            var value = _notificationService.TGetById(id);
            _notificationService.TDelete(value);
            return Ok("Bildirim Silindi");

        }
        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetById(id);
            return Ok(value);


        }

        [HttpPut]
        public  IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto) {
            Notification notification = new Notification()
            {
                NotificationId = updateNotificationDto.NotificationId,
                Description = updateNotificationDto.Description,
                Icon = updateNotificationDto.Icon,
                Type = updateNotificationDto.Type,
                Status = updateNotificationDto.Status,
                Date = updateNotificationDto.Date
            };
            _notificationService.TUpdate(notification);
            return Ok("Güncelleme  Başarılı");
        }
        [HttpGet("NotificaitonChangeToFalse/{id}")]
        public IActionResult NotificaitonChangeToFalse(int id)
        {
            _notificationService.TNotificaitonChangeToFalse(id);
            return Ok("Güncelleme Yapıldı");

        }

        [HttpGet("NotificaitonChangeToTrue/{id}")]
        public IActionResult NotificaitonChangeToTrue(int id)
        {
            _notificationService.TNotificaitonChangeToFalse(id);
            return Ok("Güncelleme Yapıldı");

        }
    }
}