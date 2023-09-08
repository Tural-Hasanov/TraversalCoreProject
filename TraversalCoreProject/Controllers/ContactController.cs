using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.ContactUs;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        ContactUsManager contactUsManager = new ContactUsManager(new EfContactUsDal());

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            SendContactUsValidator validationRules = new SendContactUsValidator();
            ValidationResult result = validationRules.Validate(model);
            if (result.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    MessageBody=model.MessageBody,
                    Mail=model.Mail,
                    MessageStatus=true,
                    MessageReadStatus = true,
                    Subject =model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Name=model.Name
                    
                    
                });
                return RedirectToAction("Index","Default");
            }
            return View(model);
        }
    }
}
